namespace TeamTracker
{
    partial class FullContentViewForm
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
            this.fullContentTitleBarPanel = new System.Windows.Forms.Panel();
            this.fullContentMessagePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton1 = new CloseButton();
            this.panel1.SuspendLayout();
            this.fullContentMessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.fullContentTitleBarPanel);
            this.panel1.Controls.Add(this.closeButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 35);
            this.panel1.TabIndex = 0;
            // 
            // fullContentTitleBarPanel
            // 
            this.fullContentTitleBarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullContentTitleBarPanel.Location = new System.Drawing.Point(0, 0);
            this.fullContentTitleBarPanel.Name = "fullContentTitleBarPanel";
            this.fullContentTitleBarPanel.Size = new System.Drawing.Size(565, 35);
            this.fullContentTitleBarPanel.TabIndex = 1;
            this.fullContentTitleBarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FullContentTitleBarPanel_Paint);
            // 
            // fullContentMessagePanel
            // 
            this.fullContentMessagePanel.AutoScroll = true;
            this.fullContentMessagePanel.BackColor = System.Drawing.Color.Transparent;
            this.fullContentMessagePanel.Controls.Add(this.label1);
            this.fullContentMessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fullContentMessagePanel.Location = new System.Drawing.Point(0, 35);
            this.fullContentMessagePanel.Name = "fullContentMessagePanel";
            this.fullContentMessagePanel.Padding = new System.Windows.Forms.Padding(5);
            this.fullContentMessagePanel.Size = new System.Drawing.Size(600, 365);
            this.fullContentMessagePanel.TabIndex = 1;
            this.fullContentMessagePanel.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FullContentMessagePanel_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.MaximumSize = new System.Drawing.Size(575, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Resize += new System.EventHandler(this.Label1_Resize);
            // 
            // closeButton1
            // 
            this.closeButton1.BackColor = System.Drawing.Color.Transparent;
            this.closeButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton1.Location = new System.Drawing.Point(565, 0);
            this.closeButton1.Name = "closeButton1";
            this.closeButton1.Size = new System.Drawing.Size(35, 35);
            this.closeButton1.TabIndex = 0;
            this.closeButton1.Click += new System.EventHandler(this.CloseButton1_Click);
            // 
            // FullContentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.fullContentMessagePanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FullContentViewForm";
            this.Text = "FullContentViewForm";
            this.Load += new System.EventHandler(this.FullContentViewForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FullContentFormPaint);
            this.panel1.ResumeLayout(false);
            this.fullContentMessagePanel.ResumeLayout(false);
            this.fullContentMessagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CloseButton closeButton1;
        private System.Windows.Forms.Panel fullContentMessagePanel;
        private System.Windows.Forms.Panel fullContentTitleBarPanel;
        private System.Windows.Forms.Label label1;
    }
}