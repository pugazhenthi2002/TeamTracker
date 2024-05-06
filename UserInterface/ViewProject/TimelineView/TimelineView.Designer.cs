using TeamTracker;

namespace UserInterface.ViewProject.TimelineView
{
    partial class TimelineView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timelinePaginate1 = new TeamTracker.TimelinePaginate();
            this.milestoneLabelPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.versionNames = new System.Windows.Forms.Label();
            this.dropDownPicBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.projectDisplayPanel = new System.Windows.Forms.Panel();
            this.projectDownBox = new System.Windows.Forms.PictureBox();
            this.projectUpBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownPicBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "No Project Found !!";
            this.ucNotFound1.HeadTextSize = 20;
            this.ucNotFound1.Location = new System.Drawing.Point(0, 0);
            this.ucNotFound1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(2055, 808);
            this.ucNotFound1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.milestoneLabelPanel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2055, 808);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.timelinePaginate1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(78, 66);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(1977, 665);
            this.panel5.TabIndex = 5;
            // 
            // timelinePaginate1
            // 
            this.timelinePaginate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelinePaginate1.Location = new System.Drawing.Point(22, 0);
            this.timelinePaginate1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.timelinePaginate1.Name = "timelinePaginate1";
            this.timelinePaginate1.Size = new System.Drawing.Size(1955, 665);
            this.timelinePaginate1.TabIndex = 4;
            // 
            // milestoneLabelPanel
            // 
            this.milestoneLabelPanel.AutoScroll = true;
            this.milestoneLabelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.milestoneLabelPanel.Location = new System.Drawing.Point(78, 731);
            this.milestoneLabelPanel.Name = "milestoneLabelPanel";
            this.milestoneLabelPanel.Padding = new System.Windows.Forms.Padding(68, 35, 0, 3);
            this.milestoneLabelPanel.Size = new System.Drawing.Size(1977, 77);
            this.milestoneLabelPanel.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(78, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.panel3.Size = new System.Drawing.Size(1977, 66);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panel4.Size = new System.Drawing.Size(658, 66);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.versionNames);
            this.panel7.Controls.Add(this.dropDownPicBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(319, 3);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panel7.Size = new System.Drawing.Size(336, 60);
            this.panel7.TabIndex = 3;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.OnVersionSwitchPanelPaint);
            // 
            // versionNames
            // 
            this.versionNames.BackColor = System.Drawing.Color.Transparent;
            this.versionNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionNames.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.versionNames.Location = new System.Drawing.Point(3, 3);
            this.versionNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.versionNames.Name = "versionNames";
            this.versionNames.Size = new System.Drawing.Size(297, 54);
            this.versionNames.TabIndex = 3;
            this.versionNames.Text = "On Process Version";
            this.versionNames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropDownPicBox
            // 
            this.dropDownPicBox.BackColor = System.Drawing.Color.Transparent;
            this.dropDownPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDownPicBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.dropDownPicBox.Image = global::UserInterface.Properties.Resources.Down_Dark_Blue;
            this.dropDownPicBox.Location = new System.Drawing.Point(300, 3);
            this.dropDownPicBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dropDownPicBox.Name = "dropDownPicBox";
            this.dropDownPicBox.Size = new System.Drawing.Size(33, 54);
            this.dropDownPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dropDownPicBox.TabIndex = 0;
            this.dropDownPicBox.TabStop = false;
            this.dropDownPicBox.Click += new System.EventHandler(this.VersionNamesClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.projectDisplayPanel);
            this.panel2.Controls.Add(this.projectDownBox);
            this.panel2.Controls.Add(this.projectUpBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 66, 0, 77);
            this.panel2.Size = new System.Drawing.Size(78, 808);
            this.panel2.TabIndex = 2;
            // 
            // projectDisplayPanel
            // 
            this.projectDisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.projectDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectDisplayPanel.Location = new System.Drawing.Point(0, 97);
            this.projectDisplayPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectDisplayPanel.Name = "projectDisplayPanel";
            this.projectDisplayPanel.Size = new System.Drawing.Size(78, 603);
            this.projectDisplayPanel.TabIndex = 2;
            // 
            // projectDownBox
            // 
            this.projectDownBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectDownBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectDownBox.Image = global::UserInterface.Properties.Resources.Down_Medium_Blue;
            this.projectDownBox.Location = new System.Drawing.Point(0, 700);
            this.projectDownBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectDownBox.Name = "projectDownBox";
            this.projectDownBox.Size = new System.Drawing.Size(78, 31);
            this.projectDownBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.projectDownBox.TabIndex = 1;
            this.projectDownBox.TabStop = false;
            this.projectDownBox.Click += new System.EventHandler(this.projectDownClick);
            this.projectDownBox.MouseEnter += new System.EventHandler(this.OnProjectPaginateMouseEnter);
            this.projectDownBox.MouseLeave += new System.EventHandler(this.OnProjectPaginateMouseLeave);
            // 
            // projectUpBox
            // 
            this.projectUpBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectUpBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectUpBox.Image = global::UserInterface.Properties.Resources.Up_Medium_Blue;
            this.projectUpBox.Location = new System.Drawing.Point(0, 66);
            this.projectUpBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.projectUpBox.Name = "projectUpBox";
            this.projectUpBox.Size = new System.Drawing.Size(78, 31);
            this.projectUpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.projectUpBox.TabIndex = 0;
            this.projectUpBox.TabStop = false;
            this.projectUpBox.Click += new System.EventHandler(this.projectUpClick);
            this.projectUpBox.MouseEnter += new System.EventHandler(this.OnProjectPaginateMouseEnter);
            this.projectUpBox.MouseLeave += new System.EventHandler(this.OnProjectPaginateMouseLeave);
            // 
            // TimelineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucNotFound1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TimelineView";
            this.Size = new System.Drawing.Size(2055, 808);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dropDownPicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUpBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcNotFound ucNotFound1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel projectDisplayPanel;
        private System.Windows.Forms.PictureBox projectDownBox;
        private System.Windows.Forms.PictureBox projectUpBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel milestoneLabelPanel;
        private System.Windows.Forms.Panel panel5;
        private TimelinePaginate timelinePaginate1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label versionNames;
        private System.Windows.Forms.PictureBox dropDownPicBox;
    }
}
