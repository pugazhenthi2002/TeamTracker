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
using System.Net.Mail;

namespace TeamTracker
{
    public partial class UcDeploy : UserControl
    {
        public delegate void DeployHandler(string name, ProjectVersion project);
        public event DeployHandler Deployment;

        public ProjectVersion Version
        {
            set
            {
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
            }
        }

        public UcDeploy()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
            if (version != null)
                InitializePage();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
            pictureBox1.Image?.Dispose();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            pieChart1.BackColor = profilePictureBox1.ParentColor = panel3.BackColor = panel4.BackColor = panel5.BackColor = panel6.BackColor = panel7.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            buttonDeploy.BackColor = ThemeManager.CurrentTheme.PrimaryIII;
            buttonDeploy.ForeColor = ThemeManager.GetTextColor(buttonDeploy.BackColor);
            teamLeaderName.ForeColor = label3.ForeColor = label4.ForeColor = label5.ForeColor = label7.ForeColor = labelProjNameandVersion.ForeColor = submissionDateLabel.ForeColor = ThemeManager.GetTextColor(panel4.BackColor);
            pictureBox1.Image?.Dispose();

            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Download : UserInterface.Properties.Resources.Heat_Download;
        }

        private void InitializePage()
        {
            profilePictureBox1.Image = Image.FromFile(EmployeeManager.FetchEmployeeFromProjectID(proj.ProjectID).EmpProfileLocation);
            teamLeaderName.Text = EmployeeManager.FetchEmployeeFromProjectID(proj.ProjectID).EmployeeFirstName;
            versionSourceCode = DataHandler.FetchVersionSourceCodeByVersionID(version.VersionID);
            submissionDateLabel.Text = version.EndDate.ToShortDateString();
            Dictionary<string, int> result1 = TaskManager.FilterTeamMemberTaskCountByVersionID(version);

            int total = 0;
            foreach (var Iter in result1) total += Iter.Value;

            var colorList = ThemeManager.CurrentTheme.MilestoneFadingOutColorCollection;
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
            buttonDeploy.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonDeploy.Width, buttonDeploy.Height, 20, 20));
        }
        
        private void OnDownloaded(object sender, EventArgs e)
        {
            Projects proj = VersionManager.FetchProjectFromID(version.VersionID);
            VersionSourceCode sourceCode = DataHandler.FetchVersionSourceCodeByVersionID(version.VersionID);
            string savePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ZIP Folders (.ZIP)|*.zip";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }

            try
            {
                System.IO.File.Copy(sourceCode.VersionLocation, savePath, true);
                ProjectManagerMainForm.notify.AddNotification("Download Completed", proj.ProjectName + "\n" + version.VersionName);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", proj.ProjectName + "\n" + version.VersionName);
            }
        }

        private void OnDeployClick(object sender, EventArgs e)
        {
            DataHandler.SendEmail(version.ClientEmail);
            VersionManager.VersionCompletion(version);
            Deployment?.Invoke(proj.ProjectName, version);
            MailAddress from = new MailAddress(EmployeeManager.CurrentEmployee.EmpEmail, EmployeeManager.CurrentEmployee.EmployeeFirstName + " " + EmployeeManager.CurrentEmployee.EmployeeLastName);
            MailAddress to = new MailAddress(version.ClientEmail);
            SendEmail("Want to test this damn thing", from, to);
        }

        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to)
        {
            string Text = "";
            SmtpClient mailClient = new SmtpClient("Mailhost");
            MailMessage msgMail;
            Text = "Stuff";
            msgMail = new MailMessage();
            msgMail.From = _from;
            msgMail.To.Add(_to);

            msgMail.Subject = _subject;
            msgMail.Body = Text;
            msgMail.IsBodyHtml = true;
            mailClient.Send(msgMail);
            msgMail.Dispose();
        }

        private void OnDownloadMouseEnter(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Download_Hover : UserInterface.Properties.Resources.Heat_Download_Hover;
        }

        private void OnDownloadMouseLeave(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Download : UserInterface.Properties.Resources.Heat_Download;
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
            (sender as Control).BackColor = ThemeManager.GetHoverColor((sender as Control).BackColor);
            (sender as Control).ForeColor = ThemeManager.GetTextColor((sender as Control).BackColor);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if ((sender as Control).Name == "label5")
                (sender as Control).BackColor = ThemeManager.CurrentTheme.SecondaryII;
            else
                (sender as Control).BackColor = ThemeManager.CurrentTheme.PrimaryIII;

            (sender as Control).ForeColor = ThemeManager.GetTextColor((sender as Control).BackColor);
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            System.Drawing.Pen border1 = new System.Drawing.Pen(ThemeManager.CurrentTheme.SecondaryIII, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 10));
            border1.Dispose();
        }

        private void OnLinePaint(object sender, PaintEventArgs e)
        {
            System.Drawing.Pen border1 = new System.Drawing.Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(border1, 0, (sender as Control).Height - 1, (sender as Control).Width - 2, (sender as Control).Height - 1);
            border1.Dispose();
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

        private TransparentForm transparentForm;
        private ProjectVersion version;
        private Projects proj;
        private VersionSourceCode versionSourceCode;

        
    }
}
