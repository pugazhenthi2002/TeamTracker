using TeamTracker;

namespace UserInterface.Home_Page.Team_Lead
{
    partial class TeamLeadHome
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
            this.overview1 = new UserInterface.Home_Page.Project_Manager.Overview.Overview();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.notificationContent1 = new TeamTracker.NotificationContent();
            this.reportTemplate1 = new TeamTracker.ReportTemplate();
            this.onStageTemplate1 = new UserInterface.Home_Page.Team_Lead.On_Stage.OnStageTemplate();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // overview1
            // 
            this.overview1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.overview1.Dock = System.Windows.Forms.DockStyle.Top;
            this.overview1.Location = new System.Drawing.Point(0, 378);
            this.overview1.Name = "overview1";
            this.overview1.Size = new System.Drawing.Size(1367, 476);
            this.overview1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.notificationContent1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.onStageTemplate1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 854);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1367, 400);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // notificationContent1
            // 
            this.notificationContent1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.notificationContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notificationContent1.Location = new System.Drawing.Point(686, 3);
            this.notificationContent1.Name = "notificationContent1";
            this.notificationContent1.Size = new System.Drawing.Size(678, 394);
            this.notificationContent1.TabIndex = 0;
            // 
            // reportTemplate1
            // 
            this.reportTemplate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.reportTemplate1.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportTemplate1.Location = new System.Drawing.Point(0, 0);
            this.reportTemplate1.Name = "reportTemplate1";
            this.reportTemplate1.Size = new System.Drawing.Size(1367, 378);
            this.reportTemplate1.TabIndex = 0;
            // 
            // onStageTemplate1
            // 
            this.onStageTemplate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.onStageTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onStageTemplate1.Location = new System.Drawing.Point(3, 3);
            this.onStageTemplate1.Name = "onStageTemplate1";
            this.onStageTemplate1.Size = new System.Drawing.Size(677, 394);
            this.onStageTemplate1.TabIndex = 1;
            // 
            // TeamLeadHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.overview1);
            this.Controls.Add(this.reportTemplate1);
            this.Name = "TeamLeadHome";
            this.Size = new System.Drawing.Size(1367, 714);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Project_Manager.Overview.Overview overview1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private NotificationContent notificationContent1;
        private ReportTemplate reportTemplate1;
        private On_Stage.OnStageTemplate onStageTemplate1;
    }
}
