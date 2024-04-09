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
    public partial class UcOnStage : UserControl
    {

        private AddMilestoneForm addMilestoneForm;
        private List<UcMilestone> milestoneList = new List<UcMilestone>();

        public UcOnStage()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            toolTip1.SetToolTip(pictureBoxDownload, "Download Attachements");

        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }


        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            labelProjNameandVersion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelProjNameandVersion.Width, labelProjNameandVersion.Height, 20, 20));
            labelClientName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelClientName.Width, labelClientName.Height, 20, 20));
            buttonDiscard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonDiscard.Width, buttonDiscard.Height, 10, 10));
            buttonOnStage.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonOnStage.Width, buttonOnStage.Height, 10, 10));

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
        private void OnPaintPanelBaseMilestone(object sender, PaintEventArgs e)
        {
            Point pt1 = new Point(4, 4);
            Point pt2 = new Point((sender as Panel).Width - 6, 4);
            Point pt3 = new Point((sender as Panel).Width - 6, (sender as Panel).Height - 6);
            Point pt4 = new Point(4, (sender as Panel).Height - 6);
            Pen border = new Pen(Color.Black, 2);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private void OnClickAddMilestone(object sender, MouseEventArgs e)
        {
            if (Application.OpenForms.OfType<AddMilestoneForm>().Any())
            {
                CloseForm();
                return;
            }

            addMilestoneForm = new AddMilestoneForm();

            addMilestoneForm.Location = buttonAddMilestone.PointToScreen(new Point(0,buttonAddMilestone.Height+3));
            addMilestoneForm.ClickAdd += OnClickAddMilestoneForm;
            addMilestoneForm.ProjectFrom = ucStartDate.DueDate;
            addMilestoneForm.ProjectTo = ucToDate.DueDate;

            addMilestoneForm.Show();
        }

        private void OnClickAddMilestoneForm(object sender, EventArgs e)
        {
            
            UcMilestone milestone = new UcMilestone();
            milestone.MilestoneName = addMilestoneForm.MileStoneName;
            milestone.DueDate = addMilestoneForm.To;
            milestone.Dock = DockStyle.Top;
            milestone.Size = new Size(panelMilestone.Width , 40);
            milestone.milestoneClose += OnClickCloseMilestone;
            panelMilestone.Controls.Add(milestone);

            milestoneList.Add(milestone);

        }

        private void OnClickCloseMilestone(object sender, UcMilestone e)
        {
            milestoneList.Remove(e);
        }

        private void CloseForm()
        {
            var f1 = (Application.OpenForms.OfType<AddMilestoneForm>().FirstOrDefault());

            if (f1 != null)
            {
                f1.Close();
            }

        }

        private void OnClickDownloadAttachement(object sender, EventArgs e)
        {

        }



        private void OnMouseEnterDownload(object sender, EventArgs e)
        {
            labelDownload.Font = new Font(labelDownload.Font.FontFamily, 10, labelDownload.Font.Style);
            pictureBoxDownload.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void OnMouseLeaveDownload(object sender, EventArgs e)
        {
            labelDownload.Font = new Font(labelDownload.Font.FontFamily, 9, labelDownload.Font.Style);
            pictureBoxDownload.SizeMode = PictureBoxSizeMode.CenterImage;
        }




        private void OnClickDiscard(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void OnClickStageProject(object sender, EventArgs e)
        {
            if(milestoneList.Count<4 || milestoneList.Count>20)
            {
                ProjectManagerMainForm.notify.AddNotification("Warning","Milestone count should be greater than 4 and lesser than 20");
            }
        }
    }
}
