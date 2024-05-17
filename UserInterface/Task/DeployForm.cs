using GoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Task
{
    public partial class DeployForm : Form
    {
        public DeployForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            InitializePageColor();
            this.Location = new Point(700, 300);
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        public VersionSourceCode SelectedVersionSourceCode;
        public EventHandler CloseClick;
        public EventHandler<VersionSourceCode> DoneClick;

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

        public new void Dispose()
        {
            if (pictureBoxUpload.Image != null) pictureBoxUpload.Image.Dispose();
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();

            pictureBoxUpload.Dispose(); pictureBox1.Dispose();
            clearButton.Dispose();  submitCodeButton.Dispose();
            label1.Dispose();   label3.Dispose();
            panel1.Dispose(); panel4.Dispose(); panel5.Dispose();
            tableLayoutPanel2.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            clearButton.BackColor = submitCodeButton.BackColor = panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            clearButton.ForeColor = submitCodeButton.ForeColor = label1.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);
            label3.ForeColor = ThemeManager.GetTextColor(BackColor);
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void OnClickClear(object sender, EventArgs e)
        {
            SelectedVersionSourceCode = null;
            label3.Text = "UPLOAD";
        }

        private void OnClickDone(object sender, EventArgs e)
        {
            BooleanMsg message = new BooleanMsg();
            message = EligibleToUpload();
            if (message)
            {
                DoneClick?.Invoke(this, SelectedVersionSourceCode);
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Warning", message.Message);
            }
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            DoneClick?.Invoke(this, null);
        }

        private void OnUploadSourceCode(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "Version Source Code Name";
            openFileDialog1.Filter = "ZIP Folders (.ZIP)|*.zip";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                string safeFile = openFileDialog1.SafeFileName;
                SelectedVersionSourceCode = new VersionSourceCode()
                {
                    VersionID = VersionManager.CurrentVersion.VersionID,
                    SourceCodeName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".zip",
                    VersionLocation = selectedFilePath,
                    DisplayName = safeFile
                };
                label3.Text = safeFile;
            }
        }

        private BooleanMsg EligibleToUpload()
        {
            if (SelectedVersionSourceCode == null)
            {
                return "File Not Selected\nKindly Upload a File";
            }
            
            return true;
        }
    }
}
