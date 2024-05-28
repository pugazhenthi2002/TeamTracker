namespace TeamTracker
{
    partial class ListViewTemplate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.projectDateLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.upPicBox = new System.Windows.Forms.PictureBox();
            this.downPicBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.singleListControlPanel = new System.Windows.Forms.Panel();
            this.ucNotFound2 = new UserInterface.UcNotFound();
            this.panel8 = new System.Windows.Forms.Panel();
            this.taskTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pieChart2 = new LiveCharts.WinForms.PieChart();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.doneTaskPanel = new System.Windows.Forms.Panel();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panel9 = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPicBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.taskTableLayoutPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2442, 108);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.projectDateLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2442, 108);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // projectDateLabel
            // 
            this.projectDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectDateLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.projectDateLabel.Location = new System.Drawing.Point(15, 70);
            this.projectDateLabel.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.projectDateLabel.Name = "projectDateLabel";
            this.projectDateLabel.Size = new System.Drawing.Size(2423, 38);
            this.projectDateLabel.TabIndex = 1;
            this.projectDateLabel.Text = "Project Date";
            this.projectDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.projectNameLabel);
            this.panel5.Controls.Add(this.tableLayoutPanel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(15, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2423, 70);
            this.panel5.TabIndex = 2;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.projectNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectNameLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.projectNameLabel.Location = new System.Drawing.Point(0, 0);
            this.projectNameLabel.Margin = new System.Windows.Forms.Padding(15, 0, 4, 0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(2371, 70);
            this.projectNameLabel.TabIndex = 2;
            this.projectNameLabel.Text = "Project Name";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.upPicBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.downPicBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2371, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(52, 70);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // upPicBox
            // 
            this.upPicBox.BackColor = System.Drawing.Color.Transparent;
            this.upPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upPicBox.Image = global::UserInterface.Properties.Resources.Up_Medium_Blue;
            this.upPicBox.Location = new System.Drawing.Point(0, 0);
            this.upPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.upPicBox.Name = "upPicBox";
            this.upPicBox.Size = new System.Drawing.Size(52, 35);
            this.upPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upPicBox.TabIndex = 0;
            this.upPicBox.TabStop = false;
            this.upPicBox.Click += new System.EventHandler(this.OnPaginateUp);
            this.upPicBox.MouseEnter += new System.EventHandler(this.OnListPaginateMouseEnter);
            this.upPicBox.MouseLeave += new System.EventHandler(this.OnListPaginateMouseLeave);
            // 
            // downPicBox
            // 
            this.downPicBox.BackColor = System.Drawing.Color.Transparent;
            this.downPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downPicBox.Image = global::UserInterface.Properties.Resources.Down_Medium_Blue;
            this.downPicBox.Location = new System.Drawing.Point(0, 35);
            this.downPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.downPicBox.Name = "downPicBox";
            this.downPicBox.Size = new System.Drawing.Size(52, 35);
            this.downPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.downPicBox.TabIndex = 1;
            this.downPicBox.TabStop = false;
            this.downPicBox.Click += new System.EventHandler(this.OnPaginateDown);
            this.downPicBox.MouseEnter += new System.EventHandler(this.OnListPaginateMouseEnter);
            this.downPicBox.MouseLeave += new System.EventHandler(this.OnListPaginateMouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(2442, 601);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.panel3.Controls.Add(this.singleListControlPanel);
            this.panel3.Controls.Add(this.ucNotFound2);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(15, 15);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2412, 571);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // singleListControlPanel
            // 
            this.singleListControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.singleListControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleListControlPanel.Location = new System.Drawing.Point(0, 77);
            this.singleListControlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.singleListControlPanel.Name = "singleListControlPanel";
            this.singleListControlPanel.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.singleListControlPanel.Size = new System.Drawing.Size(1862, 494);
            this.singleListControlPanel.TabIndex = 9;
            // 
            // ucNotFound2
            // 
            this.ucNotFound2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.ucNotFound2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound2.HeadText = "No Current Task Found !!";
            this.ucNotFound2.HeadTextSize = 16;
            this.ucNotFound2.Location = new System.Drawing.Point(0, 77);
            this.ucNotFound2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucNotFound2.Message = null;
            this.ucNotFound2.Name = "ucNotFound2";
            this.ucNotFound2.Size = new System.Drawing.Size(1862, 494);
            this.ucNotFound2.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.taskTableLayoutPanel);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1862, 77);
            this.panel8.TabIndex = 7;
            // 
            // taskTableLayoutPanel
            // 
            this.taskTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            this.taskTableLayoutPanel.ColumnCount = 6;
            this.taskTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.taskTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.taskTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.taskTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.taskTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.taskTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.taskTableLayoutPanel.Controls.Add(this.label9, 5, 0);
            this.taskTableLayoutPanel.Controls.Add(this.label7, 4, 0);
            this.taskTableLayoutPanel.Controls.Add(this.label6, 3, 0);
            this.taskTableLayoutPanel.Controls.Add(this.label5, 2, 0);
            this.taskTableLayoutPanel.Controls.Add(this.label4, 1, 0);
            this.taskTableLayoutPanel.Controls.Add(this.label3, 0, 0);
            this.taskTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.taskTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.taskTableLayoutPanel.Name = "taskTableLayoutPanel";
            this.taskTableLayoutPanel.RowCount = 1;
            this.taskTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.taskTableLayoutPanel.Size = new System.Drawing.Size(1862, 77);
            this.taskTableLayoutPanel.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(224)))), ((int)(((byte)(239)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1550, 2);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 75);
            this.label9.TabIndex = 6;
            this.label9.Text = "View";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1240, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(310, 75);
            this.label7.TabIndex = 4;
            this.label7.Text = "Priority";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(930, 2);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(310, 75);
            this.label6.TabIndex = 3;
            this.label6.Text = "Due Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(620, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 75);
            this.label5.TabIndex = 2;
            this.label5.Text = "Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label4.Location = new System.Drawing.Point(310, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 75);
            this.label4.TabIndex = 1;
            this.label4.Text = "Assigned By";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 77);
            this.label3.TabIndex = 0;
            this.label3.Text = "Task Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1862, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(550, 571);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(550, 571);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.OnEdgePaint);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pieChart2);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(4, 290);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(542, 276);
            this.panel11.TabIndex = 5;
            // 
            // pieChart2
            // 
            this.pieChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart2.Location = new System.Drawing.Point(0, 57);
            this.pieChart2.Margin = new System.Windows.Forms.Padding(15);
            this.pieChart2.Name = "pieChart2";
            this.pieChart2.Size = new System.Drawing.Size(542, 219);
            this.pieChart2.TabIndex = 3;
            this.pieChart2.Text = "pieChart2";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(542, 57);
            this.label8.TabIndex = 0;
            this.label8.Text = "Overall Priority View";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pieChart1);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(4, 5);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(542, 275);
            this.panel10.TabIndex = 4;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(0, 72);
            this.pieChart1.Margin = new System.Windows.Forms.Padding(15);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(542, 203);
            this.pieChart1.TabIndex = 3;
            this.pieChart1.Text = "pieChart1";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "Overall Status View";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 709);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(15);
            this.panel6.Size = new System.Drawing.Size(2442, 374);
            this.panel6.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.panel7.Controls.Add(this.doneTaskPanel);
            this.panel7.Controls.Add(this.ucNotFound1);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(15, 15);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2412, 344);
            this.panel7.TabIndex = 0;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // doneTaskPanel
            // 
            this.doneTaskPanel.BackColor = System.Drawing.Color.Transparent;
            this.doneTaskPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doneTaskPanel.Location = new System.Drawing.Point(0, 58);
            this.doneTaskPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doneTaskPanel.Name = "doneTaskPanel";
            this.doneTaskPanel.Size = new System.Drawing.Size(2412, 286);
            this.doneTaskPanel.TabIndex = 4;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "Zero Done Tasks";
            this.ucNotFound1.HeadTextSize = 12;
            this.ucNotFound1.Location = new System.Drawing.Point(0, 58);
            this.ucNotFound1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(2412, 286);
            this.ucNotFound1.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.nextBtn);
            this.panel9.Controls.Add(this.backBtn);
            this.panel9.Controls.Add(this.label1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(2412, 58);
            this.panel9.TabIndex = 2;
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextBtn.Image = global::UserInterface.Properties.Resources.Right_Medium_Blue;
            this.nextBtn.Location = new System.Drawing.Point(252, 0);
            this.nextBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(36, 58);
            this.nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextBtn.TabIndex = 2;
            this.nextBtn.TabStop = false;
            this.nextBtn.Click += new System.EventHandler(this.OnDonePaginateNext);
            this.nextBtn.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.nextBtn.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.Image = global::UserInterface.Properties.Resources.Left_Medium_Blue;
            this.backBtn.Location = new System.Drawing.Point(216, 0);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(36, 58);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 1;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.OnDonePaginateBack);
            this.backBtn.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Done Task";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListViewTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ListViewTemplate";
            this.Size = new System.Drawing.Size(2442, 1083);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPicBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.taskTableLayoutPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label projectDateLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox upPicBox;
        private System.Windows.Forms.PictureBox downPicBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel taskTableLayoutPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox nextBtn;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.Label label1;
        private UserInterface.UcNotFound ucNotFound1;
        private System.Windows.Forms.Panel doneTaskPanel;
        private UserInterface.UcNotFound ucNotFound2;
        private System.Windows.Forms.Panel singleListControlPanel;
        private System.Windows.Forms.Panel panel11;
        private LiveCharts.WinForms.PieChart pieChart2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private LiveCharts.WinForms.PieChart pieChart1;
        private System.Windows.Forms.Label label2;
    }
}
