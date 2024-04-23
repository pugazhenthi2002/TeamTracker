namespace UserInterface.ViewPage.ListView
{
    partial class DoneCardTemplate
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.projectName = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.profilePictureBox1 = new TeamTracker.ProfilePictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dueDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.projectName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(187, 134);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // projectName
            // 
            this.projectName.BackColor = System.Drawing.Color.Transparent;
            this.projectName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectName.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.projectName.Location = new System.Drawing.Point(2, 2);
            this.projectName.Margin = new System.Windows.Forms.Padding(2);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(183, 36);
            this.projectName.TabIndex = 0;
            this.projectName.Text = "ProjectNameAndVersions";
            this.projectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.projectName.Click += new System.EventHandler(this.OnClick);
            this.projectName.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.projectName.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.taskNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.profilePictureBox1, 1, 0);
            this.tableLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 42);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(183, 61);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.OnClick);
            this.tableLayoutPanel2.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.tableLayoutPanel2.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskNameLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.taskNameLabel.Location = new System.Drawing.Point(3, 0);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(131, 61);
            this.taskNameLabel.TabIndex = 1;
            this.taskNameLabel.Text = "Task Name";
            this.taskNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.taskNameLabel.Click += new System.EventHandler(this.OnClick);
            this.taskNameLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.taskNameLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // profilePictureBox1
            // 
            this.profilePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePictureBox1.Location = new System.Drawing.Point(140, 8);
            this.profilePictureBox1.Name = "profilePictureBox1";
            this.profilePictureBox1.ParentColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.profilePictureBox1.Size = new System.Drawing.Size(44, 44);
            this.profilePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox1.TabIndex = 0;
            this.profilePictureBox1.TabStop = false;
            this.profilePictureBox1.Click += new System.EventHandler(this.OnClick);
            this.profilePictureBox1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.profilePictureBox1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dueDate, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 107);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(183, 25);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.tableLayoutPanel3.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.flag_empty;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // dueDate
            // 
            this.dueDate.AutoSize = true;
            this.dueDate.BackColor = System.Drawing.Color.Transparent;
            this.dueDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dueDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dueDate.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.dueDate.Location = new System.Drawing.Point(64, 0);
            this.dueDate.Name = "dueDate";
            this.dueDate.Size = new System.Drawing.Size(116, 25);
            this.dueDate.TabIndex = 2;
            this.dueDate.Text = "Due Date";
            this.dueDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dueDate.Click += new System.EventHandler(this.OnClick);
            this.dueDate.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.dueDate.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // DoneCardTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DoneCardTemplate";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Size = new System.Drawing.Size(200, 140);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TeamTracker.ProfilePictureBox profilePictureBox1;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label dueDate;
    }
}
