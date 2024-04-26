using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class SolveNotesForm : Form
    {
        private PictureBox curStyle;
        private FontStyle currentFontStyle;
        private string style;
        private Point mouseDownPoint;
        private bool isDragging = false;
        private Issue currentIssue = null;
        IssueSolutionAttachment solnAttachment;

        public SolveNotesForm()
        {
            InitializeComponent();
            InitializeRoundedEdge();
            labelAttachmentCount.Visible = false;
            this.BackColor = Color.FromArgb(255,255,254);
            labelWarning.Hide();
            toolTip1.SetToolTip(labelAttachmentCount, "Click to remove attachment");


            //this.TransparencyKey = Color.FromArgb(255, 255, 254);
            //ucOptions1.Location = new Point(0, 0);
            //ucOptions1.Visible = false;
            //ucOptions1.BringToFront();
            //ucOptions1.colorChange += OnColorChange;
            //ucOptions1.DeleteNoteClick += OnClickDeleteNoteBtn;

        }

        public SolveNotesForm(Issue issue)
        {
            InitializeComponent();
            InitializeRoundedEdge();
            labelAttachmentCount.Visible = false;
            this.BackColor = Color.FromArgb(255, 255, 254);
            labelWarning.Hide();
            currentIssue = issue;
        }

        public EventHandler<FontStyle> TextChange;
        public EventHandler tempTextChange;
        public EventHandler<Color> ColorChange;
        public EventHandler DeleteNote;
        public EventHandler AddNoteClick;
        public EventHandler DeleteNoteForm;

        

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
            labelAttachmentCount.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, labelAttachmentCount.Width, labelAttachmentCount.Height, labelAttachmentCount.Width, labelAttachmentCount.Height));

          
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath path = new GraphicsPath();
            g.SmoothingMode = SmoothingMode.AntiAlias;

            path.AddArc(0, 0, 15 * 2, 15 * 2, 180, 90); // Top-left corner
            path.AddArc(this.Width - 2 * 15, 0, 15 * 2, 15 * 2, 270, 90); // Top-right corner
            path.AddArc(this.Width - 2 * 15, 0 + this.Height - 2 * 15, 15 * 2, 15 * 2, 0, 90); // Bottom-right corner
            path.AddArc(0, this.Height - 2 * 15, 15 * 2, 15 * 2, 90, 90); // Bottom-left corner

            path.CloseFigure();

            g.FillPath(new SolidBrush(Color.White), path);
        }


        private void OnClickNotesTextBox(object sender, MouseEventArgs e)
        {
            //ucOptions1.Visible = false;
        }

        private void OnClickTextStyle(object sender, EventArgs e)
        {
            curStyle = (sender as PictureBox);
            style = curStyle.Name;

            
            if (style != "ImagePicBox")
            {
                curStyle.BackColor = curStyle.BackColor != Color.Silver ? Color.Silver : Color.Transparent;
            }
            else
            {
                //return;
            }


            switch(style)
            {
                case "BoldPicBox":
                    ToggleFormatting(FontStyle.Bold);
                    break;
                case "ItalicPicBox":
                    ToggleFormatting(FontStyle.Italic);
                    break;
                case "UnderLinePicBox":
                    ToggleFormatting(FontStyle.Underline);
                    break;
                case "StrikeOutPicBox":
                    ToggleFormatting(FontStyle.Strikeout);
                    break;
                case "BulletesPicBox":
                    ToggleBulletPoint();
                    break;
                
            }
        }

        private void ToggleFormatting(FontStyle fontStyle)
        {
            NotesTextBox.SelectionFont = new Font(NotesTextBox.Font, NotesTextBox.SelectionFont.Style ^ fontStyle);
            currentFontStyle = fontStyle;
            //NotesTextBox.Focus(); 
        }

        private void ToggleBulletPoint()
        {
            int selectionStart = NotesTextBox.SelectionStart;

            NotesTextBox.SelectionBullet = !NotesTextBox.SelectionBullet;

            NotesTextBox.SelectionStart = selectionStart;
            NotesTextBox.Focus(); 
        }
        

        private void OnColorChange(object sender, Color e)
        {
            if (e == Color.Transparent) return;

            

            TopPanel.BackColor =e;
            BottomPanel.BackColor = e;

            NotesTextBox.BackColor = AdjustColorContrast(e,.8f);
            ColorChange?.Invoke(this, NotesTextBox.BackColor);

            this.BackColor = Color.FromArgb(255, 255, 254);
            this.TransparencyKey = Color.FromArgb(255, 255, 254);
            Invalidate();
        }

        private Color AdjustColorContrast(Color color, float contrastFactor)
        {
            float r = color.R / 255.0f;
            float g = color.G / 255.0f;
            float b = color.B / 255.0f;

            r = (r - 0.5f) * contrastFactor + 0.5f;
            g = (g - 0.5f) * contrastFactor + 0.5f;
            b = (b - 0.5f) * contrastFactor + 0.5f;

            r = Math.Max(0, Math.Min(1, r));
            g = Math.Max(0, Math.Min(1, g));
            b = Math.Max(0, Math.Min(1, b));

            return Color.FromArgb(color.A, (int)(r * 255), (int)(g * 255), (int)(b * 255));
        }

        private void OnTextChanged(object sender, EventArgs e)
        {



            TextChange?.Invoke(sender, FontStyle.Regular);

            //switch (style)
            //{
            //    case "BoldPicBox":
            //        if (curStyle.BackColor == Color.Gray)
            //        {
            //            TextChange?.Invoke(sender, FontStyle.Bold);
            //        }
            //        break;
            //    case "ItalicPicBox":
            //        if (curStyle.BackColor == Color.Gray)
            //        {
            //            TextChange?.Invoke(sender, FontStyle.Italic);
            //        }
            //        break;
            //    case "UnderLinePicBox":
            //        if (curStyle.BackColor == Color.Gray)
            //        {
            //            TextChange?.Invoke(sender, FontStyle.Underline);
            //        }
            //        break;
            //    case "StrikeOutPicBox":
            //        if (curStyle.BackColor == Color.Gray)
            //        {
            //            TextChange?.Invoke(sender, FontStyle.Strikeout);
            //        }
            //        break;
            //    case "BulletesPicBox":
            //        break;
            //    case "ImagePicBox":
            //        break;
            //    default:
            //        TextChange?.Invoke(sender, FontStyle.Regular);
            //        break;
            //}




        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = e.Location;
            isDragging = true;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if(isDragging) this.Location = new Point(Cursor.Position.X - mouseDownPoint.X, Cursor.Position.Y - mouseDownPoint.Y);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        private void OnClickAddAttachment(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open File";
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string safeFile = openFileDialog.SafeFileName;
                labelAttachmentCount.Visible = true;

                solnAttachment = new IssueSolutionAttachment()
                {
                    DisplayName = safeFile,
                    IssueSolnAttachmentName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".pdf",
                    IssueSolnAttachmentLocation = selectedFilePath
                };

            }
            else
            {
                labelAttachmentCount.Visible = false;
            }
        }

        private void OnClickDiscard(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Attachment_gray;

        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = UserInterface.Properties.Resources.Attachment_black;
        }

        private void OnClickPost(object sender, EventArgs e)
        {
            if(NotesTextBox.Text=="")
            {
                labelWarning.Text = "Add Solution";
                labelWarning.Show();
                return;
            }

            IssueSolution soln = new IssueSolution()
            {
                IssueID = currentIssue.IssueID,
                Solution = NotesTextBox.Text,
                SolvedByID = EmployeeManager.CurrentEmployee.EmployeeID
            };


            IssueManager.AddSolution(soln,solnAttachment);

            this.Close();
        }

        private void OnPaintLabel(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(201, 210, 217), 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(pen, BorderGraphicsPath.GetRoundRectangle(new Rectangle(0, 0, labelAttachmentCount.Width - 1, labelAttachmentCount.Height - 1), labelAttachmentCount.Width / 2));

            pen.Dispose();
        }

        private void OnClickAttachmentCount(object sender, EventArgs e)
        {
            labelAttachmentCount.Visible = false;
            solnAttachment = null;

        }

        private void OnMouseEnterTextStyle(object sender, EventArgs e)
        {
            curStyle = (sender as PictureBox);
            style = curStyle.Name;


            switch (style)
            {
                case "BoldPicBox":
                    curStyle.Image = UserInterface.Properties.Resources.bold_gray;
                    break;
                case "ItalicPicBox":
                    curStyle.Image = UserInterface.Properties.Resources.Italic_gray;
                    break;
                case "UnderLinePicBox":
                    curStyle.Image = UserInterface.Properties.Resources.underline_gray;
                    break;
                case "StrikeOutPicBox":
                    curStyle.Image = UserInterface.Properties.Resources.strikethrough_gray;
                    break;
                case "BulletesPicBox":
                    curStyle.Image = UserInterface.Properties.Resources.bullet_list_gray;
                    break;

            }
        }

        private void OnMouseLeaveTextStyle(object sender, EventArgs e)
        {
            curStyle = (sender as PictureBox);
            style = curStyle.Name;

            
            switch (style)
            {
                case "BoldPicBox":
                    curStyle.Image = UserInterface.Properties.Resources.Bold;
                    break;
                case "ItalicPicBox":
                    curStyle.Image = UserInterface.Properties.Resources.italic;
                    break;
                case "UnderLinePicBox":
                    curStyle.Image = UserInterface.Properties.Resources.underline;
                    break;
                case "StrikeOutPicBox":
                    curStyle.Image = UserInterface.Properties.Resources.strikethrough;
                    break;
                case "BulletesPicBox":
                    curStyle.Image = UserInterface.Properties.Resources.bullets;
                    break;

            }

        }
    }
}
