using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Home_Page.Team_Lead.On_Stage
{
    public partial class OnStageTemplate : UserControl
    {
        public event EventHandler ResetHomePage;
        public OnStageTemplate()
        {
            InitializeComponent();
        }

        public ProjectVersion SelectedVersion
        {
            set
            {
                if (value != null)
                {
                    ucNotFound1.Visible = false;
                    ucOnStage1.Visible = true;
                    ucOnStage1.SelectedVersion = value;
                }
                else
                {
                    ucOnStage1.Visible = false;
                    ucNotFound1.Visible = true;
                }
            }
        }

        private Color borderColor = Color.Blue;
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Point pt1 = new Point(9, 9);
            Point pt2 = new Point(Width - 11, 9);
            Point pt3 = new Point(Width - 11, Height - 11);
            Point pt4 = new Point(9, Height - 11);
            Pen border = new Pen(borderColor, 3);
            e.Graphics.DrawPolygon(border, new Point[] { pt1, pt2, pt3, pt4 });
        }

        private void OnResetHomePage(object sender, EventArgs e)
        {
            ResetHomePage?.Invoke(this, EventArgs.Empty);
        }
    }
}
