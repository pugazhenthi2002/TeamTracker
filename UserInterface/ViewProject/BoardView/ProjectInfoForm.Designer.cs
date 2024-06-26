﻿namespace TeamTracker
{
    partial class ProjectInfoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectInfoForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileAssignedTo = new TeamTracker.ProfilePicAndName();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.endDate = new TeamTracker.UcDueDate();
            this.startDate = new TeamTracker.UcDueDate();
            this.panelSourceCode = new System.Windows.Forms.Panel();
            this.labelSourceCode = new System.Windows.Forms.Label();
            this.pictureBoxSoureCode = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelAttachment = new System.Windows.Forms.Panel();
            this.labelAttachment = new System.Windows.Forms.Label();
            this.pictureBoxAttachment = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ucTaskDescription1 = new TeamTracker.UcTaskDescription();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTaskCount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.milestoneView1 = new TeamTracker.MilestoneView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.donePanel = new System.Windows.Forms.Panel();
            this.delayPanel = new System.Windows.Forms.Panel();
            this.currentPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notstartedPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.nextBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelSourceCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoureCode)).BeginInit();
            this.panelAttachment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttachment)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1087, 618);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.profileAssignedTo);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(1087, 61);
            this.panel1.TabIndex = 1;
            // 
            // profileAssignedTo
            // 
            this.profileAssignedTo.BackColor = System.Drawing.Color.Transparent;
            this.profileAssignedTo.BorderColor = System.Drawing.Color.Empty;
            this.profileAssignedTo.BorderRadius = 0;
            this.profileAssignedTo.Dock = System.Windows.Forms.DockStyle.Right;
            this.profileAssignedTo.EmployeeProfile = null;
            this.profileAssignedTo.HoverColor = System.Drawing.Color.Empty;
            this.profileAssignedTo.IsBorderNeeded = false;
            this.profileAssignedTo.IsOperable = false;
            this.profileAssignedTo.Location = new System.Drawing.Point(792, 0);
            this.profileAssignedTo.Margin = new System.Windows.Forms.Padding(1);
            this.profileAssignedTo.Name = "profileAssignedTo";
            this.profileAssignedTo.NormalColor = System.Drawing.Color.Empty;
            this.profileAssignedTo.Padding = new System.Windows.Forms.Padding(3);
            this.profileAssignedTo.ProfileTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.profileAssignedTo.Size = new System.Drawing.Size(240, 58);
            this.profileAssignedTo.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelTitle.Size = new System.Drawing.Size(424, 58);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Project Name";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1032, 0);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(55, 58);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.OnClose);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.OnCloseMouseEnter);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.endDate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.startDate, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelSourceCode, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelAttachment, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 246);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1087, 92);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // endDate
            // 
            this.endDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.endDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.endDate.CenterLabelText = null;
            this.endDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDate.DueDate = new System.DateTime(2024, 4, 4, 17, 49, 29, 0);
            this.endDate.DueLabelcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.endDate.HeaderForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.endDate.LabelText = "To";
            this.endDate.Location = new System.Drawing.Point(331, 20);
            this.endDate.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(316, 52);
            this.endDate.TabIndex = 3;
            // 
            // startDate
            // 
            this.startDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.startDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.startDate.CenterLabelText = null;
            this.startDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDate.DueDate = new System.DateTime(2024, 4, 12, 0, 0, 0, 0);
            this.startDate.DueLabelcolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.startDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.startDate.HeaderForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.startDate.LabelText = "From";
            this.startDate.Location = new System.Drawing.Point(5, 20);
            this.startDate.Margin = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(316, 52);
            this.startDate.TabIndex = 2;
            // 
            // panelSourceCode
            // 
            this.panelSourceCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panelSourceCode.Controls.Add(this.labelSourceCode);
            this.panelSourceCode.Controls.Add(this.pictureBoxSoureCode);
            this.panelSourceCode.Controls.Add(this.label3);
            this.panelSourceCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSourceCode.Location = new System.Drawing.Point(667, 20);
            this.panelSourceCode.Margin = new System.Windows.Forms.Padding(15, 20, 5, 20);
            this.panelSourceCode.Name = "panelSourceCode";
            this.panelSourceCode.Size = new System.Drawing.Size(197, 52);
            this.panelSourceCode.TabIndex = 4;
            this.panelSourceCode.Paint += new System.Windows.Forms.PaintEventHandler(this.OnDownloadEdgePaint);
            // 
            // labelSourceCode
            // 
            this.labelSourceCode.BackColor = System.Drawing.Color.Transparent;
            this.labelSourceCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSourceCode.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSourceCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelSourceCode.Location = new System.Drawing.Point(0, 0);
            this.labelSourceCode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSourceCode.Name = "labelSourceCode";
            this.labelSourceCode.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSourceCode.Size = new System.Drawing.Size(165, 52);
            this.labelSourceCode.TabIndex = 7;
            this.labelSourceCode.Text = "SourceCode";
            this.labelSourceCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxSoureCode
            // 
            this.pictureBoxSoureCode.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSoureCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSoureCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxSoureCode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSoureCode.Image")));
            this.pictureBoxSoureCode.Location = new System.Drawing.Point(165, 0);
            this.pictureBoxSoureCode.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxSoureCode.Name = "pictureBoxSoureCode";
            this.pictureBoxSoureCode.Size = new System.Drawing.Size(32, 52);
            this.pictureBoxSoureCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxSoureCode.TabIndex = 6;
            this.pictureBoxSoureCode.TabStop = false;
            this.pictureBoxSoureCode.Click += new System.EventHandler(this.SourceCodeDownload);
            this.pictureBoxSoureCode.MouseEnter += new System.EventHandler(this.OnDownloadMouseEnter);
            this.pictureBoxSoureCode.MouseLeave += new System.EventHandler(this.OnDownloadMouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 52);
            this.label3.TabIndex = 0;
            this.label3.Text = "No Source Code Found!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAttachment
            // 
            this.panelAttachment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panelAttachment.Controls.Add(this.labelAttachment);
            this.panelAttachment.Controls.Add(this.pictureBoxAttachment);
            this.panelAttachment.Controls.Add(this.label8);
            this.panelAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAttachment.Location = new System.Drawing.Point(884, 20);
            this.panelAttachment.Margin = new System.Windows.Forms.Padding(15, 20, 5, 20);
            this.panelAttachment.Name = "panelAttachment";
            this.panelAttachment.Size = new System.Drawing.Size(198, 52);
            this.panelAttachment.TabIndex = 5;
            this.panelAttachment.Paint += new System.Windows.Forms.PaintEventHandler(this.OnDownloadEdgePaint);
            // 
            // labelAttachment
            // 
            this.labelAttachment.BackColor = System.Drawing.Color.Transparent;
            this.labelAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAttachment.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttachment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelAttachment.Location = new System.Drawing.Point(0, 0);
            this.labelAttachment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAttachment.Name = "labelAttachment";
            this.labelAttachment.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAttachment.Size = new System.Drawing.Size(163, 52);
            this.labelAttachment.TabIndex = 10;
            this.labelAttachment.Text = "Attachment";
            this.labelAttachment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxAttachment
            // 
            this.pictureBoxAttachment.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAttachment.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxAttachment.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAttachment.Image")));
            this.pictureBoxAttachment.Location = new System.Drawing.Point(163, 0);
            this.pictureBoxAttachment.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxAttachment.Name = "pictureBoxAttachment";
            this.pictureBoxAttachment.Size = new System.Drawing.Size(35, 52);
            this.pictureBoxAttachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAttachment.TabIndex = 9;
            this.pictureBoxAttachment.TabStop = false;
            this.pictureBoxAttachment.Click += new System.EventHandler(this.AttachmentDownload);
            this.pictureBoxAttachment.MouseEnter += new System.EventHandler(this.OnDownloadMouseEnter);
            this.pictureBoxAttachment.MouseLeave += new System.EventHandler(this.OnDownloadMouseLeave);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 52);
            this.label8.TabIndex = 0;
            this.label8.Text = "No Attachment Found";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.ucTaskDescription1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1081, 179);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // ucTaskDescription1
            // 
            this.ucTaskDescription1.BackColor = System.Drawing.Color.White;
            this.ucTaskDescription1.BorderColor = System.Drawing.Color.Black;
            this.ucTaskDescription1.CenterLabelText = "Task Description...";
            this.ucTaskDescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskDescription1.EnableEdit = true;
            this.ucTaskDescription1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ucTaskDescription1.Location = new System.Drawing.Point(3, 10);
            this.ucTaskDescription1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ucTaskDescription1.Name = "ucTaskDescription1";
            this.ucTaskDescription1.Size = new System.Drawing.Size(642, 166);
            this.ucTaskDescription1.TabIndex = 3;
            this.ucTaskDescription1.TopLabelColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.ucTaskDescription1.TopLabelForeColor = System.Drawing.Color.White;
            this.ucTaskDescription1.TopLabelText = "Task Name";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelTaskCount, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(663, 15);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(15);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(403, 149);
            this.tableLayoutPanel5.TabIndex = 4;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.OnDownloadEdgePaint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(5, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Size = new System.Drawing.Size(393, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTaskCount
            // 
            this.labelTaskCount.BackColor = System.Drawing.Color.Transparent;
            this.labelTaskCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTaskCount.Font = new System.Drawing.Font("Ebrima", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelTaskCount.Location = new System.Drawing.Point(5, 0);
            this.labelTaskCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTaskCount.Name = "labelTaskCount";
            this.labelTaskCount.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTaskCount.Size = new System.Drawing.Size(393, 104);
            this.labelTaskCount.TabIndex = 1;
            this.labelTaskCount.Text = "6";
            this.labelTaskCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ucNotFound1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 274);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1081, 274);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.milestoneView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1081, 210);
            this.panel5.TabIndex = 2;
            // 
            // milestoneView1
            // 
            this.milestoneView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.milestoneView1.Location = new System.Drawing.Point(0, 0);
            this.milestoneView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.milestoneView1.MilestoneCollection = null;
            this.milestoneView1.Name = "milestoneView1";
            this.milestoneView1.Size = new System.Drawing.Size(1081, 210);
            this.milestoneView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 244);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1081, 30);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 8;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label7, 7, 0);
            this.tableLayoutPanel7.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.donePanel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.delayPanel, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.currentPanel, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.notstartedPanel, 6, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(421, 30);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(287, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Not Started";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(191, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Current";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // donePanel
            // 
            this.donePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.donePanel.BackColor = System.Drawing.Color.Transparent;
            this.donePanel.Location = new System.Drawing.Point(3, 5);
            this.donePanel.Margin = new System.Windows.Forms.Padding(0);
            this.donePanel.Name = "donePanel";
            this.donePanel.Size = new System.Drawing.Size(20, 20);
            this.donePanel.TabIndex = 0;
            this.donePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLegendPaint);
            // 
            // delayPanel
            // 
            this.delayPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delayPanel.BackColor = System.Drawing.Color.Transparent;
            this.delayPanel.Location = new System.Drawing.Point(79, 5);
            this.delayPanel.Margin = new System.Windows.Forms.Padding(0);
            this.delayPanel.Name = "delayPanel";
            this.delayPanel.Size = new System.Drawing.Size(20, 20);
            this.delayPanel.TabIndex = 1;
            this.delayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLegendPaint);
            // 
            // currentPanel
            // 
            this.currentPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentPanel.BackColor = System.Drawing.Color.Transparent;
            this.currentPanel.Location = new System.Drawing.Point(155, 5);
            this.currentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.currentPanel.Name = "currentPanel";
            this.currentPanel.Size = new System.Drawing.Size(20, 20);
            this.currentPanel.TabIndex = 2;
            this.currentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLegendPaint);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(30, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Done";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(105, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Delay";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notstartedPanel
            // 
            this.notstartedPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notstartedPanel.BackColor = System.Drawing.Color.Transparent;
            this.notstartedPanel.Location = new System.Drawing.Point(261, 5);
            this.notstartedPanel.Margin = new System.Windows.Forms.Padding(0);
            this.notstartedPanel.Name = "notstartedPanel";
            this.notstartedPanel.Size = new System.Drawing.Size(20, 20);
            this.notstartedPanel.TabIndex = 2;
            this.notstartedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLegendPaint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1081, 34);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.backBtn);
            this.panel7.Controls.Add(this.nextBtn);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1081, 34);
            this.panel7.TabIndex = 3;
            // 
            // backBtn
            // 
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.backBtn.Image = global::UserInterface.Properties.Resources.Left_Light_Blue;
            this.backBtn.Location = new System.Drawing.Point(983, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(47, 34);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 2;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.BackMilestoneClick);
            this.backBtn.MouseEnter += new System.EventHandler(this.OnMilestoneNavMouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.OnMilestoneNavMouseLeave);
            // 
            // nextBtn
            // 
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextBtn.Image = global::UserInterface.Properties.Resources.Right_Light_Blue;
            this.nextBtn.Location = new System.Drawing.Point(1030, 0);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(51, 34);
            this.nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nextBtn.TabIndex = 1;
            this.nextBtn.TabStop = false;
            this.nextBtn.Click += new System.EventHandler(this.NextMilestoneClick);
            this.nextBtn.MouseEnter += new System.EventHandler(this.OnMilestoneNavMouseEnter);
            this.nextBtn.MouseLeave += new System.EventHandler(this.OnMilestoneNavMouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Milestones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucNotFound1.HeadText = "No Milestones Found";
            this.ucNotFound1.HeadTextSize = 14;
            this.ucNotFound1.Location = new System.Drawing.Point(0, 0);
            this.ucNotFound1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ucNotFound1.Message = "Project Not Yet Started";
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(1081, 274);
            this.ucNotFound1.TabIndex = 0;
            // 
            // ProjectInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1087, 618);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectInfoForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectInfoForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelSourceCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoureCode)).EndInit();
            this.panelAttachment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttachment)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private UcDueDate endDate;
        private UcDueDate startDate;
        private ProfilePicAndName profileAssignedTo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private MilestoneView milestoneView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel donePanel;
        private System.Windows.Forms.Panel delayPanel;
        private System.Windows.Forms.Panel currentPanel;
        private System.Windows.Forms.Panel notstartedPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.PictureBox nextBtn;
        private System.Windows.Forms.Label label1;
        private UserInterface.UcNotFound ucNotFound1;
        private UcTaskDescription ucTaskDescription1;
        private System.Windows.Forms.Panel panelSourceCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTaskCount;
        private System.Windows.Forms.PictureBox pictureBoxSoureCode;
        private System.Windows.Forms.Panel panelAttachment;
        private System.Windows.Forms.Label labelAttachment;
        private System.Windows.Forms.PictureBox pictureBoxAttachment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSourceCode;
    }
}