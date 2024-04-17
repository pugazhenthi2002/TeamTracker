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
    public partial class UcCreateTask : UserControl
    {
        private PriorityDropDownForm PriortyDropForm;
        private MilestoneDropDownForm MilestoneDropForm;
        private TeamMembersListForm TeamMembersDropForm;
        private string FilePath;

        public UcCreateTask()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            toolTip1.SetToolTip(pictureBoxAttachment, "Click to Add attachment");
            toolTip1.SetToolTip(buttonSetMilestone, "Milestone");
            tableLayoutPanelFileName.Hide();

        }

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
            textBoxTaskName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxTaskName.Width, textBoxTaskName.Height, 10, 10));
            textBoxDesc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxDesc.Width, textBoxDesc.Height, 10, 10));
            buttonCreate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonCreate.Width, buttonCreate.Height, 10, 10));
            buttonDiscard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonDiscard.Width, buttonDiscard.Height, 10, 10));
            BtnAssignTo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BtnAssignTo.Width, BtnAssignTo.Height, 10, 10));
            buttonSetMilestone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSetMilestone.Width, buttonSetMilestone.Height, 10, 10));
            buttonSetMilestone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSetMilestone.Width, buttonSetMilestone.Height, 10, 10));
            labelSetPriority.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelSetPriority.Width, labelSetPriority.Height, 10, 10));
            tableLayoutPanelFileName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanelFileName.Width, tableLayoutPanelFileName.Height, 10, 10));
        }

        private void OnMouseEnterSetPriority(object sender, EventArgs e)
        {
                labelSetPriority.BackColor = Color.FromArgb(157, 178, 191);
               // pictureBoxFlag.BackColor = Color.FromArgb(157, 178, 191);
            
        }

        private void OnMouseLeaveSetPriority(object sender, EventArgs e)
        {
            labelSetPriority.BackColor = Color.Transparent;
            //pictureBoxFlag.BackColor = Color.Transparent;
        }

        private void OnClickSetPriority(object sender, MouseEventArgs e)
        {
            if (Application.OpenForms.OfType<PriorityDropDownForm>().Any())
            {
                //CloseForm();
                //return;
            }

            CloseForm();


            Point formPoint = labelSetPriority.PointToScreen(new Point(labelSetPriority.Location.X, labelSetPriority.Location.Y));

            PriortyDropForm = new PriorityDropDownForm();
            PriortyDropForm.Show();
            PriortyDropForm.Location = new Point(formPoint.X -45, formPoint.Y + labelSetPriority.Height +2);
            PriortyDropForm.Size = new Size(labelSetPriority.Width , PriortyDropForm.Height);

            //PriortyDropForm.PriorityBtnClicked += OnClickPriorityBtn;

            
        }

        private void OnClickPriorityBtn(object sender, EventArgs e)
        {
            Button clickedBtn = (sender as Button);
            Image fImage = UserInterface.Properties.Resources.flag_empty;
            switch(clickedBtn.Text)
            {
                case "Critical":
                    fImage = UserInterface.Properties.Resources.flag_OnProcess;
                    break;
                case "Hard":
                    fImage = UserInterface.Properties.Resources.flag_stuck;
                    break;
                case "Medium":
                    fImage = UserInterface.Properties.Resources.flag_NotStarted;
                    break;
                case "Easy":
                    fImage = UserInterface.Properties.Resources.flag_UnderReview;
                    break;
                default:
                    fImage = UserInterface.Properties.Resources.flag_empty;
                    break;
            }
            PriortyDropForm.Dispose();
            labelSetPriority.Text = clickedBtn.Text;
            pictureBoxFlag.Image = fImage;

        }

        private void CloseForm()
        {
            var f1 = (Application.OpenForms.OfType<PriorityDropDownForm>().FirstOrDefault());
            var f2 = (Application.OpenForms.OfType<MilestoneDropDownForm>().FirstOrDefault()); 
            var f3 = (Application.OpenForms.OfType<TeamMembersListForm>().FirstOrDefault()); 


            if (f1 != null)
            {
                f1.Dispose();
            }
            if(f2!=null)
            {
                f2.Dispose();
            }
            if(f3!=null)
            {
                f3.Dispose();
            }
            
           

        }

        private void OnMouseEnterAttachment(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Attachment_gray;

        }

        private void OnMouseLeaveAttachment(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Attachment_black;
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

                animatedLabelFilename.Text = seperatedPath[seperatedPath.Length-1];
                tableLayoutPanelFileName.Show();

            }
        }

        private void OnClickSetMilestone(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<MilestoneDropDownForm>().Any())
            {
                //CloseForm();
               // return;
            }

            CloseForm();

            Point formPoint = buttonSetMilestone.PointToScreen(new Point(buttonSetMilestone.Location.X, buttonSetMilestone.Location.Y));

            MilestoneDropForm = new MilestoneDropDownForm();
            MilestoneDropForm.Show();
            MilestoneDropForm.Location = new Point(formPoint.X -3, formPoint.Y + buttonSetMilestone.Height);
            MilestoneDropForm.Size = new Size(buttonSetMilestone.Width , MilestoneDropForm.Height);

            MilestoneDropForm.MilestoneClick += OnClickMilestoneBtn ;
        }

        private void OnClickMilestoneBtn(object sender, EventArgs e)
        {
            Button clickedBtn = (sender as Button);

            buttonSetMilestone.Text = clickedBtn.Text;

            MilestoneDropForm.Dispose();
        }

        private void OnClickAssignBtn(object sender, EventArgs e)
        {
            
            CloseForm();

            Point formPoint = BtnAssignTo.PointToScreen(new Point(BtnAssignTo.Location.X, BtnAssignTo.Location.Y));
            TeamMembersDropForm = new TeamMembersListForm();

            TeamMembersDropForm.Show();
            TeamMembersDropForm.Location = new Point(formPoint.X - 3, formPoint.Y +10);
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

        private void OnMouseEnterCloseFile(object sender, EventArgs e)
        {
            pictureBoxCloseFile.Image = UserInterface.Properties.Resources.Close_Red;
        }

        private void OnMouseLeaveCloseFile(object sender, EventArgs e)
        {
            pictureBoxCloseFile.Image = UserInterface.Properties.Resources.Close_Black;
        }

        private void OnDiscar(object sender, EventArgs e)
        {

        }
    }
}
