namespace UserInterface.ViewPage
{
    partial class MyTaskTemplate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.TableLayoutPanel();
            this.listLabel = new System.Windows.Forms.Label();
            this.listPicBox = new System.Windows.Forms.PictureBox();
            this.boardPanel = new System.Windows.Forms.TableLayoutPanel();
            this.boardPicBox = new System.Windows.Forms.PictureBox();
            this.boardLabel = new System.Windows.Forms.Label();
            this.ucTaskBoardBase1 = new TeamTracker.UcTaskBoardBase();
            this.listViewTemplate1 = new TeamTracker.ListViewTemplate();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPicBox)).BeginInit();
            this.boardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 572);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1066, 518);
            this.panel3.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 518);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucTaskBoardBase1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewTemplate1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1058, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listPanel);
            this.panel2.Controls.Add(this.boardPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 54);
            this.panel2.TabIndex = 2;
            // 
            // listPanel
            // 
            this.listPanel.ColumnCount = 2;
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.listPanel.Controls.Add(this.listLabel, 1, 0);
            this.listPanel.Controls.Add(this.listPicBox, 0, 0);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listPanel.Location = new System.Drawing.Point(214, 0);
            this.listPanel.Name = "listPanel";
            this.listPanel.RowCount = 1;
            this.listPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listPanel.Size = new System.Drawing.Size(214, 54);
            this.listPanel.TabIndex = 2;
            // 
            // listLabel
            // 
            this.listLabel.AutoSize = true;
            this.listLabel.BackColor = System.Drawing.Color.Transparent;
            this.listLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.listLabel.Location = new System.Drawing.Point(64, 0);
            this.listLabel.Margin = new System.Windows.Forms.Padding(0);
            this.listLabel.Name = "listLabel";
            this.listLabel.Size = new System.Drawing.Size(150, 54);
            this.listLabel.TabIndex = 1;
            this.listLabel.Text = "List";
            this.listLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.listLabel.Click += new System.EventHandler(this.OnListClick);
            // 
            // listPicBox
            // 
            this.listPicBox.BackColor = System.Drawing.Color.Transparent;
            this.listPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPicBox.Image = global::UserInterface.Properties.Resources.List_Normal;
            this.listPicBox.Location = new System.Drawing.Point(0, 0);
            this.listPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.listPicBox.Name = "listPicBox";
            this.listPicBox.Size = new System.Drawing.Size(64, 54);
            this.listPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.listPicBox.TabIndex = 2;
            this.listPicBox.TabStop = false;
            this.listPicBox.Click += new System.EventHandler(this.OnListClick);
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
            this.boardPanel.Size = new System.Drawing.Size(214, 54);
            this.boardPanel.TabIndex = 1;
            // 
            // boardPicBox
            // 
            this.boardPicBox.BackColor = System.Drawing.Color.Transparent;
            this.boardPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boardPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardPicBox.Image = global::UserInterface.Properties.Resources.Board_Click;
            this.boardPicBox.Location = new System.Drawing.Point(0, 0);
            this.boardPicBox.Margin = new System.Windows.Forms.Padding(0);
            this.boardPicBox.Name = "boardPicBox";
            this.boardPicBox.Size = new System.Drawing.Size(64, 54);
            this.boardPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.boardPicBox.TabIndex = 3;
            this.boardPicBox.TabStop = false;
            this.boardPicBox.Click += new System.EventHandler(this.OnBoardClick);
            // 
            // boardLabel
            // 
            this.boardLabel.AutoSize = true;
            this.boardLabel.BackColor = System.Drawing.Color.Transparent;
            this.boardLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.boardLabel.Location = new System.Drawing.Point(64, 0);
            this.boardLabel.Margin = new System.Windows.Forms.Padding(0);
            this.boardLabel.Name = "boardLabel";
            this.boardLabel.Size = new System.Drawing.Size(150, 54);
            this.boardLabel.TabIndex = 0;
            this.boardLabel.Text = "Board";
            this.boardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.boardLabel.Click += new System.EventHandler(this.OnBoardClick);
            // 
            // ucTaskBoardBase1
            // 
            this.ucTaskBoardBase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ucTaskBoardBase1.CurrentProjVersion = null;
            this.ucTaskBoardBase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskBoardBase1.Location = new System.Drawing.Point(3, 3);
            this.ucTaskBoardBase1.Name = "ucTaskBoardBase1";
            this.ucTaskBoardBase1.Size = new System.Drawing.Size(1052, 503);
            this.ucTaskBoardBase1.TabIndex = 0;
            // 
            // listViewTemplate1
            // 
            this.listViewTemplate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.listViewTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTemplate1.Location = new System.Drawing.Point(3, 3);
            this.listViewTemplate1.Name = "listViewTemplate1";
            this.listViewTemplate1.Size = new System.Drawing.Size(1052, 503);
            this.listViewTemplate1.TabIndex = 0;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "No Current Version Available !!";
            this.ucNotFound1.HeadTextSize = 16;
            this.ucNotFound1.Location = new System.Drawing.Point(0, 0);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(1066, 572);
            this.ucNotFound1.TabIndex = 0;
            // 
            // MyTaskTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucNotFound1);
            this.Name = "MyTaskTemplate";
            this.Size = new System.Drawing.Size(1066, 572);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listPicBox)).EndInit();
            this.boardPanel.ResumeLayout(false);
            this.boardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boardPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcNotFound ucNotFound1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel listPanel;
        private System.Windows.Forms.Label listLabel;
        private System.Windows.Forms.PictureBox listPicBox;
        private System.Windows.Forms.TableLayoutPanel boardPanel;
        private System.Windows.Forms.PictureBox boardPicBox;
        private System.Windows.Forms.Label boardLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private TeamTracker.UcTaskBoardBase ucTaskBoardBase1;
        private System.Windows.Forms.TabPage tabPage2;
        private TeamTracker.ListViewTemplate listViewTemplate1;
    }
}
