﻿namespace TeamTracker
{
    partial class MilestoneDropDownForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MilestoneDropDownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(208, 229);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MilestoneDropDownForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MilestoneDropDownForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MilestoneDropDownForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion
    }
}