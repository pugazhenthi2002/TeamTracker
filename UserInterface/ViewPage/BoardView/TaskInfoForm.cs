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

namespace TeamTracker
{
    public partial class TaskInfoForm : Form
    {
        public TaskInfoForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            this.Location = new Point(700, 300);
            toolTip1.SetToolTip(pictureBoxFlag, "Priority");
            
        }


        public List<SourceCode> SourceCodeList
        {
            get { return SourceCodeList; }
            set
            {
                sourceCodeList = value;
                SetCommits();
            }
        }

        public int SourceCodeID { get; set; }
        public int TaskID { get; set; }
        public string CommitName { get; set; }
        public string SourceCodeLocation { get; set; }
        public DateTime SubmittedDate { get; set; }

        private List<SourceCode> sourceCodeList = new List<SourceCode>
        {
            new SourceCode(){SourceCodeID = 1, TaskID = 4, CommitName = "commit 1", SourceCodeLocation = "c//path1", SubmittedDate = DateTime.Today},
            new SourceCode(){SourceCodeID = 2, TaskID = 4, CommitName = "commit 2", SourceCodeLocation = "c//path2", SubmittedDate = DateTime.Today},
            new SourceCode(){SourceCodeID = 3, TaskID = 4, CommitName = "commit 3", SourceCodeLocation = "c//path3", SubmittedDate = DateTime.Today},
            new SourceCode(){SourceCodeID = 4, TaskID = 4, CommitName = "commit 4", SourceCodeLocation = "c//path4", SubmittedDate = DateTime.MaxValue},
            new SourceCode(){SourceCodeID = 5, TaskID = 4, CommitName = "commit 5", SourceCodeLocation = "c//path5", SubmittedDate = DateTime.MaxValue}
        };

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetCommits();
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

        

        private void SetCommits()
        {
            if(sourceCodeList== null)
            {
                return;
            }

            Dictionary<DateTime, List<SourceCode>> dateWiseDict = sourceCodeList.GroupBy(s => s.SubmittedDate).ToDictionary(g => g.Key, g => g.ToList());

            foreach(var entry in dateWiseDict)
            {
                int commitCount = dateWiseDict[entry.Key].Count;
                UcTaskCommitsHead head = new UcTaskCommitsHead();
                head.CommitCount = commitCount;
                head.CommitDate = entry.Key;
                head.Dock = DockStyle.Top;
                //head.BringToFront();
                head.BackColor = Color.FromArgb(211, 220, 227);
                panelCommits.Controls.Add(head);

                foreach(SourceCode srcCode in dateWiseDict[entry.Key])
                {
                    UcTaskCommits commit = new UcTaskCommits();
                    commit.SourceCodeId = srcCode.SourceCodeID;
                    commit.SourceCodeLocation = srcCode.SourceCodeLocation;
                    commit.CommitName = srcCode.CommitName;
                    commit.BackColor = Color.FromArgb(211, 220, 227);
                    commit.Dock = DockStyle.Top;
                    panelCommits.Controls.Add(commit);

                    //commit.BringToFront();
                }


            }

            foreach(Control ctr in panelCommits.Controls)
            {
                ctr.BringToFront();
            }
            
            
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
  

        }

        private void OnMouseClickClose(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close;

        }

        private void OnPaintTotalCommitsPanel(object sender, PaintEventArgs e)
        {
            

            Point pt1 = new Point(4, 4);
            Point pt2 = new Point(panel2.Width - 6, 4);
            Point pt3 = new Point(panel2.Width - 6, panel2.Height - 6);
            Point pt4 = new Point(4, panel2.Height - 6);
            Pen border = new Pen(Color.Black, 2);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        
        }

        private void OnMouseLeaveDownloadPicBox(object sender, EventArgs e)
        {
            (sender as PictureBox).SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void OnMouseEnterDownloadPicBox(object sender, EventArgs e)
        {
            (sender as PictureBox).SizeMode = PictureBoxSizeMode.Zoom;

        }
    }
}
