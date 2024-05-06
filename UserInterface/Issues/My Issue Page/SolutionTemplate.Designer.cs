namespace UserInterface.Issues.My_Issue_Page
{
    partial class SolutionTemplate
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.solutionAttachmentTemplate1 = new UserInterface.Issues.My_Issue_Page.SolutionAttachmentTemplate();
            this.employeeProfilePicAndName1 = new UserInterface.ViewProject.EmployeeProfilePicAndName();
            this.totalSolutionCOuntLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(188)))), ((int)(((byte)(201)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(591, 198);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // solutionAttachmentTemplate1
            // 
            this.solutionAttachmentTemplate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.solutionAttachmentTemplate1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.solutionAttachmentTemplate1.Location = new System.Drawing.Point(2, 263);
            this.solutionAttachmentTemplate1.Name = "solutionAttachmentTemplate1";
            this.solutionAttachmentTemplate1.Size = new System.Drawing.Size(591, 40);
            this.solutionAttachmentTemplate1.TabIndex = 1;
            // 
            // employeeProfilePicAndName1
            // 
            this.employeeProfilePicAndName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.employeeProfilePicAndName1.Dock = System.Windows.Forms.DockStyle.Top;
            this.employeeProfilePicAndName1.HoverColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Location = new System.Drawing.Point(2, 27);
            this.employeeProfilePicAndName1.Name = "employeeProfilePicAndName1";
            this.employeeProfilePicAndName1.NormalColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Size = new System.Drawing.Size(591, 38);
            this.employeeProfilePicAndName1.TabIndex = 3;
            // 
            // totalSolutionCOuntLabel
            // 
            this.totalSolutionCOuntLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.totalSolutionCOuntLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.totalSolutionCOuntLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSolutionCOuntLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.totalSolutionCOuntLabel.Location = new System.Drawing.Point(2, 2);
            this.totalSolutionCOuntLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.totalSolutionCOuntLabel.Name = "totalSolutionCOuntLabel";
            this.totalSolutionCOuntLabel.Size = new System.Drawing.Size(591, 25);
            this.totalSolutionCOuntLabel.TabIndex = 5;
            this.totalSolutionCOuntLabel.Text = "Solved By";
            this.totalSolutionCOuntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SolutionTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.solutionAttachmentTemplate1);
            this.Controls.Add(this.employeeProfilePicAndName1);
            this.Controls.Add(this.totalSolutionCOuntLabel);
            this.Name = "SolutionTemplate";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(595, 305);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private SolutionAttachmentTemplate solutionAttachmentTemplate1;
        private ViewProject.EmployeeProfilePicAndName employeeProfilePicAndName1;
        private System.Windows.Forms.Label totalSolutionCOuntLabel;
    }
}
