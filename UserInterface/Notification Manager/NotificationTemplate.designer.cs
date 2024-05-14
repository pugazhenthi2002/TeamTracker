namespace TeamTracker
{
    partial class NotificationTemplate
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
            this.timePanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.seeMorePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timePanel
            // 
            this.timePanel.BackColor = System.Drawing.Color.Transparent;
            this.timePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timePanel.Location = new System.Drawing.Point(0, 151);
            this.timePanel.Name = "timePanel";
            this.timePanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.timePanel.Size = new System.Drawing.Size(400, 24);
            this.timePanel.TabIndex = 3;
            this.timePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnTimePanelPaint);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 34);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.contentPanel.Size = new System.Drawing.Size(400, 104);
            this.contentPanel.TabIndex = 4;
            this.contentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnContentPanelPaint);
            // 
            // seeMorePanel
            // 
            this.seeMorePanel.BackColor = System.Drawing.Color.Transparent;
            this.seeMorePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.seeMorePanel.Location = new System.Drawing.Point(0, 138);
            this.seeMorePanel.Name = "seeMorePanel";
            this.seeMorePanel.Size = new System.Drawing.Size(400, 13);
            this.seeMorePanel.TabIndex = 5;
            this.seeMorePanel.Click += new System.EventHandler(this.OnFullContentViewed);
            this.seeMorePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SeeMorePanel_Paint);
            this.seeMorePanel.MouseEnter += new System.EventHandler(this.OnSeeMorePanelEnter);
            this.seeMorePanel.MouseLeave += new System.EventHandler(this.OnSeeMorePanelLeave);
            this.seeMorePanel.MouseHover += new System.EventHandler(this.OnSeeMorePanelHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.headerPanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 34);
            this.panel1.TabIndex = 6;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.headerPanel.Size = new System.Drawing.Size(361, 34);
            this.headerPanel.TabIndex = 3;
            this.headerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnHeaderPanelPaint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::UserInterface.Properties.Resources.Close_30;
            this.pictureBox1.Location = new System.Drawing.Point(361, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.OnNotificationClosed);
            // 
            // NotificationTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(400, 175);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.seeMorePanel);
            this.Controls.Add(this.timePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NotificationTemplate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFadeClose_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NotificationTemplate_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            this.Resize += new System.EventHandler(this.OnNotifyResize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel seeMorePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}