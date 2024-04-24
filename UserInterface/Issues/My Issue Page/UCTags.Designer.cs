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
            this.LabelTag = new System.Windows.Forms.Label();
            this.ClosePicBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.LabelTag, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ClosePicBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(228, 51);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // LabelTag
            // 
            this.LabelTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTag.Location = new System.Drawing.Point(5, 2);
            this.LabelTag.Name = "LabelTag";
            this.LabelTag.Size = new System.Drawing.Size(173, 47);
            this.LabelTag.TabIndex = 0;
            this.LabelTag.Text = "label1";
            this.LabelTag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClosePicBox
            // 
            this.ClosePicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClosePicBox.Image = global::UserInterface.Properties.Resources.Close_Black;
            this.ClosePicBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("ClosePicBox.InitialImage")));
            this.ClosePicBox.Location = new System.Drawing.Point(181, 9);
            this.ClosePicBox.Margin = new System.Windows.Forms.Padding(0, 7, 20, 7);
            this.ClosePicBox.Name = "ClosePicBox";
            this.ClosePicBox.Size = new System.Drawing.Size(25, 33);
            this.ClosePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePicBox.TabIndex = 1;
            this.ClosePicBox.TabStop = false;
            this.ClosePicBox.Click += new System.EventHandler(this.OnClickCloseTag);
            this.ClosePicBox.MouseEnter += new System.EventHandler(this.OnMouseEnterClose);
            this.ClosePicBox.MouseLeave += new System.EventHandler(this.OnMouseLeaveClose);
            // 
            // UCTags
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.Name = "UCTags";
            this.Size = new System.Drawing.Size(228, 51);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label LabelTag;
        private System.Windows.Forms.PictureBox ClosePicBox;
    }
}
