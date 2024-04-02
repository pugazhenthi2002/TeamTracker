namespace TeamTracker
{
    partial class UCTaskBoard
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.ucDueDate1 = new UserInterface.ViewPage.BoardView.UcDueDate();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelTask = new System.Windows.Forms.Label();
            this.profilePictureBoxAssignedBy = new TeamTracker.ProfilePictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBoxAssignedBy)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(362, 166);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelVersion, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelProjectName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 59);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelVersion.Location = new System.Drawing.Point(178, 0);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(178, 59);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProjectName
            // 
            this.labelProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProjectName.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelProjectName.Location = new System.Drawing.Point(0, 0);
            this.labelProjectName.Margin = new System.Windows.Forms.Padding(0);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(178, 59);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "Project Name";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxFlag, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxInfo, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ucDueDate1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 121);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(356, 42);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFlag.Image = global::UserInterface.Properties.Resources.flag_UnderReview;
            this.pictureBoxFlag.Location = new System.Drawing.Point(106, 0);
            this.pictureBoxFlag.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(71, 42);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFlag.TabIndex = 1;
            this.pictureBoxFlag.TabStop = false;
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInfo.Image = global::UserInterface.Properties.Resources.info_black;
            this.pictureBoxInfo.Location = new System.Drawing.Point(283, 0);
            this.pictureBoxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(73, 42);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxInfo.TabIndex = 2;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.OnClickInfo);
            this.pictureBoxInfo.MouseEnter += new System.EventHandler(this.OnMouseEnterInfo);
            this.pictureBoxInfo.MouseLeave += new System.EventHandler(this.OnMouseLeaveInfo);
            // 
            // ucDueDate1
            // 
            this.ucDueDate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ucDueDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDueDate1.DueDate = new System.DateTime(2024, 3, 7, 0, 0, 0, 0);
            this.ucDueDate1.DueLabelcolor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ucDueDate1.Location = new System.Drawing.Point(0, 0);
            this.ucDueDate1.Margin = new System.Windows.Forms.Padding(0);
            this.ucDueDate1.Name = "ucDueDate1";
            this.ucDueDate1.Size = new System.Drawing.Size(106, 42);
            this.ucDueDate1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.LabelTask, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.profilePictureBoxAssignedBy, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(356, 59);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // LabelTask
            // 
            this.LabelTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTask.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LabelTask.Location = new System.Drawing.Point(0, 0);
            this.LabelTask.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTask.Name = "LabelTask";
            this.LabelTask.Size = new System.Drawing.Size(249, 59);
            this.LabelTask.TabIndex = 2;
            this.LabelTask.Text = "Task";
            this.LabelTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilePictureBoxAssignedBy
            // 
            this.profilePictureBoxAssignedBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilePictureBoxAssignedBy.Location = new System.Drawing.Point(283, 10);
            this.profilePictureBoxAssignedBy.Name = "profilePictureBoxAssignedBy";
            this.profilePictureBoxAssignedBy.Size = new System.Drawing.Size(39, 39);
            this.profilePictureBoxAssignedBy.TabIndex = 3;
            this.profilePictureBoxAssignedBy.TabStop = false;
            // 
            // UCTaskBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "UCTaskBoard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(372, 176);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Resize += new System.EventHandler(this.OnResize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBoxAssignedBy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LabelTask;
        private ProfilePictureBox profilePictureBoxAssignedBy;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private UserInterface.ViewPage.BoardView.UcDueDate ucDueDate1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
