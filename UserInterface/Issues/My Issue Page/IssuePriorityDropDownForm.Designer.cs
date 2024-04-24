namespace TeamTracker
{
    partial class IssuePriorityDropDownForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnLow = new System.Windows.Forms.Button();
            this.BtnMedium = new System.Windows.Forms.Button();
            this.BtnHigh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.BtnLow, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnMedium, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnHigh, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BtnLow
            // 
            this.BtnLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnLow.FlatAppearance.BorderSize = 0;
            this.BtnLow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLow.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLow.Location = new System.Drawing.Point(3, 69);
            this.BtnLow.Name = "BtnLow";
            this.BtnLow.Size = new System.Drawing.Size(244, 28);
            this.BtnLow.TabIndex = 5;
            this.BtnLow.Text = "Low";
            this.BtnLow.UseVisualStyleBackColor = true;
            this.BtnLow.Click += new System.EventHandler(this.OnClickBtn);
            // 
            // BtnMedium
            // 
            this.BtnMedium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMedium.FlatAppearance.BorderSize = 0;
            this.BtnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedium.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedium.Location = new System.Drawing.Point(3, 36);
            this.BtnMedium.Name = "BtnMedium";
            this.BtnMedium.Size = new System.Drawing.Size(244, 27);
            this.BtnMedium.TabIndex = 4;
            this.BtnMedium.Text = "Medium";
            this.BtnMedium.UseVisualStyleBackColor = true;
            this.BtnMedium.Click += new System.EventHandler(this.OnClickBtn);
            // 
            // BtnHigh
            // 
            this.BtnHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnHigh.FlatAppearance.BorderSize = 0;
            this.BtnHigh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHigh.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHigh.Location = new System.Drawing.Point(3, 3);
            this.BtnHigh.Name = "BtnHigh";
            this.BtnHigh.Size = new System.Drawing.Size(244, 27);
            this.BtnHigh.TabIndex = 3;
            this.BtnHigh.Text = "High";
            this.BtnHigh.UseVisualStyleBackColor = true;
            this.BtnHigh.Click += new System.EventHandler(this.OnClickBtn);
            // 
            // IssuePriorityDropDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(250, 100);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssuePriorityDropDownForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PriorityDropDownFrom";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnLow;
        private System.Windows.Forms.Button BtnMedium;
        private System.Windows.Forms.Button BtnHigh;
    }
}