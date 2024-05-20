namespace TeamTracker
{
    partial class AddMilestoneForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMilestoneForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.downPicBox = new System.Windows.Forms.PictureBox();
            this.upPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.milestoneTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.milestoneDateTime = new UserInterface.Add_Project.Custom_Control.CustomDateTime();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.basePanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.downPicBox);
            this.panel2.Controls.Add(this.upPicBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 69);
            this.panel2.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Image = global::UserInterface.Properties.Resources.Close_30;
            this.closeButton.Location = new System.Drawing.Point(834, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(72, 69);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.OnCloseClick);
            this.closeButton.MouseEnter += new System.EventHandler(this.OnCloseMouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            // 
            // downPicBox
            // 
            this.downPicBox.BackColor = System.Drawing.Color.Transparent;
            this.downPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downPicBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.downPicBox.Image = global::UserInterface.Properties.Resources.Down_Medium_Blue;
            this.downPicBox.Location = new System.Drawing.Point(512, 0);
            this.downPicBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.downPicBox.Name = "downPicBox";
            this.downPicBox.Size = new System.Drawing.Size(60, 69);
            this.downPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.downPicBox.TabIndex = 2;
            this.downPicBox.TabStop = false;
            this.downPicBox.Click += new System.EventHandler(this.OnDownClick);
            this.downPicBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.downPicBox.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // upPicBox
            // 
            this.upPicBox.BackColor = System.Drawing.Color.Transparent;
            this.upPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upPicBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.upPicBox.Image = global::UserInterface.Properties.Resources.Up_Medium_Blue;
            this.upPicBox.Location = new System.Drawing.Point(452, 0);
            this.upPicBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upPicBox.Name = "upPicBox";
            this.upPicBox.Size = new System.Drawing.Size(60, 69);
            this.upPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.upPicBox.TabIndex = 1;
            this.upPicBox.TabStop = false;
            this.upPicBox.Click += new System.EventHandler(this.OnUpClick);
            this.upPicBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.upPicBox.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Milestones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 269);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 89);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(906, 180);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(906, 180);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(756, 55);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.addMilestoneButton_Click);
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.OnCurveBorderPaint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(336, 140);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.OnCurveBorderPaint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 66);
            this.label2.TabIndex = 0;
            this.label2.Text = "Milestone Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.milestoneTextBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(15, 75);
            this.panel5.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel5.Size = new System.Drawing.Size(306, 60);
            this.panel5.TabIndex = 1;
            // 
            // milestoneTextBox
            // 
            this.milestoneTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.milestoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.milestoneTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.milestoneTextBox.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milestoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.milestoneTextBox.Location = new System.Drawing.Point(6, 6);
            this.milestoneTextBox.Margin = new System.Windows.Forms.Padding(15, 11, 8, 8);
            this.milestoneTextBox.Multiline = true;
            this.milestoneTextBox.Name = "milestoneTextBox";
            this.milestoneTextBox.Size = new System.Drawing.Size(294, 48);
            this.milestoneTextBox.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.milestoneDateTime, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(396, 20);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(20, 20, 20, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 140);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnCurveBorderPaint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 66);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // milestoneDateTime
            // 
            this.milestoneDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.milestoneDateTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.milestoneDateTime.BorderSize = 2;
            this.milestoneDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.milestoneDateTime.Location = new System.Drawing.Point(42, 87);
            this.milestoneDateTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.milestoneDateTime.MinimumSize = new System.Drawing.Size(4, 35);
            this.milestoneDateTime.Name = "milestoneDateTime";
            this.milestoneDateTime.Size = new System.Drawing.Size(252, 35);
            this.milestoneDateTime.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.milestoneDateTime.TabIndex = 2;
            this.milestoneDateTime.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(832, 55);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.clearAllButton_Click);
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnCurveBorderPaint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(906, 89);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.endDateLabel, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.startDateLabel, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(906, 89);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.OnLineSeperatePaint);
            // 
            // endDateLabel
            // 
            this.endDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.endDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDateLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.endDateLabel.Location = new System.Drawing.Point(457, 44);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(445, 45);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "label7";
            this.endDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startDateLabel
            // 
            this.startDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.startDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDateLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.startDateLabel.Location = new System.Drawing.Point(4, 44);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(445, 45);
            this.startDateLabel.TabIndex = 2;
            this.startDateLabel.Text = "label6";
            this.startDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(457, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(445, 44);
            this.label5.TabIndex = 1;
            this.label5.Text = "Version End Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(445, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Version Start Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.Transparent;
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 338);
            this.basePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.basePanel.Name = "basePanel";
            this.basePanel.Padding = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.basePanel.Size = new System.Drawing.Size(906, 565);
            this.basePanel.TabIndex = 3;
            // 
            // AddMilestoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(906, 903);
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddMilestoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddMilestoneForm";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.PictureBox downPicBox;
        private System.Windows.Forms.PictureBox upPicBox;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox milestoneTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private UserInterface.Add_Project.Custom_Control.CustomDateTime milestoneDateTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}