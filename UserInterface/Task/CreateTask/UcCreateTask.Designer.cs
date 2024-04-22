namespace TeamTracker
{
    partial class UcCreateTask
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSetMilestone = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSetPriority = new System.Windows.Forms.Label();
            this.pictureBoxFlag = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAssignTo = new System.Windows.Forms.Button();
            this.labelFrom = new System.Windows.Forms.Label();
            this.employeeProfilePicAndName1 = new UserInterface.ViewProject.EmployeeProfilePicAndName();
            this.tableLayoutPanelFileName = new System.Windows.Forms.TableLayoutPanel();
            this.animatedLabelFilename = new TeamTracker.AnimatedLabel();
            this.pictureBoxCloseFile = new System.Windows.Forms.PictureBox();
            this.textBoxTaskName = new TeamTracker.TextBoxU();
            this.textBoxDesc = new TeamTracker.TextBoxU();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonDiscard = new System.Windows.Forms.Button();
            this.pictureBoxAttachment = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanelFileName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseFile)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttachment)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSetMilestone, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 404);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(991, 69);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonSetMilestone
            // 
            this.buttonSetMilestone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.buttonSetMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSetMilestone.FlatAppearance.BorderSize = 0;
            this.buttonSetMilestone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.buttonSetMilestone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetMilestone.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetMilestone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonSetMilestone.Location = new System.Drawing.Point(10, 11);
            this.buttonSetMilestone.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.buttonSetMilestone.Name = "buttonSetMilestone";
            this.buttonSetMilestone.Size = new System.Drawing.Size(227, 47);
            this.buttonSetMilestone.TabIndex = 6;
            this.buttonSetMilestone.Text = "Set Milestone";
            this.buttonSetMilestone.UseVisualStyleBackColor = false;
            this.buttonSetMilestone.Click += new System.EventHandler(this.OnClickSetMilestone);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePickerTo, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(494, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 11);
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(247, 69);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Set Due";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerTo.Location = new System.Drawing.Point(4, 28);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(239, 26);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel5.Controls.Add(this.labelSetPriority, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBoxFlag, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(741, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(206, 69);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // labelSetPriority
            // 
            this.labelSetPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.labelSetPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSetPriority.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSetPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelSetPriority.Location = new System.Drawing.Point(69, 8);
            this.labelSetPriority.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.labelSetPriority.Name = "labelSetPriority";
            this.labelSetPriority.Size = new System.Drawing.Size(129, 53);
            this.labelSetPriority.TabIndex = 3;
            this.labelSetPriority.Text = "Set Priority";
            this.labelSetPriority.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSetPriority.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickSetPriority);
            this.labelSetPriority.MouseEnter += new System.EventHandler(this.OnMouseEnterSetPriority);
            this.labelSetPriority.MouseLeave += new System.EventHandler(this.OnMouseLeaveSetPriority);
            // 
            // pictureBoxFlag
            // 
            this.pictureBoxFlag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFlag.Image = global::UserInterface.Properties.Resources.flag_empty;
            this.pictureBoxFlag.InitialImage = null;
            this.pictureBoxFlag.Location = new System.Drawing.Point(27, 0);
            this.pictureBoxFlag.Margin = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.pictureBoxFlag.Name = "pictureBoxFlag";
            this.pictureBoxFlag.Size = new System.Drawing.Size(34, 69);
            this.pictureBoxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFlag.TabIndex = 0;
            this.pictureBoxFlag.TabStop = false;
            this.pictureBoxFlag.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickSetPriority);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.employeeProfilePicAndName1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(247, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 69);
            this.panel1.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.BtnAssignTo, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelFrom, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(247, 69);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // BtnAssignTo
            // 
            this.BtnAssignTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.BtnAssignTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAssignTo.FlatAppearance.BorderSize = 0;
            this.BtnAssignTo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.BtnAssignTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAssignTo.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAssignTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnAssignTo.Location = new System.Drawing.Point(4, 27);
            this.BtnAssignTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 11);
            this.BtnAssignTo.Name = "BtnAssignTo";
            this.BtnAssignTo.Size = new System.Drawing.Size(239, 31);
            this.BtnAssignTo.TabIndex = 7;
            this.BtnAssignTo.Text = "Not Assigned ▼";
            this.BtnAssignTo.UseVisualStyleBackColor = false;
            this.BtnAssignTo.Click += new System.EventHandler(this.OnClickAssignBtn);
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFrom.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelFrom.Location = new System.Drawing.Point(4, 5);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(239, 22);
            this.labelFrom.TabIndex = 2;
            this.labelFrom.Text = "Assign to";
            // 
            // employeeProfilePicAndName1
            // 
            this.employeeProfilePicAndName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeProfilePicAndName1.HoverColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Location = new System.Drawing.Point(0, 0);
            this.employeeProfilePicAndName1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.employeeProfilePicAndName1.Name = "employeeProfilePicAndName1";
            this.employeeProfilePicAndName1.NormalColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Size = new System.Drawing.Size(247, 69);
            this.employeeProfilePicAndName1.TabIndex = 0;
            this.employeeProfilePicAndName1.Click += new System.EventHandler(this.OnClickAssignBtn);
            // 
            // tableLayoutPanelFileName
            // 
            this.tableLayoutPanelFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.tableLayoutPanelFileName.ColumnCount = 2;
            this.tableLayoutPanelFileName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelFileName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelFileName.Controls.Add(this.animatedLabelFilename, 0, 0);
            this.tableLayoutPanelFileName.Controls.Add(this.pictureBoxCloseFile, 1, 0);
            this.tableLayoutPanelFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFileName.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelFileName.Location = new System.Drawing.Point(150, 478);
            this.tableLayoutPanelFileName.Margin = new System.Windows.Forms.Padding(150, 0, 150, 0);
            this.tableLayoutPanelFileName.Name = "tableLayoutPanelFileName";
            this.tableLayoutPanelFileName.RowCount = 1;
            this.tableLayoutPanelFileName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelFileName.Size = new System.Drawing.Size(699, 53);
            this.tableLayoutPanelFileName.TabIndex = 4;
            // 
            // animatedLabelFilename
            // 
            this.animatedLabelFilename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.animatedLabelFilename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animatedLabelFilename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.animatedLabelFilename.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatedLabelFilename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.animatedLabelFilename.LabelCornerColor = System.Drawing.Color.Empty;
            this.animatedLabelFilename.Location = new System.Drawing.Point(4, 5);
            this.animatedLabelFilename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.animatedLabelFilename.Name = "animatedLabelFilename";
            this.animatedLabelFilename.Size = new System.Drawing.Size(551, 43);
            this.animatedLabelFilename.TabIndex = 0;
            this.animatedLabelFilename.Text = "FileName";
            this.animatedLabelFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxCloseFile
            // 
            this.pictureBoxCloseFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.pictureBoxCloseFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCloseFile.Image = global::UserInterface.Properties.Resources.Close_Black;
            this.pictureBoxCloseFile.Location = new System.Drawing.Point(563, 5);
            this.pictureBoxCloseFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxCloseFile.Name = "pictureBoxCloseFile";
            this.pictureBoxCloseFile.Size = new System.Drawing.Size(132, 43);
            this.pictureBoxCloseFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCloseFile.TabIndex = 1;
            this.pictureBoxCloseFile.TabStop = false;
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.textBoxTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTaskName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTaskName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxTaskName.Interval = 15;
            this.textBoxTaskName.Location = new System.Drawing.Point(15, 15);
            this.textBoxTaskName.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.textBoxTaskName.Multiline = true;
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Padding = new System.Windows.Forms.Padding(18, 20, 12, 9);
            this.textBoxTaskName.PasswordChar = '\0';
            this.textBoxTaskName.PlaceholderLabelAtCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.textBoxTaskName.PlaceholderLabelAtTopColor = System.Drawing.Color.Black;
            this.textBoxTaskName.PlaceholderText = "Task Name";
            this.textBoxTaskName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTaskName.Size = new System.Drawing.Size(969, 103);
            this.textBoxTaskName.TabIndex = 0;
            this.textBoxTaskName.TextBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.textBoxTaskName.TextBoxDock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTaskName.TextBoxtext = "";
            this.textBoxTaskName.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTaskName.UseSystemPasswordChar = false;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.textBoxDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDesc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDesc.Interval = 15;
            this.textBoxDesc.Location = new System.Drawing.Point(15, 148);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.textBoxDesc.Multiline = true;
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Padding = new System.Windows.Forms.Padding(18, 20, 12, 9);
            this.textBoxDesc.PasswordChar = '\0';
            this.textBoxDesc.PlaceholderLabelAtCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.textBoxDesc.PlaceholderLabelAtTopColor = System.Drawing.Color.Black;
            this.textBoxDesc.PlaceholderText = "Description";
            this.textBoxDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxDesc.Size = new System.Drawing.Size(969, 236);
            this.textBoxDesc.TabIndex = 1;
            this.textBoxDesc.TextBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.textBoxDesc.TextBoxDock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDesc.TextBoxtext = "";
            this.textBoxDesc.TextForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxDesc.UseSystemPasswordChar = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.buttonCreate, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonDiscard, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBoxAttachment, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 531);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(999, 63);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreate.FlatAppearance.BorderSize = 0;
            this.buttonCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonCreate.Location = new System.Drawing.Point(755, 8);
            this.buttonCreate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(236, 47);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonDiscard
            // 
            this.buttonDiscard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonDiscard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDiscard.FlatAppearance.BorderSize = 0;
            this.buttonDiscard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscard.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiscard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonDiscard.Location = new System.Drawing.Point(506, 8);
            this.buttonDiscard.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonDiscard.Name = "buttonDiscard";
            this.buttonDiscard.Size = new System.Drawing.Size(233, 47);
            this.buttonDiscard.TabIndex = 0;
            this.buttonDiscard.Text = "Discard";
            this.buttonDiscard.UseVisualStyleBackColor = false;
            // 
            // pictureBoxAttachment
            // 
            this.pictureBoxAttachment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxAttachment.Image = global::UserInterface.Properties.Resources.Attachment_black;
            this.pictureBoxAttachment.Location = new System.Drawing.Point(423, 5);
            this.pictureBoxAttachment.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxAttachment.Name = "pictureBoxAttachment";
            this.pictureBoxAttachment.Size = new System.Drawing.Size(51, 52);
            this.pictureBoxAttachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAttachment.TabIndex = 3;
            this.pictureBoxAttachment.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxDesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTaskName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelFileName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(999, 594);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UcCreateTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcCreateTask";
            this.Size = new System.Drawing.Size(999, 594);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlag)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanelFileName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseFile)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAttachment)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonSetMilestone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelSetPriority;
        private System.Windows.Forms.PictureBox pictureBoxFlag;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button BtnAssignTo;
        private System.Windows.Forms.Label labelFrom;
        private UserInterface.ViewProject.EmployeeProfilePicAndName employeeProfilePicAndName1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFileName;
        private AnimatedLabel animatedLabelFilename;
        private System.Windows.Forms.PictureBox pictureBoxCloseFile;
        private TextBoxU textBoxTaskName;
        private TextBoxU textBoxDesc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonDiscard;
        private System.Windows.Forms.PictureBox pictureBoxAttachment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
