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

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public OnStageTemplate()
        {
            InitializeComponent();
            InitializePageColor();
        }

        public new void Dispose()
        {
            panel1.Dispose();   panel2.Dispose();   panel3.Dispose();   panel4.Dispose();   panel5.Dispose();
            label1.Dispose();   ucNotFound1.Dispose();  ucOnStage1.Dispose();
        }

        private void InitializePageColor()
        {
            label1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            label1.ForeColor = ThemeManager.GetTextColor(label1.BackColor);
            ucNotFound1.BackColor = ucOnStage1.BackColor = BackColor = ThemeManager.CurrentTheme.SecondaryIII;
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

        private Color borderColor = Color.Blue;
    }
}
