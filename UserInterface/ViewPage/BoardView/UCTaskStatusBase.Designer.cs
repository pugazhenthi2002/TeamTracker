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
            this.ucTaskStatusHead1 = new TeamTracker.UcTaskStatusHead();
            this.SuspendLayout();
            // 
            // ucTaskStatusHead1
            // 
            this.ucTaskStatusHead1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ucTaskStatusHead1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTaskStatusHead1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ucTaskStatusHead1.Location = new System.Drawing.Point(5, 5);
            this.ucTaskStatusHead1.Name = "ucTaskStatusHead1";
            this.ucTaskStatusHead1.Size = new System.Drawing.Size(323, 53);
            this.ucTaskStatusHead1.Status = TeamTracker.TaskStatus.Done;
            this.ucTaskStatusHead1.TabIndex = 0;
            // 
            // UCTaskStatusBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.ucTaskStatusHead1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCTaskStatusBase";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(333, 500);
            this.ResumeLayout(false);

        }

        #endregion

        private TeamTracker.UcTaskStatusHead ucTaskStatusHead1;
    }
}
