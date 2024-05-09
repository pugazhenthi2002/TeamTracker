namespace UserInterface.Home_Page.Project_Manager.Overview
{
    partial class Overview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.dropDownPicBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.overviewMilestoneContent1 = new UserInterface.Home_Page.Project_Manager.Overview.OverviewMilestoneContent();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownPicBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 488);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1376, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 488);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1356, 20);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "On Process Project";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(20, 468);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1356, 20);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(1356, 39);
            this.panel6.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(935, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "All On Process Version";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.projectNameLabel);
            this.panel7.Controls.Add(this.dropDownPicBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1127, 5);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(2);
            this.panel7.Size = new System.Drawing.Size(224, 29);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.OnVersionSwitchPanelPaint);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectNameLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.projectNameLabel.Location = new System.Drawing.Point(2, 2);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(198, 25);
            this.projectNameLabel.TabIndex = 3;
            this.projectNameLabel.Text = "On Process Version";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropDownPicBox
            // 
            this.dropDownPicBox.BackColor = System.Drawing.Color.Transparent;
            this.dropDownPicBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.dropDownPicBox.Image = global::UserInterface.Properties.Resources.Down_Dark_Blue;
            this.dropDownPicBox.Location = new System.Drawing.Point(200, 2);
            this.dropDownPicBox.Name = "dropDownPicBox";
            this.dropDownPicBox.Size = new System.Drawing.Size(22, 25);
            this.dropDownPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dropDownPicBox.TabIndex = 0;
            this.dropDownPicBox.TabStop = false;
            this.dropDownPicBox.Click += new System.EventHandler(this.OnOverviewClick);
            this.dropDownPicBox.MouseEnter += new System.EventHandler(this.OnDropDownMouseEnter);
            this.dropDownPicBox.MouseLeave += new System.EventHandler(this.OnDropDownMouseLEave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.overviewMilestoneContent1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(20, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1356, 448);
            this.panel5.TabIndex = 6;
            // 
            // overviewMilestoneContent1
            // 
            this.overviewMilestoneContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewMilestoneContent1.Location = new System.Drawing.Point(0, 39);
            this.overviewMilestoneContent1.Margin = new System.Windows.Forms.Padding(0);
            this.overviewMilestoneContent1.Name = "overviewMilestoneContent1";
            this.overviewMilestoneContent1.Size = new System.Drawing.Size(1356, 409);
            this.overviewMilestoneContent1.TabIndex = 1;
            this.overviewMilestoneContent1.Version = null;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "Overview Not Found!!";
            this.ucNotFound1.HeadTextSize = 16;
            this.ucNotFound1.Location = new System.Drawing.Point(20, 20);
            this.ucNotFound1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucNotFound1.Message = "No On-Process Project";
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(1356, 448);
            this.ucNotFound1.TabIndex = 4;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.ucNotFound1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(1396, 488);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dropDownPicBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private UcNotFound ucNotFound1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.PictureBox dropDownPicBox;
        private System.Windows.Forms.Panel panel5;
        private OverviewMilestoneContent overviewMilestoneContent1;
    }
}
