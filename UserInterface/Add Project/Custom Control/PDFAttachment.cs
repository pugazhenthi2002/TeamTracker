using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class PDFAttachment : UserControl
    {
        public event EventHandler AttachmentRemove;
        public string FileName
        {
            get
            {
                return label1.Text;
            }

            set
            {
                label1.Text = value;
            }
        }

        public PDFAttachment()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
            closePicBox.Click -= OnCloseCLick;  closePicBox.MouseEnter -= OnCloseMouseEnter;    closePicBox.MouseLeave -= OnCloseMouseLeave;

            pictureBox1.Image?.Dispose();
            closePicBox.Image?.Dispose();
        }

        private void InitializePageColor()
        {
            panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            label1.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);

            pictureBox1.Image?.Dispose();
            closePicBox.Image?.Dispose();

            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                pictureBox1.Image = UserInterface.Properties.Resources.Cold_Light_Document;
                closePicBox.Image = UserInterface.Properties.Resources.Cold_Close_Light;
            }
            else
            {
                pictureBox1.Image = UserInterface.Properties.Resources.Heat_Light_Document;
                closePicBox.Image = UserInterface.Properties.Resources.Heat_Close_Light;
            }
        }

        private void OnCloseCLick(object sender, EventArgs e)
        {
            AttachmentRemove?.Invoke(this, e);
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (closePicBox.Image != null)
                closePicBox.Image.Dispose();

            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                closePicBox.Image = UserInterface.Properties.Resources.Cold_Close_Light_Hover;
            }
            else
            {
                closePicBox.Image = UserInterface.Properties.Resources.Heat_Close_Light_Hover;
            }
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            if (closePicBox.Image != null)
                closePicBox.Image.Dispose();

            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                closePicBox.Image = UserInterface.Properties.Resources.Cold_Close_Light;
            }
            else
            {
                closePicBox.Image = UserInterface.Properties.Resources.Heat_Close_Light;
            }
        }
    }
}
