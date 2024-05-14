namespace UserInterface.Edit_Project.Controls
{
    partial class ProjectBoardTemplate
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
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.employeeProfilePicAndName1 = new UserInterface.ViewProject.EmployeeProfilePicAndName();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.totalVersionsLabel = new System.Windows.Forms.Label();
            this.lastVersionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectNameLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.projectNameLabel.Location = new System.Drawing.Point(0, 0);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(291, 64);
            this.projectNameLabel.TabIndex = 1;
            this.projectNameLabel.Text = "Project Name";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectNameLabel.Click += new System.EventHandler(this.OnProjectClicked);
            this.projectNameLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.projectNameLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // employeeProfilePicAndName1
            // 
            this.employeeProfilePicAndName1.BackColor = System.Drawing.Color.Transparent;
            this.employeeProfilePicAndName1.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeProfilePicAndName1.HoverColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Location = new System.Drawing.Point(0, 64);
            this.employeeProfilePicAndName1.Name = "employeeProfilePicAndName1";
            this.employeeProfilePicAndName1.NormalColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Size = new System.Drawing.Size(291, 41);
            this.employeeProfilePicAndName1.TabIndex = 2;
            this.employeeProfilePicAndName1.Click += new System.EventHandler(this.OnProjectClicked);
            this.employeeProfilePicAndName1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.employeeProfilePicAndName1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lastVersionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalVersionsLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 45);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // totalVersionsLabel
            // 
            this.totalVersionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalVersionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalVersionsLabel.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVersionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.totalVersionsLabel.Location = new System.Drawing.Point(0, 0);
            this.totalVersionsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalVersionsLabel.Name = "totalVersionsLabel";
            this.totalVersionsLabel.Size = new System.Drawing.Size(145, 45);
            this.totalVersionsLabel.TabIndex = 2;
            this.totalVersionsLabel.Text = "Total Versions: 10";
            this.totalVersionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalVersionsLabel.Click += new System.EventHandler(this.OnProjectClicked);
            this.totalVersionsLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.totalVersionsLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lastVersionLabel
            // 
            this.lastVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastVersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastVersionLabel.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastVersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.lastVersionLabel.Location = new System.Drawing.Point(145, 0);
            this.lastVersionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastVersionLabel.Name = "lastVersionLabel";
            this.lastVersionLabel.Size = new System.Drawing.Size(146, 45);
            this.lastVersionLabel.TabIndex = 3;
            this.lastVersionLabel.Text = "Last Version: 1.0";
            this.lastVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastVersionLabel.Click += new System.EventHandler(this.OnProjectClicked);
            this.lastVersionLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.lastVersionLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // ProjectBoardTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.employeeProfilePicAndName1);
            this.Controls.Add(this.projectNameLabel);
            this.Name = "ProjectBoardTemplate";
            this.Size = new System.Drawing.Size(291, 150);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label projectNameLabel;
        private ViewProject.EmployeeProfilePicAndName employeeProfilePicAndName1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lastVersionLabel;
        private System.Windows.Forms.Label totalVersionsLabel;
    }
}
