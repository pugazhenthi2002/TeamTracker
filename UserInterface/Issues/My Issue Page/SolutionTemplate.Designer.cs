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
            this.panel6 = new System.Windows.Forms.Panel();
            this.solvedByLabel = new System.Windows.Forms.Label();
            this.employeeProfilePicAndName1 = new UserInterface.ViewProject.EmployeeProfilePicAndName();
            this.panel7 = new System.Windows.Forms.Panel();
            this.solutionAttachmentTemplate1 = new UserInterface.Issues.My_Issue_Page.SolutionAttachmentTemplate();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.solvedByLabel);
            this.panel6.Controls.Add(this.employeeProfilePicAndName1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(2, 368);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.panel6.Size = new System.Drawing.Size(718, 85);
            this.panel6.TabIndex = 1;
            // 
            // solvedByLabel
            // 
            this.solvedByLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.solvedByLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.solvedByLabel.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solvedByLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.solvedByLabel.Location = new System.Drawing.Point(30, 12);
            this.solvedByLabel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.solvedByLabel.Name = "solvedByLabel";
            this.solvedByLabel.Size = new System.Drawing.Size(658, 25);
            this.solvedByLabel.TabIndex = 7;
            this.solvedByLabel.Text = "Solved By";
            this.solvedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // employeeProfilePicAndName1
            // 
            this.employeeProfilePicAndName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.employeeProfilePicAndName1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.employeeProfilePicAndName1.HoverColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Location = new System.Drawing.Point(30, 37);
            this.employeeProfilePicAndName1.Name = "employeeProfilePicAndName1";
            this.employeeProfilePicAndName1.NormalColor = System.Drawing.Color.Empty;
            this.employeeProfilePicAndName1.Size = new System.Drawing.Size(658, 38);
            this.employeeProfilePicAndName1.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.solutionAttachmentTemplate1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(2, 303);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.panel7.Size = new System.Drawing.Size(718, 65);
            this.panel7.TabIndex = 2;
            // 
            // solutionAttachmentTemplate1
            // 
            this.solutionAttachmentTemplate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.solutionAttachmentTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionAttachmentTemplate1.Location = new System.Drawing.Point(30, 10);
            this.solutionAttachmentTemplate1.Name = "solutionAttachmentTemplate1";
            this.solutionAttachmentTemplate1.Size = new System.Drawing.Size(658, 45);
            this.solutionAttachmentTemplate1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(188)))), ((int)(((byte)(201)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(718, 301);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // SolutionTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Name = "SolutionTemplate";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(722, 455);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label solvedByLabel;
        private ViewProject.EmployeeProfilePicAndName employeeProfilePicAndName1;
        private System.Windows.Forms.Panel panel7;
        private SolutionAttachmentTemplate solutionAttachmentTemplate1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
