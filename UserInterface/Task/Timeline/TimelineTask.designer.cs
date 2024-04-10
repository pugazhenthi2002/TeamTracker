using System;

namespace TeamTracker
{
    partial class TimelineTask
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.edgeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 54);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 3, 15, 0);
            this.label1.Size = new System.Drawing.Size(412, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "TaskName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Paint += new System.Windows.Forms.PaintEventHandler(this.SliderPanelPaint);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.label1.MouseEnter += new System.EventHandler(this.OnTimelineTaskMouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.OnTimelineTaskMouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.label1.Resize += new System.EventHandler(this.OnResize);
            // 
            // edgeTimer
            // 
            this.edgeTimer.Interval = 2000;
            this.edgeTimer.Tick += new System.EventHandler(this.OnEdgeTick);
            // 
            // TimelineTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panel1);
            this.Name = "TimelineTask";
            this.Size = new System.Drawing.Size(412, 54);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer edgeTimer;
    }
}
