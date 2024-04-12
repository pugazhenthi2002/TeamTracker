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

namespace UserInterface.Task.CreateTask
{
    public partial class CreateTaskForm : Form
    {
        public CreateTaskForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            toolTip1.SetToolTip(pictureBoxAttachment, "Click to Add attachment");
            toolTip1.SetToolTip(buttonSetMilestone, "Milestone");
            tableLayoutPanelFileName.Hide();
        }

        private PriorityDropDownForm PriortyDropForm;
        private MilestoneDropDownForm MilestoneDropForm;
        private TeamMembersListForm TeamMembersDropForm;
        private string FilePath;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
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
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            tableLayoutPanel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel4.Width, tableLayoutPanel4.Height, 20, 20));
            tableLayoutPanel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel5.Width, tableLayoutPanel5.Height, 20, 20));
            textBoxTaskName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxTaskName.Width, textBoxTaskName.Height, 10, 10));
            textBoxDesc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxDesc.Width, textBoxDesc.Height, 10, 10));
            buttonCreate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonCreate.Width, buttonCreate.Height, 10, 10));
            buttonDiscard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonDiscard.Width, buttonDiscard.Height, 10, 10));
            buttonSetMilestone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSetMilestone.Width, buttonSetMilestone.Height, 10, 10));
            buttonSetMilestone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSetMilestone.Width, buttonSetMilestone.Height, 10, 10));
            labelSetPriority.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelSetPriority.Width, labelSetPriority.Height, 10, 10));
            tableLayoutPanelFileName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanelFileName.Width, tableLayoutPanelFileName.Height, 10, 10));
        }

        private void OnClickPriorityBtn(object sender, EventArgs e)
        {

        }
        
        private void OnClickAddAttachment(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open File";
            openFileDialog.InitialDirectory = @"C:\";

            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
                string[] seperatedPath = FilePath.Split('\\');

                animatedLabelFilename.Text = seperatedPath[seperatedPath.Length - 1];
                tableLayoutPanelFileName.Show();

            }
        }

        private void OnClickSetMilestone(object sender, EventArgs e)
        {
            Point formPoint = buttonSetMilestone.PointToScreen(new Point(buttonSetMilestone.Location.X, buttonSetMilestone.Location.Y));

            MilestoneDropForm = new MilestoneDropDownForm();
            MilestoneDropForm.Show();
            MilestoneDropForm.Location = new Point(formPoint.X - 3, formPoint.Y + buttonSetMilestone.Height);
            MilestoneDropForm.Size = new Size(buttonSetMilestone.Width, MilestoneDropForm.Height);

            MilestoneDropForm.MilestoneClick += OnClickMilestoneBtn;
        }

        private void OnClickMilestoneBtn(object sender, EventArgs e)
        {

        }

        private void OnClickAssignBtn(object sender, EventArgs e)
        {
            Point formPoint = BtnAssignTo.PointToScreen(new Point(BtnAssignTo.Location.X, BtnAssignTo.Location.Y));
            TeamMembersDropForm = new TeamMembersListForm();

            TeamMembersDropForm.Show();
            TeamMembersDropForm.Location = new Point(formPoint.X - 3, formPoint.Y + 10);
            TeamMembersDropForm.Size = new Size(buttonSetMilestone.Width, TeamMembersDropForm.Height);

            TeamMembersDropForm.TeamMemberClick += OnClickTeamMember;

        }

        private void OnClickTeamMember(object sender, Employee e)
        {
            Button clickedBtn = (sender as Button);
            tableLayoutPanel3.Hide();
            employeeProfilePicAndName1.Profile = e;
            TeamMembersDropForm.Dispose();
        }

        private void OnClickCloseFile(object sender, EventArgs e)
        {
            tableLayoutPanelFileName.Hide();
        }
        
        private void OnClickSetPriority(object sender, EventArgs e)
        {
            Point formPoint = labelSetPriority.PointToScreen(new Point(labelSetPriority.Location.X, labelSetPriority.Location.Y));

            PriortyDropForm = new PriorityDropDownForm();
            PriortyDropForm.Show();
            PriortyDropForm.Location = new Point(formPoint.X - 45, formPoint.Y + labelSetPriority.Height + 2);
            PriortyDropForm.Size = new Size(labelSetPriority.Width, PriortyDropForm.Height);
            PriortyDropForm.PriorityBtnClicked += OnClickPriorityBtn;
        }

        private void OnDiscardClick(object sender, EventArgs e)
        {

        }

        private void OnCreateClick(object sender, EventArgs e)
        {

        }
    }
}
