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

        public UcOnStage()
        {
            InitializeComponent();
            InitializeRoundedEdge();
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

            addMilestoneForm.Location = PointToScreen(new Point(e.Location.X + 320, e.Location.Y + 10));
            addMilestoneForm.ClickAdd += OnClickAddMilestoneForm;
            addMilestoneForm.Show();
        }

        private void OnClickAddMilestoneForm(object sender, EventArgs e)
        {
            

            UcMilestone milestone = new UcMilestone();
            milestone.MilestoneName = addMilestoneForm.MileStoneName;
            milestone.DueDate = addMilestoneForm.To;
            milestone.Dock = DockStyle.Top;
            milestone.Size = new Size(panelMilestone.Width , 40);

            panelMilestone.Controls.Add(milestone);


        }

        private void CloseForm()
        {
            var f1 = (Application.OpenForms.OfType<AddMilestoneForm>().FirstOrDefault());

            if (f1 != null)
            {
                f1.Close();
            }
            

        }


    }
}
