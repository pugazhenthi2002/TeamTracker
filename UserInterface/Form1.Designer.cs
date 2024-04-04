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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.ucTaskBoardBase1 = new TeamTracker.UcTaskBoardBase();
            this.ucCreateTask1 = new TeamTracker.UcCreateTask();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 514);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ucTaskBoardBase1
            // 
            this.ucTaskBoardBase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.ucTaskBoardBase1.CurrentProjVersion = null;
            this.ucTaskBoardBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskBoardBase1.Location = new System.Drawing.Point(100, 0);
            this.ucTaskBoardBase1.Name = "ucTaskBoardBase1";
            this.ucTaskBoardBase1.Size = new System.Drawing.Size(1285, 514);
            this.ucTaskBoardBase1.TabIndex = 6;
            // 
            // ucCreateTask1
            // 
            this.ucCreateTask1.Location = new System.Drawing.Point(266, 59);
            this.ucCreateTask1.Name = "ucCreateTask1";
            this.ucCreateTask1.Size = new System.Drawing.Size(551, 369);
            this.ucCreateTask1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 514);
            this.Controls.Add(this.ucCreateTask1);
            this.Controls.Add(this.ucTaskBoardBase1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TeamTracker.RippleButton rippleButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private TeamTracker.UcTaskBoardBase ucTaskBoardBase1;
        private TeamTracker.UcCreateTask ucCreateTask1;
    }
}

