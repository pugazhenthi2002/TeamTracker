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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.profilePostedBy = new TeamTracker.ProfilePicAndName();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTags = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAddTag = new System.Windows.Forms.Button();
            this.panelTags = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProjectEntryTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ucIssueDescription1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IssueTitleTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.solutionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.IssueDate = new UserInterface.Add_Project.Custom_Control.CustomDateTime();
            this.BtnSetPriority = new System.Windows.Forms.Button();
            this.BtnSetType = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddSolution = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelAttachment = new System.Windows.Forms.Label();
            this.pictureBoxAttachments = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanelTags.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ProjectEntryTablePanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panelTop.Controls.Add(this.profilePostedBy);
            this.panelTop.Controls.Add(this.pictureBoxClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1408, 78);
            this.panelTop.TabIndex = 4;
            // 
            // profilePostedBy
            // 
            this.profilePostedBy.BackColor = System.Drawing.Color.Transparent;
            this.profilePostedBy.BorderColor = System.Drawing.Color.Empty;
            this.profilePostedBy.BorderRadius = 0;
            this.profilePostedBy.EmployeeProfile = null;
            this.profilePostedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(245)))));
            this.profilePostedBy.HoverColor = System.Drawing.Color.Empty;
            this.profilePostedBy.IsBorderNeeded = false;
            this.profilePostedBy.IsOperable = false;
            this.profilePostedBy.Location = new System.Drawing.Point(15, 2);
            this.profilePostedBy.Margin = new System.Windows.Forms.Padding(6);
            this.profilePostedBy.Name = "profilePostedBy";
            this.profilePostedBy.NormalColor = System.Drawing.Color.Empty;
            this.profilePostedBy.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.profilePostedBy.ProfileTextColor = System.Drawing.Color.Empty;
            this.profilePostedBy.Size = new System.Drawing.Size(332, 77);
            this.profilePostedBy.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxClose.Image = global::UserInterface.Properties.Resources.Close_30;
            this.pictureBoxClose.Location = new System.Drawing.Point(1310, 0);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(98, 78);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClickClose);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 78);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1408, 426);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tableLayoutPanelTags);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(854, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 408);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanelTags
            // 
            this.tableLayoutPanelTags.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelTags.ColumnCount = 1;
            this.tableLayoutPanelTags.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTags.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanelTags.Controls.Add(this.panelTags, 0, 1);
            this.tableLayoutPanelTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTags.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTags.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTags.Name = "tableLayoutPanelTags";
            this.tableLayoutPanelTags.RowCount = 2;
            this.tableLayoutPanelTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelTags.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelTags.Size = new System.Drawing.Size(544, 408);
            this.tableLayoutPanelTags.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.BtnAddTag, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(8, 3, 8, 0);
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(544, 81);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // BtnAddTag
            // 
            this.BtnAddTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnAddTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddTag.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnAddTag.Location = new System.Drawing.Point(12, 11);
            this.BtnAddTag.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.BtnAddTag.Name = "BtnAddTag";
            this.BtnAddTag.Size = new System.Drawing.Size(520, 62);
            this.BtnAddTag.TabIndex = 1;
            this.BtnAddTag.Text = "Tags";
            this.BtnAddTag.UseVisualStyleBackColor = false;
            // 
            // panelTags
            // 
            this.panelTags.AutoScroll = true;
            this.panelTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTags.Location = new System.Drawing.Point(4, 86);
            this.panelTags.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTags.Name = "panelTags";
            this.panelTags.Size = new System.Drawing.Size(536, 317);
            this.panelTags.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.ProjectEntryTablePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 408);
            this.panel1.TabIndex = 0;
            // 
            // ProjectEntryTablePanel
            // 
            this.ProjectEntryTablePanel.BackColor = System.Drawing.Color.Transparent;
            this.ProjectEntryTablePanel.ColumnCount = 1;
            this.ProjectEntryTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProjectEntryTablePanel.Controls.Add(this.ucIssueDescription1, 0, 3);
            this.ProjectEntryTablePanel.Controls.Add(this.label1, 0, 0);
            this.ProjectEntryTablePanel.Controls.Add(this.label2, 0, 2);
            this.ProjectEntryTablePanel.Controls.Add(this.IssueTitleTextBox, 0, 1);
            this.ProjectEntryTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectEntryTablePanel.Location = new System.Drawing.Point(0, 0);
            this.ProjectEntryTablePanel.Margin = new System.Windows.Forms.Padding(0);
            this.ProjectEntryTablePanel.Name = "ProjectEntryTablePanel";
            this.ProjectEntryTablePanel.RowCount = 4;
            this.ProjectEntryTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ProjectEntryTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.ProjectEntryTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ProjectEntryTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProjectEntryTablePanel.Size = new System.Drawing.Size(824, 408);
            this.ProjectEntryTablePanel.TabIndex = 0;
            // 
            // ucIssueDescription1
            // 
            this.ucIssueDescription1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucIssueDescription1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ucIssueDescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucIssueDescription1.Enabled = false;
            this.ucIssueDescription1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucIssueDescription1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ucIssueDescription1.Location = new System.Drawing.Point(10, 138);
            this.ucIssueDescription1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 20);
            this.ucIssueDescription1.Multiline = true;
            this.ucIssueDescription1.Name = "ucIssueDescription1";
            this.ucIssueDescription1.Size = new System.Drawing.Size(804, 250);
            this.ucIssueDescription1.TabIndex = 3;
            this.ucIssueDescription1.Text = "Enter Your Text";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Title*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(818, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Issue Description*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IssueTitleTextBox
            // 
            this.IssueTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.IssueTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IssueTitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IssueTitleTextBox.Enabled = false;
            this.IssueTitleTextBox.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueTitleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.IssueTitleTextBox.Location = new System.Drawing.Point(10, 49);
            this.IssueTitleTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.IssueTitleTextBox.Multiline = true;
            this.IssueTitleTextBox.Name = "IssueTitleTextBox";
            this.IssueTitleTextBox.Size = new System.Drawing.Size(804, 31);
            this.IssueTitleTextBox.TabIndex = 2;
            this.IssueTitleTextBox.Text = "Enter Issue Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.solutionTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 593);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15, 0, 15, 15);
            this.panel3.Size = new System.Drawing.Size(1408, 417);
            this.panel3.TabIndex = 12;
            // 
            // solutionTextBox
            // 
            this.solutionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.solutionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.solutionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionTextBox.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solutionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.solutionTextBox.Location = new System.Drawing.Point(15, 60);
            this.solutionTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 20);
            this.solutionTextBox.Multiline = true;
            this.solutionTextBox.Name = "solutionTextBox";
            this.solutionTextBox.Size = new System.Drawing.Size(1378, 342);
            this.solutionTextBox.TabIndex = 4;
            this.solutionTextBox.Text = "Enter a Solution";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(15, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1378, 60);
            this.label3.TabIndex = 1;
            this.label3.Text = "Solution";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 1010);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1408, 60);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.IssueDate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnSetPriority, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnSetType, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 504);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1408, 89);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // IssueDate
            // 
            this.IssueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IssueDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.IssueDate.BorderSize = 2;
            this.IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDate.Location = new System.Drawing.Point(731, 24);
            this.IssueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.IssueDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(298, 35);
            this.IssueDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.IssueDate.TabIndex = 6;
            this.IssueDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            // 
            // BtnSetPriority
            // 
            this.BtnSetPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnSetPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSetPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetPriority.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnSetPriority.Location = new System.Drawing.Point(12, 12);
            this.BtnSetPriority.Margin = new System.Windows.Forms.Padding(12);
            this.BtnSetPriority.Name = "BtnSetPriority";
            this.BtnSetPriority.Size = new System.Drawing.Size(328, 65);
            this.BtnSetPriority.TabIndex = 0;
            this.BtnSetPriority.Text = "Set Priority";
            this.BtnSetPriority.UseVisualStyleBackColor = false;
            // 
            // BtnSetType
            // 
            this.BtnSetType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnSetType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSetType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetType.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnSetType.Location = new System.Drawing.Point(364, 12);
            this.BtnSetType.Margin = new System.Windows.Forms.Padding(12);
            this.BtnSetType.Name = "BtnSetType";
            this.BtnSetType.Size = new System.Drawing.Size(328, 65);
            this.BtnSetType.TabIndex = 1;
            this.BtnSetType.Text = "Set Type";
            this.BtnSetType.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.ucNotFound1);
            this.panel4.Location = new System.Drawing.Point(1061, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 83);
            this.panel4.TabIndex = 7;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "No Attachment";
            this.ucNotFound1.HeadTextSize = 6;
            this.ucNotFound1.Location = new System.Drawing.Point(0, 0);
            this.ucNotFound1.Margin = new System.Windows.Forms.Padding(4, 1, 4, 5);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(342, 83);
            this.ucNotFound1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 83);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attachment";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.Download_Dark_Blue;
            this.pictureBox1.Location = new System.Drawing.Point(291, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnClickDownloadAttachment);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddSolution, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1402, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.OnAddAttachment);
            // 
            // buttonAddSolution
            // 
            this.buttonAddSolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.buttonAddSolution.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAddSolution.FlatAppearance.BorderSize = 0;
            this.buttonAddSolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddSolution.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonAddSolution.Location = new System.Drawing.Point(1153, 8);
            this.buttonAddSolution.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.buttonAddSolution.Name = "buttonAddSolution";
            this.buttonAddSolution.Size = new System.Drawing.Size(234, 38);
            this.buttonAddSolution.TabIndex = 11;
            this.buttonAddSolution.Text = "Add Solution";
            this.buttonAddSolution.UseVisualStyleBackColor = false;
            this.buttonAddSolution.Click += new System.EventHandler(this.OnClickAddSolution);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelAttachment);
            this.panel5.Controls.Add(this.pictureBoxAttachments);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1016, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(86, 54);
            this.panel5.TabIndex = 12;
            // 
            // labelAttachment
            // 
            this.labelAttachment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelAttachment.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttachment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.labelAttachment.Location = new System.Drawing.Point(56, 5);
            this.labelAttachment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAttachment.Name = "labelAttachment";
            this.labelAttachment.Size = new System.Drawing.Size(22, 23);
            this.labelAttachment.TabIndex = 0;
            this.labelAttachment.Text = "1";
            this.labelAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAttachment.Click += new System.EventHandler(this.OnClickAttachmentCount);
            // 
            // pictureBoxAttachments
            // 
            this.pictureBoxAttachments.Image = global::UserInterface.Properties.Resources.Attachment_black;
            this.pictureBoxAttachments.Location = new System.Drawing.Point(4, 5);
            this.pictureBoxAttachments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxAttachments.Name = "pictureBoxAttachments";
            this.pictureBoxAttachments.Size = new System.Drawing.Size(70, 46);
            this.pictureBoxAttachments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAttachments.TabIndex = 3;
            this.pictureBoxAttachments.TabStop = false;
            // 
            // IssueInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1408, 1070);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "IssueInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanelTags.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ProjectEntryTablePanel.ResumeLayout(false);
            this.ProjectEntryTablePanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttachments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelTop;
        private ProfilePicAndName profilePostedBy;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTags;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtnAddTag;
        private System.Windows.Forms.Panel panelTags;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel ProjectEntryTablePanel;
        private System.Windows.Forms.TextBox ucIssueDescription1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IssueTitleTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox solutionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnSetPriority;
        private System.Windows.Forms.Button BtnSetType;
        private UserInterface.Add_Project.Custom_Control.CustomDateTime IssueDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserInterface.UcNotFound ucNotFound1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonAddSolution;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelAttachment;
        private System.Windows.Forms.PictureBox pictureBoxAttachments;
    }
}