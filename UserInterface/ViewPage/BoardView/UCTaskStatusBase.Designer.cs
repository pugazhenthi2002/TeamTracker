namespace TeamTracker
{
    partial class UCTaskStatusBase
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelSpacePanel = new System.Windows.Forms.Panel();
            this.ucTaskStatusHead1 = new TeamTracker.UcTaskStatusHead();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.ucTaskStatusHead1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(5, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(323, 57);
            this.panelTop.TabIndex = 1;
            // 
            // panelBase
            // 
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(5, 109);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(323, 386);
            this.panelBase.TabIndex = 2;
            // 
            // panelSpacePanel
            // 
            this.panelSpacePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSpacePanel.Location = new System.Drawing.Point(5, 62);
            this.panelSpacePanel.Name = "panelSpacePanel";
            this.panelSpacePanel.Size = new System.Drawing.Size(323, 47);
            this.panelSpacePanel.TabIndex = 3;
            // 
            // ucTaskStatusHead1
            // 
            this.ucTaskStatusHead1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ucTaskStatusHead1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskStatusHead1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ucTaskStatusHead1.Location = new System.Drawing.Point(0, 0);
            this.ucTaskStatusHead1.Name = "ucTaskStatusHead1";
            this.ucTaskStatusHead1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.ucTaskStatusHead1.Size = new System.Drawing.Size(323, 57);
            this.ucTaskStatusHead1.Status = TeamTracker.TaskStatus.Done;
            this.ucTaskStatusHead1.TabIndex = 0;
            // 
            // UCTaskStatusBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelSpacePanel);
            this.Controls.Add(this.panelTop);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCTaskStatusBase";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(333, 500);
            this.Load += new System.EventHandler(this.OnLoad);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TeamTracker.UcTaskStatusHead ucTaskStatusHead1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel panelSpacePanel;
    }
}
