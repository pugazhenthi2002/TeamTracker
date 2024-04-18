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
    public partial class FileAttachment : UserControl
    {

        public Dictionary<string, VersionAttachment> attachmentCollection;
        private PDFAttachment pdfAttachment;


        public FileAttachment()
        {
            InitializeComponent();
            AttachmentCollection = new Dictionary<string, VersionAttachment>();
        }

        public bool ClearAttachments
        {
            set
            {
                if (value == true)
                {
                    attachmentDisplayPanel.Controls.Clear();
                }
            }
        }

        public Dictionary<string, VersionAttachment> AttachmentCollection
        {
            get { return attachmentCollection; }
            set
            {
                if(value == null)
                {
                    attachmentCollection = null;
                }
            }
        }

        public new void Dispose()
        {
            for(int ctr=0; ctr < attachmentDisplayPanel.Controls.Count; ctr++)
            {
                (attachmentDisplayPanel.Controls[ctr] as PDFAttachment).Dispose();
                attachmentDisplayPanel.Controls.Remove(attachmentDisplayPanel.Controls[ctr]);
                ctr--;
            }
        }

        private void OnResize(object sender, EventArgs e)
        {
            int value = (tableLayoutPanel2.Width - 150) / 2;
            browseLabel.Margin = new Padding(value, 0, value, 0);
        }

        private void OnBrowseClick(object sender, EventArgs e)
        {
            if (attachmentCollection == null) attachmentCollection = new Dictionary<string, VersionAttachment>();

            openFileDialog = new OpenFileDialog
            {
                Title = "Open PDF File",
                Filter = "PDF Files (*.pdf)|*.pdf"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string safeFile = openFileDialog.SafeFileName;

                if (!AttachmentCollection.ContainsKey(safeFile))
                {
                    AttachmentCollection.Add(safeFile, new VersionAttachment()
                    {
                        DisplayName = safeFile,
                        AttachmentName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + ".pdf",
                        AttachmentLocation = selectedFilePath
                    });
                    AddAttachmentUI(safeFile);
                }
            }
        }

        private void AddAttachmentUI(string safeFile)
        {
            pdfAttachment = new PDFAttachment
            {
                Dock = DockStyle.Top,
                Height = 50,
                FileName = safeFile
            };
            pdfAttachment.BringToFront();
            pdfAttachment.AttachmentRemove += OnAttachmentRemoved;
            attachmentDisplayPanel.Controls.Add(pdfAttachment);
        }

        private void OnAttachmentRemoved(object sender, EventArgs e)
        {
            AttachmentCollection.Remove((sender as PDFAttachment).FileName);
            attachmentDisplayPanel.Controls.Remove(sender as PDFAttachment);
            (sender as PDFAttachment).Dispose();
        }


        private void OnBrowseMouseEnter(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.Blue;
        }

        private void OnBrowseMouseLeave(object sender, EventArgs e)
        {
            (sender as Label).BackColor = Color.RoyalBlue;
        }

        private void OnTablePanelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawLine(border, new Point(Width - 349, 0), new Point(Width - 349, tableLayoutPanel1.Height));
            border.Dispose();
        }
    }
}
