using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Home_Page.Project_Manager.Deploy
{
    public partial class DeployContent : UserControl
    {
        public List<ProjectVersion> DeployVersions
        {
            set
            {
                ucDeploy1.SuspendLayout();
                InitializePageColor();
                if (value != null && value.Count > 0)
                {
                    counter = 0;
                    deployVersions = value;
                    isNextEnable = value.Count > 1 ? true : false;

                    if (nextBtn.Image != null) nextBtn.Image.Dispose();
                    if (backBtn.Image != null) backBtn.Image.Dispose();

                    ResetButton();

                    ucDeploy1.Version = value[counter];
                }
                else
                {
                    nextBtn.Visible = backBtn.Visible = ucDeploy1.Visible = false;
                }
                ucDeploy1.ResumeLayout();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public DeployContent()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            if (nextBtn.Image != null) nextBtn.Image.Dispose();
            if (backBtn.Image != null) backBtn.Image.Dispose();

            nextBtn.MouseEnter -= OnMouseEnter;
            backBtn.MouseEnter -= OnMouseLeave;
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void InitializePageColor()
        {
            ucDeploy1.BackColor = ucNotFound1.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            label1.BackColor = backBtn.BackColor = nextBtn.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            label1.ForeColor = ThemeManager.GetTextColor(label1.BackColor);
            backBtn.Image?.Dispose();
            nextBtn.Image?.Dispose();
            ResetButton();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Point pt1 = new Point(9, 9);
            Point pt2 = new Point(Width - 11, 9);
            Point pt3 = new Point(Width - 11, Height - 11);
            Point pt4 = new Point(9, Height - 11);
            Pen border = new Pen(borderColor, 3);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private void OnDeployment(string name, ProjectVersion e)
        {
            if ((counter == 0 && deployVersions.Count == 1))
            {
                counter--;
                ucDeploy1.Visible = false;
            }
            else
            {
                counter--;
                SetDeployControl();
            }
            deployVersions.Remove(e);
        }

        private void OnNextClick(object sender, EventArgs e)
        {
            if (isNextEnable)
            {
                counter++;
                SetDeployControl();
            }
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            if (isBackEnable)
            {
                counter--;
                SetDeployControl();
            }
        }

        private void OnSourceCodeDownload(object sender, EventArgs e)
        {
            Projects proj = VersionManager.FetchProjectFromID(deployVersions[counter].VersionID);
            VersionSourceCode sourceCode = DataHandler.FetchVersionSourceCodeByVersionID(deployVersions[counter].VersionID);
            string savePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }

            try
            {
                string filePath = System.IO.Path.Combine(savePath, sourceCode.DisplayName);
                System.IO.File.Copy(sourceCode.VersionLocation, filePath, true);
                ProjectManagerMainForm.notify.AddNotification("Download Completed", proj.ProjectName + "\n" + deployVersions[counter].VersionName);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", proj.ProjectName + "\n" + deployVersions[counter].VersionName);
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "BackBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = Properties.Resources.Cold_Left_Dark_Hover;
                }
                else
                {
                    backBtn.Image = Properties.Resources.Heat_Left_Dark_Hover;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    nextBtn.Image = Properties.Resources.Cold_Right_Dark_Hover;
                }
                else
                {
                    nextBtn.Image = Properties.Resources.Heat_Right_Dark_Hover;
                }
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "BackBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = isBackEnable ? Properties.Resources.Cold_Left_Dark : Properties.Resources.Cold_Left_Medium;
                }
                else
                {
                    backBtn.Image = isBackEnable ? Properties.Resources.Heat_Left_Dark : Properties.Resources.Heat_Left_Medium;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    nextBtn.Image = isNextEnable ? Properties.Resources.Cold_Right_Dark : Properties.Resources.Cold_Right_Medium;
                }
                else
                {
                    nextBtn.Image = isNextEnable ? Properties.Resources.Heat_Right_Dark : Properties.Resources.Heat_Right_Medium;
                }
            }
        }

        private void SetDeployControl()
        {
            ucDeploy1.Version = deployVersions[counter];

            isBackEnable = counter == 0 ? false : true;
            isNextEnable = counter == deployVersions.Count - 1 ? false : true;

            if (nextBtn.Image != null) nextBtn.Image.Dispose();
            if (backBtn.Image != null) backBtn.Image.Dispose();

            ResetButton();
        }

        private void ResetButton()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                backBtn.Image = isBackEnable ? Properties.Resources.Cold_Left_Light : Properties.Resources.Cold_Left_Medium;
                nextBtn.Image = isNextEnable ? Properties.Resources.Cold_Right_Light : Properties.Resources.Cold_Right_Medium;
            }
            else
            {
                backBtn.Image = isBackEnable ? Properties.Resources.Heat_Left_Light : Properties.Resources.Heat_Left_Medium;
                nextBtn.Image = isNextEnable ? Properties.Resources.Heat_Right_Light : Properties.Resources.Heat_Right_Medium;
            }
        }

        private int counter = 0;
        private bool isBackEnable = false, isNextEnable = false;
        private List<ProjectVersion> deployVersions;
        private Color borderColor = Color.Blue;
    }
}
