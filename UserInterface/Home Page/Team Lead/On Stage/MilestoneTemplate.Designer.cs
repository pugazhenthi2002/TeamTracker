namespace UserInterface.Home_Page.Team_Lead.On_Stage
{
    partial class MilestoneTemplate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.downButton = new System.Windows.Forms.PictureBox();
            this.counterLabel = new System.Windows.Forms.Label();
            this.milestoneDate = new UserInterface.Add_Project.Custom_Control.CustomDateTime();
            this.upButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.milestoneName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(569, 46);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.closeButton, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.downButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.counterLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.milestoneDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.upButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(565, 42);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.Image = global::UserInterface.Properties.Resources.Close_30;
            this.closeButton.Location = new System.Drawing.Point(515, 1);
            this.closeButton.Margin = new System.Windows.Forms.Padding(1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(49, 40);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeButton.TabIndex = 5;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.OnDelete);
            this.closeButton.MouseEnter += new System.EventHandler(this.OnCloseMouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            // 
            // downButton
            // 
            this.downButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downButton.Image = global::UserInterface.Properties.Resources.Down_Light_Blue;
            this.downButton.Location = new System.Drawing.Point(480, 1);
            this.downButton.Margin = new System.Windows.Forms.Padding(1);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(33, 40);
            this.downButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.downButton.TabIndex = 4;
            this.downButton.TabStop = false;
            this.downButton.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.downButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // counterLabel
            // 
            this.counterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.counterLabel.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.Location = new System.Drawing.Point(3, 0);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(29, 42);
            this.counterLabel.TabIndex = 0;
            this.counterLabel.Text = "1";
            this.counterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.counterLabel.Click += new System.EventHandler(this.OnClicked);
            // 
            // milestoneDate
            // 
            this.milestoneDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.milestoneDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.milestoneDate.BorderSize = 0;
            this.milestoneDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.milestoneDate.Location = new System.Drawing.Point(304, 3);
            this.milestoneDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.milestoneDate.Name = "milestoneDate";
            this.milestoneDate.Size = new System.Drawing.Size(137, 35);
            this.milestoneDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.milestoneDate.TabIndex = 2;
            this.milestoneDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            // 
            // upButton
            // 
            this.upButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upButton.Image = global::UserInterface.Properties.Resources.Up_Light_Blue;
            this.upButton.Location = new System.Drawing.Point(445, 1);
            this.upButton.Margin = new System.Windows.Forms.Padding(1);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(33, 40);
            this.upButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.upButton.TabIndex = 3;
            this.upButton.TabStop = false;
            this.upButton.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.upButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.milestoneName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(37, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Size = new System.Drawing.Size(262, 38);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // milestoneName
            // 
            this.milestoneName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.milestoneName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.milestoneName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.milestoneName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milestoneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.milestoneName.Location = new System.Drawing.Point(7, 6);
            this.milestoneName.Multiline = true;
            this.milestoneName.Name = "milestoneName";
            this.milestoneName.Size = new System.Drawing.Size(248, 26);
            this.milestoneName.TabIndex = 2;
            this.milestoneName.Text = "Hello";
            // 
            // MilestoneTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "MilestoneTemplate";
            this.Size = new System.Drawing.Size(569, 46);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox downButton;
        private Add_Project.Custom_Control.CustomDateTime milestoneDate;
        private System.Windows.Forms.PictureBox upButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox milestoneName;
    }
}
