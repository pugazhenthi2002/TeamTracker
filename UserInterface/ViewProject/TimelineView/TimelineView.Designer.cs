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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimelineView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.projectDisplayPanel = new System.Windows.Forms.Panel();
            this.projectDownBox = new System.Windows.Forms.PictureBox();
            this.projectUpBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.versionNames = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timelinePaginate1 = new UserInterface.ViewProject.TimelineView.Controls.TimelinePaginate();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectDownBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectUpBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.projectDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectDisplayPanel.Location = new System.Drawing.Point(0, 20);
            this.projectDisplayPanel.Name = "projectDisplayPanel";
            this.projectDisplayPanel.Size = new System.Drawing.Size(52, 485);
            this.projectDisplayPanel.TabIndex = 2;
            // 
            // projectDownBox
            // 
            this.projectDownBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.projectDownBox.Image = ((System.Drawing.Image)(resources.GetObject("projectDownBox.Image")));
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
            this.projectUpBox.Image = ((System.Drawing.Image)(resources.GetObject("projectUpBox.Image")));
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
            this.panel2.Controls.Add(this.versionNames);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(52, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1252, 43);
            this.panel2.TabIndex = 1;
            // 
            // versionNames
            // 
            this.versionNames.Dock = System.Windows.Forms.DockStyle.Right;
            this.versionNames.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionNames.Location = new System.Drawing.Point(1106, 0);
            this.versionNames.Name = "versionNames";
            this.versionNames.Size = new System.Drawing.Size(146, 43);
            this.versionNames.TabIndex = 0;
            this.versionNames.Text = "Version Names";
            this.versionNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.versionNames.Click += new System.EventHandler(this.VersionNamesClick);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(52, 494);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1252, 31);
            this.panel3.TabIndex = 2;
            // 
            // timelinePaginate1
            // 
            this.timelinePaginate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelinePaginate1.Location = new System.Drawing.Point(52, 43);
            this.timelinePaginate1.Name = "timelinePaginate1";
            this.timelinePaginate1.Size = new System.Drawing.Size(1252, 451);
            this.timelinePaginate1.TabIndex = 3;
            // 
            // TimelineView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timelinePaginate1);
            this.Controls.Add(this.panel3);
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
        private System.Windows.Forms.Panel panel3;
        private Controls.TimelinePaginate timelinePaginate1;
    }
}
