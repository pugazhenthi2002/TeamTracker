namespace TeamTracker
{
    partial class TaskInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.profileAssignedBy = new TeamTracker.ProfilePicAndName();
            this.ucTaskDescription1 = new TeamTracker.UcTaskDescription();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.animatedLabelStatus = new TeamTracker.AnimatedLabel();
            this.animatedLabelMilestone = new TeamTracker.AnimatedLabel();
            this.employeeProfilePicAndName1 = new UserInterface.ViewProject.EmployeeProfilePicAndName();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.ucDueDate1 = new UcDueDate();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCommits = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBoxDownloadAttachment = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownloadAttachment)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucTaskDescription1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(641, 509);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(641, 65);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxClose, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.profileAssignedBy, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(641, 62);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxClose.Image = global::UserInterface.Properties.Resources.Close;
            this.pictureBoxClose.Location = new System.Drawing.Point(542, 0);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(99, 62);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClickClose);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.OnMouseEnterClose);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.OnMouseLeaveClose);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelTitle.Location = new System.Drawing.Point(10, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(246, 62);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "ProjName/version";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileAssignedBy
            // 
            this.profileAssignedBy.BackColor = System.Drawing.Color.Transparent;
            this.profileAssignedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileAssignedBy.EmployeeProfile = null;
            this.profileAssignedBy.HoverColor = System.Drawing.Color.Empty;
            this.profileAssignedBy.isOperable = false;
            this.profileAssignedBy.Location = new System.Drawing.Point(258, 2);
            this.profileAssignedBy.Margin = new System.Windows.Forms.Padding(2);
            this.profileAssignedBy.Name = "profileAssignedBy";
            this.profileAssignedBy.NormalColor = System.Drawing.Color.Empty;
            this.profileAssignedBy.Padding = new System.Windows.Forms.Padding(3);
            this.profileAssignedBy.Size = new System.Drawing.Size(252, 58);
            this.profileAssignedBy.TabIndex = 2;
            // 
            // ucTaskDescription1
            // 
            this.ucTaskDescription1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.ucTaskDescription1.BorderColor = System.Drawing.Color.Black;
            this.ucTaskDescription1.CenterLabelText = "Task Description...";
            this.ucTaskDescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskDescription1.Location = new System.Drawing.Point(3, 75);
            this.ucTaskDescription1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ucTaskDescription1.Name = "ucTaskDescription1";
            this.ucTaskDescription1.Size = new System.Drawing.Size(635, 182);
            this.ucTaskDescription1.TabIndex = 2;
            this.ucTaskDescription1.TopLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.ucTaskDescription1.TopLabelText = "Task Name";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.animatedLabelStatus, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.animatedLabelMilestone, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.employeeProfilePicAndName1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxFlag, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ucDueDate1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxDownloadAttachment, 5, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 260);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(641, 65);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // animatedLabelStatus
            // 
            this.animatedLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.animatedLabelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animatedLabelStatus.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatedLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.animatedLabelStatus.LabelCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.animatedLabelStatus.Location = new System.Drawing.Point(453, 5);
            this.animatedLabelStatus.Margin = new System.Windows.Forms.Padding(5);
            this.animatedLabelStatus.Name = "animatedLabelStatus";
            this.animatedLabelStatus.Size = new System.Drawing.Size(118, 55);
            this.animatedLabelStatus.TabIndex = 4;
            this.animatedLabelStatus.Text = "Status";
            this.animatedLabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animatedLabelMilestone
            // 
            this.animatedLabelMilestone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.animatedLabelMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animatedLabelMilestone.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatedLabelMilestone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.animatedLabelMilestone.LabelCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.animatedLabelMilestone.Location = new System.Drawing.Point(5, 5);
            this.animatedLabelMilestone.Margin = new System.Windows.Forms.Padding(5);
            this.animatedLabelMilestone.Name = "animatedLabelMilestone";
            this.animatedLabelMilestone.Size = new System.Drawing.Size(118, 55);
            this.animatedLabelMilestone.TabIndex = 0;
            this.animatedLabelMilestone.Text = "Milestone";
            this.animatedLabelMilestone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeProfilePicAndName1
            // 
            this.employeeProfilePicAndName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeProfilePicAndName1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeProfilePicAndName1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.employeeProfilePicAndName1.HoverColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Location = new System.Drawing.Point(227, 3);
            this.employeeProfilePicAndName1.Name = "employeeProfilePicAndName1";
            this.employeeProfilePicAndName1.NormalColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Size = new System.Drawing.Size(154, 59);
            this.employeeProfilePicAndName1.TabIndex = 2;
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFlag.Image = global::UserInterface.Properties.Resources.flag_empty;
            this.pictureBoxFlag.Location = new System.Drawing.Point(387, 3);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(58, 59);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFlag.TabIndex = 3;
            this.pictureBoxFlag.TabStop = false;
            // 
            // ucDueDate1
            // 
            this.ucDueDate1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucDueDate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ucDueDate1.CenterLabelText = null;
            this.ucDueDate1.DueDate = new System.DateTime(2024, 4, 4, 17, 49, 29, 0);
            this.ucDueDate1.DueLabelcolor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.ucDueDate1.LabelText = "Due";
            this.ucDueDate1.Location = new System.Drawing.Point(131, 12);
            this.ucDueDate1.Name = "ucDueDate1";
            this.ucDueDate1.Size = new System.Drawing.Size(90, 40);
            this.ucDueDate1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelCommits);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 330);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 315);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaintTotalCommitsPanel);
            // 
            // panelCommits
            // 
            this.panelCommits.AutoScroll = true;
            this.panelCommits.BackColor = System.Drawing.Color.Transparent;
            this.panelCommits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCommits.Location = new System.Drawing.Point(20, 20);
            this.panelCommits.Margin = new System.Windows.Forms.Padding(20);
            this.panelCommits.Name = "panelCommits";
            this.panelCommits.Size = new System.Drawing.Size(591, 275);
            this.panelCommits.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 20);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(198, -3);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Commits";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 295);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(611, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 295);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 295);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(631, 20);
            this.panel4.TabIndex = 1;
            // 
            // pictureBoxDownloadAttachment
            // 
            this.pictureBoxDownloadAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDownloadAttachment.Image = global::UserInterface.Properties.Resources.download_Icon;
            this.pictureBoxDownloadAttachment.Location = new System.Drawing.Point(579, 3);
            this.pictureBoxDownloadAttachment.Name = "pictureBoxDownloadAttachment";
            this.pictureBoxDownloadAttachment.Size = new System.Drawing.Size(59, 59);
            this.pictureBoxDownloadAttachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDownloadAttachment.TabIndex = 5;
            this.pictureBoxDownloadAttachment.TabStop = false;
            this.pictureBoxDownloadAttachment.MouseEnter += new System.EventHandler(this.OnMouseEnterDownloadPicBox);
            this.pictureBoxDownloadAttachment.MouseLeave += new System.EventHandler(this.OnMouseLeaveDownloadPicBox);
            // 
            // TaskInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(641, 509);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskInfoForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownloadAttachment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label labelTitle;
        private ProfilePicAndName profileAssignedBy;
        private System.Windows.Forms.Panel panel1;
        private UcTaskDescription ucTaskDescription1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private AnimatedLabel animatedLabelMilestone;
        private UcDueDate ucDueDate1;
        private UserInterface.ViewProject.EmployeeProfilePicAndName employeeProfilePicAndName1;
        private AnimatedLabel animatedLabelStatus;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCommits;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxDownloadAttachment;
    }
}