namespace TeamTracker
{
    partial class UCTags
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTags));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ClosePicBox = new System.Windows.Forms.PictureBox();
            this.LabelTag = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Controls.Add(this.ClosePicBox, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.LabelTag, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(223, 51);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // ClosePicBox
            // 
            this.ClosePicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClosePicBox.Image = global::UserInterface.Properties.Resources.Close_Black;
            this.ClosePicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("ClosePicBox.InitialImage")));
            this.ClosePicBox.Location = new System.Drawing.Point(189, 9);
            this.ClosePicBox.Margin = new System.Windows.Forms.Padding(0);
            this.ClosePicBox.Name = "ClosePicBox";
            this.ClosePicBox.Size = new System.Drawing.Size(25, 33);
            this.ClosePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePicBox.TabIndex = 1;
            this.ClosePicBox.TabStop = false;
            this.ClosePicBox.Click += new System.EventHandler(this.OnClickCloseTag);
            this.ClosePicBox.MouseEnter += new System.EventHandler(this.OnMouseEnterClose);
            this.ClosePicBox.MouseLeave += new System.EventHandler(this.OnMouseLeaveClose);
            // 
            // LabelTag
            // 
            this.LabelTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTag.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LabelTag.Location = new System.Drawing.Point(41, 2);
            this.LabelTag.Name = "LabelTag";
            this.LabelTag.Size = new System.Drawing.Size(139, 47);
            this.LabelTag.TabIndex = 0;
            this.LabelTag.Text = "label1";
            this.LabelTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.tag_black;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UCTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.Name = "UCTags";
            this.Size = new System.Drawing.Size(223, 51);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelTag;
        private System.Windows.Forms.PictureBox ClosePicBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
