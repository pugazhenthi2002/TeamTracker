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
            this.toggleButton1 = new UserInterface.Project_Manager_Main_Page.ToggleButton();
            this.SuspendLayout();
            // 
            // toggleButton1
            // 
            this.toggleButton1.BackColor = System.Drawing.Color.Transparent;
            this.toggleButton1.BorderColorForOff1 = System.Drawing.Color.DarkRed;
            this.toggleButton1.BorderColorForOn1 = System.Drawing.Color.DarkGreen;
            this.toggleButton1.BorderRadius1 = 3;
            this.toggleButton1.Checked = false;
            this.toggleButton1.ForeColor = System.Drawing.Color.Black;
            this.toggleButton1.Location = new System.Drawing.Point(156, 261);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(253, 69);
            this.toggleButton1.SkinColorForOff1 = System.Drawing.Color.IndianRed;
            this.toggleButton1.SkinColorForOn1 = System.Drawing.Color.MediumSeaGreen;
            this.toggleButton1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(888, 678);
            this.Controls.Add(this.toggleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "e";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private TeamTracker.RippleButton rippleButton1;
        private ViewPage.ListView.DoneCardTemplate doneCardTemplate1;
        private Project_Manager_Main_Page.ToggleButton toggleButton1;
    }
}

