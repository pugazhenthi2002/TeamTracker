namespace UserInterface.ViewPage
{
    partial class ViewPageContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPageContent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timelinePanel = new System.Windows.Forms.TableLayoutPanel();
            this.timelineLabel = new System.Windows.Forms.Label();
            this.timelinePicBox = new System.Windows.Forms.PictureBox();
            this.boardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.boardPicBox = new System.Windows.Forms.PictureBox();
            this.boardLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucTaskBoardBase1 = new TeamTracker.UcTaskBoardBase();
            this.listViewTemplate1 = new TeamTracker.ListViewTemplate();
            this.panel1.SuspendLayout();
            this.timelinePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timelinePicBox)).BeginInit();
            this.boardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timelinePanel);
            this.panel1.Controls.Add(this.boardPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 48);
            this.panel1.TabIndex = 1;
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
            this.timelineLabel.Text = "List";
            this.timelineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timelinePicBox
            // 
            this.timelinePicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelinePicBox.Image = ((System.Drawing.Image)(resources.GetObject("timelinePicBox.Image")));
            this.timelinePicBox.Location = new System.Drawing.Point(3, 3);
            this.timelinePicBox.Name = "timelinePicBox";
            this.timelinePicBox.Size = new System.Drawing.Size(58, 42);
            this.timelinePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.timelinePicBox.TabIndex = 2;
            this.timelinePicBox.TabStop = false;
            // 
            // boardPanel
            // 
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
            this.boardPicBox.Image = global::UserInterface.Properties.Resources.Board_Normal;
            this.boardPicBox.Location = new System.Drawing.Point(3, 3);
            this.boardPicBox.Name = "boardPicBox";
            this.boardPicBox.Size = new System.Drawing.Size(58, 42);
            this.boardPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boardPicBox.TabIndex = 3;
            this.boardPicBox.TabStop = false;
            // 
            // boardLabel
            // 
            this.boardLabel.AutoSize = true;
            this.boardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.boardLabel.Location = new System.Drawing.Point(67, 0);
            this.boardLabel.Name = "boardLabel";
            this.boardLabel.Size = new System.Drawing.Size(144, 48);
            this.boardLabel.TabIndex = 0;
            this.boardLabel.Text = "Board";
            this.boardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tabControl1.Size = new System.Drawing.Size(1388, 721);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.tabPage2.Controls.Add(this.listViewTemplate1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1380, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.tabPage1.Controls.Add(this.ucTaskBoardBase1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1380, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // ucTaskBoardBase1
            // 
            this.ucTaskBoardBase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucTaskBoardBase1.CurrentProjVersion = null;
            this.ucTaskBoardBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskBoardBase1.Location = new System.Drawing.Point(3, 3);
            this.ucTaskBoardBase1.Name = "ucTaskBoardBase1";
            this.ucTaskBoardBase1.Size = new System.Drawing.Size(1374, 706);
            this.ucTaskBoardBase1.TabIndex = 0;
            // 
            // listViewTemplate1
            // 
            this.listViewTemplate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.listViewTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTemplate1.Location = new System.Drawing.Point(3, 3);
            this.listViewTemplate1.Name = "listViewTemplate1";
            this.listViewTemplate1.Size = new System.Drawing.Size(1374, 706);
            this.listViewTemplate1.TabIndex = 0;
            // 
            // ViewPageContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "ViewPageContent";
            this.Size = new System.Drawing.Size(1388, 769);
            this.panel1.ResumeLayout(false);
            this.timelinePanel.ResumeLayout(false);
            this.timelinePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timelinePicBox)).EndInit();
            this.boardPanel.ResumeLayout(false);
            this.boardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private TeamTracker.UcTaskBoardBase ucTaskBoardBase1;
        private TeamTracker.ListViewTemplate listViewTemplate1;
    }
}
