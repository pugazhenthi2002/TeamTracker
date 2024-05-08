namespace UserInterface.Add_Project.Custom_Control
{
    partial class SelectProjectTemplate
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
            this.singleProjectSelectTemplate2 = new UserInterface.Add_Project.Custom_Control.SingleProjectSelectTemplate();
            this.singleProjectSelectTemplate1 = new UserInterface.Add_Project.Custom_Control.SingleProjectSelectTemplate();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.singleProjectSelectTemplate2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.singleProjectSelectTemplate1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 128);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // singleProjectSelectTemplate2
            // 
            this.singleProjectSelectTemplate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.singleProjectSelectTemplate2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleProjectSelectTemplate2.IsClicked = false;
            this.singleProjectSelectTemplate2.Location = new System.Drawing.Point(191, 7);
            this.singleProjectSelectTemplate2.Margin = new System.Windows.Forms.Padding(7);
            this.singleProjectSelectTemplate2.Name = "singleProjectSelectTemplate2";
            this.singleProjectSelectTemplate2.Padding = new System.Windows.Forms.Padding(5);
            this.singleProjectSelectTemplate2.Project = null;
            this.singleProjectSelectTemplate2.Size = new System.Drawing.Size(171, 114);
            this.singleProjectSelectTemplate2.TabIndex = 1;
            this.singleProjectSelectTemplate2.ProjectClick += new System.EventHandler<TeamTracker.Projects>(this.OnProjectSelected);
            // 
            // singleProjectSelectTemplate1
            // 
            this.singleProjectSelectTemplate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.singleProjectSelectTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.singleProjectSelectTemplate1.IsClicked = false;
            this.singleProjectSelectTemplate1.Location = new System.Drawing.Point(7, 7);
            this.singleProjectSelectTemplate1.Margin = new System.Windows.Forms.Padding(7);
            this.singleProjectSelectTemplate1.Name = "singleProjectSelectTemplate1";
            this.singleProjectSelectTemplate1.Padding = new System.Windows.Forms.Padding(5);
            this.singleProjectSelectTemplate1.Project = null;
            this.singleProjectSelectTemplate1.Size = new System.Drawing.Size(170, 114);
            this.singleProjectSelectTemplate1.TabIndex = 0;
            this.singleProjectSelectTemplate1.ProjectClick += new System.EventHandler<TeamTracker.Projects>(this.OnProjectSelected);
            // 
            // SelectProjectTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectProjectTemplate";
            this.Size = new System.Drawing.Size(369, 128);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SingleProjectSelectTemplate singleProjectSelectTemplate2;
        private SingleProjectSelectTemplate singleProjectSelectTemplate1;
    }
}
