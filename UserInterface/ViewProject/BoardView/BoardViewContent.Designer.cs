namespace UserInterface.ViewProject.BoardView
{
    partial class BoardViewContent
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
            this.upcomingTemplates = new UserInterface.ViewProject.BoardView.Custom_Controls.StatusViewTemplate();
            this.onStageTemplate = new UserInterface.ViewProject.BoardView.Custom_Controls.StatusViewTemplate();
            this.onProcessTemplate = new UserInterface.ViewProject.BoardView.Custom_Controls.StatusViewTemplate();
            this.deploymentTemplate = new UserInterface.ViewProject.BoardView.Custom_Controls.StatusViewTemplate();
            this.completedTemplate = new UserInterface.ViewProject.BoardView.Custom_Controls.StatusViewTemplate();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.upcomingTemplates, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.onStageTemplate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.onProcessTemplate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.deploymentTemplate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.completedTemplate, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1162, 581);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // upcomingTemplates
            // 
            this.upcomingTemplates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upcomingTemplates.Location = new System.Drawing.Point(930, 2);
            this.upcomingTemplates.Margin = new System.Windows.Forms.Padding(2);
            this.upcomingTemplates.Name = "upcomingTemplates";
            this.upcomingTemplates.Size = new System.Drawing.Size(230, 577);
            this.upcomingTemplates.TabIndex = 4;
            // 
            // onStageTemplate
            // 
            this.onStageTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onStageTemplate.Location = new System.Drawing.Point(698, 2);
            this.onStageTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.onStageTemplate.Name = "onStageTemplate";
            this.onStageTemplate.Size = new System.Drawing.Size(228, 577);
            this.onStageTemplate.TabIndex = 3;
            // 
            // onProcessTemplate
            // 
            this.onProcessTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onProcessTemplate.Location = new System.Drawing.Point(466, 2);
            this.onProcessTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.onProcessTemplate.Name = "onProcessTemplate";
            this.onProcessTemplate.Size = new System.Drawing.Size(228, 577);
            this.onProcessTemplate.TabIndex = 2;
            // 
            // deploymentTemplate
            // 
            this.deploymentTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deploymentTemplate.Location = new System.Drawing.Point(234, 2);
            this.deploymentTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.deploymentTemplate.Name = "deploymentTemplate";
            this.deploymentTemplate.Size = new System.Drawing.Size(228, 577);
            this.deploymentTemplate.TabIndex = 1;
            // 
            // completedTemplate
            // 
            this.completedTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completedTemplate.Location = new System.Drawing.Point(2, 2);
            this.completedTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.completedTemplate.Name = "completedTemplate";
            this.completedTemplate.Size = new System.Drawing.Size(228, 577);
            this.completedTemplate.TabIndex = 0;
            // 
            // BoardViewContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BoardViewContent";
            this.Size = new System.Drawing.Size(1162, 581);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Custom_Controls.StatusViewTemplate upcomingTemplates;
        private Custom_Controls.StatusViewTemplate onStageTemplate;
        private Custom_Controls.StatusViewTemplate onProcessTemplate;
        private Custom_Controls.StatusViewTemplate deploymentTemplate;
        private Custom_Controls.StatusViewTemplate completedTemplate;
    }
}
