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

namespace TeamTracker 
{
    public partial class UCCreateIssue : UserControl
    {
        private IssuePriorityDropDownForm PriorityForm;
        private IssueTypeDropDownForm TypeForm;
        private Issue issueData;
        private UCTags tag;
        private List<string> TagList = new List<string>();
        private IssueAttachment Attachement;


        public UCCreateIssue()
        {
            InitializeComponent();
            InitializeRoundedEdge();

            panelTags.HorizontalScroll.Enabled = false;
            panelTags.HorizontalScroll.Visible = false;

            toolTip1.SetToolTip( pictureBoxAttachments, "Add Attachments");
            toolTip1.SetToolTip( BtnSetPriority, "Issue Priority");
            toolTip1.SetToolTip( BtnSetType, "Issue type");
            labelWarning.Hide();
            
            
        }



        public EventHandler DiscardClick;
        public EventHandler PostClick;

        public Issue IssueData
        {
            get
            {
                return issueData;
            }
            set
            {
                issueData = value;
                SetIssue();
            }
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

        private void InitializeRoundedEdge()
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            panelAttachment.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelAttachment.Width, panelAttachment.Height, 20, 20));
        }

        private void SetIssue()
        {
            IssueTitleTextBox.Text = issueData.IssueName;
            IssueDescTextBox.Text = issueData.IssueDesc;
            BtnSetPriority.Text = issueData.Priority+"";
            BtnSetType.Text = issueData.Type+"";
            
            foreach(string tag in issueData.Tags)
            {
                UCTags tagUc = new UCTags();
                tagUc.Size = new Size(panelTags.Width - 20, panelTags.Height / 4 - 5);
                tagUc.Dock = DockStyle.Top;

                tagUc.SetText(textBoxTags.Text);

                panelTags.Controls.Add(tagUc);
                tagUc.BringToFront();
            }

            
            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void ProjectEntryTablePanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(39, 55, 77));
            e.Graphics.DrawLine(pen, new Point(10, IssueTitleTextBox.Location.Y + IssueTitleTextBox.Height + 1), new Point(ProjectEntryTablePanel.Width - 10, IssueTitleTextBox.Location.Y + IssueTitleTextBox.Height + 1));
            e.Graphics.DrawLine(pen, new Point(10, IssueDescTextBox.Location.Y + IssueDescTextBox.Height + 1), new Point(ProjectEntryTablePanel.Width - 10, IssueDescTextBox.Location.Y + IssueDescTextBox.Height + 1));
            pen.Dispose();
        }

        private void ProjectEntryTablePanel_Resize(object sender, EventArgs e)
        {
            ProjectEntryTablePanel.Invalidate();
        }

        private void OnClickSetPriority(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<IssuePriorityDropDownForm>().Any())
            {
                CloseForm();
                return;
            }
            else if (Application.OpenForms.OfType<IssueTypeDropDownForm>().Any())
            {
                CloseForm();
            }

            Button PriorityBtn = sender as Button;
            Point BtnPoint = PriorityBtn.PointToScreen(new Point(PriorityBtn.Location.X, PriorityBtn.Location.Y));

            PriorityForm = new IssuePriorityDropDownForm();
            PriorityForm.Location = new Point(BtnPoint.X, BtnPoint.Y + PriorityBtn.Height);
            PriorityForm.Size = new Size(PriorityBtn.Width-3, PriorityForm.Height);
            PriorityForm.PriorityClick = OnClickPriority;

            PriorityForm.Show();

        }

        private void OnClickPriority(object sender, EventArgs e)
        {
            BtnSetPriority.Text = (sender as Button).Text;
            CloseForm();
        }

        private void OnClickSetType(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<IssueTypeDropDownForm>().Any())
            {
                CloseForm();
                return;
            }
            else if (Application.OpenForms.OfType<IssuePriorityDropDownForm>().Any())
            {
                CloseForm();
            }

            Button TypeBtn = sender as Button;
            Point BtnPoint = TypeBtn.PointToScreen(new Point(TypeBtn.Location.X, TypeBtn.Location.Y));

            TypeForm = new IssueTypeDropDownForm();
            TypeForm.Location = new Point(BtnPoint.X-TypeBtn.Width-7, BtnPoint.Y + TypeBtn.Height);
            TypeForm.Size = new Size(TypeBtn.Width - 3, TypeForm.Height);
            TypeForm.TypeClick += OnClickType;

            TypeForm.Show();
        }

        private void OnClickType(object sender, EventArgs e)
        {
            BtnSetType.Text = (sender as Button).Text;
            CloseForm();
        }

        private void CloseForm()
        {
            var f1 = (Application.OpenForms.OfType<IssuePriorityDropDownForm>().FirstOrDefault());
            var f2 = (Application.OpenForms.OfType<IssueTypeDropDownForm>().FirstOrDefault());

            if (f1 != null)
            {
                f1.Close();
            }
            if (f2 != null)
            {
                f2.Close();
            }

        }

        private void OnClickAddTag(object sender, EventArgs e)
        {
            if(textBoxTags.Text =="" || textBoxTags.Text == "Enter Tags")
            {
                return;
            }

            if(textBoxTags.Text.Contains(","))
            {
                labelWarning.Text = "No delimiters allowed for tags!";
                labelWarning.Show();
                return;
            }

            tag = new UCTags();
            tag.Size = new Size(panelTags.Width-20, panelTags.Height / 4 - 5);
            tag.Dock = DockStyle.Top;

            tag.SetText(textBoxTags.Text);

            panelTags.Controls.Add(tag);
            tag.BringToFront();

            TagList.Add(textBoxTags.Text);

            textBoxTags.Text = "";

        }

        private void OnClickTextBox(object sender, EventArgs e)
        {
            if(textBoxTags.Text == "") textBoxTags.Text = "Enter Tags";
            if (IssueTitleTextBox.Text == "") IssueTitleTextBox.Text = "Enter Issue Name";
            if (IssueDescTextBox.Text == "") IssueDescTextBox.Text = "Enter Your Text";
            if ((sender as TextBox).Text == "Enter Tags"|| (sender as TextBox).Text== "Enter Issue Name" || (sender as TextBox).Text == "Enter Your Text")
            {
                (sender as TextBox).Text = "";
            }
        }

        private void OnClickPostIssue(object sender, EventArgs e)
        {
            if(IssueTitleTextBox.Text==""|| IssueTitleTextBox.Text == "Enter Issue Name")
            {
                labelWarning.Show();
                labelWarning.Text = "Set valid Title!";
                return;
            }
            else if(IssueDescTextBox.Text==""|| IssueDescTextBox.Text == "Enter Your Text")
            {
                labelWarning.Show();
                labelWarning.Text = "Set valid Description";
                return;
            }
            else if(BtnSetPriority.Text == "Set Priority")
            {
                labelWarning.Show();
                labelWarning.Text = "Set valid priority!";
                return;
            }
            else if(BtnSetType.Text == "Set Type")
            {
                labelWarning.Show();
                labelWarning.Text = "Set valid type!";
                return;
            }
            else if(TagList.Count == 0)
            {
                labelWarning.Show();
                labelWarning.Text = "Add tags";
                return;
            }
            //public int IssueID { get; set; }
            //public string IssueName { get; set; }
            //public string IssueDesc { get; set; }
            //public int PostedBy { get; set; }
            //public IssueType Type { get; set; }
            //public IssuePriority Priority { get; set; }
            //public DateTime PostedDate { get; set; }
            //public List<string> Tags { get; set; }
            Issue curIssue = new Issue()
            {
                IssueName = IssueTitleTextBox.Text,
                IssueDesc = IssueDescTextBox.Text,
                PostedBy = EmployeeManager.CurrentEmployee.EmployeeID,
                Type = (BtnSetType.Text == "Bug") ? Issue.IssueType.Bug : ((BtnSetType.Text == "Feature Request") ? Issue.IssueType.FeatureRequest : ((BtnSetType.Text == "Optimization") ? Issue.IssueType.Optimization : ((BtnSetType.Text == "Security") ? Issue.IssueType.Security : ((BtnSetType.Text == "Logical Need") ? Issue.IssueType.LogicalNeed : Issue.IssueType.Other)))),
                Priority = (BtnSetPriority.Text == "High") ? Issue.IssuePriority.High : ((BtnSetPriority.Text == "Medium") ? Issue.IssuePriority.Medium : Issue.IssuePriority.Low),
                PostedDate = DateTime.Today.Date,
                Tags = TagList
            };

            IssueManager.AddIssue(curIssue, Attachement);

            PostClick?.Invoke(sender, e);
        }

        private bool PanelContainsUC()
        {
            foreach (Control control in panel1.Controls)
            {
                if (control is UCTags)
                {
                    return true;
                }
            }
            return false;
        }

        private void OnClickDiscard(object sender, EventArgs e)
        {
            DiscardClick?.Invoke(sender, e);
        }

        private void OnClickAddAttachment(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open File";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string safeFile = openFileDialog.SafeFileName;
                UcFileName file = new UcFileName();

                file.FileName = safeFile;
                file.Dock = DockStyle.Fill;
                panelAttachment.Controls.Add(file);

                Attachement = new IssueAttachment()
                {
                    DisplayName = safeFile,
                    IssueAttachmentName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".pdf",
                    IssueAttachmentLocation = selectedFilePath
                };

        

            }
        }

        private void OnMouseEnterAttachementPicBox(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Attachment_gray;
        }

        private void OnMouseLeaveAttachmentPicBox(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Attachment_black;
        }
    }
}
