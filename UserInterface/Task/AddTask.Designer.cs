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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.currentTimelineContent1 = new UserInterface.Task.Timeline.CurrentTimelineContent();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelBase = new System.Windows.Forms.Panel();
            this.ucNotFound2 = new UserInterface.UcNotFound();
            this.panel8 = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.milestoneSwitch1 = new UserInterface.Task.MilestoneSwitch();
            this.ucNotFound3 = new UserInterface.UcNotFound();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
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
            this.panel3.Location = new System.Drawing.Point(0, 370);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel3.Size = new System.Drawing.Size(1201, 232);
            this.panel3.TabIndex = 7;
            // 
            // currentTimelineContent1
            // 
            this.currentTimelineContent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(219)))), ((int)(((byte)(228)))));
            this.currentTimelineContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentTimelineContent1.Location = new System.Drawing.Point(0, 10);
            this.currentTimelineContent1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentTimelineContent1.Name = "currentTimelineContent1";
            this.currentTimelineContent1.Size = new System.Drawing.Size(1201, 222);
            this.currentTimelineContent1.TabIndex = 0;
            this.currentTimelineContent1.Reset += new System.EventHandler(this.OnReset);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(0, 326);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1201, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Timeline";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(1201, 269);
            this.panel5.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.panel7.Controls.Add(this.panelBase);
            this.panel7.Controls.Add(this.ucNotFound2);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(10, 10);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.panel7.Size = new System.Drawing.Size(738, 249);
            this.panel7.TabIndex = 1;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.Color.Transparent;
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(2, 52);
            this.panelBase.Name = "panelBase";
            this.panelBase.Padding = new System.Windows.Forms.Padding(5);
            this.panelBase.Size = new System.Drawing.Size(734, 197);
            this.panelBase.TabIndex = 3;
            // 
            // ucNotFound2
            // 
            this.ucNotFound2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.ucNotFound2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound2.HeadText = "No Under-Review Task !!";
            this.ucNotFound2.HeadTextSize = 14;
            this.ucNotFound2.Location = new System.Drawing.Point(2, 52);
            this.ucNotFound2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucNotFound2.Message = null;
            this.ucNotFound2.Name = "ucNotFound2";
            this.ucNotFound2.Size = new System.Drawing.Size(734, 197);
            this.ucNotFound2.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.nextBtn);
            this.panel8.Controls.Add(this.backBtn);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(2, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(734, 52);
            this.panel8.TabIndex = 1;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.OnReviewLineSplitPaint);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextBtn.Image = global::UserInterface.Properties.Resources.Right_Medium_Blue;
            this.nextBtn.Location = new System.Drawing.Point(220, 0);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(56, 52);
            this.nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.nextBtn.TabIndex = 3;
            this.nextBtn.TabStop = false;
            this.nextBtn.Click += new System.EventHandler(this.NextClick);
            this.nextBtn.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.nextBtn.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.Image = global::UserInterface.Properties.Resources.Left_Medium_Blue;
            this.backBtn.Location = new System.Drawing.Point(164, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(56, 52);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.backBtn.TabIndex = 2;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.BackClick);
            this.backBtn.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
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
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.milestoneSwitch1);
            this.panel6.Controls.Add(this.ucNotFound3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(748, 10);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel6.Size = new System.Drawing.Size(443, 249);
            this.panel6.TabIndex = 0;
            // 
            // milestoneSwitch1
            // 
            this.milestoneSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.milestoneSwitch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.milestoneSwitch1.Location = new System.Drawing.Point(20, 0);
            this.milestoneSwitch1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.milestoneSwitch1.Name = "milestoneSwitch1";
            this.milestoneSwitch1.Size = new System.Drawing.Size(423, 249);
            this.milestoneSwitch1.TabIndex = 1;
            this.milestoneSwitch1.ResetForm += new System.EventHandler(this.OnResetForm);
            this.milestoneSwitch1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnBorderPaint);
            // 
            // ucNotFound3
            // 
            this.ucNotFound3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.ucNotFound3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound3.HeadText = "No Current Milestone !!";
            this.ucNotFound3.HeadTextSize = 14;
            this.ucNotFound3.Location = new System.Drawing.Point(20, 0);
            this.ucNotFound3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucNotFound3.Message = null;
            this.ucNotFound3.Name = "ucNotFound3";
            this.ucNotFound3.Size = new System.Drawing.Size(423, 249);
            this.ucNotFound3.TabIndex = 0;
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
            this.addTaskButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.ucNotFound1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(1201, 621);
            this.ucNotFound1.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
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
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox nextBtn;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private UcNotFound ucNotFound2;
        private System.Windows.Forms.Panel panelBase;
        private UcNotFound ucNotFound3;
        private MilestoneSwitch milestoneSwitch1;
        private System.Windows.Forms.Panel panel3;
        private Timeline.CurrentTimelineContent currentTimelineContent1;
        private System.Windows.Forms.Label label2;
    }
}
