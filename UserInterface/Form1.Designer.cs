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
            this.listViewTemplate1 = new TeamTracker.ListViewTemplate();
            this.SuspendLayout();
            // 
            // listViewTemplate1
            // 
            this.listViewTemplate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.listViewTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTemplate1.Location = new System.Drawing.Point(0, 0);
            this.listViewTemplate1.Name = "listViewTemplate1";
            this.listViewTemplate1.Size = new System.Drawing.Size(1387, 514);
            this.listViewTemplate1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1387, 514);
            this.Controls.Add(this.listViewTemplate1);
            this.Name = "Form1";
            this.Text = "e";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private TeamTracker.RippleButton rippleButton1;
        private TeamTracker.ListViewTemplate listViewTemplate1;
    }
}

