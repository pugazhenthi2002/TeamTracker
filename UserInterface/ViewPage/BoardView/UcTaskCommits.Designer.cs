namespace TeamTracker
{
    partial class UcTaskCommits
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCommitName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.EmpProfilePictureBox = new TeamTracker.ProfilePictureBox();
            this.pictureBoxDownload = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpProfilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownload)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxDownload, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelCommitName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 48);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // labelCommitName
            // 
            this.labelCommitName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCommitName.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommitName.ForeColor = System.Drawing.Color.White;
            this.labelCommitName.Location = new System.Drawing.Point(110, 0);
            this.labelCommitName.Margin = new System.Windows.Forms.Padding(110, 0, 0, 0);
            this.labelCommitName.Name = "labelCommitName";
            this.labelCommitName.Size = new System.Drawing.Size(124, 24);
            this.labelCommitName.TabIndex = 4;
            this.labelCommitName.Text = "commit Name";
            this.labelCommitName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.labelEmpName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.EmpProfilePictureBox, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(228, 18);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // labelEmpName
            // 
            this.labelEmpName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEmpName.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpName.ForeColor = System.Drawing.Color.White;
            this.labelEmpName.Location = new System.Drawing.Point(57, 0);
            this.labelEmpName.Margin = new System.Windows.Forms.Padding(0);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(171, 18);
            this.labelEmpName.TabIndex = 5;
            this.labelEmpName.Text = "Emp Name";
            this.labelEmpName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EmpProfilePictureBox
            // 
            this.EmpProfilePictureBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.EmpProfilePictureBox.Location = new System.Drawing.Point(39, 0);
            this.EmpProfilePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.EmpProfilePictureBox.Name = "EmpProfilePictureBox";
            this.EmpProfilePictureBox.ParentColor = System.Drawing.Color.Empty;
            this.EmpProfilePictureBox.Size = new System.Drawing.Size(18, 18);
            this.EmpProfilePictureBox.TabIndex = 0;
            this.EmpProfilePictureBox.TabStop = false;
            // 
            // pictureBoxDownload
            // 
            this.pictureBoxDownload.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDownload.Image = global::UserInterface.Properties.Resources.Download_Dark_Blue;
            this.pictureBoxDownload.Location = new System.Drawing.Point(246, 12);
            this.pictureBoxDownload.Margin = new System.Windows.Forms.Padding(12);
            this.pictureBoxDownload.Name = "pictureBoxDownload";
            this.pictureBoxDownload.Size = new System.Drawing.Size(55, 24);
            this.pictureBoxDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDownload.TabIndex = 3;
            this.pictureBoxDownload.TabStop = false;
            this.pictureBoxDownload.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickDownloadSourceCode);
            this.pictureBoxDownload.MouseEnter += new System.EventHandler(this.OnMouseEnterDownloadPicBox);
            this.pictureBoxDownload.MouseLeave += new System.EventHandler(this.OnMouseLeaveDownloadPicBox);
            // 
            // UcTaskCommits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcTaskCommits";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Size = new System.Drawing.Size(315, 50);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmpProfilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDownload)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxDownload;
        private System.Windows.Forms.Label labelCommitName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelEmpName;
        private ProfilePictureBox EmpProfilePictureBox;
    }
}
