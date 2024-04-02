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
        public UcCreateTask()
        {
            InitializeComponent();
            InitializeRoundedEdge();

        }

        PriorityDropDownForm PriortyDropForm;

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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            textBoxTaskName.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxTaskName.Width, textBoxTaskName.Height, 20, 20));
            textBoxDesc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxDesc.Width, textBoxDesc.Height, 20, 20));
            buttonCreate.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonCreate.Width, buttonCreate.Height, 10, 10));
            buttonDiscard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonDiscard.Width, buttonDiscard.Height, 10, 10));
            

        }

        private void OnMouseEnterSetPriority(object sender, EventArgs e)
        {
                labelSetPriority.BackColor = Color.FromArgb(157, 178, 191);
                pictureBoxFlag.BackColor = Color.FromArgb(157, 178, 191);
            
        }

        private void OnMouseLeaveSetPriority(object sender, EventArgs e)
        {
            labelSetPriority.BackColor = Color.Transparent;
            pictureBoxFlag.BackColor = Color.Transparent;
        }

        private void OnClickSetPriority(object sender, MouseEventArgs e)
        {
            if (Application.OpenForms.OfType<PriorityDropDownForm>().Any())
            {
                CloseForm();
                return;
            }
            else if (Application.OpenForms.OfType<PriorityDropDownForm>().Any())
            {
                CloseForm();
            }


            Point formPoint = pictureBoxFlag.PointToScreen(new Point(pictureBoxFlag.Location.X, pictureBoxFlag.Location.Y));

            PriortyDropForm = new PriorityDropDownForm();
            PriortyDropForm.Show();
            PriortyDropForm.Location = new Point(formPoint.X - pictureBoxFlag.Margin.Left, formPoint.Y + pictureBoxFlag.Height);
            PriortyDropForm.Size = new Size(labelSetPriority.Width +pictureBoxFlag.Width , PriortyDropForm.Height);

            PriortyDropForm.PriorityBtnClicked += OnClickPriorityBtn;

            
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
            pictureBoxFlag.Image = fImage;

        }

        private void CloseForm()
        {
            var f1 = (Application.OpenForms.OfType<PriorityDropDownForm>().FirstOrDefault());

            if (f1 != null)
            {
                f1.Dispose();
            }
           

        }
    }
}
