﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Text.RegularExpressions;

namespace TeamTracker 
{
    public partial class UCCreateIssue : UserControl
    {
        private const int CSDropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }

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
            toolTip1.SetToolTip(labelAttachment, "Click to remove attachment");
            labelWarning.Hide();
            labelAttachment.Hide();
            profilePicAndName1.EmployeeProfile = EmployeeManager.CurrentEmployee;

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
               // SetIssue();
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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            labelAttachment.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelAttachment.Width, labelAttachment.Height, labelAttachment.Width, labelAttachment.Width));
            tableLayoutPanel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel5.Width, tableLayoutPanel5.Height, 20, 20));
        }

        private void SetIssue()
        {

            if(issueData==null)
            {
                return;
            }
            IssueTitleTextBox.Text = issueData.IssueName;
            IssueDescTextBox.Text = issueData.IssueDesc;
            BtnSetPriority.Text = issueData.Priority+"";
            BtnSetType.Text = issueData.Type+"";
            
            foreach(string tag in issueData.Tags)
            {
                UCTags tagUc = new UCTags();
                tagUc.Size = new Size(panelTags.Width - 50, panelTags.Height / 4 - 5);
                tagUc.Dock = DockStyle.Top;

                tagUc.SetText(tag);

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
            Button PriorityBtn = sender as Button;

            PriorityForm = new IssuePriorityDropDownForm();
            PriorityForm.Location = PriorityBtn.PointToScreen(new Point(0, PriorityBtn.Height + 1));
            PriorityForm.Width = PriorityBtn.Width;
            PriorityForm.PriorityClick = OnClickPriority;
            PriorityForm.Show();

        }

        private void OnClickPriority(object sender, EventArgs e)
        {
            BtnSetPriority.Text = (sender as Button).Text;
        }

        private void OnClickSetType(object sender, EventArgs e)
        {
            Button TypeBtn = sender as Button;
            Point BtnPoint = TypeBtn.PointToScreen(new Point(TypeBtn.Location.X, TypeBtn.Location.Y));

            TypeForm = new IssueTypeDropDownForm();
            TypeForm.Location = TypeBtn.PointToScreen(new Point(0, TypeBtn.Height + 1));
            TypeForm.Width = TypeBtn.Width;
            TypeForm.TypeClick += OnClickType;

            TypeForm.Show();
        }

        private void OnClickType(object sender, EventArgs e)
        {
            BtnSetType.Text = (sender as Button).Text;
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
            if(IssueTitleTextBox.Text==""|| IssueTitleTextBox.Text == "Enter Issue Name" ||  Regex.IsMatch(textBoxTags.Text, @"\d"))
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

            PostClick?.Invoke(ParentForm, e);
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
            DiscardClick?.Invoke(ParentForm, e);
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

                //UcFileName file = new UcFileName();

                //file.FileName = safeFile;
                //file.Dock = DockStyle.Fill;
                //panelAttachment.Controls.Add(file);

                string extension = System.IO.Path.GetExtension(selectedFilePath);

                Attachement = new IssueAttachment()
                {
                    DisplayName = safeFile,
                    IssueAttachmentName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + extension,
                    IssueAttachmentLocation = selectedFilePath
                };

                labelAttachment.Show();

            }
            else
            {
                labelAttachment.Hide();
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


        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close_Alice_Blue_30;

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(150, 170, 190),2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, labelAttachment.Width - 1, labelAttachment.Height -  1),labelAttachment.Width/2));

            pen.Dispose();
        }
        private void OnClickAttachmentCount(object sender, EventArgs e)
        {
            labelAttachment.Hide();
            Attachement = null;

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetIssue();
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, (sender as Control).Width - 1, (sender as Control).Height - 1), 15));
            border.Dispose();
        }
    }
}
