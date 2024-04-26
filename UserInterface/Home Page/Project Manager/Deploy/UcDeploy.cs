using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Media;
using UserInterface;

namespace TeamTracker
{
    public partial class UcDeploy : UserControl
    {
        private TransparentForm transparentForm;
        private ProjectVersion version;
        private Projects proj;
        private VersionSourceCode versionSourceCode;


        public UcDeploy()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

        

        public delegate void DeployHandler(string name, ProjectVersion project);
        public event DeployHandler Deployment;

        public ProjectVersion Version
        {
            set
            {
                //SuspendLayout();
                if (value != null)
                {
                    version = value;
                    proj = VersionManager.FetchProjectFromID(value.ProjectID);
                    if (proj != null)
                    {
                        labelProjNameandVersion.Text = proj.ProjectName + "\n" + value.VersionName;
                    }
                    InitializePage();
                }
                //ResumeLayout();
            }
        }

        private void InitializePage()
        {
            profilePictureBox1.Image = Image.FromFile(EmployeeManager.FetchEmployeeFromProjectID(proj.ProjectID).EmpProfileLocation);
            teamLeaderName.Text = EmployeeManager.FetchEmployeeFromProjectID(proj.ProjectID).EmployeeFirstName;
            versionSourceCode = DataHandler.FetchVersionSourceCodeByVersionID(version.VersionID);
            submissionDateLabel.Text = versionSourceCode.SubmissionDate.ToShortDateString();
            Dictionary<string, int> result1 = TaskManager.FilterTeamMemberTaskCountByVersionID(version.VersionID);

            int total = 0;
            foreach (var Iter in result1) total += Iter.Value;

            var colorList = ColorManager.ColorFadingOut;
            int colorIndex = 0;

            if (total > 0)
            {
                pieChart1.Visible = true;
                SeriesCollection seriesCollection = new SeriesCollection();
                foreach (var Iter in result1)
                {
                    seriesCollection.Add(new PieSeries { Title = Iter.Key, Values = new ChartValues<double> { Iter.Value }, Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(colorList[colorIndex].A, colorList[colorIndex].R, colorList[colorIndex].G, colorList[colorIndex].B)) });
                    colorIndex = (colorIndex + 2) % colorList.Count;
                }
                pieChart1.Series = seriesCollection;
            }
            else
            {
                pieChart1.Visible = false;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }


        private void InitializeRoundedEdge()
        {
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void OnDownloaded(object sender, EventArgs e)
        {
            Projects proj = VersionManager.FetchProjectFromID(version.VersionID);
            VersionSourceCode sourceCode = DataHandler.FetchVersionSourceCodeByVersionID(version.VersionID);
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
                ProjectManagerMainForm.notify.AddNotification("Download Completed", proj.ProjectName + "\n" + version.VersionName);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", proj.ProjectName + "\n" + version.VersionName);
            }
        }

        private void OnDeployClick(object sender, EventArgs e)
        {
            VersionManager.VersionCompletion(version);
            Deployment?.Invoke(proj.ProjectName, version);
        }

        private void OnPaintTlBase(object sender, PaintEventArgs e)
        {
            Point pt1 = new Point(4, 4);
            Point pt2 = new Point((sender as Panel).Width - 6, 4);
            Point pt3 = new Point((sender as Panel).Width - 6, (sender as Panel).Height - 6);
            Point pt4 = new Point(4, (sender as Panel).Height - 6);
            System.Drawing.Pen border = new System.Drawing.Pen(System.Drawing.Color.Black, 2);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }


        private void OnDownloadMouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

            pictureBox1.Image = UserInterface.Properties.Resources.Download_Medium_Blue_Color;
        }

        private void OnDownloadMouseLeave(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

            pictureBox1.Image = UserInterface.Properties.Resources.Download_Light_Blue;
        }

        private void OnViewClick(object sender, EventArgs e)
        {
            ProjectInfoForm form = new ProjectInfoForm();
            form.SelectedVersion = version;
            form.InfoFormClose += OnInfoFormClosed;

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(form);
        }

        private void OnInfoFormClosed(object sender, EventArgs e)
        {
            (sender as ProjectInfoForm).Dispose();
            (sender as ProjectInfoForm).Close();
            ParentForm.Show();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as Control).ForeColor = System.Drawing.Color.FromArgb(241, 250, 255);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as Control).ForeColor = System.Drawing.Color.FromArgb(211, 220, 227);
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            System.Drawing.Pen border1 = new System.Drawing.Pen(System.Drawing.Color.FromArgb(221, 230, 237), 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 10));

            border1.Dispose();
        }
    }
}
