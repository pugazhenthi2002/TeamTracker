namespace UserInterface.Add_Project.Custom_Control
{
    partial class ChooseProjectForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelButton = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.downPicBox = new System.Windows.Forms.PictureBox();
            this.upPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPicBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 691);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 75);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 225F));
            this.tableLayoutPanel1.Controls.Add(this.cancelButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(771, 75);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.cancelButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.cancelButton.Location = new System.Drawing.Point(569, 12);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(178, 51);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelButton.Click += new System.EventHandler(this.OnCancelClick);
            this.cancelButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.cancelButton.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.cancelButton.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // selectButton
            // 
            this.selectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.selectButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.selectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.selectButton.Location = new System.Drawing.Point(364, 12);
            this.selectButton.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(178, 51);
            this.selectButton.TabIndex = 0;
            this.selectButton.Text = "Select";
            this.selectButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectButton.Click += new System.EventHandler(this.OnSelectClick);
            this.selectButton.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.selectButton.MouseEnter += new System.EventHandler(this.OnButtonMouseEnter);
            this.selectButton.MouseLeave += new System.EventHandler(this.OnButtonMouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 72);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.downPicBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.upPicBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(270, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(72, 72);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // downPicBox
            // 
            this.downPicBox.BackColor = System.Drawing.Color.Transparent;
            this.downPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downPicBox.Image = global::UserInterface.Properties.Resources.Down_Medium_Blue;
            this.downPicBox.Location = new System.Drawing.Point(0, 36);
            this.downPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.downPicBox.Name = "downPicBox";
            this.downPicBox.Size = new System.Drawing.Size(72, 36);
            this.downPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.downPicBox.TabIndex = 1;
            this.downPicBox.TabStop = false;
            this.downPicBox.Click += new System.EventHandler(this.OnPaginateDownClick);
            this.downPicBox.MouseEnter += new System.EventHandler(this.OnPaginateMouseEnter);
            this.downPicBox.MouseLeave += new System.EventHandler(this.OnPaginateMouseLeave);
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
            this.upPicBox.Size = new System.Drawing.Size(72, 36);
            this.upPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upPicBox.TabIndex = 0;
            this.upPicBox.TabStop = false;
            this.upPicBox.Click += new System.EventHandler(this.OnPaginateUpClick);
            this.upPicBox.MouseEnter += new System.EventHandler(this.OnPaginateMouseEnter);
            this.upPicBox.MouseLeave += new System.EventHandler(this.OnPaginateMouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Projects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.controlPanel);
            this.panel3.Controls.Add(this.ucNotFound1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 619);
            this.panel3.TabIndex = 2;
            // 
            // controlPanel
            // 
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(771, 619);
            this.controlPanel.TabIndex = 3;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "No Projects Available !!";
            this.ucNotFound1.HeadTextSize = 14;
            this.ucNotFound1.Location = new System.Drawing.Point(0, 0);
            this.ucNotFound1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.ucNotFound1.Message = "All Projects are already in Version Upgrade";
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(771, 619);
            this.ucNotFound1.TabIndex = 2;
            // 
            // ChooseProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(771, 766);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChooseProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChooseProjectForm";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPicBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox downPicBox;
        private System.Windows.Forms.PictureBox upPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel controlPanel;
        private UcNotFound ucNotFound1;
        private System.Windows.Forms.Label selectButton;
        private System.Windows.Forms.Label cancelButton;
    }
}