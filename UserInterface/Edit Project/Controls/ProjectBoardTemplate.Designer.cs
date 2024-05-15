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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lastVersionLabel = new System.Windows.Forms.Label();
            this.totalVersionsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePictureBox1 = new TeamTracker.ProfilePictureBox();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.projectNameLabel);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(281, 150);
            this.panel1.TabIndex = 2;
            this.panel1.Click += new System.EventHandler(this.OnProjectClicked);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderDrawPaint);
            this.panel1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lastVersionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalVersionsLabel, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 38);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.OnProjectClicked);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // lastVersionLabel
            // 
            this.lastVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.lastVersionLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lastVersionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastVersionLabel.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastVersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.lastVersionLabel.Location = new System.Drawing.Point(139, 0);
            this.lastVersionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lastVersionLabel.Name = "lastVersionLabel";
            this.lastVersionLabel.Size = new System.Drawing.Size(140, 38);
            this.lastVersionLabel.TabIndex = 3;
            this.lastVersionLabel.Text = "Last Version: 1.0";
            this.lastVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lastVersionLabel.Click += new System.EventHandler(this.OnProjectClicked);
            this.lastVersionLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.lastVersionLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // totalVersionsLabel
            // 
            this.totalVersionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalVersionsLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.totalVersionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalVersionsLabel.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVersionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.totalVersionsLabel.Location = new System.Drawing.Point(0, 0);
            this.totalVersionsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.totalVersionsLabel.Name = "totalVersionsLabel";
            this.totalVersionsLabel.Size = new System.Drawing.Size(139, 38);
            this.totalVersionsLabel.TabIndex = 2;
            this.totalVersionsLabel.Text = "Total Versions: 10";
            this.totalVersionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.totalVersionsLabel.Click += new System.EventHandler(this.OnProjectClicked);
            this.totalVersionsLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.totalVersionsLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.profilePictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(1, 65);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.panel2.Size = new System.Drawing.Size(279, 46);
            this.panel2.TabIndex = 7;
            this.panel2.Click += new System.EventHandler(this.OnProjectClicked);
            this.panel2.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(50, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Profile";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.OnProjectClicked);
            this.label1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // profilePictureBox1
            // 
            this.profilePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.profilePictureBox1.Location = new System.Drawing.Point(4, 0);
            this.profilePictureBox1.Name = "profilePictureBox1";
            this.profilePictureBox1.ParentColor = System.Drawing.Color.Empty;
            this.profilePictureBox1.Size = new System.Drawing.Size(46, 46);
            this.profilePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox1.TabIndex = 6;
            this.profilePictureBox1.TabStop = false;
            this.profilePictureBox1.Click += new System.EventHandler(this.OnProjectClicked);
            this.profilePictureBox1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.profilePictureBox1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectNameLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.projectNameLabel.Location = new System.Drawing.Point(1, 1);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(279, 64);
            this.projectNameLabel.TabIndex = 4;
            this.projectNameLabel.Text = "Project Name";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectNameLabel.Click += new System.EventHandler(this.OnProjectClicked);
            this.projectNameLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineSeperatePaint);
            this.projectNameLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.projectNameLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // ProjectBoardTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "ProjectBoardTemplate";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Size = new System.Drawing.Size(291, 150);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lastVersionLabel;
        private System.Windows.Forms.Label totalVersionsLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private TeamTracker.ProfilePictureBox profilePictureBox1;
    }
}
