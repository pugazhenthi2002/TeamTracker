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
            this.panel1 = new System.Windows.Forms.Panel();
            this.projectDisplayPanel = new System.Windows.Forms.Panel();
            this.projectDownBox = new System.Windows.Forms.PictureBox();
            this.projectUpBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.versionNames = new System.Windows.Forms.Label();
            this.milestoneLabelPanel = new System.Windows.Forms.Panel();
            this.timelinePaginate1 = new TeamTracker.TimelinePaginate();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUpBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.projectDisplayPanel);
            this.panel1.Controls.Add(this.projectDownBox);
            this.panel1.Controls.Add(this.projectUpBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(52, 525);
            this.panel1.TabIndex = 0;
            // 
            // projectDisplayPanel
            // 
            this.projectDisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.projectDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectDisplayPanel.Location = new System.Drawing.Point(0, 20);
            this.projectDisplayPanel.Name = "projectDisplayPanel";
            this.projectDisplayPanel.Size = new System.Drawing.Size(52, 485);
            this.projectDisplayPanel.TabIndex = 2;
            // 
            // projectDownBox
            // 
            this.projectDownBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectDownBox.Image = global::UserInterface.Properties.Resources.Paginate_Down_Blue;
            this.projectDownBox.Location = new System.Drawing.Point(0, 505);
            this.projectDownBox.Name = "projectDownBox";
            this.projectDownBox.Size = new System.Drawing.Size(52, 20);
            this.projectDownBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.projectDownBox.TabIndex = 1;
            this.projectDownBox.TabStop = false;
            this.projectDownBox.Click += new System.EventHandler(this.projectDownClick);
            // 
            // projectUpBox
            // 
            this.projectUpBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectUpBox.Image = global::UserInterface.Properties.Resources.Paginate_Up_Blue;
            this.projectUpBox.Location = new System.Drawing.Point(0, 0);
            this.projectUpBox.Name = "projectUpBox";
            this.projectUpBox.Size = new System.Drawing.Size(52, 20);
            this.projectUpBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.projectUpBox.TabIndex = 0;
            this.projectUpBox.TabStop = false;
            this.projectUpBox.Click += new System.EventHandler(this.projectUpClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.versionNames);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(52, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 43);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(986, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Version Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // versionNames
            // 
            this.versionNames.Dock = System.Windows.Forms.DockStyle.Right;
            this.versionNames.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionNames.Location = new System.Drawing.Point(1132, 0);
            this.versionNames.Name = "versionNames";
            this.versionNames.Size = new System.Drawing.Size(120, 43);
            this.versionNames.TabIndex = 0;
            this.versionNames.Text = "Version Names";
            this.versionNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionNames.Click += new System.EventHandler(this.VersionNamesClick);
            // 
            // milestoneLabelPanel
            // 
            this.milestoneLabelPanel.AutoScroll = true;
            this.milestoneLabelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.milestoneLabelPanel.Location = new System.Drawing.Point(52, 475);
            this.milestoneLabelPanel.Margin = new System.Windows.Forms.Padding(2);
            this.milestoneLabelPanel.Name = "milestoneLabelPanel";
            this.milestoneLabelPanel.Size = new System.Drawing.Size(1252, 50);
            this.milestoneLabelPanel.TabIndex = 2;
            // 
            // timelinePaginate1
            // 
            this.timelinePaginate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelinePaginate1.Location = new System.Drawing.Point(52, 43);
            this.timelinePaginate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timelinePaginate1.Name = "timelinePaginate1";
            this.timelinePaginate1.Size = new System.Drawing.Size(1252, 432);
            this.timelinePaginate1.TabIndex = 3;
            // 
            // TimelineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.timelinePaginate1);
            this.Controls.Add(this.milestoneLabelPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TimelineView";
            this.Size = new System.Drawing.Size(1304, 525);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectDownBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUpBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel projectDisplayPanel;
        private System.Windows.Forms.PictureBox projectDownBox;
        private System.Windows.Forms.PictureBox projectUpBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label versionNames;
        private System.Windows.Forms.Panel milestoneLabelPanel;
        private System.Windows.Forms.Label label1;
        private TimelinePaginate timelinePaginate1;
    }
}
