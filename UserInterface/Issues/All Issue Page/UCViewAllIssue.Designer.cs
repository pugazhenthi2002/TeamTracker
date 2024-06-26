﻿namespace TeamTracker
{
    partial class UCViewAllIssue
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panelDatagridviewBase = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filterPeople1 = new UserInterface.Issues.All_Issue_Page.FilterPeople();
            this.checkBoxOther = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxBug = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxFeatureRequest = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxOptimization = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxSecurity = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxLogicalNeed = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxHigh = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxMedium = new UserInterface.Issues.CustomCheckBox();
            this.checkBoxLow = new UserInterface.Issues.CustomCheckBox();
            this.MainPanel.SuspendLayout();
            this.panelDatagridviewBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panelDatagridviewBase);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1256, 827);
            this.MainPanel.TabIndex = 1;
            // 
            // panelDatagridviewBase
            // 
            this.panelDatagridviewBase.Controls.Add(this.dataGridView1);
            this.panelDatagridviewBase.Controls.Add(this.panel1);
            this.panelDatagridviewBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDatagridviewBase.Location = new System.Drawing.Point(0, 0);
            this.panelDatagridviewBase.Name = "panelDatagridviewBase";
            this.panelDatagridviewBase.Size = new System.Drawing.Size(1256, 827);
            this.panelDatagridviewBase.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView1.Location = new System.Drawing.Point(343, 0);
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
            this.dataGridView1.Size = new System.Drawing.Size(913, 827);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDoubleClickCell);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDownDatagridview);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 827);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.filterPeople1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 673);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(326, 501);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 277);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(326, 396);
            this.panel3.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxOther, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxBug, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxFeatureRequest, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxOptimization, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxSecurity, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxLogicalNeed, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(316, 386);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineBorderPaint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(326, 231);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxHigh, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxMedium, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxLow, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 221);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Priority";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineBorderPaint);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filterPeople1
            // 
            this.filterPeople1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.filterPeople1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPeople1.Location = new System.Drawing.Point(10, 10);
            this.filterPeople1.Name = "filterPeople1";
            this.filterPeople1.Size = new System.Drawing.Size(306, 481);
            this.filterPeople1.TabIndex = 0;
            this.filterPeople1.EmployeeSelect += new System.EventHandler<TeamTracker.Employee>(this.OnEmployeeSelected);
            // 
            // checkBoxOther
            // 
            this.checkBoxOther.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOther.CheckBoxText = "Other";
            this.checkBoxOther.Checked = false;
            this.checkBoxOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxOther.Location = new System.Drawing.Point(3, 333);
            this.checkBoxOther.Name = "checkBoxOther";
            this.checkBoxOther.Size = new System.Drawing.Size(310, 50);
            this.checkBoxOther.TabIndex = 7;
            this.checkBoxOther.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxBug
            // 
            this.checkBoxBug.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxBug.CheckBoxText = "Bug";
            this.checkBoxBug.Checked = false;
            this.checkBoxBug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxBug.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxBug.Location = new System.Drawing.Point(3, 58);
            this.checkBoxBug.Name = "checkBoxBug";
            this.checkBoxBug.Size = new System.Drawing.Size(310, 49);
            this.checkBoxBug.TabIndex = 0;
            this.checkBoxBug.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxFeatureRequest
            // 
            this.checkBoxFeatureRequest.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxFeatureRequest.CheckBoxText = "FeatureRequest";
            this.checkBoxFeatureRequest.Checked = false;
            this.checkBoxFeatureRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxFeatureRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxFeatureRequest.Location = new System.Drawing.Point(3, 113);
            this.checkBoxFeatureRequest.Name = "checkBoxFeatureRequest";
            this.checkBoxFeatureRequest.Size = new System.Drawing.Size(310, 49);
            this.checkBoxFeatureRequest.TabIndex = 1;
            this.checkBoxFeatureRequest.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxOptimization
            // 
            this.checkBoxOptimization.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxOptimization.CheckBoxText = "Optimization";
            this.checkBoxOptimization.Checked = false;
            this.checkBoxOptimization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxOptimization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxOptimization.Location = new System.Drawing.Point(3, 168);
            this.checkBoxOptimization.Name = "checkBoxOptimization";
            this.checkBoxOptimization.Size = new System.Drawing.Size(310, 49);
            this.checkBoxOptimization.TabIndex = 2;
            this.checkBoxOptimization.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxSecurity
            // 
            this.checkBoxSecurity.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSecurity.CheckBoxText = "Security";
            this.checkBoxSecurity.Checked = false;
            this.checkBoxSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxSecurity.Location = new System.Drawing.Point(3, 223);
            this.checkBoxSecurity.Name = "checkBoxSecurity";
            this.checkBoxSecurity.Size = new System.Drawing.Size(310, 49);
            this.checkBoxSecurity.TabIndex = 5;
            this.checkBoxSecurity.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxLogicalNeed
            // 
            this.checkBoxLogicalNeed.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLogicalNeed.CheckBoxText = "LogicalNeed";
            this.checkBoxLogicalNeed.Checked = false;
            this.checkBoxLogicalNeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxLogicalNeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxLogicalNeed.Location = new System.Drawing.Point(3, 278);
            this.checkBoxLogicalNeed.Name = "checkBoxLogicalNeed";
            this.checkBoxLogicalNeed.Size = new System.Drawing.Size(310, 49);
            this.checkBoxLogicalNeed.TabIndex = 6;
            this.checkBoxLogicalNeed.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxHigh
            // 
            this.checkBoxHigh.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxHigh.CheckBoxText = "High";
            this.checkBoxHigh.Checked = false;
            this.checkBoxHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxHigh.Location = new System.Drawing.Point(3, 58);
            this.checkBoxHigh.Name = "checkBoxHigh";
            this.checkBoxHigh.Size = new System.Drawing.Size(310, 49);
            this.checkBoxHigh.TabIndex = 0;
            this.checkBoxHigh.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxMedium
            // 
            this.checkBoxMedium.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMedium.CheckBoxText = "Medium";
            this.checkBoxMedium.Checked = false;
            this.checkBoxMedium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxMedium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxMedium.Location = new System.Drawing.Point(3, 113);
            this.checkBoxMedium.Name = "checkBoxMedium";
            this.checkBoxMedium.Size = new System.Drawing.Size(310, 49);
            this.checkBoxMedium.TabIndex = 1;
            this.checkBoxMedium.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // checkBoxLow
            // 
            this.checkBoxLow.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLow.CheckBoxText = "Low";
            this.checkBoxLow.Checked = false;
            this.checkBoxLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.checkBoxLow.Location = new System.Drawing.Point(3, 168);
            this.checkBoxLow.Name = "checkBoxLow";
            this.checkBoxLow.Size = new System.Drawing.Size(310, 50);
            this.checkBoxLow.TabIndex = 2;
            this.checkBoxLow.CheckBoxValueChanged += new System.EventHandler(this.OnCheckBoxCheckedChanged);
            // 
            // UCViewAllIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCViewAllIssue";
            this.Size = new System.Drawing.Size(1256, 827);
            this.MainPanel.ResumeLayout(false);
            this.panelDatagridviewBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelDatagridviewBase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UserInterface.Issues.CustomCheckBox checkBoxOther;
        private System.Windows.Forms.Label label3;
        private UserInterface.Issues.CustomCheckBox checkBoxBug;
        private UserInterface.Issues.CustomCheckBox checkBoxFeatureRequest;
        private UserInterface.Issues.CustomCheckBox checkBoxOptimization;
        private UserInterface.Issues.CustomCheckBox checkBoxSecurity;
        private UserInterface.Issues.CustomCheckBox checkBoxLogicalNeed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private UserInterface.Issues.CustomCheckBox checkBoxHigh;
        private UserInterface.Issues.CustomCheckBox checkBoxMedium;
        private UserInterface.Issues.CustomCheckBox checkBoxLow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private UserInterface.Issues.All_Issue_Page.FilterPeople filterPeople1;
    }
}
