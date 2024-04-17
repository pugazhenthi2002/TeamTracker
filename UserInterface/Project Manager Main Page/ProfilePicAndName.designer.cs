namespace TeamTracker
{
    partial class ProfilePicAndName
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.designationLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.profilePictureBox1 = new TeamTracker.ProfilePictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(57, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 54);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.designationLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.employeeNameLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(158, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // designationLabel
            // 
            this.designationLabel.AutoSize = true;
            this.designationLabel.BackColor = System.Drawing.Color.Transparent;
            this.designationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.designationLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.designationLabel.Location = new System.Drawing.Point(2, 0);
            this.designationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.designationLabel.Name = "designationLabel";
            this.designationLabel.Size = new System.Drawing.Size(154, 27);
            this.designationLabel.TabIndex = 0;
            this.designationLabel.Text = "Designation";
            this.designationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.designationLabel.Click += new System.EventHandler(this.OnCLicked);
            this.designationLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.designationLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.employeeNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeNameLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.employeeNameLabel.Location = new System.Drawing.Point(2, 27);
            this.employeeNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(154, 27);
            this.employeeNameLabel.TabIndex = 1;
            this.employeeNameLabel.Text = "Employee Name";
            this.employeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeNameLabel.Click += new System.EventHandler(this.OnCLicked);
            this.employeeNameLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.employeeNameLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // profilePictureBox1
            // 
            this.profilePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.profilePictureBox1.Location = new System.Drawing.Point(3, 3);
            this.profilePictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.profilePictureBox1.Name = "profilePictureBox1";
            this.profilePictureBox1.ParentColor = System.Drawing.Color.Empty;
            this.profilePictureBox1.Size = new System.Drawing.Size(54, 54);
            this.profilePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox1.TabIndex = 0;
            this.profilePictureBox1.TabStop = false;
            this.profilePictureBox1.Click += new System.EventHandler(this.OnCLicked);
            this.profilePictureBox1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.profilePictureBox1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // ProfilePicAndName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.profilePictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProfilePicAndName";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(218, 60);
            this.Click += new System.EventHandler(this.OnCLicked);
            this.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProfilePictureBox profilePictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label designationLabel;
        private System.Windows.Forms.Label employeeNameLabel;
    }
}
