namespace TeamTracker
{
    partial class PriorityDropDownForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCritical = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnCritical, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(172, 200);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(2, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 50);
            this.label3.TabIndex = 3;
            this.label3.Text = "Easy";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickPriorityBtn);
            this.label3.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(2, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Medium";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickPriorityBtn);
            this.label2.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(2, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickPriorityBtn);
            this.label1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // BtnCritical
            // 
            this.BtnCritical.BackColor = System.Drawing.Color.Transparent;
            this.BtnCritical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCritical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCritical.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCritical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnCritical.Location = new System.Drawing.Point(2, 0);
            this.BtnCritical.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BtnCritical.Name = "BtnCritical";
            this.BtnCritical.Size = new System.Drawing.Size(168, 50);
            this.BtnCritical.TabIndex = 0;
            this.BtnCritical.Text = "Critical";
            this.BtnCritical.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCritical.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickPriorityBtn);
            this.BtnCritical.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.BtnCritical.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // PriorityDropDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(172, 200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "PriorityDropDownForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PriorityDropDownForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label BtnCritical;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}