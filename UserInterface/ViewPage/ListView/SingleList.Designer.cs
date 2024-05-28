using UserInterface.ViewProject;

namespace TeamTracker
{
    partial class SingleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleList));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.assignedBy = new UserInterface.ViewProject.EmployeeProfilePicAndName();
            this.panel3 = new System.Windows.Forms.Panel();
            this.statusLabel = new TeamTracker.AnimatedLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.priorityLabel = new TeamTracker.AnimatedLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.viewTask = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewTask)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1437, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.taskName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(239, 58);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.EdgePaint);
            // 
            // taskName
            // 
            this.taskName.BackColor = System.Drawing.Color.Transparent;
            this.taskName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.Location = new System.Drawing.Point(1, 1);
            this.taskName.Margin = new System.Windows.Forms.Padding(0);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(237, 56);
            this.taskName.TabIndex = 1;
            this.taskName.Text = "label1";
            this.taskName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.assignedBy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(239, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(239, 58);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.EdgePaint);
            // 
            // assignedBy
            // 
            this.assignedBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assignedBy.BackColor = System.Drawing.Color.Transparent;
            this.assignedBy.HoverColor = System.Drawing.Color.Empty;
            this.assignedBy.Location = new System.Drawing.Point(3, 13);
            this.assignedBy.Margin = new System.Windows.Forms.Padding(0);
            this.assignedBy.Name = "assignedBy";
            this.assignedBy.NormalColor = System.Drawing.Color.Empty;
            this.assignedBy.Size = new System.Drawing.Size(233, 32);
            this.assignedBy.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.statusLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(478, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(1);
            this.panel3.Size = new System.Drawing.Size(239, 58);
            this.panel3.TabIndex = 8;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.EdgePaint);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.LabelCornerColor = System.Drawing.Color.Empty;
            this.statusLabel.Location = new System.Drawing.Point(1, 1);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.ParentColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.statusLabel.Size = new System.Drawing.Size(237, 56);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "animatedLabel1";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.statusLabel.Click += new System.EventHandler(this.OnStatusClicked);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dueDateLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(717, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(1);
            this.panel4.Size = new System.Drawing.Size(239, 58);
            this.panel4.TabIndex = 9;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.EdgePaint);
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dueDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dueDateLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.Location = new System.Drawing.Point(1, 1);
            this.dueDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(237, 56);
            this.dueDateLabel.TabIndex = 2;
            this.dueDateLabel.Text = "label2";
            this.dueDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.priorityLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(956, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(1);
            this.panel5.Size = new System.Drawing.Size(239, 58);
            this.panel5.TabIndex = 10;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.EdgePaint);
            // 
            // priorityLabel
            // 
            this.priorityLabel.BackColor = System.Drawing.Color.Transparent;
            this.priorityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.priorityLabel.LabelCornerColor = System.Drawing.Color.Empty;
            this.priorityLabel.Location = new System.Drawing.Point(1, 1);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.ParentColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.priorityLabel.Size = new System.Drawing.Size(237, 56);
            this.priorityLabel.TabIndex = 5;
            this.priorityLabel.Text = "animatedLabel2";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.viewTask);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1195, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(1);
            this.panel6.Size = new System.Drawing.Size(242, 58);
            this.panel6.TabIndex = 11;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.EdgePaint);
            // 
            // viewTask
            // 
            this.viewTask.BackColor = System.Drawing.Color.Transparent;
            this.viewTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTask.Image = ((System.Drawing.Image)(resources.GetObject("viewTask.Image")));
            this.viewTask.Location = new System.Drawing.Point(1, 1);
            this.viewTask.Margin = new System.Windows.Forms.Padding(0);
            this.viewTask.Name = "viewTask";
            this.viewTask.Size = new System.Drawing.Size(240, 56);
            this.viewTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.viewTask.TabIndex = 6;
            this.viewTask.TabStop = false;
            this.viewTask.Click += new System.EventHandler(this.ViewTaskClick);
            // 
            // SingleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SingleList";
            this.Size = new System.Drawing.Size(1437, 58);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Panel panel2;
        private EmployeeProfilePicAndName assignedBy;
        private System.Windows.Forms.Panel panel3;
        private AnimatedLabel statusLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.Panel panel5;
        private AnimatedLabel priorityLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox viewTask;
    }
}
