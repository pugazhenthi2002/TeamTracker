namespace UserInterface.Task
{
    partial class MilestoneSwitch
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelBase = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.switchMilestoneButton = new System.Windows.Forms.Button();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 207);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panelBase);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 207);
            this.panel3.TabIndex = 1;
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.Transparent;
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 38);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(211, 169);
            this.panelBase.TabIndex = 2;
            this.panelBase.Paint += new System.Windows.Forms.PaintEventHandler(this.OnMilestonePaint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Milestone";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pieChart1);
            this.panel2.Controls.Add(this.ucNotFound1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(211, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 207);
            this.panel2.TabIndex = 0;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "Zero Task Count !!";
            this.ucNotFound1.HeadTextSize = 12;
            this.ucNotFound1.Location = new System.Drawing.Point(0, 38);
            this.ucNotFound1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(211, 169);
            this.ucNotFound1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Task Report";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.switchMilestoneButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(60, 10, 60, 10);
            this.panel1.Size = new System.Drawing.Size(422, 58);
            this.panel1.TabIndex = 1;
            // 
            // switchMilestoneButton
            // 
            this.switchMilestoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.switchMilestoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchMilestoneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switchMilestoneButton.FlatAppearance.BorderSize = 0;
            this.switchMilestoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchMilestoneButton.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchMilestoneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.switchMilestoneButton.Location = new System.Drawing.Point(60, 10);
            this.switchMilestoneButton.Name = "switchMilestoneButton";
            this.switchMilestoneButton.Size = new System.Drawing.Size(302, 38);
            this.switchMilestoneButton.TabIndex = 0;
            this.switchMilestoneButton.Text = "Start Next Milestone";
            this.switchMilestoneButton.UseVisualStyleBackColor = false;
            this.switchMilestoneButton.Click += new System.EventHandler(this.OnSwitchMilestone);
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.Transparent;
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(0, 38);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(211, 169);
            this.pieChart1.TabIndex = 2;
            this.pieChart1.Text = "pieChart1";
            // 
            // MilestoneSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "MilestoneSwitch";
            this.Size = new System.Drawing.Size(422, 265);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button switchMilestoneButton;
        private System.Windows.Forms.Label label1;
        private UcNotFound ucNotFound1;
        private System.Windows.Forms.Panel panelBase;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}
