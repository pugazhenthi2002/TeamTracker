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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCommits = new System.Windows.Forms.Panel();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileAssignedBy = new TeamTracker.ProfilePicAndName();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.ucTaskDescription1 = new TeamTracker.UcTaskDescription();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.animatedLabelStatus = new TeamTracker.AnimatedLabel();
            this.animatedLabelMilestone = new TeamTracker.AnimatedLabel();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.pictureBoxDownloadAttachment = new System.Windows.Forms.PictureBox();
            this.startDate = new UserInterface.Add_Project.Custom_Control.CustomDateTime();
            this.endDate = new UserInterface.Add_Project.Custom_Control.CustomDateTime();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 568);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelCommits);
            this.panel2.Controls.Add(this.ucNotFound1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 287);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 276);
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
            this.panelCommits.Size = new System.Drawing.Size(757, 236);
            this.panelCommits.TabIndex = 7;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "No Commits Found !!";
            this.ucNotFound1.HeadTextSize = 14;
            this.ucNotFound1.Location = new System.Drawing.Point(20, 20);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(757, 236);
            this.ucNotFound1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 20);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(134, 20);
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
            this.panel6.Size = new System.Drawing.Size(20, 256);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(777, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 256);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(797, 20);
            this.panel4.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.profileAssignedBy);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(807, 56);
            this.panel1.TabIndex = 1;
            // 
            // profileAssignedBy
            // 
            this.profileAssignedBy.BackColor = System.Drawing.Color.Transparent;
            this.profileAssignedBy.BorderColor = System.Drawing.Color.Empty;
            this.profileAssignedBy.BorderRadius = 0;
            this.profileAssignedBy.Dock = System.Windows.Forms.DockStyle.Right;
            this.profileAssignedBy.EmployeeProfile = null;
            this.profileAssignedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.profileAssignedBy.HoverColor = System.Drawing.Color.Empty;
            this.profileAssignedBy.IsBorderNeeded = false;
            this.profileAssignedBy.IsOperable = false;
            this.profileAssignedBy.Location = new System.Drawing.Point(430, 0);
            this.profileAssignedBy.Margin = new System.Windows.Forms.Padding(2);
            this.profileAssignedBy.Name = "profileAssignedBy";
            this.profileAssignedBy.NormalColor = System.Drawing.Color.Empty;
            this.profileAssignedBy.Padding = new System.Windows.Forms.Padding(3);
            this.profileAssignedBy.ProfileTextColor = System.Drawing.Color.Empty;
            this.profileAssignedBy.Size = new System.Drawing.Size(318, 53);
            this.profileAssignedBy.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.Close_30;
            this.pictureBox1.Location = new System.Drawing.Point(748, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClickClose);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(374, 53);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "ProjName/version";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucTaskDescription1
            // 
            this.ucTaskDescription1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucTaskDescription1.BorderColor = System.Drawing.Color.Black;
            this.ucTaskDescription1.CenterLabelText = "Task Description...";
            this.ucTaskDescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskDescription1.EnableEdit = true;
            this.ucTaskDescription1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucTaskDescription1.Location = new System.Drawing.Point(20, 66);
            this.ucTaskDescription1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.ucTaskDescription1.Name = "ucTaskDescription1";
            this.ucTaskDescription1.Size = new System.Drawing.Size(767, 150);
            this.ucTaskDescription1.TabIndex = 2;
            this.ucTaskDescription1.TopLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ucTaskDescription1.TopLabelForeColor = System.Drawing.Color.White;
            this.ucTaskDescription1.TopLabelText = "Task Name";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.animatedLabelStatus, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.animatedLabelMilestone, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxFlag, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxDownloadAttachment, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.startDate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.endDate, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 226);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(807, 56);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // animatedLabelStatus
            // 
            this.animatedLabelStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animatedLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.animatedLabelStatus.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatedLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.animatedLabelStatus.LabelCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.animatedLabelStatus.Location = new System.Drawing.Point(568, 10);
            this.animatedLabelStatus.Margin = new System.Windows.Forms.Padding(5);
            this.animatedLabelStatus.Name = "animatedLabelStatus";
            this.animatedLabelStatus.ParentColor = System.Drawing.Color.Empty;
            this.animatedLabelStatus.Size = new System.Drawing.Size(151, 35);
            this.animatedLabelStatus.TabIndex = 4;
            this.animatedLabelStatus.Text = "Status";
            this.animatedLabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // animatedLabelMilestone
            // 
            this.animatedLabelMilestone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animatedLabelMilestone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.animatedLabelMilestone.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatedLabelMilestone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.animatedLabelMilestone.LabelCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.animatedLabelMilestone.Location = new System.Drawing.Point(5, 10);
            this.animatedLabelMilestone.Margin = new System.Windows.Forms.Padding(5);
            this.animatedLabelMilestone.Name = "animatedLabelMilestone";
            this.animatedLabelMilestone.ParentColor = System.Drawing.Color.Empty;
            this.animatedLabelMilestone.Size = new System.Drawing.Size(151, 35);
            this.animatedLabelMilestone.TabIndex = 0;
            this.animatedLabelMilestone.Text = "Milestone";
            this.animatedLabelMilestone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFlag.Image = global::UserInterface.Properties.Resources.Critical;
            this.pictureBoxFlag.Location = new System.Drawing.Point(486, 3);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(74, 50);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFlag.TabIndex = 3;
            this.pictureBoxFlag.TabStop = false;
            // 
            // pictureBoxDownloadAttachment
            // 
            this.pictureBoxDownloadAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDownloadAttachment.Image = global::UserInterface.Properties.Resources.Download_Dark_Blue;
            this.pictureBoxDownloadAttachment.Location = new System.Drawing.Point(727, 3);
            this.pictureBoxDownloadAttachment.Name = "pictureBoxDownloadAttachment";
            this.pictureBoxDownloadAttachment.Size = new System.Drawing.Size(77, 50);
            this.pictureBoxDownloadAttachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDownloadAttachment.TabIndex = 5;
            this.pictureBoxDownloadAttachment.TabStop = false;
            this.pictureBoxDownloadAttachment.Click += new System.EventHandler(this.AttachmentDownloadClick);
            this.pictureBoxDownloadAttachment.MouseEnter += new System.EventHandler(this.OnMouseEnterDownloadPicBox);
            this.pictureBoxDownloadAttachment.MouseLeave += new System.EventHandler(this.OnMouseLeaveDownloadPicBox);
            // 
            // startDate
            // 
            this.startDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.startDate.BorderSize = 0;
            this.startDate.Enabled = false;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Location = new System.Drawing.Point(164, 10);
            this.startDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(155, 35);
            this.startDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.startDate.TabIndex = 0;
            this.startDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            // 
            // endDate
            // 
            this.endDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.endDate.BorderSize = 0;
            this.endDate.Enabled = false;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Location = new System.Drawing.Point(325, 10);
            this.endDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(155, 35);
            this.endDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.endDate.TabIndex = 6;
            this.endDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            // 
            // TaskInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(807, 568);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskInfoForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownloadAttachment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private AnimatedLabel animatedLabelMilestone;
        private AnimatedLabel animatedLabelStatus;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBoxDownloadAttachment;
        private UserInterface.Add_Project.Custom_Control.CustomDateTime endDate;
        private UserInterface.UcNotFound ucNotFound1;
        private UcTaskDescription ucTaskDescription1;
        private UserInterface.Add_Project.Custom_Control.CustomDateTime startDate;
        private System.Windows.Forms.Panel panelCommits;
        private ProfilePicAndName profileAssignedBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
    }
}