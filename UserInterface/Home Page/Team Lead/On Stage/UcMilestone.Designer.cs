namespace TeamTracker
{
    partial class UcMilestone
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
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.ucDueDate1 = new UserInterface.ViewPage.BoardView.UcDueDate();
            this.animatedLabelMilestoneName = new TeamTracker.AnimatedLabel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxClose, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ucDueDate1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.animatedLabelMilestoneName, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxClose.Image = global::UserInterface.Properties.Resources.Close;
            this.pictureBoxClose.Location = new System.Drawing.Point(263, 8);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(30, 29);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 0;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.OnClickClose);
            this.pictureBoxClose.MouseEnter += new System.EventHandler(this.OnMouseEnterClose);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.OnMouseLeaveClose);
            // 
            // ucDueDate1
            // 
            this.ucDueDate1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.ucDueDate1.CenterLabelText = null;
            this.ucDueDate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDueDate1.DueDate = new System.DateTime(2024, 4, 11, 0, 0, 0, 0);
            this.ucDueDate1.DueLabelcolor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.ucDueDate1.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucDueDate1.LabelText = "Due";
            this.ucDueDate1.Location = new System.Drawing.Point(138, 3);
            this.ucDueDate1.Name = "ucDueDate1";
            this.ucDueDate1.Size = new System.Drawing.Size(114, 39);
            this.ucDueDate1.TabIndex = 1;
            // 
            // animatedLabelMilestoneName
            // 
            this.animatedLabelMilestoneName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(109)))), ((int)(((byte)(130)))));
            this.animatedLabelMilestoneName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animatedLabelMilestoneName.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatedLabelMilestoneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.animatedLabelMilestoneName.LabelCornerColor = System.Drawing.Color.Empty;
            this.animatedLabelMilestoneName.Location = new System.Drawing.Point(7, 7);
            this.animatedLabelMilestoneName.Margin = new System.Windows.Forms.Padding(7);
            this.animatedLabelMilestoneName.Name = "animatedLabelMilestoneName";
            this.animatedLabelMilestoneName.Size = new System.Drawing.Size(121, 31);
            this.animatedLabelMilestoneName.TabIndex = 2;
            this.animatedLabelMilestoneName.Text = "Milestone Name";
            this.animatedLabelMilestoneName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UcMilestone
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UcMilestone";
            this.Size = new System.Drawing.Size(301, 45);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private UserInterface.ViewPage.BoardView.UcDueDate ucDueDate1;
        private AnimatedLabel animatedLabelMilestoneName;
    }
}
