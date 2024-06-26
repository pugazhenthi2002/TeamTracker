﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Issues.My_Issue_Page
{
    public partial class SolutionAttachmentTemplate : UserControl
    {
        private IssueSolutionAttachment attachment;
        public IssueSolutionAttachment SelectedAttachment
        {
            set
            {
                if (value != null)
                {
                    attachment = value;
                    label1.Text = attachment.DisplayName;
                }
            }
        }

        public new void Dispose()
        {
            if (pictureBox1.Image != null) { pictureBox1.Image.Dispose(); }
            if (pictureBox2.Image != null) { pictureBox2.Image.Dispose(); }

            pictureBox1.Dispose();
            pictureBox2.Dispose();

            label1.Dispose();
        }

        public SolutionAttachmentTemplate()
        {
            InitializeComponent();
            InitializePageColor();
        }


        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.PrimaryI;
            label1.ForeColor = ThemeManager.CurrentTheme.SecondaryIII;

            pictureBox1.Image?.Dispose();
            pictureBox2.Image?.Dispose();

            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? Properties.Resources.Cold_Light_Document : Properties.Resources.Heat_Light_Document;
            pictureBox2.Image = Properties.Resources.Download_Light_Blue;
        }

        private void OnDownloadClick(object sender, EventArgs e)
        {
            string savePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Filter = "All files(*.*)| *.* ";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }
            string fileNetworkPath = attachment.IssueSolnAttachmentLocation;
            try
            {
                string fileName = System.IO.Path.GetFileName(fileNetworkPath);
                string filePath = System.IO.Path.GetDirectoryName(savePath);
                filePath = System.IO.Path.Combine(filePath, attachment.DisplayName);
                System.IO.File.Copy(fileNetworkPath, filePath, true);
                ProjectManagerMainForm.notify.AddNotification("Download Completed", attachment.DisplayName);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", attachment.DisplayName);
            }
        }
    }
}
