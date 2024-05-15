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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lastVersionLabel = new System.Windows.Forms.Label();
            this.totalVersionsLabel = new System.Windows.Forms.Label();
            this.employeeProfilePicAndName1 = new UserInterface.ViewProject.EmployeeProfilePicAndName();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.employeeProfilePicAndName1);
            this.panel1.Controls.Add(this.projectNameLabel);
            this.panel1.Location = new System.Drawing.Point(540, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 159);
            this.panel1.TabIndex = 1;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(314, 54);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lastVersionLabel
            // 
            this.lastVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastVersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastVersionLabel.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastVersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.lastVersionLabel.Location = new System.Drawing.Point(157, 0);
            this.lastVersionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastVersionLabel.Name = "lastVersionLabel";
            this.lastVersionLabel.Size = new System.Drawing.Size(157, 54);
            this.lastVersionLabel.TabIndex = 3;
            this.lastVersionLabel.Text = "Last Version: 1.0";
            this.lastVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.totalVersionsLabel.Size = new System.Drawing.Size(157, 54);
            this.totalVersionsLabel.TabIndex = 2;
            this.totalVersionsLabel.Text = "Total Versions: 10";
            this.totalVersionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // employeeProfilePicAndName1
            // 
            this.employeeProfilePicAndName1.BackColor = System.Drawing.Color.Transparent;
            this.employeeProfilePicAndName1.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeProfilePicAndName1.HoverColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Location = new System.Drawing.Point(0, 64);
            this.employeeProfilePicAndName1.Name = "employeeProfilePicAndName1";
            this.employeeProfilePicAndName1.NormalColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Size = new System.Drawing.Size(314, 41);
            this.employeeProfilePicAndName1.TabIndex = 5;
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
            this.projectNameLabel.Size = new System.Drawing.Size(314, 64);
            this.projectNameLabel.TabIndex = 4;
            this.projectNameLabel.Text = "Project Name";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(888, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "e";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TeamTracker.RippleButton rippleButton1;
        private ViewPage.ListView.DoneCardTemplate doneCardTemplate1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lastVersionLabel;
        private System.Windows.Forms.Label totalVersionsLabel;
        private ViewProject.EmployeeProfilePicAndName employeeProfilePicAndName1;
        private System.Windows.Forms.Label projectNameLabel;
    }
}

