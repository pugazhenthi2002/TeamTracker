namespace UserInterface
{
    partial class Form1
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
            this.ucNotification1 = new TeamTracker.UcNotification();
            this.SuspendLayout();
            // 
            // ucNotification1
            // 
            this.ucNotification1.BackColor = System.Drawing.Color.Transparent;
            this.ucNotification1.Location = new System.Drawing.Point(86, 198);
            this.ucNotification1.Name = "ucNotification1";
            this.ucNotification1.NotficationData = null;
            this.ucNotification1.Padding = new System.Windows.Forms.Padding(5);
            this.ucNotification1.Size = new System.Drawing.Size(576, 191);
            this.ucNotification1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(888, 678);
            this.Controls.Add(this.ucNotification1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "e";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private TeamTracker.RippleButton rippleButton1;
        private ViewPage.ListView.DoneCardTemplate doneCardTemplate1;
        private TeamTracker.UcNotification ucNotification1;
    }
}

