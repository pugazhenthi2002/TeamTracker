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
            this.rippleButton1 = new TeamTracker.RippleButton();
            this.SuspendLayout();
            // 
            // rippleButton1
            // 
            this.rippleButton1.Location = new System.Drawing.Point(763, 122);
            this.rippleButton1.Name = "rippleButton1";
            this.rippleButton1.Size = new System.Drawing.Size(118, 66);
            this.rippleButton1.TabIndex = 0;
            this.rippleButton1.Text = "rippleButton1";
            this.rippleButton1.UseVisualStyleBackColor = true;
            this.rippleButton1.Click += new System.EventHandler(this.rippleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 514);
            this.Controls.Add(this.rippleButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private TeamTracker.RippleButton rippleButton1;
    }
}

