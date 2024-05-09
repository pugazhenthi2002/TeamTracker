namespace UserInterface.Home_Page.Project_Manager.Deploy
{
    partial class DeployContent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ucDeploy1 = new TeamTracker.UcDeploy();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 329);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(20, 309);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 20);
            this.panel2.TabIndex = 1;
            this.panel2.Tag = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.nextBtn);
            this.panel3.Controls.Add(this.backBtn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 20);
            this.panel3.TabIndex = 2;
            this.panel3.Tag = "";
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextBtn.Image = global::UserInterface.Properties.Resources.Right_Medium_Blue;
            this.nextBtn.Location = new System.Drawing.Point(99, 0);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(23, 20);
            this.nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextBtn.TabIndex = 5;
            this.nextBtn.TabStop = false;
            this.nextBtn.Click += new System.EventHandler(this.OnNextClick);
            this.nextBtn.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.nextBtn.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.Image = global::UserInterface.Properties.Resources.Left_Medium_Blue;
            this.backBtn.Location = new System.Drawing.Point(76, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(23, 20);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 4;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.OnBackClick);
            this.backBtn.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deploy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(526, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 329);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.ucDeploy1);
            this.panel5.Controls.Add(this.ucNotFound1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(20, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(506, 289);
            this.panel5.TabIndex = 4;
            // 
            // ucDeploy1
            // 
            this.ucDeploy1.BackColor = System.Drawing.Color.Transparent;
            this.ucDeploy1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDeploy1.Location = new System.Drawing.Point(0, 0);
            this.ucDeploy1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucDeploy1.Name = "ucDeploy1";
            this.ucDeploy1.Size = new System.Drawing.Size(506, 289);
            this.ucDeploy1.TabIndex = 1;
            this.ucDeploy1.Deployment += new TeamTracker.UcDeploy.DeployHandler(this.OnDeployment);
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "Zero Deployment Project !!";
            this.ucNotFound1.HeadTextSize = 12;
            this.ucNotFound1.Location = new System.Drawing.Point(0, 0);
            this.ucNotFound1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(506, 289);
            this.ucNotFound1.TabIndex = 0;
            // 
            // DeployContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "DeployContent";
            this.Size = new System.Drawing.Size(546, 329);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private UcNotFound ucNotFound1;
        private System.Windows.Forms.PictureBox nextBtn;
        private System.Windows.Forms.PictureBox backBtn;
        private TeamTracker.UcDeploy ucDeploy1;
    }
}
