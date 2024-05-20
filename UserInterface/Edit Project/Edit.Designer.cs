namespace UserInterface.Edit_Project
{
    partial class Edit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.editVersion1 = new UserInterface.Edit_Project.Controls.EditVersion();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.editMilestoneButton = new System.Windows.Forms.Button();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.editMilestone1 = new UserInterface.Edit_Project.Controls.EditMilestone();
            this.editTask1 = new UserInterface.Edit_Project.Controls.EditTask();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(932, 542);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.editVersion1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // editVersion1
            // 
            this.editVersion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.editVersion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editVersion1.Location = new System.Drawing.Point(3, 3);
            this.editVersion1.Name = "editVersion1";
            this.editVersion1.ProjectCollection = null;
            this.editVersion1.Size = new System.Drawing.Size(918, 527);
            this.editVersion1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 44);
            this.panel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl2.Location = new System.Drawing.Point(3, 47);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(918, 483);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.editMilestone1);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(910, 474);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.editTask1);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(910, 474);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.editMilestoneButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.editTaskButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(918, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // editMilestoneButton
            // 
            this.editMilestoneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editMilestoneButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMilestoneButton.Location = new System.Drawing.Point(3, 3);
            this.editMilestoneButton.Name = "editMilestoneButton";
            this.editMilestoneButton.Size = new System.Drawing.Size(453, 38);
            this.editMilestoneButton.TabIndex = 0;
            this.editMilestoneButton.Text = "Edit Milestone";
            this.editMilestoneButton.UseVisualStyleBackColor = true;
            this.editMilestoneButton.Click += new System.EventHandler(this.EditMilestoneClick);
            // 
            // editTaskButton
            // 
            this.editTaskButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editTaskButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTaskButton.Location = new System.Drawing.Point(462, 3);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(453, 38);
            this.editTaskButton.TabIndex = 1;
            this.editTaskButton.Text = "Edit Task";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.EditTaskClick);
            // 
            // editMilestone1
            // 
            this.editMilestone1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(190)))));
            this.editMilestone1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editMilestone1.Location = new System.Drawing.Point(3, 3);
            this.editMilestone1.Name = "editMilestone1";
            this.editMilestone1.ProjectCollection = null;
            this.editMilestone1.Size = new System.Drawing.Size(904, 468);
            this.editMilestone1.TabIndex = 0;
            // 
            // editTask1
            // 
            this.editTask1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.editTask1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editTask1.Location = new System.Drawing.Point(3, 3);
            this.editTask1.Name = "editTask1";
            this.editTask1.Size = new System.Drawing.Size(904, 468);
            this.editTask1.TabIndex = 0;
            this.editTask1.TaskCollection = null;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Edit";
            this.Size = new System.Drawing.Size(932, 542);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.EditVersion editVersion1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button editMilestoneButton;
        private System.Windows.Forms.Button editTaskButton;
        private Controls.EditMilestone editMilestone1;
        private Controls.EditTask editTask1;
    }
}
