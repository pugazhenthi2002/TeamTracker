namespace UserInterface.Issues.All_Issue_Page
{
    partial class FilterPeople
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
            this.label3 = new System.Windows.Forms.Label();
            this.upPicBox = new System.Windows.Forms.PictureBox();
            this.downPicBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.profilePicAndName1 = new TeamTracker.ProfilePicAndName();
            this.deleteFilterPicBox = new System.Windows.Forms.PictureBox();
            this.basePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPicBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteFilterPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.upPicBox);
            this.panel1.Controls.Add(this.downPicBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "People";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upPicBox
            // 
            this.upPicBox.BackColor = System.Drawing.Color.Transparent;
            this.upPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upPicBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.upPicBox.Image = global::UserInterface.Properties.Resources.Up_Dark_Blue;
            this.upPicBox.Location = new System.Drawing.Point(262, 0);
            this.upPicBox.Name = "upPicBox";
            this.upPicBox.Size = new System.Drawing.Size(29, 50);
            this.upPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upPicBox.TabIndex = 7;
            this.upPicBox.TabStop = false;
            this.upPicBox.Click += new System.EventHandler(this.OnUpClicked);
            this.upPicBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.upPicBox.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // downPicBox
            // 
            this.downPicBox.BackColor = System.Drawing.Color.Transparent;
            this.downPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downPicBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.downPicBox.Image = global::UserInterface.Properties.Resources.Down_Dark_Blue;
            this.downPicBox.Location = new System.Drawing.Point(291, 0);
            this.downPicBox.Name = "downPicBox";
            this.downPicBox.Size = new System.Drawing.Size(29, 50);
            this.downPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.downPicBox.TabIndex = 6;
            this.downPicBox.TabStop = false;
            this.downPicBox.Click += new System.EventHandler(this.OnDownClicked);
            this.downPicBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.downPicBox.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 63);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTextBoxBorderPaint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.richTextBox1.Location = new System.Drawing.Point(25, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(269, 27);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.OnEmployeeFilterTextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.profilePicAndName1);
            this.panel2.Controls.Add(this.deleteFilterPicBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 113);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(320, 66);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // profilePicAndName1
            // 
            this.profilePicAndName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.profilePicAndName1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.profilePicAndName1.BorderRadius = 10;
            this.profilePicAndName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePicAndName1.EmployeeProfile = null;
            this.profilePicAndName1.HoverColor = System.Drawing.Color.Empty;
            this.profilePicAndName1.IsBorderNeeded = false;
            this.profilePicAndName1.IsOperable = false;
            this.profilePicAndName1.Location = new System.Drawing.Point(10, 10);
            this.profilePicAndName1.Margin = new System.Windows.Forms.Padding(2);
            this.profilePicAndName1.Name = "profilePicAndName1";
            this.profilePicAndName1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.profilePicAndName1.Padding = new System.Windows.Forms.Padding(3);
            this.profilePicAndName1.ProfileTextColor = System.Drawing.Color.Empty;
            this.profilePicAndName1.Size = new System.Drawing.Size(252, 46);
            this.profilePicAndName1.TabIndex = 1;
            // 
            // deleteFilterPicBox
            // 
            this.deleteFilterPicBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(190)))), ((int)(((byte)(197)))));
            this.deleteFilterPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteFilterPicBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteFilterPicBox.Image = global::UserInterface.Properties.Resources.Close_Dark_Blue;
            this.deleteFilterPicBox.Location = new System.Drawing.Point(262, 10);
            this.deleteFilterPicBox.Name = "deleteFilterPicBox";
            this.deleteFilterPicBox.Size = new System.Drawing.Size(48, 46);
            this.deleteFilterPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.deleteFilterPicBox.TabIndex = 0;
            this.deleteFilterPicBox.TabStop = false;
            this.deleteFilterPicBox.Click += new System.EventHandler(this.OnDeleteClick);
            this.deleteFilterPicBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.deleteFilterPicBox.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // basePanel
            // 
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basePanel.Location = new System.Drawing.Point(0, 179);
            this.basePanel.Name = "basePanel";
            this.basePanel.Padding = new System.Windows.Forms.Padding(10);
            this.basePanel.Size = new System.Drawing.Size(320, 179);
            this.basePanel.TabIndex = 3;
            // 
            // FilterPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FilterPeople";
            this.Size = new System.Drawing.Size(320, 358);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downPicBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deleteFilterPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox upPicBox;
        private System.Windows.Forms.PictureBox downPicBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private TeamTracker.ProfilePicAndName profilePicAndName1;
        private System.Windows.Forms.PictureBox deleteFilterPicBox;
        private System.Windows.Forms.Panel basePanel;
    }
}
