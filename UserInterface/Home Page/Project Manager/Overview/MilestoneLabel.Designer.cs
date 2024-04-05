namespace UserInterface.Home_Page.Project_Manager.Overview
{
    partial class MilestoneLabel
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.donePanel = new System.Windows.Forms.Panel();
            this.currentPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.notStartedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.delayPanel, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.donePanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentPanel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.notStartedPanel, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(626, 41);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(521, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delay";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Not Started";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delayPanel
            // 
            this.delayPanel.BackColor = System.Drawing.Color.Transparent;
            this.delayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.delayPanel.Location = new System.Drawing.Point(468, 0);
            this.delayPanel.Margin = new System.Windows.Forms.Padding(0);
            this.delayPanel.Name = "delayPanel";
            this.delayPanel.Size = new System.Drawing.Size(50, 41);
            this.delayPanel.TabIndex = 2;
            this.delayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.delayPanel_Paint);
            // 
            // donePanel
            // 
            this.donePanel.BackColor = System.Drawing.Color.Transparent;
            this.donePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donePanel.Location = new System.Drawing.Point(0, 0);
            this.donePanel.Margin = new System.Windows.Forms.Padding(0);
            this.donePanel.Name = "donePanel";
            this.donePanel.Size = new System.Drawing.Size(50, 41);
            this.donePanel.TabIndex = 0;
            this.donePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.donePanel_Paint);
            // 
            // currentPanel
            // 
            this.currentPanel.BackColor = System.Drawing.Color.Transparent;
            this.currentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentPanel.Location = new System.Drawing.Point(156, 0);
            this.currentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.currentPanel.Name = "currentPanel";
            this.currentPanel.Size = new System.Drawing.Size(50, 41);
            this.currentPanel.TabIndex = 1;
            this.currentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.currentPanel_Paint);
            // 
            // notStartedPanel
            // 
            this.notStartedPanel.BackColor = System.Drawing.Color.Transparent;
            this.notStartedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notStartedPanel.Location = new System.Drawing.Point(312, 0);
            this.notStartedPanel.Margin = new System.Windows.Forms.Padding(0);
            this.notStartedPanel.Name = "notStartedPanel";
            this.notStartedPanel.Size = new System.Drawing.Size(50, 41);
            this.notStartedPanel.TabIndex = 2;
            this.notStartedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.notStartedPanel_Paint);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Done";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MilestoneLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MilestoneLabel";
            this.Size = new System.Drawing.Size(626, 41);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel delayPanel;
        private System.Windows.Forms.Panel donePanel;
        private System.Windows.Forms.FlowLayoutPanel currentPanel;
        private System.Windows.Forms.FlowLayoutPanel notStartedPanel;
        private System.Windows.Forms.Label label1;
    }
}
