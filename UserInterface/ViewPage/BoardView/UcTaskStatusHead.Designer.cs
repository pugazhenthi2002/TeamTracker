namespace TeamTracker
{
    partial class UcTaskStatusHead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTaskStatusHead));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanelUpDown = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.labelTaskCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelUpDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.labelStatus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelUpDown, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTaskCount, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 45);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelStatus
            // 
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatus.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(3, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(237, 45);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelUpDown
            // 
            this.tableLayoutPanelUpDown.ColumnCount = 1;
            this.tableLayoutPanelUpDown.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUpDown.Controls.Add(this.pictureBoxUp, 0, 0);
            this.tableLayoutPanelUpDown.Controls.Add(this.pictureBoxDown, 0, 1);
            this.tableLayoutPanelUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUpDown.Location = new System.Drawing.Point(344, 0);
            this.tableLayoutPanelUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelUpDown.Name = "tableLayoutPanelUpDown";
            this.tableLayoutPanelUpDown.RowCount = 2;
            this.tableLayoutPanelUpDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUpDown.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelUpDown.Size = new System.Drawing.Size(61, 45);
            this.tableLayoutPanelUpDown.TabIndex = 1;
            // 
            // pictureBoxUp
            // 
            this.pictureBoxUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxUp.Image = global::UserInterface.Properties.Resources.sort_up;
            this.pictureBoxUp.Location = new System.Drawing.Point(0, 5);
            this.pictureBoxUp.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pictureBoxUp.Name = "pictureBoxUp";
            this.pictureBoxUp.Size = new System.Drawing.Size(61, 17);
            this.pictureBoxUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxUp.TabIndex = 0;
            this.pictureBoxUp.TabStop = false;
            this.pictureBoxUp.Click += new System.EventHandler(this.OnClickBack);
            this.pictureBoxUp.MouseEnter += new System.EventHandler(this.OnMouseEnterArrow);
            this.pictureBoxUp.MouseLeave += new System.EventHandler(this.OnMouseLeaveArrow);
            // 
            // pictureBoxDown
            // 
            this.pictureBoxDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDown.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDown.Image")));
            this.pictureBoxDown.Location = new System.Drawing.Point(0, 22);
            this.pictureBoxDown.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.Size = new System.Drawing.Size(61, 18);
            this.pictureBoxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDown.TabIndex = 0;
            this.pictureBoxDown.TabStop = false;
            this.pictureBoxDown.Click += new System.EventHandler(this.OnClickNext);
            this.pictureBoxDown.MouseEnter += new System.EventHandler(this.OnMouseEnterArrow);
            this.pictureBoxDown.MouseLeave += new System.EventHandler(this.OnMouseLeaveArrow);
            // 
            // labelTaskCount
            // 
            this.labelTaskCount.BackColor = System.Drawing.Color.DarkGray;
            this.labelTaskCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTaskCount.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTaskCount.ForeColor = System.Drawing.Color.White;
            this.labelTaskCount.Location = new System.Drawing.Point(250, 7);
            this.labelTaskCount.Margin = new System.Windows.Forms.Padding(7);
            this.labelTaskCount.Name = "labelTaskCount";
            this.labelTaskCount.Size = new System.Drawing.Size(33, 31);
            this.labelTaskCount.TabIndex = 2;
            this.labelTaskCount.Text = "4";
            this.labelTaskCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTaskCount.Paint += new System.Windows.Forms.PaintEventHandler(this.OnCountLabelBorderPaint);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 10);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // UcTaskStatusHead
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "UcTaskStatusHead";
            this.Size = new System.Drawing.Size(405, 55);
            this.Load += new System.EventHandler(this.OnLoad);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelUpDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUpDown;
        public System.Windows.Forms.PictureBox pictureBoxUp;
        public System.Windows.Forms.PictureBox pictureBoxDown;
        public System.Windows.Forms.Label labelTaskCount;
    }
}
