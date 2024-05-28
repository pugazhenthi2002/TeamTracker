namespace UserInterface.ViewProject.BoardView.Custom_Controls
{
    partial class BoardViewTemplate
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
            UnSubscribeEventsAndRemoveMemory();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoardViewTemplate));
            this.statusToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.versionNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.versionDateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.taskCountLabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.milestoneCountLabel = new System.Windows.Forms.Label();
            this.milestoneStatusPicBox = new System.Windows.Forms.PictureBox();
            this.profilePictureBox1 = new TeamTracker.ProfilePictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milestoneStatusPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.panel1.Size = new System.Drawing.Size(289, 157);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.versionNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 145);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnUserControlPaint);
            // 
            // versionNameLabel
            // 
            this.versionNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionNameLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.versionNameLabel.Location = new System.Drawing.Point(0, 0);
            this.versionNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.versionNameLabel.Name = "versionNameLabel";
            this.versionNameLabel.Size = new System.Drawing.Size(285, 58);
            this.versionNameLabel.TabIndex = 0;
            this.versionNameLabel.Text = "Version Name";
            this.versionNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.versionNameLabel.Click += new System.EventHandler(this.OnBoardClick);
            this.versionNameLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.versionNameLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.versionDateLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 29);
            this.panel2.TabIndex = 1;
            // 
            // versionDateLabel
            // 
            this.versionDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionDateLabel.Font = new System.Drawing.Font("Ebrima", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.versionDateLabel.Location = new System.Drawing.Point(25, 0);
            this.versionDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.versionDateLabel.Name = "versionDateLabel";
            this.versionDateLabel.Size = new System.Drawing.Size(260, 29);
            this.versionDateLabel.TabIndex = 2;
            this.versionDateLabel.Text = "Version Date";
            this.versionDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.versionDateLabel.Click += new System.EventHandler(this.OnBoardClick);
            this.versionDateLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.versionDateLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnBoardClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.milestoneStatusPicBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.profilePictureBox1, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 87);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 58);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.OnBoardClick);
            this.tableLayoutPanel2.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.tableLayoutPanel2.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.taskCountLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(71, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(71, 58);
            this.tableLayoutPanel4.TabIndex = 1;
            this.tableLayoutPanel4.Click += new System.EventHandler(this.OnBoardClick);
            this.tableLayoutPanel4.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.tableLayoutPanel4.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // taskCountLabel
            // 
            this.taskCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.taskCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskCountLabel.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskCountLabel.ForeColor = System.Drawing.Color.Black;
            this.taskCountLabel.Location = new System.Drawing.Point(43, 19);
            this.taskCountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.taskCountLabel.Name = "taskCountLabel";
            this.taskCountLabel.Size = new System.Drawing.Size(20, 19);
            this.taskCountLabel.TabIndex = 6;
            this.taskCountLabel.Text = "5";
            this.taskCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.taskCountLabel.Click += new System.EventHandler(this.OnBoardClick);
            this.taskCountLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.taskCountLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 58);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.OnBoardClick);
            this.pictureBox5.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.milestoneCountLabel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(71, 58);
            this.tableLayoutPanel3.TabIndex = 0;
            this.tableLayoutPanel3.Click += new System.EventHandler(this.OnBoardClick);
            this.tableLayoutPanel3.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.tableLayoutPanel3.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.OnBoardClick);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // milestoneCountLabel
            // 
            this.milestoneCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.milestoneCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.milestoneCountLabel.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milestoneCountLabel.ForeColor = System.Drawing.Color.Black;
            this.milestoneCountLabel.Location = new System.Drawing.Point(43, 19);
            this.milestoneCountLabel.Margin = new System.Windows.Forms.Padding(0);
            this.milestoneCountLabel.Name = "milestoneCountLabel";
            this.milestoneCountLabel.Size = new System.Drawing.Size(20, 19);
            this.milestoneCountLabel.TabIndex = 5;
            this.milestoneCountLabel.Text = "5";
            this.milestoneCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.milestoneCountLabel.Click += new System.EventHandler(this.OnBoardClick);
            this.milestoneCountLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.milestoneCountLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // milestoneStatusPicBox
            // 
            this.milestoneStatusPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.milestoneStatusPicBox.BackColor = System.Drawing.Color.Transparent;
            this.milestoneStatusPicBox.Image = global::UserInterface.Properties.Resources.Version_Milestone_Status_Down_Down;
            this.milestoneStatusPicBox.Location = new System.Drawing.Point(164, 15);
            this.milestoneStatusPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.milestoneStatusPicBox.Name = "milestoneStatusPicBox";
            this.milestoneStatusPicBox.Size = new System.Drawing.Size(27, 28);
            this.milestoneStatusPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.milestoneStatusPicBox.TabIndex = 3;
            this.milestoneStatusPicBox.TabStop = false;
            this.milestoneStatusPicBox.Click += new System.EventHandler(this.OnBoardClick);
            this.milestoneStatusPicBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.milestoneStatusPicBox.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // profilePictureBox1
            // 
            this.profilePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox1.Location = new System.Drawing.Point(233, 13);
            this.profilePictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.profilePictureBox1.Name = "profilePictureBox1";
            this.profilePictureBox1.ParentColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.profilePictureBox1.Size = new System.Drawing.Size(31, 31);
            this.profilePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox1.TabIndex = 4;
            this.profilePictureBox1.TabStop = false;
            this.profilePictureBox1.Click += new System.EventHandler(this.OnBoardClick);
            this.profilePictureBox1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.profilePictureBox1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // BoardViewTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BoardViewTemplate";
            this.Size = new System.Drawing.Size(289, 157);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milestoneStatusPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip statusToolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label versionNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label versionDateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label taskCountLabel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label milestoneCountLabel;
        private System.Windows.Forms.PictureBox milestoneStatusPicBox;
        private TeamTracker.ProfilePictureBox profilePictureBox1;
    }
}
