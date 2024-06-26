﻿using System;
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
    public partial class UcTaskCommits : UserControl
    {
        private string commitName;
        private Employee commitOwner ;
        private int sourceCodeId;

        public UcTaskCommits()
        {
            InitializeComponent();
            InitializePageColor();
            InitializeRoundedEdge();
        }


        public string CommitName
        {
            get { return commitName; }
            set
            {
                commitName = value;
                SetCommitName();
            }
        }

        public int SourceCodeId
        {
            get { return sourceCodeId; }
            set
            {
                sourceCodeId = value;
                SetSourceCodeId();
            }
        }

        public Employee CommitOwner
        {
            get { return commitOwner; }
            set
            {
                commitOwner = value;
                SetCommitOwner();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundedEdge();
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

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            labelCommitName.ForeColor = labelEmpName.ForeColor = ThemeManager.GetTextColor(BackColor);

            pictureBoxDownload.Image?.Dispose();

            pictureBoxDownload.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Download : UserInterface.Properties.Resources.Heat_Download;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            pictureBoxDownload.Image?.Dispose();
        }

        private void InitializeRoundedEdge()
        {
            //this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 10, 10));
        }
        private void SetSourceCodeId()
        {
            
        }
        private void SetCommitName()
        {
            labelCommitName.Text = commitName ;
        }

        private void SetCommitOwner()
        {
            EmpProfilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            EmpProfilePictureBox.ImageLocation = commitOwner.EmpProfileLocation;
            labelEmpName.Text = commitOwner.EmployeeFirstName;
        }
        

        private void OnMouseLeaveDownloadPicBox(object sender, EventArgs e)
        {
            pictureBoxDownload.Image?.Dispose();
            pictureBoxDownload.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Download : UserInterface.Properties.Resources.Heat_Download;
        }

        private void OnMouseEnterDownloadPicBox(object sender, EventArgs e)
        {
            pictureBoxDownload.Image?.Dispose();
            pictureBoxDownload.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Download_Hover : UserInterface.Properties.Resources.Heat_Download_Hover;
        }

        private void OnClickDownloadSourceCode(object sender, MouseEventArgs e)
        {
            SourceCode sourceCode = DataHandler.GetTaskSourceBySourceCodeID(sourceCodeId);

            string savePath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ZIP Folders(.ZIP)| *.zip";
            saveFileDialog.FilterIndex = 1;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                savePath = saveFileDialog.FileName;
            }

            string fileNetworkPath = sourceCode.SourceCodeLocation;
            try
            {
                System.IO.File.Copy(fileNetworkPath, savePath, true);
                ProjectManagerMainForm.notify.AddNotification("Download Completed", savePath);
            }
            catch
            {
                ProjectManagerMainForm.notify.AddNotification("Download Failed", savePath);
            }
        }
    }
}
