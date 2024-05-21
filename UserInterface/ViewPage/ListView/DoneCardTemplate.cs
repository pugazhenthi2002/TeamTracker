using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using TeamTracker;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

namespace UserInterface.ViewPage.ListView
{
    public enum CardMode
    {
        TeamLead,
        TeamMember
    }

    public partial class DoneCardTemplate : UserControl
    {
        private TransparentForm transparentForm;
        public TeamTracker.Task SelectedTask
        {
            get
            {
                return selectedTask;
            }
            set
            {
                if (value != null)
                {
                    selectedTask = value;
                    SetDoneTaskUI();
                }
            }
        }

        public CardMode ModeOfView
        {
            get; set;
        }

        private TeamTracker.Task selectedTask;
        public DoneCardTemplate()
        {
            InitializeComponent();
            InitializeDoubleBuffer();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void InitializePageColor()
        {
            profilePictureBox1.ParentColor = tableLayoutPanel1.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            dueDate.ForeColor = projectName.ForeColor = taskNameLabel.ForeColor = ThemeManager.GetTextColor(tableLayoutPanel1.BackColor);
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
            pictureBox1.Image?.Dispose();
        }

        private void InitializeDoubleBuffer()
        {
            DoubleBuffered = true;
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, tableLayoutPanel1, new object[] { true });
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, tableLayoutPanel2, new object[] { true });
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, tableLayoutPanel3, new object[] { true });
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, taskNameLabel, new object[] { true });
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, projectName, new object[] { true });
            typeof(Label).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, dueDate, new object[] { true });
            typeof(PictureBox).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, pictureBox1, new object[] { true });
            typeof(ProfilePictureBox).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.NonPublic | BindingFlags.Instance, null, profilePictureBox1, new object[] { true });
        }

        private void SetDoneTaskUI()
        {
            if (ModeOfView == CardMode.TeamLead)
            {
                profilePictureBox1.Image = Image.FromFile(EmployeeManager.FetchEmployeeFromID(selectedTask.AssignedBy).EmpProfileLocation);
            }
            else
            {
                profilePictureBox1.Image = Image.FromFile(EmployeeManager.FetchEmployeeFromID(selectedTask.AssignedTo).EmpProfileLocation);
            }
            projectName.Text = VersionManager.FetchProjectName(selectedTask.VersionID);
            taskNameLabel.Text = selectedTask.TaskName;
            dueDate.Text = selectedTask.EndDate.ToShortDateString();

            switch (selectedTask.TaskPriority)
            {
                case Priority.Critical:
                    pictureBox1.Image = UserInterface.Properties.Resources.Critical;
                    break;
                case Priority.Hard:
                    pictureBox1.Image = UserInterface.Properties.Resources.Hard;
                    break;
                case Priority.Medium:
                    pictureBox1.Image = UserInterface.Properties.Resources.Medium;
                    break;
                case Priority.Easy:
                    pictureBox1.Image = UserInterface.Properties.Resources.Easy;
                    break;
                default:
                    pictureBox1.Image = UserInterface.Properties.Resources.flag_empty;
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
        }

        private void OnBorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec1 = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            Rectangle rec2 = new Rectangle(2, 2, (sender as Control).Width - 5, (sender as Control).Height - 5);
            Pen border1 = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            Pen border2 = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec1, 10));
            e.Graphics.DrawPath(border2, BorderGraphicsPath.GetRoundRectangle(rec2, 10));
            border1.Dispose();
            border2.Dispose();
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

        private void OnClick(object sender, EventArgs e)
        {
            TaskInfoForm form = new TaskInfoForm();
            form.SelectedTask = selectedTask;
            form.InfoFormClose += OnFormClosed;

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(form);
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            (sender as TaskInfoForm).Close();

            if (ParentForm != null)
                ParentForm.Show();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            profilePictureBox1.ParentColor = tableLayoutPanel1.BackColor = ThemeManager.CurrentTheme.PrimaryIII;
            taskNameLabel.ForeColor = projectName.ForeColor = dueDate.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            profilePictureBox1.ParentColor = tableLayoutPanel1.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            taskNameLabel.ForeColor = projectName.ForeColor = dueDate.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
        }
    }
}
