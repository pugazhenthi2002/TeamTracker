namespace UserInterface.Home_Page.Project_Manager.Deploy
{
    partial class UcZipFileView
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDownloadZip = new System.Windows.Forms.Label();
            this.pictureBoxZip = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZip)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.labelDownloadZip, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBoxZip, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(333, 57);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // labelDownloadZip
            // 
            this.labelDownloadZip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDownloadZip.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownloadZip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelDownloadZip.Location = new System.Drawing.Point(3, 0);
            this.labelDownloadZip.Name = "labelDownloadZip";
            this.labelDownloadZip.Size = new System.Drawing.Size(160, 57);
            this.labelDownloadZip.TabIndex = 2;
            this.labelDownloadZip.Text = "Download ZIP";
            this.labelDownloadZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelDownloadZip.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.labelDownloadZip.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // pictureBoxZip
            // 
            this.pictureBoxZip.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxZip.Image = global::UserInterface.Properties.Resources.Zip_Black;
            this.pictureBoxZip.Location = new System.Drawing.Point(166, 0);
            this.pictureBoxZip.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxZip.Name = "pictureBoxZip";
            this.pictureBoxZip.Size = new System.Drawing.Size(49, 57);
            this.pictureBoxZip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxZip.TabIndex = 3;
            this.pictureBoxZip.TabStop = false;
            this.pictureBoxZip.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.pictureBoxZip.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // UcZipFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "UcZipFileView";
            this.Size = new System.Drawing.Size(333, 57);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelDownloadZip;
        private System.Windows.Forms.PictureBox pictureBoxZip;
    }
}
