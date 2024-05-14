namespace UserInterface
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTags = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAddTag = new System.Windows.Forms.Button();
            this.panelTags = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProjectEntryTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.ucIssueDescription1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IssueTitleTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.IssueDate = new UserInterface.Add_Project.Custom_Control.CustomDateTime();
            this.BtnSetPriority = new System.Windows.Forms.Button();
            this.BtnSetType = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanelTags.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ProjectEntryTablePanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Location = new System.Drawing.Point(64, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 311);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(626, 253);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tableLayoutPanelTags);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(382, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(237, 241);
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
            this.tableLayoutPanelTags.Size = new System.Drawing.Size(237, 241);
            this.tableLayoutPanelTags.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel4.Controls.Add(this.BtnAddTag, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(5, 2, 5, 0);
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(237, 48);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // BtnAddTag
            // 
            this.BtnAddTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnAddTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddTag.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnAddTag.Location = new System.Drawing.Point(8, 7);
            this.BtnAddTag.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.BtnAddTag.Name = "BtnAddTag";
            this.BtnAddTag.Size = new System.Drawing.Size(221, 36);
            this.BtnAddTag.TabIndex = 1;
            this.BtnAddTag.Text = "Tags";
            this.BtnAddTag.UseVisualStyleBackColor = false;
            // 
            // panelTags
            // 
            this.panelTags.AutoScroll = true;
            this.panelTags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTags.Location = new System.Drawing.Point(3, 51);
            this.panelTags.Name = "panelTags";
            this.panelTags.Size = new System.Drawing.Size(231, 187);
            this.panelTags.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.ProjectEntryTablePanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(7, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 241);
            this.panel3.TabIndex = 0;
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
            this.ProjectEntryTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.ProjectEntryTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.ProjectEntryTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.ProjectEntryTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ProjectEntryTablePanel.Size = new System.Drawing.Size(361, 241);
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
            this.ucIssueDescription1.Location = new System.Drawing.Point(7, 90);
            this.ucIssueDescription1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 13);
            this.ucIssueDescription1.Multiline = true;
            this.ucIssueDescription1.Name = "ucIssueDescription1";
            this.ucIssueDescription1.ReadOnly = true;
            this.ucIssueDescription1.Size = new System.Drawing.Size(347, 138);
            this.ucIssueDescription1.TabIndex = 3;
            this.ucIssueDescription1.Text = "Enter Your Text";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Title*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(2, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 26);
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
            this.IssueTitleTextBox.Location = new System.Drawing.Point(7, 32);
            this.IssueTitleTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.IssueTitleTextBox.Multiline = true;
            this.IssueTitleTextBox.Name = "IssueTitleTextBox";
            this.IssueTitleTextBox.ReadOnly = true;
            this.IssueTitleTextBox.Size = new System.Drawing.Size(347, 20);
            this.IssueTitleTextBox.TabIndex = 2;
            this.IssueTitleTextBox.Text = "Enter Issue Name";
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
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 253);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(626, 58);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // IssueDate
            // 
            this.IssueDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IssueDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.IssueDate.BorderSize = 2;
            this.IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDate.Location = new System.Drawing.Point(315, 10);
            this.IssueDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.IssueDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(150, 35);
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
            this.BtnSetPriority.Location = new System.Drawing.Point(8, 8);
            this.BtnSetPriority.Margin = new System.Windows.Forms.Padding(8);
            this.BtnSetPriority.Name = "BtnSetPriority";
            this.BtnSetPriority.Size = new System.Drawing.Size(140, 42);
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
            this.BtnSetType.Location = new System.Drawing.Point(164, 8);
            this.BtnSetType.Margin = new System.Windows.Forms.Padding(8);
            this.BtnSetType.Name = "BtnSetType";
            this.BtnSetType.Size = new System.Drawing.Size(140, 42);
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
            this.panel4.Location = new System.Drawing.Point(471, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(152, 54);
            this.panel4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "Attachment";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.Download_Dark_Blue;
            this.pictureBox1.Location = new System.Drawing.Point(118, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "No Attachment";
            this.ucNotFound1.HeadTextSize = 6;
            this.ucNotFound1.Location = new System.Drawing.Point(0, 0);
            this.ucNotFound1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(152, 54);
            this.ucNotFound1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(888, 678);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "e";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanelTags.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ProjectEntryTablePanel.ResumeLayout(false);
            this.ProjectEntryTablePanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TeamTracker.RippleButton rippleButton1;
        private ViewPage.ListView.DoneCardTemplate doneCardTemplate1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTags;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button BtnAddTag;
        private System.Windows.Forms.Panel panelTags;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel ProjectEntryTablePanel;
        private System.Windows.Forms.TextBox ucIssueDescription1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IssueTitleTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Add_Project.Custom_Control.CustomDateTime IssueDate;
        private System.Windows.Forms.Button BtnSetPriority;
        private System.Windows.Forms.Button BtnSetType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UcNotFound ucNotFound1;
    }
}

