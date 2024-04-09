namespace TeamTracker
{
    partial class UcOnStage
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBaseMilestone = new System.Windows.Forms.Panel();
            this.panelMilestone = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonAddMilestone = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelProjNameandVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucDueDate1 = new UserInterface.ViewPage.BoardView.UcDueDate();
            this.ucStartDate = new UserInterface.ViewPage.BoardView.UcDueDate();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelBaseMilestone.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panelBaseMilestone, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(551, 205);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelBaseMilestone
            // 
            this.panelBaseMilestone.Controls.Add(this.panelMilestone);
            this.panelBaseMilestone.Controls.Add(this.panel3);
            this.panelBaseMilestone.Controls.Add(this.panel6);
            this.panelBaseMilestone.Controls.Add(this.panel5);
            this.panelBaseMilestone.Controls.Add(this.panel4);
            this.panelBaseMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBaseMilestone.Location = new System.Drawing.Point(280, 5);
            this.panelBaseMilestone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 8);
            this.panelBaseMilestone.Name = "panelBaseMilestone";
            this.panelBaseMilestone.Size = new System.Drawing.Size(266, 192);
            this.panelBaseMilestone.TabIndex = 7;
            this.panelBaseMilestone.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaintPanelBaseMilestone);
            // 
            // panelMilestone
            // 
            this.panelMilestone.AutoScroll = true;
            this.panelMilestone.BackColor = System.Drawing.Color.Transparent;
            this.panelMilestone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMilestone.Location = new System.Drawing.Point(15, 20);
            this.panelMilestone.Margin = new System.Windows.Forms.Padding(20);
            this.panelMilestone.Name = "panelMilestone";
            this.panelMilestone.Size = new System.Drawing.Size(236, 152);
            this.panelMilestone.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.buttonAddMilestone);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(15, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(236, 20);
            this.panel3.TabIndex = 0;
            // 
            // buttonAddMilestone
            // 
            this.buttonAddMilestone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.buttonAddMilestone.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddMilestone.FlatAppearance.BorderSize = 0;
            this.buttonAddMilestone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMilestone.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMilestone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonAddMilestone.Location = new System.Drawing.Point(0, 0);
            this.buttonAddMilestone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddMilestone.Name = "buttonAddMilestone";
            this.buttonAddMilestone.Size = new System.Drawing.Size(122, 20);
            this.buttonAddMilestone.TabIndex = 0;
            this.buttonAddMilestone.Text = "Add Milestone ▼";
            this.buttonAddMilestone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddMilestone.UseVisualStyleBackColor = false;
            this.buttonAddMilestone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickAddMilestone);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(15, 172);
            this.panel6.TabIndex = 3;
            this.panel6.Tag = "12,1";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(251, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 172);
            this.panel5.TabIndex = 2;
            this.panel5.Tag = "12,1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 20);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.labelClientName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelProjNameandVersion, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(265, 195);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelClientName
            // 
            this.labelClientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.labelClientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClientName.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelClientName.Location = new System.Drawing.Point(3, 68);
            this.labelClientName.Margin = new System.Windows.Forms.Padding(3);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(259, 59);
            this.labelClientName.TabIndex = 1;
            this.labelClientName.Text = "Client Name ";
            this.labelClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProjNameandVersion
            // 
            this.labelProjNameandVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.labelProjNameandVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProjNameandVersion.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjNameandVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.labelProjNameandVersion.Location = new System.Drawing.Point(3, 3);
            this.labelProjNameandVersion.Margin = new System.Windows.Forms.Padding(3);
            this.labelProjNameandVersion.Name = "labelProjNameandVersion";
            this.labelProjNameandVersion.Size = new System.Drawing.Size(259, 59);
            this.labelProjNameandVersion.TabIndex = 0;
            this.labelProjNameandVersion.Text = "Project Name - Version";
            this.labelProjNameandVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.ucDueDate1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.ucStartDate, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 130);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(265, 65);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 343);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ucDueDate1
            // 
            this.ucDueDate1.BorderColor = System.Drawing.Color.Black;
            this.ucDueDate1.CenterLabelText = null;
            this.ucDueDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDueDate1.DueDate = new System.DateTime(2024, 4, 13, 0, 0, 0, 0);
            this.ucDueDate1.DueLabelcolor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ucDueDate1.LabelText = "To";
            this.ucDueDate1.Location = new System.Drawing.Point(137, 10);
            this.ucDueDate1.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.ucDueDate1.Name = "ucDueDate1";
            this.ucDueDate1.Size = new System.Drawing.Size(123, 50);
            this.ucDueDate1.TabIndex = 1;
            // 
            // ucStartDate
            // 
            this.ucStartDate.BorderColor = System.Drawing.Color.Black;
            this.ucStartDate.CenterLabelText = null;
            this.ucStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStartDate.DueDate = new System.DateTime(2024, 4, 8, 12, 47, 26, 0);
            this.ucStartDate.DueLabelcolor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ucStartDate.LabelText = "From";
            this.ucStartDate.Location = new System.Drawing.Point(5, 10);
            this.ucStartDate.Margin = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.ucStartDate.Name = "ucStartDate";
            this.ucStartDate.Size = new System.Drawing.Size(122, 50);
            this.ucStartDate.TabIndex = 0;
            // 
            // UcOnStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcOnStage";
            this.Size = new System.Drawing.Size(551, 343);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelBaseMilestone.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelProjNameandVersion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private UserInterface.ViewPage.BoardView.UcDueDate ucDueDate1;
        private UserInterface.ViewPage.BoardView.UcDueDate ucStartDate;
        private System.Windows.Forms.Panel panelBaseMilestone;
        private System.Windows.Forms.Panel panelMilestone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonAddMilestone;
    }
}
