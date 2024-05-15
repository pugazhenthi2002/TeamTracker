namespace UserInterface.Edit_Project.Controls
{
    partial class EditMilestone
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.boardBasePanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NextBtn = new System.Windows.Forms.PictureBox();
            this.BackBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchVersion1 = new UserInterface.Edit_Project.Controls.SearchVersion();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.versionNames = new System.Windows.Forms.Label();
            this.dropDownPicBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1109, 225);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.boardBasePanel);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1089, 205);
            this.panel4.TabIndex = 4;
            // 
            // boardBasePanel
            // 
            this.boardBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardBasePanel.Location = new System.Drawing.Point(0, 40);
            this.boardBasePanel.Name = "boardBasePanel";
            this.boardBasePanel.Padding = new System.Windows.Forms.Padding(5);
            this.boardBasePanel.Size = new System.Drawing.Size(1089, 165);
            this.boardBasePanel.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.NextBtn);
            this.panel5.Controls.Add(this.BackBtn);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel5.Size = new System.Drawing.Size(1089, 40);
            this.panel5.TabIndex = 1;
            // 
            // NextBtn
            // 
            this.NextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.NextBtn.Location = new System.Drawing.Point(200, 0);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(42, 38);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.TabStop = false;
            this.NextBtn.Click += new System.EventHandler(this.OnNextBtnClicked);
            // 
            // BackBtn
            // 
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackBtn.Location = new System.Drawing.Point(158, 0);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(42, 38);
            this.BackBtn.TabIndex = 1;
            this.BackBtn.TabStop = false;
            this.BackBtn.Click += new System.EventHandler(this.OnBackBtnClicked);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Milestone";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchVersion1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(1109, 51);
            this.panel1.TabIndex = 2;
            // 
            // searchVersion1
            // 
            this.searchVersion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(190)))));
            this.searchVersion1.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchVersion1.Location = new System.Drawing.Point(5, 5);
            this.searchVersion1.Name = "searchVersion1";
            this.searchVersion1.Size = new System.Drawing.Size(257, 41);
            this.searchVersion1.TabIndex = 0;
            this.searchVersion1.ProjectNameChange += new System.EventHandler<string>(this.OnProjectNameChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 276);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel3.Size = new System.Drawing.Size(1109, 48);
            this.panel3.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(743, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(2);
            this.panel6.Size = new System.Drawing.Size(366, 46);
            this.panel6.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.versionNames);
            this.panel7.Controls.Add(this.dropDownPicBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(140, 2);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(2);
            this.panel7.Size = new System.Drawing.Size(224, 42);
            this.panel7.TabIndex = 3;
            // 
            // versionNames
            // 
            this.versionNames.BackColor = System.Drawing.Color.Transparent;
            this.versionNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionNames.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.versionNames.Location = new System.Drawing.Point(2, 2);
            this.versionNames.Name = "versionNames";
            this.versionNames.Size = new System.Drawing.Size(198, 38);
            this.versionNames.TabIndex = 3;
            this.versionNames.Text = "On Process Version";
            this.versionNames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dropDownPicBox
            // 
            this.dropDownPicBox.BackColor = System.Drawing.Color.Transparent;
            this.dropDownPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropDownPicBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.dropDownPicBox.Image = global::UserInterface.Properties.Resources.Down_Dark_Blue;
            this.dropDownPicBox.Location = new System.Drawing.Point(200, 2);
            this.dropDownPicBox.Name = "dropDownPicBox";
            this.dropDownPicBox.Size = new System.Drawing.Size(22, 38);
            this.dropDownPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dropDownPicBox.TabIndex = 0;
            this.dropDownPicBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Project";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 324);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(5);
            this.panel8.Size = new System.Drawing.Size(1109, 444);
            this.panel8.TabIndex = 5;
            // 
            // EditMilestone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditMilestone";
            this.Size = new System.Drawing.Size(1109, 768);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dropDownPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel boardBasePanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox NextBtn;
        private System.Windows.Forms.PictureBox BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private SearchVersion searchVersion1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label versionNames;
        private System.Windows.Forms.PictureBox dropDownPicBox;
        private System.Windows.Forms.Panel panel8;
    }
}
