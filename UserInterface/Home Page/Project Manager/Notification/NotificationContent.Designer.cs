namespace TeamTracker
{
    partial class NotificationContent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearAllButton = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.PictureBox();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucNotFound1 = new UserInterface.UcNotFound();
            this.panelBase = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 376);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(567, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 376);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.clearAllButton);
            this.panel2.Controls.Add(this.nextBtn);
            this.panel2.Controls.Add(this.backBtn);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 20);
            this.panel2.TabIndex = 4;
            // 
            // clearAllButton
            // 
            this.clearAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.clearAllButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.clearAllButton.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.clearAllButton.Location = new System.Drawing.Point(451, 0);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(96, 20);
            this.clearAllButton.TabIndex = 4;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearAllButton.Click += new System.EventHandler(this.ClearAllButtonClicked);
            this.clearAllButton.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.clearAllButton.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextBtn.Image = global::UserInterface.Properties.Resources.Next_LightBlue;
            this.nextBtn.Location = new System.Drawing.Point(178, 0);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(23, 20);
            this.nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextBtn.TabIndex = 3;
            this.nextBtn.TabStop = false;
            this.nextBtn.Click += new System.EventHandler(this.OnNextClick);
            this.nextBtn.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.nextBtn.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.Image = global::UserInterface.Properties.Resources.Back_Hover;
            this.backBtn.Location = new System.Drawing.Point(155, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(23, 20);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 2;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.OnBackClick);
            this.backBtn.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.backBtn.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notification";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 20);
            this.panel3.TabIndex = 5;
            // 
            // ucNotFound1
            // 
            this.ucNotFound1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ucNotFound1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotFound1.HeadText = "Zero Notifications !!";
            this.ucNotFound1.HeadTextSize = 12;
            this.ucNotFound1.Location = new System.Drawing.Point(20, 20);
            this.ucNotFound1.Message = null;
            this.ucNotFound1.Name = "ucNotFound1";
            this.ucNotFound1.Size = new System.Drawing.Size(547, 336);
            this.ucNotFound1.TabIndex = 6;
            // 
            // panelBase
            // 
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(20, 20);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(547, 336);
            this.panelBase.TabIndex = 7;
            // 
            // NotificationContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.ucNotFound1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "NotificationContent";
            this.Size = new System.Drawing.Size(587, 376);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox nextBtn;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.Label clearAllButton;
        private UserInterface.UcNotFound ucNotFound1;
        private System.Windows.Forms.Panel panelBase;
    }
}
