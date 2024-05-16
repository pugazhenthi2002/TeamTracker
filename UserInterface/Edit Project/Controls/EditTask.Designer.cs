namespace UserInterface.Edit_Project.Controls
{
    partial class EditTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTask));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.boardBasePanel = new System.Windows.Forms.Panel();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.boardBaseManualPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchTask1 = new UserInterface.Edit_Project.Controls.SearchTask();
            this.ucNotFound2 = new UserInterface.UcNotFound();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NextBtn = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.manualEdit = new System.Windows.Forms.Label();
            this.requiredEdit = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pictureBoxAttachment = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelFileName = new System.Windows.Forms.TableLayoutPanel();
            this.animatedLabelFilename = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSetPriority = new System.Windows.Forms.Label();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.endDate = new UserInterface.Add_Project.Custom_Control.CustomDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startDate = new UserInterface.Add_Project.Custom_Control.CustomDateTime();
            this.buttonSetMilestone = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.employeeName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAssignTo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttachment)).BeginInit();
            this.tableLayoutPanelFileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAssignTo)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1057, 323);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineSeperatePaint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1037, 303);
            this.panel4.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1037, 263);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.boardBasePanel);
            this.tabPage1.Controls.Add(this.ucNotFound1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1029, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // boardBasePanel
            // 
            this.boardBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardBasePanel.Location = new System.Drawing.Point(3, 3);
            this.boardBasePanel.Name = "boardBasePanel";
            this.boardBasePanel.Padding = new System.Windows.Forms.Padding(5);
            this.boardBasePanel.Size = new System.Drawing.Size(1023, 248);
            this.boardBasePanel.TabIndex = 5;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "No Required Task To Edit";
            this.ucNotFound1.HeadTextSize = 12;
            this.ucNotFound1.Location = new System.Drawing.Point(3, 3);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(1023, 248);
            this.ucNotFound1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.boardBaseManualPanel);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.ucNotFound2);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1029, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // boardBaseManualPanel
            // 
            this.boardBaseManualPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardBaseManualPanel.Location = new System.Drawing.Point(3, 57);
            this.boardBaseManualPanel.Name = "boardBaseManualPanel";
            this.boardBaseManualPanel.Padding = new System.Windows.Forms.Padding(5);
            this.boardBaseManualPanel.Size = new System.Drawing.Size(1023, 194);
            this.boardBaseManualPanel.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchTask1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(1023, 54);
            this.panel1.TabIndex = 6;
            // 
            // searchTask1
            // 
            this.searchTask1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(190)))));
            this.searchTask1.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchTask1.Location = new System.Drawing.Point(5, 5);
            this.searchTask1.Name = "searchTask1";
            this.searchTask1.Size = new System.Drawing.Size(243, 44);
            this.searchTask1.TabIndex = 0;
            this.searchTask1.TaskNameChange += new System.EventHandler<string>(this.OnTaskNameChanged);
            // 
            // ucNotFound2
            // 
            this.ucNotFound2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotFound2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound2.HeadText = "No Manual Task To Edit";
            this.ucNotFound2.HeadTextSize = 12;
            this.ucNotFound2.Location = new System.Drawing.Point(3, 3);
            this.ucNotFound2.Message = null;
            this.ucNotFound2.Name = "ucNotFound2";
            this.ucNotFound2.Size = new System.Drawing.Size(1023, 248);
            this.ucNotFound2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.NextBtn);
            this.panel5.Controls.Add(this.BackBtn);
            this.panel5.Controls.Add(this.manualEdit);
            this.panel5.Controls.Add(this.requiredEdit);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel5.Size = new System.Drawing.Size(1037, 40);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineSeperatePaint);
            // 
            // NextBtn
            // 
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.NextBtn.Location = new System.Drawing.Point(358, 0);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(42, 38);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.TabStop = false;
            this.NextBtn.Click += new System.EventHandler(this.OnNextClick);
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackBtn.Location = new System.Drawing.Point(316, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(42, 38);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.OnBackClick);
            // 
            // manualEdit
            // 
            this.manualEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manualEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.manualEdit.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualEdit.Location = new System.Drawing.Point(158, 0);
            this.manualEdit.Name = "manualEdit";
            this.manualEdit.Size = new System.Drawing.Size(158, 38);
            this.manualEdit.TabIndex = 0;
            this.manualEdit.Text = "Manual Edit";
            this.manualEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.manualEdit.Click += new System.EventHandler(this.OnManualClick);
            // 
            // requiredEdit
            // 
            this.requiredEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requiredEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.requiredEdit.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredEdit.Location = new System.Drawing.Point(0, 0);
            this.requiredEdit.Name = "requiredEdit";
            this.requiredEdit.Size = new System.Drawing.Size(158, 38);
            this.requiredEdit.TabIndex = 3;
            this.requiredEdit.Text = "Required Edit";
            this.requiredEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.requiredEdit.Click += new System.EventHandler(this.OnRequiredClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelFileName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 323);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1057, 474);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.buttonUpdate, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonDelete, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxAttachment, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 423);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1057, 51);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUpdate.FlatAppearance.BorderSize = 0;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonUpdate.Location = new System.Drawing.Point(796, 5);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(256, 41);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.OnTaskUpdate);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonDelete.Location = new System.Drawing.Point(532, 5);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(254, 41);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.OnTaskDelete);
            // 
            // pictureBoxAttachment
            // 
            this.pictureBoxAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAttachment.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxAttachment.Image = global::UserInterface.Properties.Resources.Attachment_black;
            this.pictureBoxAttachment.Location = new System.Drawing.Point(493, 0);
            this.pictureBoxAttachment.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxAttachment.Name = "pictureBoxAttachment";
            this.pictureBoxAttachment.Size = new System.Drawing.Size(34, 51);
            this.pictureBoxAttachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAttachment.TabIndex = 3;
            this.pictureBoxAttachment.TabStop = false;
            this.pictureBoxAttachment.Click += new System.EventHandler(this.OnClickAddAttachment);
            // 
            // tableLayoutPanelFileName
            // 
            this.tableLayoutPanelFileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.tableLayoutPanelFileName.ColumnCount = 3;
            this.tableLayoutPanelFileName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelFileName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFileName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelFileName.Controls.Add(this.animatedLabelFilename, 1, 0);
            this.tableLayoutPanelFileName.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanelFileName.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanelFileName.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelFileName.Location = new System.Drawing.Point(240, 388);
            this.tableLayoutPanelFileName.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelFileName.Name = "tableLayoutPanelFileName";
            this.tableLayoutPanelFileName.RowCount = 1;
            this.tableLayoutPanelFileName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFileName.Size = new System.Drawing.Size(577, 35);
            this.tableLayoutPanelFileName.TabIndex = 4;
            // 
            // animatedLabelFilename
            // 
            this.animatedLabelFilename.AutoSize = true;
            this.animatedLabelFilename.BackColor = System.Drawing.Color.Transparent;
            this.animatedLabelFilename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animatedLabelFilename.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatedLabelFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.animatedLabelFilename.Location = new System.Drawing.Point(41, 1);
            this.animatedLabelFilename.Margin = new System.Windows.Forms.Padding(1);
            this.animatedLabelFilename.Name = "animatedLabelFilename";
            this.animatedLabelFilename.Size = new System.Drawing.Size(495, 33);
            this.animatedLabelFilename.TabIndex = 4;
            this.animatedLabelFilename.Text = "Attachment Name";
            this.animatedLabelFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::UserInterface.Properties.Resources.Close_Dark_Blue;
            this.pictureBox2.Location = new System.Drawing.Point(539, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.OnClickCloseFile);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSetMilestone, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 303);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1051, 82);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Controls.Add(this.labelSetPriority, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBoxFlag, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(854, 30);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(182, 22);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // labelSetPriority
            // 
            this.labelSetPriority.BackColor = System.Drawing.Color.Transparent;
            this.labelSetPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSetPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSetPriority.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelSetPriority.Location = new System.Drawing.Point(54, 0);
            this.labelSetPriority.Margin = new System.Windows.Forms.Padding(0);
            this.labelSetPriority.Name = "labelSetPriority";
            this.labelSetPriority.Size = new System.Drawing.Size(128, 22);
            this.labelSetPriority.TabIndex = 3;
            this.labelSetPriority.Text = "Set Priority";
            this.labelSetPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSetPriority.Click += new System.EventHandler(this.OnClickSetPriority);
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFlag.Image = global::UserInterface.Properties.Resources.flag_empty;
            this.pictureBoxFlag.InitialImage = null;
            this.pictureBoxFlag.Location = new System.Drawing.Point(18, 0);
            this.pictureBoxFlag.Margin = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(36, 22);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFlag.TabIndex = 0;
            this.pictureBoxFlag.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.endDate, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.startDate, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(475, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(361, 76);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // endDate
            // 
            this.endDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.endDate.BorderSize = 2;
            this.endDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.endDate.Location = new System.Drawing.Point(183, 38);
            this.endDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.endDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(175, 35);
            this.endDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.endDate.TabIndex = 6;
            this.endDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(183, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startDate
            // 
            this.startDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.startDate.BorderSize = 2;
            this.startDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.startDate.Location = new System.Drawing.Point(3, 38);
            this.startDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.startDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(174, 35);
            this.startDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.startDate.TabIndex = 5;
            this.startDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            // 
            // buttonSetMilestone
            // 
            this.buttonSetMilestone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonSetMilestone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSetMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetMilestone.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetMilestone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonSetMilestone.Location = new System.Drawing.Point(15, 30);
            this.buttonSetMilestone.Margin = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.buttonSetMilestone.Name = "buttonSetMilestone";
            this.buttonSetMilestone.Size = new System.Drawing.Size(180, 22);
            this.buttonSetMilestone.TabIndex = 9;
            this.buttonSetMilestone.Text = "Set Milestone";
            this.buttonSetMilestone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSetMilestone.Click += new System.EventHandler(this.OnClickSetMilestone);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(225, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(15, 30, 15, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 22);
            this.panel3.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.employeeName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(232, 22);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // employeeName
            // 
            this.employeeName.BackColor = System.Drawing.Color.Transparent;
            this.employeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.employeeName.Location = new System.Drawing.Point(0, 8);
            this.employeeName.Margin = new System.Windows.Forms.Padding(0);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(232, 14);
            this.employeeName.TabIndex = 5;
            this.employeeName.Text = "Employee Name";
            this.employeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.BtnAssignTo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(1);
            this.panel6.Size = new System.Drawing.Size(232, 8);
            this.panel6.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 6);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assigned To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAssignTo
            // 
            this.BtnAssignTo.BackColor = System.Drawing.Color.Transparent;
            this.BtnAssignTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAssignTo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnAssignTo.Image = global::UserInterface.Properties.Resources.Paginate_Down_Blue;
            this.BtnAssignTo.Location = new System.Drawing.Point(204, 1);
            this.BtnAssignTo.Name = "BtnAssignTo";
            this.BtnAssignTo.Size = new System.Drawing.Size(27, 6);
            this.BtnAssignTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnAssignTo.TabIndex = 0;
            this.BtnAssignTo.TabStop = false;
            this.BtnAssignTo.Click += new System.EventHandler(this.OnClickAssignBtn);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1053, 66);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(2, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1049, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Task Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(2, 72);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1053, 226);
            this.tableLayoutPanel8.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(2, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1049, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Task Description";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBoxTaskName);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 35);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel7.Size = new System.Drawing.Size(1047, 28);
            this.panel7.TabIndex = 2;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineSeperatePaint);
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.textBoxTaskName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTaskName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTaskName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaskName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.textBoxTaskName.Location = new System.Drawing.Point(0, 0);
            this.textBoxTaskName.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.textBoxTaskName.Multiline = true;
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(1047, 27);
            this.textBoxTaskName.TabIndex = 5;
            this.textBoxTaskName.Text = "Enter Task Title..";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.textBoxDesc);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 35);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panel8.Size = new System.Drawing.Size(1047, 188);
            this.panel8.TabIndex = 3;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineSeperatePaint);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.textBoxDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDesc.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.textBoxDesc.Location = new System.Drawing.Point(0, 0);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(1047, 187);
            this.textBoxDesc.TabIndex = 6;
            this.textBoxDesc.Text = "Enter Task Description..";
            // 
            // EditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "EditTask";
            this.Size = new System.Drawing.Size(1057, 797);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttachment)).EndInit();
            this.tableLayoutPanelFileName.ResumeLayout(false);
            this.tableLayoutPanelFileName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAssignTo)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox NextBtn;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.Label manualEdit;
        private System.Windows.Forms.Label requiredEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.PictureBox pictureBoxAttachment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFileName;
        private System.Windows.Forms.Label animatedLabelFilename;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelSetPriority;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BtnAssignTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Add_Project.Custom_Control.CustomDateTime endDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Add_Project.Custom_Control.CustomDateTime startDate;
        private System.Windows.Forms.Label buttonSetMilestone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDelete;
        private UcNotFound ucNotFound1;
        private System.Windows.Forms.Panel boardBasePanel;
        private UcNotFound ucNotFound2;
        private System.Windows.Forms.Panel boardBaseManualPanel;
        private System.Windows.Forms.Panel panel1;
        private SearchTask searchTask1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBoxDesc;
    }
}
