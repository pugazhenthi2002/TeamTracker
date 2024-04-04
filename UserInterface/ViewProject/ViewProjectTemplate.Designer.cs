namespace UserInterface.ViewProject
{
    partial class ViewProjectTemplate
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timelinePanel = new System.Windows.Forms.TableLayoutPanel();
            this.timelineLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.boardLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.boardViewContent1 = new UserInterface.ViewProject.BoardView.BoardViewContent();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timelineView1 = new UserInterface.ViewProject.TimelineView.TimelineView();
            this.profilePictureBox1 = new TeamTracker.ProfilePictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timelinePicBox = new System.Windows.Forms.PictureBox();
            this.boardPicBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.timelinePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.boardPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timelinePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.profilePictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 45);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(334, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 45);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(167, 45);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(53, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.OnFilterClicked);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.timelinePanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(167, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 45);
            this.panel3.TabIndex = 1;
            // 
            // timelinePanel
            // 
            this.timelinePanel.ColumnCount = 2;
            this.timelinePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.timelinePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.timelinePanel.Controls.Add(this.timelineLabel, 1, 0);
            this.timelinePanel.Controls.Add(this.timelinePicBox, 0, 0);
            this.timelinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelinePanel.Location = new System.Drawing.Point(0, 0);
            this.timelinePanel.Name = "timelinePanel";
            this.timelinePanel.RowCount = 1;
            this.timelinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timelinePanel.Size = new System.Drawing.Size(167, 45);
            this.timelinePanel.TabIndex = 1;
            // 
            // timelineLabel
            // 
            this.timelineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelineLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.timelineLabel.Location = new System.Drawing.Point(53, 0);
            this.timelineLabel.Name = "timelineLabel";
            this.timelineLabel.Size = new System.Drawing.Size(111, 45);
            this.timelineLabel.TabIndex = 3;
            this.timelineLabel.Text = "Timeline";
            this.timelineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timelineLabel.Click += new System.EventHandler(this.OnTimelineClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.boardPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 45);
            this.panel2.TabIndex = 0;
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.boardPanel.ColumnCount = 2;
            this.boardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.boardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.boardPanel.Controls.Add(this.boardPicBox, 0, 0);
            this.boardPanel.Controls.Add(this.boardLabel, 1, 0);
            this.boardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardPanel.Location = new System.Drawing.Point(0, 0);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.RowCount = 1;
            this.boardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.boardPanel.Size = new System.Drawing.Size(167, 45);
            this.boardPanel.TabIndex = 0;
            // 
            // boardLabel
            // 
            this.boardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.boardLabel.Location = new System.Drawing.Point(53, 0);
            this.boardLabel.Name = "boardLabel";
            this.boardLabel.Size = new System.Drawing.Size(111, 45);
            this.boardLabel.TabIndex = 2;
            this.boardLabel.Text = "Board";
            this.boardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boardLabel.Click += new System.EventHandler(this.OnBoardClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 515);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.tabPage1.Controls.Add(this.boardViewContent1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1240, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // boardViewContent1
            // 
            this.boardViewContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardViewContent1.Location = new System.Drawing.Point(3, 3);
            this.boardViewContent1.Margin = new System.Windows.Forms.Padding(2);
            this.boardViewContent1.Name = "boardViewContent1";
            this.boardViewContent1.Size = new System.Drawing.Size(1234, 500);
            this.boardViewContent1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.timelineView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timelineView1
            // 
            this.timelineView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.timelineView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelineView1.Location = new System.Drawing.Point(3, 3);
            this.timelineView1.Name = "timelineView1";
            this.timelineView1.Size = new System.Drawing.Size(1234, 500);
            this.timelineView1.TabIndex = 0;
            // 
            // profilePictureBox1
            // 
            this.profilePictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.profilePictureBox1.Location = new System.Drawing.Point(501, 0);
            this.profilePictureBox1.Name = "profilePictureBox1";
            this.profilePictureBox1.Size = new System.Drawing.Size(45, 45);
            this.profilePictureBox1.TabIndex = 3;
            this.profilePictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::UserInterface.Properties.Resources.Filter_Normal;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.OnFilterClicked);
            // 
            // timelinePicBox
            // 
            this.timelinePicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timelinePicBox.Image = global::UserInterface.Properties.Resources.Timeline_Normal;
            this.timelinePicBox.Location = new System.Drawing.Point(3, 3);
            this.timelinePicBox.Name = "timelinePicBox";
            this.timelinePicBox.Size = new System.Drawing.Size(44, 39);
            this.timelinePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timelinePicBox.TabIndex = 1;
            this.timelinePicBox.TabStop = false;
            this.timelinePicBox.Click += new System.EventHandler(this.OnTimelineClicked);
            // 
            // boardPicBox
            // 
            this.boardPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boardPicBox.Image = global::UserInterface.Properties.Resources.Board_Normal;
            this.boardPicBox.Location = new System.Drawing.Point(3, 3);
            this.boardPicBox.Name = "boardPicBox";
            this.boardPicBox.Size = new System.Drawing.Size(44, 39);
            this.boardPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boardPicBox.TabIndex = 0;
            this.boardPicBox.TabStop = false;
            this.boardPicBox.Click += new System.EventHandler(this.OnBoardClicked);
            // 
            // ViewProjectTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewProjectTemplate";
            this.Size = new System.Drawing.Size(1248, 560);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.timelinePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.boardPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timelinePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel timelinePanel;
        private System.Windows.Forms.PictureBox timelinePicBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel boardPanel;
        private System.Windows.Forms.PictureBox boardPicBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timelineLabel;
        private System.Windows.Forms.Label boardLabel;
        private TeamTracker.ProfilePictureBox profilePictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private TimelineView.TimelineView timelineView1;
        private BoardView.BoardViewContent boardViewContent1;
    }
}
