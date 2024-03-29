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
            this.overview1 = new UserInterface.Home_Page.Project_Manager.Overview.Overview();
            this.ucProjectStatusHead1 = new TeamTracker.UcProjectStatusHead();
            this.SuspendLayout();
            // 
            // overview1
            // 
            this.overview1.BorderColor = System.Drawing.Color.DarkMagenta;
            this.overview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overview1.Location = new System.Drawing.Point(0, 0);
            this.overview1.Name = "overview1";
            this.overview1.Size = new System.Drawing.Size(1385, 514);
            this.overview1.TabIndex = 0;
            // 
            // ucProjectStatusHead1
            // 
            this.ucProjectStatusHead1.Location = new System.Drawing.Point(281, 128);
            this.ucProjectStatusHead1.Name = "ucProjectStatusHead1";
            this.ucProjectStatusHead1.Size = new System.Drawing.Size(401, 55);
            this.ucProjectStatusHead1.Status = TeamTracker.ProjectStatus.UpComing;
            this.ucProjectStatusHead1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 514);
            this.Controls.Add(this.ucProjectStatusHead1);
            this.Controls.Add(this.overview1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Home_Page.Project_Manager.Overview.Overview overview1;
        private TeamTracker.UcProjectStatusHead ucProjectStatusHead1;
    }
}

