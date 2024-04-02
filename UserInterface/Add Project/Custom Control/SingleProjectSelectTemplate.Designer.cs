namespace UserInterface.Add_Project.Custom_Control
{
    partial class SingleProjectSelectTemplate
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
            this.versionLabel = new System.Windows.Forms.Label();
            this.projectLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.teamLeadLabel = new System.Windows.Forms.Label();
            this.profilePictureBox1 = new TeamTracker.ProfilePictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // versionLabel
            // 
            this.versionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.versionLabel.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(0, 59);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(170, 24);
            this.versionLabel.TabIndex = 0;
            this.versionLabel.Text = "Latest Version: ";
            this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.versionLabel.Click += new System.EventHandler(this.OnClicked);
            // 
            // projectLabel
            // 
            this.projectLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectLabel.Location = new System.Drawing.Point(0, 0);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(170, 59);
            this.projectLabel.TabIndex = 1;
            this.projectLabel.Text = "Project Name";
            this.projectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectLabel.Click += new System.EventHandler(this.OnClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 33);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.teamLeadLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.profilePictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 33);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.OnClicked);
            // 
            // teamLeadLabel
            // 
            this.teamLeadLabel.AutoSize = true;
            this.teamLeadLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamLeadLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLeadLabel.Location = new System.Drawing.Point(0, 0);
            this.teamLeadLabel.Margin = new System.Windows.Forms.Padding(0);
            this.teamLeadLabel.Name = "teamLeadLabel";
            this.teamLeadLabel.Size = new System.Drawing.Size(119, 33);
            this.teamLeadLabel.TabIndex = 0;
            this.teamLeadLabel.Text = "Project Lead Name";
            this.teamLeadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teamLeadLabel.Click += new System.EventHandler(this.OnClicked);
            // 
            // profilePictureBox1
            // 
            this.profilePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilePictureBox1.Location = new System.Drawing.Point(131, 3);
            this.profilePictureBox1.Name = "profilePictureBox1";
            this.profilePictureBox1.Size = new System.Drawing.Size(26, 26);
            this.profilePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox1.TabIndex = 1;
            this.profilePictureBox1.TabStop = false;
            // 
            // SingleProjectSelectTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.projectLabel);
            this.Name = "SingleProjectSelectTemplate";
            this.Size = new System.Drawing.Size(170, 116);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label teamLeadLabel;
        private TeamTracker.ProfilePictureBox profilePictureBox1;
    }
}
