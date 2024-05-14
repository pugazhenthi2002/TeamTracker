namespace UserInterface.ViewProject.BoardView.Custom_Controls
{
    partial class StatusViewTemplate
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.downPicBox = new System.Windows.Forms.PictureBox();
            this.upPicBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boardBasePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.downPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 54);
            this.panel1.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(0, 18);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(214, 36);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status Of Project";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(214, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(27, 36);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.downPicBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.upPicBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(27, 36);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // downPicBox
            // 
            this.downPicBox.BackColor = System.Drawing.Color.Transparent;
            this.downPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downPicBox.Image = global::UserInterface.Properties.Resources.Down_Medium_Blue;
            this.downPicBox.Location = new System.Drawing.Point(0, 18);
            this.downPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.downPicBox.Name = "downPicBox";
            this.downPicBox.Size = new System.Drawing.Size(27, 18);
            this.downPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.downPicBox.TabIndex = 1;
            this.downPicBox.TabStop = false;
            this.downPicBox.Click += new System.EventHandler(this.OnPaginateDown);
            this.downPicBox.MouseEnter += new System.EventHandler(this.OnNavMouseEnter);
            this.downPicBox.MouseLeave += new System.EventHandler(this.OnNavMouseLeave);
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
            this.upPicBox.Size = new System.Drawing.Size(27, 18);
            this.upPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.upPicBox.TabIndex = 0;
            this.upPicBox.TabStop = false;
            this.upPicBox.Click += new System.EventHandler(this.OnPaginateUp);
            this.upPicBox.MouseEnter += new System.EventHandler(this.OnNavMouseEnter);
            this.upPicBox.MouseLeave += new System.EventHandler(this.OnNavMouseLeave);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 18);
            this.panel2.TabIndex = 0;
            // 
            // boardBasePanel
            // 
            this.boardBasePanel.BackColor = System.Drawing.Color.Transparent;
            this.boardBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardBasePanel.Location = new System.Drawing.Point(0, 54);
            this.boardBasePanel.Margin = new System.Windows.Forms.Padding(2);
            this.boardBasePanel.Name = "boardBasePanel";
            this.boardBasePanel.Size = new System.Drawing.Size(241, 440);
            this.boardBasePanel.TabIndex = 1;
            // 
            // StatusViewTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boardBasePanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StatusViewTemplate";
            this.Size = new System.Drawing.Size(241, 494);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.downPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox downPicBox;
        private System.Windows.Forms.PictureBox upPicBox;
        private System.Windows.Forms.Panel boardBasePanel;
    }
}
