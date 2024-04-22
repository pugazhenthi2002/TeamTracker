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
            this.filteredUser = new TeamTracker.ProfilePictureBox();
            this.filterPanel = new System.Windows.Forms.TableLayoutPanel();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterPicBox = new System.Windows.Forms.PictureBox();
            this.timelinePanel = new System.Windows.Forms.TableLayoutPanel();
            this.timelineLabel = new System.Windows.Forms.Label();
            this.timelinePicBox = new System.Windows.Forms.PictureBox();
            this.boardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.boardPicBox = new System.Windows.Forms.PictureBox();
            this.boardLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.boardViewContent1 = new UserInterface.ViewProject.BoardView.BoardViewContent();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timelineView1 = new UserInterface.ViewProject.TimelineView.TimelineView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteredUser)).BeginInit();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterPicBox)).BeginInit();
            this.timelinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timelinePicBox)).BeginInit();
            this.boardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.filteredUser);
            this.panel1.Controls.Add(this.filterPanel);
            this.panel1.Controls.Add(this.timelinePanel);
            this.panel1.Controls.Add(this.boardPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1115, 48);
            this.panel1.TabIndex = 0;
            // 
            // filteredUser
            // 
            this.filteredUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filteredUser.Location = new System.Drawing.Point(642, 0);
            this.filteredUser.Name = "filteredUser";
            this.filteredUser.ParentColor = System.Drawing.Color.Empty;
            this.filteredUser.Size = new System.Drawing.Size(48, 48);
            this.filteredUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filteredUser.TabIndex = 3;
            this.filteredUser.TabStop = false;
            // 
            // filterPanel
            // 
            this.filterPanel.ColumnCount = 2;
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.filterPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.filterPanel.Controls.Add(this.filterLabel, 1, 0);
            this.filterPanel.Controls.Add(this.filterPicBox, 0, 0);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterPanel.Location = new System.Drawing.Point(428, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.RowCount = 1;
            this.filterPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filterPanel.Size = new System.Drawing.Size(214, 48);
            this.filterPanel.TabIndex = 2;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.filterLabel.Location = new System.Drawing.Point(67, 0);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(144, 48);
            this.filterLabel.TabIndex = 1;
            this.filterLabel.Text = "Filter";
            this.filterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterLabel.Click += new System.EventHandler(this.OnFilterClicked);
            // 
            // filterPicBox
            // 
            this.filterPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPicBox.Image = global::UserInterface.Properties.Resources.Filter_Normal;
            this.filterPicBox.Location = new System.Drawing.Point(3, 3);
            this.filterPicBox.Name = "filterPicBox";
            this.filterPicBox.Size = new System.Drawing.Size(58, 42);
            this.filterPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.filterPicBox.TabIndex = 2;
            this.filterPicBox.TabStop = false;
            this.filterPicBox.Click += new System.EventHandler(this.OnFilterClicked);
            // 
            // timelinePanel
            // 
            this.timelinePanel.ColumnCount = 2;
            this.timelinePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.timelinePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.timelinePanel.Controls.Add(this.timelineLabel, 1, 0);
            this.timelinePanel.Controls.Add(this.timelinePicBox, 0, 0);
            this.timelinePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.timelinePanel.Location = new System.Drawing.Point(214, 0);
            this.timelinePanel.Name = "timelinePanel";
            this.timelinePanel.RowCount = 1;
            this.timelinePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timelinePanel.Size = new System.Drawing.Size(214, 48);
            this.timelinePanel.TabIndex = 1;
            // 
            // timelineLabel
            // 
            this.timelineLabel.AutoSize = true;
            this.timelineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelineLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.timelineLabel.Location = new System.Drawing.Point(67, 0);
            this.timelineLabel.Name = "timelineLabel";
            this.timelineLabel.Size = new System.Drawing.Size(144, 48);
            this.timelineLabel.TabIndex = 1;
            this.timelineLabel.Text = "Timeline";
            this.timelineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timelineLabel.Click += new System.EventHandler(this.OnTimelineClicked);
            // 
            // timelinePicBox
            // 
            this.timelinePicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelinePicBox.Image = global::UserInterface.Properties.Resources.Timeline_Normal;
            this.timelinePicBox.Location = new System.Drawing.Point(3, 3);
            this.timelinePicBox.Name = "timelinePicBox";
            this.timelinePicBox.Size = new System.Drawing.Size(58, 42);
            this.timelinePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timelinePicBox.TabIndex = 2;
            this.timelinePicBox.TabStop = false;
            this.timelinePicBox.Click += new System.EventHandler(this.OnTimelineClicked);
            // 
            // boardPanel
            // 
            this.boardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.boardPanel.ColumnCount = 2;
            this.boardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.boardPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.boardPanel.Controls.Add(this.boardPicBox, 0, 0);
            this.boardPanel.Controls.Add(this.boardLabel, 1, 0);
            this.boardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.boardPanel.Location = new System.Drawing.Point(0, 0);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.RowCount = 1;
            this.boardPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.boardPanel.Size = new System.Drawing.Size(214, 48);
            this.boardPanel.TabIndex = 0;
            // 
            // boardPicBox
            // 
            this.boardPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardPicBox.Image = global::UserInterface.Properties.Resources.Board_Click;
            this.boardPicBox.Location = new System.Drawing.Point(3, 3);
            this.boardPicBox.Name = "boardPicBox";
            this.boardPicBox.Size = new System.Drawing.Size(58, 42);
            this.boardPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boardPicBox.TabIndex = 3;
            this.boardPicBox.TabStop = false;
            this.boardPicBox.Click += new System.EventHandler(this.OnBoardClicked);
            // 
            // boardLabel
            // 
            this.boardLabel.AutoSize = true;
            this.boardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.boardLabel.Location = new System.Drawing.Point(67, 0);
            this.boardLabel.Name = "boardLabel";
            this.boardLabel.Size = new System.Drawing.Size(144, 48);
            this.boardLabel.TabIndex = 0;
            this.boardLabel.Text = "Board";
            this.boardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boardLabel.Click += new System.EventHandler(this.OnBoardClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1115, 373);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.boardViewContent1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1107, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // boardViewContent1
            // 
            this.boardViewContent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.boardViewContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardViewContent1.Location = new System.Drawing.Point(3, 3);
            this.boardViewContent1.Margin = new System.Windows.Forms.Padding(2);
            this.boardViewContent1.Name = "boardViewContent1";
            this.boardViewContent1.Size = new System.Drawing.Size(1101, 358);
            this.boardViewContent1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.timelineView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timelineView1
            // 
            this.timelineView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.timelineView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelineView1.Location = new System.Drawing.Point(3, 3);
            this.timelineView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timelineView1.Name = "timelineView1";
            this.timelineView1.Size = new System.Drawing.Size(1101, 358);
            this.timelineView1.TabIndex = 0;
            // 
            // ViewProjectTemplate
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewProjectTemplate";
            this.Size = new System.Drawing.Size(1115, 421);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filteredUser)).EndInit();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterPicBox)).EndInit();
            this.timelinePanel.ResumeLayout(false);
            this.timelinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timelinePicBox)).EndInit();
            this.boardPanel.ResumeLayout(false);
            this.boardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel timelinePanel;
        private System.Windows.Forms.Label timelineLabel;
        private System.Windows.Forms.PictureBox timelinePicBox;
        private System.Windows.Forms.TableLayoutPanel boardPanel;
        private System.Windows.Forms.PictureBox boardPicBox;
        private System.Windows.Forms.Label boardLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private TimelineView.TimelineView timelineView1;
        private System.Windows.Forms.TableLayoutPanel filterPanel;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.PictureBox filterPicBox;
        private BoardView.BoardViewContent boardViewContent1;
        private TeamTracker.ProfilePictureBox filteredUser;
    }
}
