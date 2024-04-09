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
    public partial class UcMilestone : UserControl
    {
        private string milestoneName;
        private DateTime dueDate;


        public UcMilestone()
        {
            InitializeComponent();
            InitializeRoundedEdge();
        }

        public EventHandler<UcMilestone> milestoneClose;
        
        public string MilestoneName
        {
            get
            {
                return milestoneName;
            }
            set
            {
                milestoneName = value;
                SetMilestoneName();
            }
        }

        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value;
                SetDueDate();
            }
        }

        private void SetDueDate()
        {
            ucDueDate1.DueDate = dueDate;
        }

        private void SetMilestoneName()
        {
            animatedLabelMilestoneName.Text = milestoneName;
        }

        private void OnMouseEnterClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.close_Hover;
        }

        private void OnMouseLeaveClose(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Close;

        }

        private void OnClickClose(object sender, EventArgs e)
        {
            milestoneClose?.Invoke(sender, this);
            this.Dispose();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }


        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));

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
    }
}
