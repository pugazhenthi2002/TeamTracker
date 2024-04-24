namespace TeamTracker
{
    partial class IssueInfoForm
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
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.profilePostedBy = new TeamTracker.ProfilePicAndName();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.animatedLabelType = new TeamTracker.AnimatedLabel();
            this.IssueDate = new UserInterface.Add_Project.Custom_Control.CustomDateTime();
            this.pictureBoxDownloadAttachment = new System.Windows.Forms.PictureBox();
            this.animatedLabelPriority = new TeamTracker.AnimatedLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTags = new System.Windows.Forms.Panel();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucIssueDescription1 = new TeamTracker.UcTaskDescription();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAddSolution = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownloadAttachment)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(773, 449);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pictureBoxFlag);
            this.panel1.Controls.Add(this.profilePostedBy);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(773, 67);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxFlag.Image = global::UserInterface.Properties.Resources.Critical;
            this.pictureBoxFlag.Location = new System.Drawing.Point(639, 0);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(75, 64);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFlag.TabIndex = 6;
            this.pictureBoxFlag.TabStop = false;
            // 
            // profilePostedBy
            // 
            this.profilePostedBy.BackColor = System.Drawing.Color.Transparent;
            this.profilePostedBy.BorderColor = System.Drawing.Color.Empty;
            this.profilePostedBy.BorderRadius = 0;
            this.profilePostedBy.EmployeeProfile = null;
            this.profilePostedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.profilePostedBy.HoverColor = System.Drawing.Color.Empty;
            this.profilePostedBy.IsBorderNeeded = false;
            this.profilePostedBy.IsOperable = false;
            this.profilePostedBy.Location = new System.Drawing.Point(9, 9);
            this.profilePostedBy.Margin = new System.Windows.Forms.Padding(5);
            this.profilePostedBy.Name = "profilePostedBy";
            this.profilePostedBy.NormalColor = System.Drawing.Color.Empty;
            this.profilePostedBy.Padding = new System.Windows.Forms.Padding(3);
            this.profilePostedBy.ProfileTextColor = System.Drawing.Color.Empty;
            this.profilePostedBy.Size = new System.Drawing.Size(302, 50);
            this.profilePostedBy.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.Close_Alice_Blue_30;
            this.pictureBox1.Location = new System.Drawing.Point(714, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClickClose);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.OnMouseEnterClose);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.OnMouseLeaveClose);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxDownloadAttachment, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.IssueDate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.animatedLabelPriority, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.animatedLabelType, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 313);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(773, 89);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // animatedLabelType
            // 
            this.animatedLabelType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animatedLabelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.animatedLabelType.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatedLabelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.animatedLabelType.LabelCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.animatedLabelType.Location = new System.Drawing.Point(10, 27);
            this.animatedLabelType.Margin = new System.Windows.Forms.Padding(5);
            this.animatedLabelType.Name = "animatedLabelType";
            this.animatedLabelType.Size = new System.Drawing.Size(211, 35);
            this.animatedLabelType.TabIndex = 4;
            this.animatedLabelType.Text = "Bug";
            this.animatedLabelType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IssueDate
            // 
            this.IssueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IssueDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.IssueDate.BorderSize = 0;
            this.IssueDate.Enabled = false;
            this.IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDate.Location = new System.Drawing.Point(481, 27);
            this.IssueDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(155, 35);
            this.IssueDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.IssueDate.TabIndex = 0;
            this.IssueDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            // 
            // pictureBoxDownloadAttachment
            // 
            this.pictureBoxDownloadAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDownloadAttachment.Image = global::UserInterface.Properties.Resources.download_Icon;
            this.pictureBoxDownloadAttachment.Location = new System.Drawing.Point(680, 25);
            this.pictureBoxDownloadAttachment.Margin = new System.Windows.Forms.Padding(25);
            this.pictureBoxDownloadAttachment.Name = "pictureBoxDownloadAttachment";
            this.pictureBoxDownloadAttachment.Size = new System.Drawing.Size(68, 39);
            this.pictureBoxDownloadAttachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDownloadAttachment.TabIndex = 5;
            this.pictureBoxDownloadAttachment.TabStop = false;
            this.pictureBoxDownloadAttachment.Click += new System.EventHandler(this.OnClickDownloadAttachment);
            this.pictureBoxDownloadAttachment.MouseEnter += new System.EventHandler(this.OnMouseEnterDownloadPicBox);
            this.pictureBoxDownloadAttachment.MouseLeave += new System.EventHandler(this.OnMouseLeaveDownloadPicBox);
            // 
            // animatedLabelPriority
            // 
            this.animatedLabelPriority.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.animatedLabelPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.animatedLabelPriority.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatedLabelPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.animatedLabelPriority.LabelCornerColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.animatedLabelPriority.Location = new System.Drawing.Point(241, 27);
            this.animatedLabelPriority.Margin = new System.Windows.Forms.Padding(5);
            this.animatedLabelPriority.Name = "animatedLabelPriority";
            this.animatedLabelPriority.Size = new System.Drawing.Size(211, 35);
            this.animatedLabelPriority.TabIndex = 0;
            this.animatedLabelPriority.Text = "High";
            this.animatedLabelPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucIssueDescription1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(767, 240);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTags);
            this.panel2.Controls.Add(this.ucNotFound1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(470, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 227);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaintTagsPanel);
            // 
            // panelTags
            // 
            this.panelTags.AutoScroll = true;
            this.panelTags.BackColor = System.Drawing.Color.Transparent;
            this.panelTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTags.Location = new System.Drawing.Point(20, 20);
            this.panelTags.Margin = new System.Windows.Forms.Padding(10, 20, 20, 20);
            this.panelTags.Name = "panelTags";
            this.panelTags.Size = new System.Drawing.Size(247, 187);
            this.panelTags.TabIndex = 7;
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
            this.ucNotFound1.Size = new System.Drawing.Size(247, 187);
            this.ucNotFound1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(20, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 20);
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
            this.label1.Text = "Tags";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 207);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(267, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 207);
            this.panel5.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(287, 20);
            this.panel4.TabIndex = 1;
            // 
            // ucIssueDescription1
            // 
            this.ucIssueDescription1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(170)))), ((int)(((byte)(190)))));
            this.ucIssueDescription1.BorderColor = System.Drawing.Color.Black;
            this.ucIssueDescription1.CenterLabelText = "Issue Description...";
            this.ucIssueDescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucIssueDescription1.EnableEdit = true;
            this.ucIssueDescription1.Location = new System.Drawing.Point(3, 10);
            this.ucIssueDescription1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ucIssueDescription1.Name = "ucIssueDescription1";
            this.ucIssueDescription1.Size = new System.Drawing.Size(454, 227);
            this.ucIssueDescription1.TabIndex = 2;
            this.ucIssueDescription1.TopLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucIssueDescription1.TopLabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ucIssueDescription1.TopLabelText = "Issue Title";
            // 
            // buttonAddSolution
            // 
            this.buttonAddSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.buttonAddSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddSolution.FlatAppearance.BorderSize = 0;
            this.buttonAddSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSolution.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonAddSolution.Location = new System.Drawing.Point(623, 5);
            this.buttonAddSolution.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.buttonAddSolution.Name = "buttonAddSolution";
            this.buttonAddSolution.Size = new System.Drawing.Size(134, 31);
            this.buttonAddSolution.TabIndex = 8;
            this.buttonAddSolution.Text = "Add Solution";
            this.buttonAddSolution.UseVisualStyleBackColor = false;
            this.buttonAddSolution.Click += new System.EventHandler(this.OnClickAddSolution);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.buttonAddSolution, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 405);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(767, 41);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // IssueInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(773, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueInfoForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownloadAttachment)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTags;
        private UserInterface.UcNotFound ucNotFound1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private ProfilePicAndName profilePostedBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UcTaskDescription ucIssueDescription1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private AnimatedLabel animatedLabelType;
        private AnimatedLabel animatedLabelPriority;
        private System.Windows.Forms.PictureBox pictureBoxDownloadAttachment;
        private UserInterface.Add_Project.Custom_Control.CustomDateTime IssueDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonAddSolution;
    }
}