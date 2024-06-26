﻿using System;
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
        public bool Clear
        {
            set
            {
                if (value == true)
                {
                    ClearAttachments();
                }
            }
        }

        public Dictionary<string, VersionAttachment> AttachmentCollection
        {
            get { return attachmentCollection; }
            set
            {
                attachmentCollection = value;
                if(value != null)
                {
                    foreach(var Iter in value)
                    {
                        AddAttachmentUI(Iter.Key);
                    }
                }
            }
        }

        public FileAttachment()
        {
            InitializeComponent();
            InitializePageColor();
            AttachmentCollection = new Dictionary<string, VersionAttachment>();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            for (int ctr = 0; ctr < attachmentDisplayPanel.Controls.Count; ctr++)
            {
                (attachmentDisplayPanel.Controls[ctr] as PDFAttachment).AttachmentRemove -= OnAttachmentRemoved;
                (attachmentDisplayPanel.Controls[ctr] as PDFAttachment).Dispose();
                ctr--;
            }

            ThemeManager.ThemeChange -= OnThemeChanged;
            browseLabel.Click -= OnBrowseClick; browseLabel.MouseEnter -= OnBrowseMouseEnter;   browseLabel.MouseLeave -= OnBrowseMouseLeave;
            tableLayoutPanel1.Paint -= OnTablePanelPaint;

            pictureBox1.Image?.Dispose();
        }

        public void ClearAttachments()
        {
            for (int ctr = 0; ctr < attachmentDisplayPanel.Controls.Count; ctr++)
            {
                (attachmentDisplayPanel.Controls[ctr] as PDFAttachment).AttachmentRemove -= OnAttachmentRemoved;
                (attachmentDisplayPanel.Controls[ctr] as PDFAttachment).Dispose();
                ctr--;
            }
        }

        private void InitializePageColor()
        {
            browseLabel.BackColor = label1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            browseLabel.ForeColor = label1.ForeColor = ThemeManager.GetTextColor(browseLabel.BackColor);
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;

            pictureBox1.Image?.Dispose();

            if(ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                pictureBox1.Image = UserInterface.Properties.Resources.Cold_Browse;
            }
            else
            {
                pictureBox1.Image = UserInterface.Properties.Resources.Heat_Browse;
            }
        }

        private void OnBrowseClick(object sender, EventArgs e)
        {
            if (attachmentCollection == null) attachmentCollection = new Dictionary<string, VersionAttachment>();

            openFileDialog = new OpenFileDialog
            {
                Title = "Choose Your File",
                Filter = "All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string safeFile = openFileDialog.SafeFileName;
                string extension = System.IO.Path.GetExtension(openFileDialog.SafeFileName);

                if (!AttachmentCollection.ContainsKey(safeFile))
                {
                    AttachmentCollection.Add(safeFile, new VersionAttachment()
                    {
                        DisplayName = safeFile,
                        AttachmentName = "" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second + extension,
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
            pdfAttachment.AttachmentRemove += OnAttachmentRemoved;
            attachmentDisplayPanel.Controls.Add(pdfAttachment);
            foreach(Control Iter in attachmentDisplayPanel.Controls)
            {
                Iter.BringToFront();
            }
        }

        private void OnAttachmentRemoved(object sender, EventArgs e)
        {
            (sender as PDFAttachment).AttachmentRemove -= OnAttachmentRemoved;
            AttachmentCollection.Remove((sender as PDFAttachment).FileName);
            attachmentDisplayPanel.Controls.Remove(sender as PDFAttachment);
            (sender as PDFAttachment).Dispose();
        }


        private void OnBrowseMouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            (sender as Label).BackColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.PrimaryI);
            (sender as Label).ForeColor = ThemeManager.GetTextColor((sender as Label).BackColor);
        }

        private void OnBrowseMouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            (sender as Label).BackColor = ThemeManager.CurrentTheme.PrimaryI;
            (sender as Label).ForeColor = ThemeManager.GetTextColor((sender as Label).BackColor);
        }

        private void OnTablePanelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(Width - 349, 0), new Point(Width - 349, tableLayoutPanel1.Height));
            border.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int value = (tableLayoutPanel2.Width - 150) / 2;
            browseLabel.Margin = new Padding(value, 0, value, 0);
        }

        public Dictionary<string, VersionAttachment> attachmentCollection;
        private PDFAttachment pdfAttachment;
    }
}
