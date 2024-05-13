namespace TeamTracker
{
    partial class UcTaskBoardBase
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
            this.ucTaskStatusBaseNotYetStarted = new TeamTracker.UCTaskStatusBase();
            this.ucTaskStatusBaseOnProcess = new TeamTracker.UCTaskStatusBase();
            this.ucTaskStatusBaseStuck = new TeamTracker.UCTaskStatusBase();
            this.ucTaskStatusBaseUnderReview = new TeamTracker.UCTaskStatusBase();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ucTaskStatusBaseNotYetStarted, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucTaskStatusBaseOnProcess, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucTaskStatusBaseStuck, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucTaskStatusBaseUnderReview, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1089, 478);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ucTaskStatusBaseNotYetStarted
            // 
            this.ucTaskStatusBaseNotYetStarted.BackColor = System.Drawing.Color.Transparent;
            this.ucTaskStatusBaseNotYetStarted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskStatusBaseNotYetStarted.Location = new System.Drawing.Point(0, 0);
            this.ucTaskStatusBaseNotYetStarted.Margin = new System.Windows.Forms.Padding(0);
            this.ucTaskStatusBaseNotYetStarted.Name = "ucTaskStatusBaseNotYetStarted";
            this.ucTaskStatusBaseNotYetStarted.Padding = new System.Windows.Forms.Padding(5);
            this.ucTaskStatusBaseNotYetStarted.Size = new System.Drawing.Size(272, 478);
            this.ucTaskStatusBaseNotYetStarted.Status = TeamTracker.TaskStatus.NotYetStarted;
            this.ucTaskStatusBaseNotYetStarted.TabIndex = 0;
            // 
            // ucTaskStatusBaseOnProcess
            // 
            this.ucTaskStatusBaseOnProcess.BackColor = System.Drawing.Color.Transparent;
            this.ucTaskStatusBaseOnProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskStatusBaseOnProcess.Location = new System.Drawing.Point(272, 0);
            this.ucTaskStatusBaseOnProcess.Margin = new System.Windows.Forms.Padding(0);
            this.ucTaskStatusBaseOnProcess.Name = "ucTaskStatusBaseOnProcess";
            this.ucTaskStatusBaseOnProcess.Padding = new System.Windows.Forms.Padding(5);
            this.ucTaskStatusBaseOnProcess.Size = new System.Drawing.Size(272, 478);
            this.ucTaskStatusBaseOnProcess.Status = TeamTracker.TaskStatus.OnProcess;
            this.ucTaskStatusBaseOnProcess.TabIndex = 0;
            // 
            // ucTaskStatusBaseStuck
            // 
            this.ucTaskStatusBaseStuck.BackColor = System.Drawing.Color.Transparent;
            this.ucTaskStatusBaseStuck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskStatusBaseStuck.Location = new System.Drawing.Point(544, 0);
            this.ucTaskStatusBaseStuck.Margin = new System.Windows.Forms.Padding(0);
            this.ucTaskStatusBaseStuck.Name = "ucTaskStatusBaseStuck";
            this.ucTaskStatusBaseStuck.Padding = new System.Windows.Forms.Padding(5);
            this.ucTaskStatusBaseStuck.Size = new System.Drawing.Size(272, 478);
            this.ucTaskStatusBaseStuck.Status = TeamTracker.TaskStatus.Stuck;
            this.ucTaskStatusBaseStuck.TabIndex = 0;
            // 
            // ucTaskStatusBaseUnderReview
            // 
            this.ucTaskStatusBaseUnderReview.BackColor = System.Drawing.Color.Transparent;
            this.ucTaskStatusBaseUnderReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTaskStatusBaseUnderReview.Location = new System.Drawing.Point(816, 0);
            this.ucTaskStatusBaseUnderReview.Margin = new System.Windows.Forms.Padding(0);
            this.ucTaskStatusBaseUnderReview.Name = "ucTaskStatusBaseUnderReview";
            this.ucTaskStatusBaseUnderReview.Padding = new System.Windows.Forms.Padding(5);
            this.ucTaskStatusBaseUnderReview.Size = new System.Drawing.Size(273, 478);
            this.ucTaskStatusBaseUnderReview.Status = TeamTracker.TaskStatus.UnderReview;
            this.ucTaskStatusBaseUnderReview.TabIndex = 0;
            // 
            // UcTaskBoardBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcTaskBoardBase";
            this.Size = new System.Drawing.Size(1089, 478);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UCTaskStatusBase ucTaskStatusBaseNotYetStarted;
        private UCTaskStatusBase ucTaskStatusBaseOnProcess;
        private UCTaskStatusBase ucTaskStatusBaseStuck;
        private UCTaskStatusBase ucTaskStatusBaseUnderReview;
    }
}
