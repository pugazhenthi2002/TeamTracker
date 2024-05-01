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
using System.Reflection;

namespace UserInterface.Issues.My_Issue_Page
{
    public partial class SolutionTemplate : UserControl
    {
        private int remainingHeight = 0;
        private Label label1 = new Label();
        private Rectangle rec = new Rectangle();
        private IssueSolution selectedSolution;
        public IssueSolution SelectedSolution
        {
            set
            {
                if (value != null)
                {
                    selectedSolution = value;
                    InitializePage();
                }
            }
        }

        public SolutionTemplate()
        {
            DoubleBuffered = true;
            InitializeComponent();
            //MouseWheel += SolutionTemplate_MouseWheel;
        }

        private void SolutionTemplate_MouseWheel(object sender, MouseEventArgs e)
        {
            rec = DisplayRectangle;
            rec.Width -= 5;
            rec.Height = rec.Height - 5 - remainingHeight;
            this.Invalidate();
        }

        public new void Dispose()
        {
            for (int ctr = 0; ctr < Controls.Count; ctr++)
            {
                if (Controls[ctr] is PictureBox)
                {
                    if ((Controls[ctr] as PictureBox).Image != null) (Controls[ctr] as PictureBox).Image.Dispose();
                }
                (Controls[ctr] as Control).Dispose();
                ctr--;
            }
        }

        private void InitializePage()
        {
            remainingHeight = 0;
            IssueSolutionAttachment attachment = DataHandler.FetchIssueSolutionAttachment(selectedSolution.IssueSolutionID);
            string extension = "";

            if (attachment != null)
                extension = System.IO.Path.GetExtension(attachment.IssueSolnAttachmentLocation);
            label1 = new Label()
            {
                Name = "label1",
                AutoSize = true,
                Dock = DockStyle.Top,
                BackColor = Color.Transparent,
                Font = new Font(new FontFamily("Ebrima"), 12, FontStyle.Regular),
                ForeColor = Color.FromArgb(40, 50, 80),
                Text = selectedSolution.Solution,
                MaximumSize = new Size(Width - 20, 0),
                MinimumSize = new Size(Width - 20, 0),
                Padding = new Padding(10)
            };
            Controls.Add(label1);
            rec = DisplayRectangle;
            rec.Width -= 5;
            rec.Height -= 5;

            if (extension == ".png" || extension == ".jpeg" || extension == ".jpg")
            {
                PictureBox picBox = new PictureBox()
                {
                    Dock = DockStyle.Top,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Location = new Point(0, label1.Height),
                    Width = Width - 20,
                    BackColor = Color.Transparent,
                    Height = 400
                };

                Controls.Add(picBox);
                try
                {
                    picBox.Image = Image.FromFile(attachment.IssueSolnAttachmentLocation);
                }
                catch
                {
                    ;
                }

                rec = DisplayRectangle;
                rec.Width -= 5;
                rec.Height -= 5;
                typeof(PictureBox).InvokeMember("DoubleBuffered", BindingFlags.Instance | BindingFlags.SetProperty | BindingFlags.NonPublic, null, picBox, new object[] { true });
                picBox.BringToFront();
            }
            else if (extension != "")
            {
                Panel panel1 = new Panel()
                {
                    Dock = DockStyle.Top,
                    Padding = new Padding(50,0,50,0)
                };

                Label label2 = new Label()
                {
                    Name = "label2",
                    Dock = DockStyle.Fill,
                    AutoSize = false,
                    Location = new Point(0, label1.Height),
                    Font = new Font(new FontFamily("Ebrima"), 14, FontStyle.Bold),
                    ForeColor = Color.FromArgb(40, 50, 80),
                    Text = "Attachments",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = Width,
                    Height = 30
                };
                panel1.Controls.Add(label2);
                Controls.Add(panel1);
                remainingHeight += label2.Height;
                SolutionAttachmentTemplate attachmentTemplate = new SolutionAttachmentTemplate()
                {
                    SelectedAttachment = attachment,
                    Location = new Point(0, label2.Location.Y + label2.Height),
                    Width = Width,
                    Height = 40
                };
                Controls.Add(attachmentTemplate);
                attachmentTemplate.SendToBack();
                panel1.SendToBack();
            }

            ProfilePicAndName profile = new ProfilePicAndName()
            {
                Dock = DockStyle.Top,
                EmployeeProfile = EmployeeManager.FetchEmployeeFromID(selectedSolution.SolvedByID),
                Location = new Point(0, DisplayRectangle.Height)
            };
            remainingHeight += profile.Height;
            Controls.Add(profile);

            profile.SendToBack();
            label1.SendToBack();
            this.Invalidate();
        }

        private void OnContentBorderPaint(object sender, PaintEventArgs e)
        {
            rec = DisplayRectangle;
            rec.Width -= 5;
            rec.Height = rec.Height - 5 - remainingHeight;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(221, 230, 237), 2);
            e.Graphics.DrawPath(border, BorderGraphicsPath.GetRoundRectangle(rec, 10));
            border.Dispose();
        }

        private void OnScrolled(object sender, ScrollEventArgs e)
        {

        }
    }
}