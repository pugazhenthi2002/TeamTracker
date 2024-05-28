namespace UserInterface.Project_Manager_Main_Page
{
    partial class ThemeToggle
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
            this.components = new System.ComponentModel.Container();
            this.profilePictureBox1 = new TeamTracker.ProfilePictureBox();
            this.toggleTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureBox1
            // 
            this.profilePictureBox1.Location = new System.Drawing.Point(0, 0);
            this.profilePictureBox1.Name = "profilePictureBox1";
            this.profilePictureBox1.ParentColor = System.Drawing.Color.Empty;
            this.profilePictureBox1.Size = new System.Drawing.Size(50, 50);
            this.profilePictureBox1.TabIndex = 0;
            this.profilePictureBox1.TabStop = false;
            this.profilePictureBox1.Click += new System.EventHandler(this.OnToggled);
            // 
            // toggleTimer
            // 
            this.toggleTimer.Interval = 1;
            this.toggleTimer.Tick += new System.EventHandler(this.OnToggleTick);
            // 
            // ThemeToggle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.profilePictureBox1);
            this.Name = "ThemeToggle";
            this.Size = new System.Drawing.Size(227, 45);
            this.Click += new System.EventHandler(this.OnToggled);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TeamTracker.ProfilePictureBox profilePictureBox1;
        private System.Windows.Forms.Timer toggleTimer;
    }
}
