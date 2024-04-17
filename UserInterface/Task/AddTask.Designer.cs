namespace UserInterface.Task
{
    partial class AddTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currentTimelineContent1 = new UserInterface.Task.Timeline.CurrentTimelineContent();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.nextPicBox = new System.Windows.Forms.PictureBox();
            this.backPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.milestoneSwitch1 = new UserInterface.Task.MilestoneSwitch();
            this.ucNotFound2 = new UserInterface.UcNotFound();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicBox)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 621);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.currentTimelineContent1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 326);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(1201, 276);
            this.panel3.TabIndex = 4;
            // 
            // currentTimelineContent1
            // 
            this.currentTimelineContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTimelineContent1.Location = new System.Drawing.Point(0, 10);
            this.currentTimelineContent1.Name = "currentTimelineContent1";
            this.currentTimelineContent1.Size = new System.Drawing.Size(1201, 266);
            this.currentTimelineContent1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1201, 269);
            this.panel5.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panelBase);
            this.panel7.Controls.Add(this.ucNotFound2);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(752, 269);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.nextPicBox);
            this.panel8.Controls.Add(this.backPicBox);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(752, 52);
            this.panel8.TabIndex = 1;
            // 
            // nextPicBox
            // 
            this.nextPicBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextPicBox.Image = global::UserInterface.Properties.Resources.Next_Hover;
            this.nextPicBox.Location = new System.Drawing.Point(220, 0);
            this.nextPicBox.Name = "nextPicBox";
            this.nextPicBox.Size = new System.Drawing.Size(56, 52);
            this.nextPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nextPicBox.TabIndex = 3;
            this.nextPicBox.TabStop = false;
            this.nextPicBox.Click += new System.EventHandler(this.NextClick);
            // 
            // backPicBox
            // 
            this.backPicBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.backPicBox.Image = global::UserInterface.Properties.Resources.Back_Hover;
            this.backPicBox.Location = new System.Drawing.Point(164, 0);
            this.backPicBox.Name = "backPicBox";
            this.backPicBox.Size = new System.Drawing.Size(56, 52);
            this.backPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backPicBox.TabIndex = 2;
            this.backPicBox.TabStop = false;
            this.backPicBox.Click += new System.EventHandler(this.BackClick);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(164, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Review Task";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.milestoneSwitch1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(752, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(449, 269);
            this.panel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 602);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1201, 19);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addTaskButton);
            this.panel2.Controls.Add(this.projectNameLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1201, 57);
            this.panel2.TabIndex = 2;
            // 
            // addTaskButton
            // 
            this.addTaskButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.addTaskButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTaskButton.BackgroundImage")));
            this.addTaskButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addTaskButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.addTaskButton.FlatAppearance.BorderSize = 0;
            this.addTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTaskButton.Location = new System.Drawing.Point(1146, 5);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(50, 47);
            this.addTaskButton.TabIndex = 1;
            this.addTaskButton.UseVisualStyleBackColor = false;
            this.addTaskButton.Click += new System.EventHandler(this.AddTaskClick);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.projectNameLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.projectNameLabel.Location = new System.Drawing.Point(5, 5);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(227, 47);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Project Name";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "No Current Project Available !!";
            this.ucNotFound1.HeadTextSize = 14;
            this.ucNotFound1.Location = new System.Drawing.Point(0, 0);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(1201, 621);
            this.ucNotFound1.TabIndex = 2;
            // 
            // milestoneSwitch1
            // 
            this.milestoneSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.milestoneSwitch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.milestoneSwitch1.Location = new System.Drawing.Point(0, 0);
            this.milestoneSwitch1.Name = "milestoneSwitch1";
            this.milestoneSwitch1.Size = new System.Drawing.Size(449, 269);
            this.milestoneSwitch1.TabIndex = 0;
            // 
            // ucNotFound2
            // 
            this.ucNotFound2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotFound2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound2.HeadText = "No Under-Review Task !!";
            this.ucNotFound2.HeadTextSize = 14;
            this.ucNotFound2.Location = new System.Drawing.Point(0, 52);
            this.ucNotFound2.Message = null;
            this.ucNotFound2.Name = "ucNotFound2";
            this.ucNotFound2.Size = new System.Drawing.Size(752, 217);
            this.ucNotFound2.TabIndex = 2;
            // 
            // panelBase
            // 
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 52);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(752, 217);
            this.panelBase.TabIndex = 3;
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucNotFound1);
            this.Name = "AddTask";
            this.Size = new System.Drawing.Size(1201, 621);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicBox)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UcNotFound ucNotFound1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox nextPicBox;
        private System.Windows.Forms.PictureBox backPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private Timeline.CurrentTimelineContent currentTimelineContent1;
        private MilestoneSwitch milestoneSwitch1;
        private UcNotFound ucNotFound2;
        private System.Windows.Forms.Panel panelBase;
    }
}
