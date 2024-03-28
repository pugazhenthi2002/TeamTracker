﻿namespace TeamTracker
{
    partial class ProjectManagerMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagerMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.profilePicAndName1 = new TeamTracker.ProfilePicAndName();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucDeploy1 = new UserInterface.Home_Page.Project_Manager.Deploy.UcDeploy();
            this.ucNotificationBase1 = new TeamTracker.UcNotificationBase();
            this.ucNotificationBase2 = new TeamTracker.UcNotificationBase();
            this.ucNotificationBase3 = new TeamTracker.UcNotificationBase();
            this.ucNotificationBase4 = new TeamTracker.UcNotificationBase();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 480);
            this.panel1.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.headerPanel.Controls.Add(this.profilePicAndName1);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(254, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.headerPanel.Size = new System.Drawing.Size(558, 57);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnHeaderPanelPaint);
            // 
            // profilePicAndName1
            // 
            this.profilePicAndName1.BackColor = System.Drawing.Color.Transparent;
            this.profilePicAndName1.Dock = System.Windows.Forms.DockStyle.Right;
            this.profilePicAndName1.EmployeeProfile = null;
            this.profilePicAndName1.Location = new System.Drawing.Point(247, 0);
            this.profilePicAndName1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilePicAndName1.Name = "profilePicAndName1";
            this.profilePicAndName1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.profilePicAndName1.Size = new System.Drawing.Size(257, 54);
            this.profilePicAndName1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(504, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel3.Controls.Add(this.ucDeploy1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(254, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(558, 423);
            this.panel3.TabIndex = 2;
            // 
            // ucDeploy1
            // 
            this.ucDeploy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucDeploy1.Location = new System.Drawing.Point(57, 76);
            this.ucDeploy1.Name = "ucDeploy1";
            this.ucDeploy1.Size = new System.Drawing.Size(380, 166);
            this.ucDeploy1.TabIndex = 0;
            // 
            // ucNotificationBase1
            // 
            this.ucNotificationBase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotificationBase1.Location = new System.Drawing.Point(0, 0);
            this.ucNotificationBase1.Name = "ucNotificationBase1";
            this.ucNotificationBase1.NotifyList = ((System.Collections.Generic.List<TeamTracker.Notify>)(resources.GetObject("ucNotificationBase1.NotifyList")));
            this.ucNotificationBase1.Size = new System.Drawing.Size(391, 272);
            this.ucNotificationBase1.TabIndex = 0;
            // 
            // ucNotificationBase2
            // 
            this.ucNotificationBase2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotificationBase2.Location = new System.Drawing.Point(0, 0);
            this.ucNotificationBase2.Name = "ucNotificationBase2";
            this.ucNotificationBase2.NotifyList = ((System.Collections.Generic.List<TeamTracker.Notify>)(resources.GetObject("ucNotificationBase2.NotifyList")));
            this.ucNotificationBase2.Size = new System.Drawing.Size(391, 272);
            this.ucNotificationBase2.TabIndex = 0;
            // 
            // ucNotificationBase3
            // 
            this.ucNotificationBase3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotificationBase3.Location = new System.Drawing.Point(0, 0);
            this.ucNotificationBase3.Name = "ucNotificationBase3";
            this.ucNotificationBase3.NotifyList = ((System.Collections.Generic.List<TeamTracker.Notify>)(resources.GetObject("ucNotificationBase3.NotifyList")));
            this.ucNotificationBase3.Size = new System.Drawing.Size(568, 386);
            this.ucNotificationBase3.TabIndex = 0;
            // 
            // ucNotificationBase4
            // 
            this.ucNotificationBase4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotificationBase4.Location = new System.Drawing.Point(0, 0);
            this.ucNotificationBase4.Name = "ucNotificationBase4";
            this.ucNotificationBase4.NotifyList = ((System.Collections.Generic.List<TeamTracker.Notify>)(resources.GetObject("ucNotificationBase4.NotifyList")));
            this.ucNotificationBase4.Size = new System.Drawing.Size(568, 386);
            this.ucNotificationBase4.TabIndex = 0;
            // 
            // ProjectManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectManagerMainForm";
            this.Text = "ProjectManagerMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TeamTracker.ProfilePicAndName profilePicAndName1;
        private UcNotificationBase ucNotificationBase1;
        private UcNotificationBase ucNotificationBase2;
        private UcNotificationBase ucNotificationBase3;
        private UcNotificationBase ucNotificationBase4;
        private UserInterface.Home_Page.Project_Manager.Deploy.UcDeploy ucDeploy1;
    }
}