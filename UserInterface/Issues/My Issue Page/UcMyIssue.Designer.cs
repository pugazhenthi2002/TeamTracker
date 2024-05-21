namespace TeamTracker
{
    partial class UcMyIssue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMyIssue));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelDatagridviewBase = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxOther = new UserInterface.Issues.CustomCheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxBug = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxFeatureRequest = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxOptimization = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxSecurity = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxLogicalNeed = new UserInterface.Issues.CustomCheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxHigh = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxMedium = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxLow = new UserInterface.Issues.CustomCheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonCreateIssue = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDatagridviewBase.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateIssue)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 60;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(514, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 45;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 1139);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDoubleClickCell);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewCellMouseClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownDatagridview);
            // 
            // panelDatagridviewBase
            // 
            this.panelDatagridviewBase.BackColor = System.Drawing.Color.Transparent;
            this.panelDatagridviewBase.Controls.Add(this.dataGridView1);
            this.panelDatagridviewBase.Controls.Add(this.panel1);
            this.panelDatagridviewBase.Controls.Add(this.panel5);
            this.panelDatagridviewBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatagridviewBase.Location = new System.Drawing.Point(0, 0);
            this.panelDatagridviewBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDatagridviewBase.Name = "panelDatagridviewBase";
            this.panelDatagridviewBase.Size = new System.Drawing.Size(1740, 1234);
            this.panelDatagridviewBase.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 1139);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 426);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel3.Size = new System.Drawing.Size(514, 609);
            this.panel3.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxOther, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxBug, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxFeatureRequest, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxOptimization, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxSecurity, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxLogicalNeed, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(498, 593);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.CheckBoxText = "Other";
            this.checkBoxOther.Checked = false;
            this.checkBoxOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxOther.Location = new System.Drawing.Point(6, 512);
            this.checkBoxOther.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.Size = new System.Drawing.Size(486, 73);
            this.checkBoxOther.TabIndex = 7;
            this.checkBoxOther.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(482, 68);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineBorderPaint);
            // 
            // checkBoxBug
            // 
            this.checkBoxBug.CheckBoxText = "Bug";
            this.checkBoxBug.Checked = false;
            this.checkBoxBug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxBug.Location = new System.Drawing.Point(6, 92);
            this.checkBoxBug.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxBug.Name = "checkBoxBug";
            this.checkBoxBug.Size = new System.Drawing.Size(486, 68);
            this.checkBoxBug.TabIndex = 0;
            this.checkBoxBug.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxFeatureRequest
            // 
            this.checkBoxFeatureRequest.CheckBoxText = "FeatureRequest";
            this.checkBoxFeatureRequest.Checked = false;
            this.checkBoxFeatureRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxFeatureRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxFeatureRequest.Location = new System.Drawing.Point(6, 176);
            this.checkBoxFeatureRequest.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxFeatureRequest.Name = "checkBoxFeatureRequest";
            this.checkBoxFeatureRequest.Size = new System.Drawing.Size(486, 68);
            this.checkBoxFeatureRequest.TabIndex = 1;
            this.checkBoxFeatureRequest.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxOptimization
            // 
            this.checkBoxOptimization.CheckBoxText = "Optimization";
            this.checkBoxOptimization.Checked = false;
            this.checkBoxOptimization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOptimization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxOptimization.Location = new System.Drawing.Point(6, 260);
            this.checkBoxOptimization.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxOptimization.Name = "checkBoxOptimization";
            this.checkBoxOptimization.Size = new System.Drawing.Size(486, 68);
            this.checkBoxOptimization.TabIndex = 2;
            this.checkBoxOptimization.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxSecurity
            // 
            this.checkBoxSecurity.CheckBoxText = "Security";
            this.checkBoxSecurity.Checked = false;
            this.checkBoxSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxSecurity.Location = new System.Drawing.Point(6, 344);
            this.checkBoxSecurity.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxSecurity.Name = "checkBoxSecurity";
            this.checkBoxSecurity.Size = new System.Drawing.Size(486, 68);
            this.checkBoxSecurity.TabIndex = 5;
            this.checkBoxSecurity.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxLogicalNeed
            // 
            this.checkBoxLogicalNeed.CheckBoxText = "LogicalNeed";
            this.checkBoxLogicalNeed.Checked = false;
            this.checkBoxLogicalNeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxLogicalNeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxLogicalNeed.Location = new System.Drawing.Point(6, 428);
            this.checkBoxLogicalNeed.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxLogicalNeed.Name = "checkBoxLogicalNeed";
            this.checkBoxLogicalNeed.Size = new System.Drawing.Size(486, 68);
            this.checkBoxLogicalNeed.TabIndex = 6;
            this.checkBoxLogicalNeed.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel2.Size = new System.Drawing.Size(514, 355);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxHigh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxMedium, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxLow, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 339);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label6.Location = new System.Drawing.Point(8, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(482, 68);
            this.label6.TabIndex = 4;
            this.label6.Text = "Priority";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineBorderPaint);
            // 
            // checkBoxHigh
            // 
            this.checkBoxHigh.CheckBoxText = "High";
            this.checkBoxHigh.Checked = false;
            this.checkBoxHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxHigh.Location = new System.Drawing.Point(6, 92);
            this.checkBoxHigh.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxHigh.Name = "checkBoxHigh";
            this.checkBoxHigh.Size = new System.Drawing.Size(486, 68);
            this.checkBoxHigh.TabIndex = 0;
            this.checkBoxHigh.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxMedium
            // 
            this.checkBoxMedium.CheckBoxText = "Medium";
            this.checkBoxMedium.Checked = false;
            this.checkBoxMedium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxMedium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxMedium.Location = new System.Drawing.Point(6, 176);
            this.checkBoxMedium.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxMedium.Name = "checkBoxMedium";
            this.checkBoxMedium.Size = new System.Drawing.Size(486, 68);
            this.checkBoxMedium.TabIndex = 1;
            this.checkBoxMedium.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxLow
            // 
            this.checkBoxLow.CheckBoxText = "Low";
            this.checkBoxLow.Checked = false;
            this.checkBoxLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxLow.Location = new System.Drawing.Point(6, 260);
            this.checkBoxLow.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.checkBoxLow.Name = "checkBoxLow";
            this.checkBoxLow.Size = new System.Drawing.Size(486, 71);
            this.checkBoxLow.TabIndex = 2;
            this.checkBoxLow.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(514, 71);
            this.label7.TabIndex = 3;
            this.label7.Text = "Filter";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1740, 95);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineBorderPaint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1533, 95);
            this.label1.TabIndex = 4;
            this.label1.Text = "My Issue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.buttonCreateIssue);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1533, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panel4.Size = new System.Drawing.Size(105, 95);
            this.panel4.TabIndex = 7;
            // 
            // buttonCreateIssue
            // 
            this.buttonCreateIssue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCreateIssue.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateIssue.Image")));
            this.buttonCreateIssue.Location = new System.Drawing.Point(15, 15);
            this.buttonCreateIssue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateIssue.Name = "buttonCreateIssue";
            this.buttonCreateIssue.Size = new System.Drawing.Size(75, 65);
            this.buttonCreateIssue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonCreateIssue.TabIndex = 7;
            this.buttonCreateIssue.TabStop = false;
            this.buttonCreateIssue.Click += new System.EventHandler(this.OnClickCreateIssue);
            this.buttonCreateIssue.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.buttonCreateIssue.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.buttonDelete);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1638, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panel6.Size = new System.Drawing.Size(102, 95);
            this.panel6.TabIndex = 8;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.Location = new System.Drawing.Point(15, 15);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(72, 65);
            this.buttonDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Click += new System.EventHandler(this.OnClickDeleteIssue);
            this.buttonDelete.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.buttonDelete.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // UcMyIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panelDatagridviewBase);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcMyIssue";
            this.Size = new System.Drawing.Size(1740, 1234);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDatagridviewBase.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateIssue)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelDatagridviewBase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UserInterface.Issues.CustomCheckBox checkBoxOther;
        private System.Windows.Forms.Label label5;
        private UserInterface.Issues.CustomCheckBox checkBoxBug;
        private UserInterface.Issues.CustomCheckBox checkBoxFeatureRequest;
        private UserInterface.Issues.CustomCheckBox checkBoxOptimization;
        private UserInterface.Issues.CustomCheckBox checkBoxSecurity;
        private UserInterface.Issues.CustomCheckBox checkBoxLogicalNeed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private UserInterface.Issues.CustomCheckBox checkBoxHigh;
        private UserInterface.Issues.CustomCheckBox checkBoxMedium;
        private UserInterface.Issues.CustomCheckBox checkBoxLow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox buttonCreateIssue;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox buttonDelete;
    }
}
