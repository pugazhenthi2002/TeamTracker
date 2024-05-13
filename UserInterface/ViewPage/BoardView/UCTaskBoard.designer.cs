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
            this.ucDueDate1 = new TeamTracker.UcDueDate();
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
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 172);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderRadiusPaint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelVersion, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelProjectName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(363, 49);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // labelVersion
            // 
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelVersion.Location = new System.Drawing.Point(181, 0);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(182, 49);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownTaskBoard);
            this.labelVersion.MouseEnter += new System.EventHandler(this.OnMouseEnterTaskBoard);
            this.labelVersion.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBoard);
            this.labelVersion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMoveTaskBoard);
            this.labelVersion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUpTaskBoard);
            // 
            // labelProjectName
            // 
            this.labelProjectName.BackColor = System.Drawing.Color.Transparent;
            this.labelProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProjectName.Font = new System.Drawing.Font("Ebrima", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelProjectName.Location = new System.Drawing.Point(0, 0);
            this.labelProjectName.Margin = new System.Windows.Forms.Padding(0);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(181, 49);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "Project Name";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProjectName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownTaskBoard);
            this.labelProjectName.MouseEnter += new System.EventHandler(this.OnMouseEnterTaskBoard);
            this.labelProjectName.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBoard);
            this.labelProjectName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMoveTaskBoard);
            this.labelProjectName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUpTaskBoard);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxFlag, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxInfo, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ucDueDate1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 119);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(363, 53);
            this.tableLayoutPanel3.TabIndex = 2;
            this.tableLayoutPanel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownTaskBoard);
            this.tableLayoutPanel3.MouseEnter += new System.EventHandler(this.OnMouseEnterTaskBoard);
            this.tableLayoutPanel3.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBoard);
            this.tableLayoutPanel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMoveTaskBoard);
            this.tableLayoutPanel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUpTaskBoard);
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFlag.Image = global::UserInterface.Properties.Resources.flag_UnderReview;
            this.pictureBoxFlag.Location = new System.Drawing.Point(145, 0);
            this.pictureBoxFlag.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(72, 53);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFlag.TabIndex = 1;
            this.pictureBoxFlag.TabStop = false;
            this.pictureBoxFlag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownTaskBoard);
            this.pictureBoxFlag.MouseEnter += new System.EventHandler(this.OnMouseEnterTaskBoard);
            this.pictureBoxFlag.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBoard);
            this.pictureBoxFlag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMoveTaskBoard);
            this.pictureBoxFlag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUpTaskBoard);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInfo.Image = global::UserInterface.Properties.Resources.info_black;
            this.pictureBoxInfo.Location = new System.Drawing.Point(289, 0);
            this.pictureBoxInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(74, 53);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxInfo.TabIndex = 2;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.OnClickInfo);
            this.pictureBoxInfo.MouseEnter += new System.EventHandler(this.OnMouseEnterInfo);
            this.pictureBoxInfo.MouseLeave += new System.EventHandler(this.OnMouseLeaveInfo);
            // 
            // ucDueDate1
            // 
            this.ucDueDate1.BackColor = System.Drawing.Color.Transparent;
            this.ucDueDate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ucDueDate1.CenterLabelText = null;
            this.ucDueDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDueDate1.DueDate = new System.DateTime(2024, 3, 7, 0, 0, 0, 0);
            this.ucDueDate1.DueLabelcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ucDueDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDueDate1.HeaderForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucDueDate1.LabelText = "Due";
            this.ucDueDate1.Location = new System.Drawing.Point(3, 3);
            this.ucDueDate1.Name = "ucDueDate1";
            this.ucDueDate1.Size = new System.Drawing.Size(139, 47);
            this.ucDueDate1.TabIndex = 3;
            this.ucDueDate1.MouseEnter += new System.EventHandler(this.OnMouseEnterTaskBoard);
            this.ucDueDate1.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBoard);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.LabelTask, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.profilePictureBoxAssignedBy, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(363, 68);
            this.tableLayoutPanel4.TabIndex = 3;
            this.tableLayoutPanel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownTaskBoard);
            this.tableLayoutPanel4.MouseEnter += new System.EventHandler(this.OnMouseEnterTaskBoard);
            this.tableLayoutPanel4.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBoard);
            this.tableLayoutPanel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMoveTaskBoard);
            this.tableLayoutPanel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUpTaskBoard);
            // 
            // LabelTask
            // 
            this.LabelTask.BackColor = System.Drawing.Color.Transparent;
            this.LabelTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTask.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LabelTask.Location = new System.Drawing.Point(0, 0);
            this.LabelTask.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTask.Name = "LabelTask";
            this.LabelTask.Size = new System.Drawing.Size(254, 68);
            this.LabelTask.TabIndex = 2;
            this.LabelTask.Text = "Task";
            this.LabelTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTask.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDownTaskBoard);
            this.LabelTask.MouseEnter += new System.EventHandler(this.OnMouseEnterTaskBoard);
            this.LabelTask.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBoard);
            this.LabelTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMoveTaskBoard);
            this.LabelTask.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUpTaskBoard);
            // 
            // profilePictureBoxAssignedBy
            // 
            this.profilePictureBoxAssignedBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilePictureBoxAssignedBy.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBoxAssignedBy.Location = new System.Drawing.Point(279, 5);
            this.profilePictureBoxAssignedBy.Name = "profilePictureBoxAssignedBy";
            this.profilePictureBoxAssignedBy.ParentColor = System.Drawing.Color.Empty;
            this.profilePictureBoxAssignedBy.Size = new System.Drawing.Size(58, 58);
            this.profilePictureBoxAssignedBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBoxAssignedBy.TabIndex = 3;
            this.profilePictureBoxAssignedBy.TabStop = false;
            this.profilePictureBoxAssignedBy.MouseEnter += new System.EventHandler(this.OnMouseEnterTaskBoard);
            this.profilePictureBoxAssignedBy.MouseLeave += new System.EventHandler(this.OnMouseLeaveTaskBoard);
            // 
            // UCTaskBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UCTaskBoard";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(369, 178);
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
        private System.Windows.Forms.ToolTip toolTip1;
        private UcDueDate ucDueDate1;
    }
}
