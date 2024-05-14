namespace UserInterface.Edit_Project.Controls
{
    partial class EditVersion
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
            this.searchVersion1 = new UserInterface.Edit_Project.Controls.SearchVersion();
            this.panel2 = new System.Windows.Forms.Panel();
            this.boardBasePanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchVersion1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.panel1.Size = new System.Drawing.Size(999, 51);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.boardBasePanel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 187);
            this.panel2.TabIndex = 1;
            // 
            // boardBasePanel
            // 
            this.boardBasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardBasePanel.Location = new System.Drawing.Point(0, 40);
            this.boardBasePanel.Name = "boardBasePanel";
            this.boardBasePanel.Size = new System.Drawing.Size(999, 147);
            this.boardBasePanel.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(999, 40);
            this.panel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(999, 197);
            this.panel3.TabIndex = 2;
            // 
            // EditVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditVersion";
            this.Size = new System.Drawing.Size(999, 435);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel boardBasePanel;
        private System.Windows.Forms.Panel panel4;
        private SearchVersion searchVersion1;
    }
}
