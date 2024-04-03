﻿namespace TeamTracker
{
    partial class UcDeploy
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.profilePicAndNameSquare1 = new TeamTracker.ProfilePicAndNameSquare();
            this.BtnDeploy = new TeamTracker.RippleButton();
            this.downloadBtn1 = new TeamTracker.DownloadBtn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnDeploy, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.downloadBtn1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 288);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.profilePicAndNameSquare1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(448, 144);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DateLabel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelProjectName, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(214, 134);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // DateLabel
            // 
            this.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateLabel.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.DateLabel.Location = new System.Drawing.Point(3, 67);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(208, 67);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Version";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProjectName
            // 
            this.labelProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProjectName.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProjectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.labelProjectName.Location = new System.Drawing.Point(3, 0);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(208, 67);
            this.labelProjectName.TabIndex = 0;
            this.labelProjectName.Text = "Project Name";
            this.labelProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profilePicAndNameSquare1
            // 
            this.profilePicAndNameSquare1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.profilePicAndNameSquare1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePicAndNameSquare1.Location = new System.Drawing.Point(229, 5);
            this.profilePicAndNameSquare1.Margin = new System.Windows.Forms.Padding(5);
            this.profilePicAndNameSquare1.Name = "profilePicAndNameSquare1";
            this.profilePicAndNameSquare1.Size = new System.Drawing.Size(214, 134);
            this.profilePicAndNameSquare1.TabIndex = 1;
            // 
            // BtnDeploy
            // 
            this.BtnDeploy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDeploy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.BtnDeploy.FlatAppearance.BorderSize = 0;
            this.BtnDeploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeploy.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeploy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnDeploy.Location = new System.Drawing.Point(130, 242);
            this.BtnDeploy.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDeploy.Name = "BtnDeploy";
            this.BtnDeploy.Size = new System.Drawing.Size(187, 34);
            this.BtnDeploy.TabIndex = 1;
            this.BtnDeploy.Text = "Deploy";
            this.BtnDeploy.UseVisualStyleBackColor = false;
            this.BtnDeploy.Click += new System.EventHandler(this.OnDeployClick);
            // 
            // downloadBtn1
            // 
            this.downloadBtn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.downloadBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.downloadBtn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.downloadBtn1.Location = new System.Drawing.Point(51, 162);
            this.downloadBtn1.Name = "downloadBtn1";
            this.downloadBtn1.Size = new System.Drawing.Size(346, 50);
            this.downloadBtn1.TabIndex = 2;
            this.downloadBtn1.Download += new System.EventHandler(this.OnDownloaded);
            // 
            // UcDeploy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcDeploy";
            this.Size = new System.Drawing.Size(448, 288);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label labelProjectName;
        private TeamTracker.RippleButton BtnDeploy;
        private ProfilePicAndNameSquare profilePicAndNameSquare1;
        private DownloadBtn downloadBtn1;
    }
}
