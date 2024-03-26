namespace TeamTracker
{
    partial class TeamLeaderPicAndName
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.teamLeaderName = new System.Windows.Forms.Label();
            this.profilePictureBox2 = new ProfilePictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(327, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.panel1.Controls.Add(this.teamLeaderName);
            this.panel1.Controls.Add(this.profilePictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 54);
            this.panel1.TabIndex = 0;
            // 
            // teamLeaderName
            // 
            this.teamLeaderName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamLeaderName.Font = new System.Drawing.Font("Ebrima", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLeaderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.teamLeaderName.Location = new System.Drawing.Point(54, 0);
            this.teamLeaderName.Name = "teamLeaderName";
            this.teamLeaderName.Size = new System.Drawing.Size(267, 54);
            this.teamLeaderName.TabIndex = 2;
            this.teamLeaderName.Text = "Team Leader Name";
            this.teamLeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.teamLeaderName.Click += new System.EventHandler(this.OnProfileClicked);
            this.teamLeaderName.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.teamLeaderName.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // profilePictureBox2
            // 
            this.profilePictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.profilePictureBox2.Location = new System.Drawing.Point(0, 0);
            this.profilePictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilePictureBox2.Name = "profilePictureBox2";
            this.profilePictureBox2.Size = new System.Drawing.Size(54, 54);
            this.profilePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox2.TabIndex = 3;
            this.profilePictureBox2.TabStop = false;
            this.profilePictureBox2.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.profilePictureBox2.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // TeamLeaderPicAndName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TeamLeaderPicAndName";
            this.Size = new System.Drawing.Size(327, 67);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label teamLeaderName;
        private ProfilePictureBox profilePictureBox2;
    }
}
