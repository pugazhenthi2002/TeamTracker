namespace UserInterface.ViewProject.TimelineView.Controls
{
    partial class TaskTimelineTemplate
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
            this.taskLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // taskLabel
            // 
            this.taskLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel.Location = new System.Drawing.Point(0, 0);
            this.taskLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(203, 31);
            this.taskLabel.TabIndex = 0;
            this.taskLabel.Text = "Task Name";
            this.taskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskLabel.Click += new System.EventHandler(this.OnClicked);
            // 
            // TaskTimelineTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.taskLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TaskTimelineTemplate";
            this.Size = new System.Drawing.Size(203, 31);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label taskLabel;
    }
}
