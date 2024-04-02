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
            this.BtnEasy = new System.Windows.Forms.Button();
            this.BtnMedium = new System.Windows.Forms.Button();
            this.BtnHard = new System.Windows.Forms.Button();
            this.BtnCritical = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.BtnEasy, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnMedium, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnHard, 0, 1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(172, 184);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // BtnEasy
            // 
            this.BtnEasy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEasy.FlatAppearance.BorderSize = 0;
            this.BtnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEasy.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEasy.Location = new System.Drawing.Point(3, 141);
            this.BtnEasy.Name = "BtnEasy";
            this.BtnEasy.Size = new System.Drawing.Size(166, 40);
            this.BtnEasy.TabIndex = 6;
            this.BtnEasy.Text = "Easy";
            this.BtnEasy.UseVisualStyleBackColor = true;
            this.BtnEasy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickPriorityBtn);
            // 
            // BtnMedium
            // 
            this.BtnMedium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMedium.FlatAppearance.BorderSize = 0;
            this.BtnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMedium.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMedium.Location = new System.Drawing.Point(3, 95);
            this.BtnMedium.Name = "BtnMedium";
            this.BtnMedium.Size = new System.Drawing.Size(166, 40);
            this.BtnMedium.TabIndex = 5;
            this.BtnMedium.Text = "Medium";
            this.BtnMedium.UseVisualStyleBackColor = true;
            this.BtnMedium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickPriorityBtn);
            // 
            // BtnHard
            // 
            this.BtnHard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnHard.FlatAppearance.BorderSize = 0;
            this.BtnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHard.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHard.Location = new System.Drawing.Point(3, 49);
            this.BtnHard.Name = "BtnHard";
            this.BtnHard.Size = new System.Drawing.Size(166, 40);
            this.BtnHard.TabIndex = 4;
            this.BtnHard.Text = "Hard";
            this.BtnHard.UseVisualStyleBackColor = true;
            this.BtnHard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickPriorityBtn);
            // 
            // BtnCritical
            // 
            this.BtnCritical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCritical.FlatAppearance.BorderSize = 0;
            this.BtnCritical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCritical.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCritical.Location = new System.Drawing.Point(3, 3);
            this.BtnCritical.Name = "BtnCritical";
            this.BtnCritical.Size = new System.Drawing.Size(166, 40);
            this.BtnCritical.TabIndex = 3;
            this.BtnCritical.Text = "Critical";
            this.BtnCritical.UseVisualStyleBackColor = true;
            this.BtnCritical.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickPriorityBtn);
            // 
            // PriorityDropDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 184);
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
        private System.Windows.Forms.Button BtnMedium;
        private System.Windows.Forms.Button BtnHard;
        private System.Windows.Forms.Button BtnCritical;
        private System.Windows.Forms.Button BtnEasy;
    }
}