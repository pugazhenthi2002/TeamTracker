namespace UserInterface.Issues.My_Issue_Page
{
    partial class ViewSolutionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalSolutionCOuntLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nextPicBox = new System.Windows.Forms.PictureBox();
            this.backPicBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.solutionTemplate1 = new UserInterface.Issues.My_Issue_Page.SolutionTemplate();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicBox)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(860, 56);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.close_Hover;
            this.pictureBox1.Location = new System.Drawing.Point(801, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnCloseClick);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(286, 53);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Issue Name";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.panel2.Controls.Add(this.totalSolutionCOuntLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.DarkGray;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel2.Size = new System.Drawing.Size(860, 28);
            this.panel2.TabIndex = 3;
            // 
            // totalSolutionCOuntLabel
            // 
            this.totalSolutionCOuntLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalSolutionCOuntLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSolutionCOuntLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.totalSolutionCOuntLabel.Location = new System.Drawing.Point(0, 0);
            this.totalSolutionCOuntLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.totalSolutionCOuntLabel.Name = "totalSolutionCOuntLabel";
            this.totalSolutionCOuntLabel.Size = new System.Drawing.Size(286, 25);
            this.totalSolutionCOuntLabel.TabIndex = 4;
            this.totalSolutionCOuntLabel.Text = "Total Solution";
            this.totalSolutionCOuntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.nextPicBox);
            this.panel3.Controls.Add(this.backPicBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(860, 36);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(30, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 36);
            this.panel4.TabIndex = 2;
            // 
            // nextPicBox
            // 
            this.nextPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPicBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextPicBox.Image = global::UserInterface.Properties.Resources.Right_Light_Blue;
            this.nextPicBox.Location = new System.Drawing.Point(830, 0);
            this.nextPicBox.Name = "nextPicBox";
            this.nextPicBox.Size = new System.Drawing.Size(30, 36);
            this.nextPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nextPicBox.TabIndex = 1;
            this.nextPicBox.TabStop = false;
            this.nextPicBox.Click += new System.EventHandler(this.OnNextClicked);
            this.nextPicBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.nextPicBox.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // backPicBox
            // 
            this.backPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPicBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.backPicBox.Image = global::UserInterface.Properties.Resources.Left_Light_Blue;
            this.backPicBox.Location = new System.Drawing.Point(0, 0);
            this.backPicBox.Name = "backPicBox";
            this.backPicBox.Size = new System.Drawing.Size(30, 36);
            this.backPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backPicBox.TabIndex = 0;
            this.backPicBox.TabStop = false;
            this.backPicBox.Click += new System.EventHandler(this.OnBackClick);
            this.backPicBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.backPicBox.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.solutionTemplate1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 120);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20);
            this.panel5.Size = new System.Drawing.Size(860, 386);
            this.panel5.TabIndex = 5;
            // 
            // solutionTemplate1
            // 
            this.solutionTemplate1.AutoScroll = true;
            this.solutionTemplate1.BackColor = System.Drawing.Color.Transparent;
            this.solutionTemplate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.solutionTemplate1.Location = new System.Drawing.Point(20, 20);
            this.solutionTemplate1.Name = "solutionTemplate1";
            this.solutionTemplate1.Size = new System.Drawing.Size(820, 350);
            this.solutionTemplate1.TabIndex = 0;
            // 
            // ViewSolutionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(860, 506);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewSolutionForm";
            this.Text = "ViewSolutionForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicBox)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label totalSolutionCOuntLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox nextPicBox;
        private System.Windows.Forms.PictureBox backPicBox;
        private System.Windows.Forms.Panel panel5;
        private SolutionTemplate solutionTemplate1;
    }
}