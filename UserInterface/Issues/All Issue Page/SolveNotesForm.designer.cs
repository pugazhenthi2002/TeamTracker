namespace TeamTracker
{
    partial class SolveNotesForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.NotesTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPost = new System.Windows.Forms.Button();
            this.BoldPicBox = new System.Windows.Forms.PictureBox();
            this.BulletesPicBox = new System.Windows.Forms.PictureBox();
            this.ItalicPicBox = new System.Windows.Forms.PictureBox();
            this.UnderLinePicBox = new System.Windows.Forms.PictureBox();
            this.StrikeOutPicBox = new System.Windows.Forms.PictureBox();
            this.FilesPicBox = new System.Windows.Forms.PictureBox();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoldPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletesPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItalicPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderLinePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrikeOutPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.BottomPanel.Controls.Add(this.tableLayoutPanel2);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 403);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(581, 40);
            this.BottomPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.TopPanel.Controls.Add(this.tableLayoutPanel1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.TopPanel.Size = new System.Drawing.Size(581, 40);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.CloseBtn.Location = new System.Drawing.Point(195, 4);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(189, 32);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Discard";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.OnClickDiscard);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.NotesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NotesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NotesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesTextBox.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTextBox.Location = new System.Drawing.Point(0, 40);
            this.NotesTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(581, 363);
            this.NotesTextBox.TabIndex = 2;
            this.NotesTextBox.Text = "";
            this.NotesTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClickNotesTextBox);
            this.NotesTextBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.BoldPicBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BulletesPicBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItalicPicBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UnderLinePicBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.StrikeOutPicBox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.FilesPicBox, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 37);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.CloseBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonPost, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(581, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.buttonPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPost.FlatAppearance.BorderSize = 0;
            this.buttonPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPost.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.buttonPost.Location = new System.Drawing.Point(388, 4);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(191, 32);
            this.buttonPost.TabIndex = 0;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.OnClickPost);
            // 
            // BoldPicBox
            // 
            this.BoldPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BoldPicBox.Image = global::UserInterface.Properties.Resources.Bold;
            this.BoldPicBox.Location = new System.Drawing.Point(10, 5);
            this.BoldPicBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.BoldPicBox.Name = "BoldPicBox";
            this.BoldPicBox.Size = new System.Drawing.Size(62, 27);
            this.BoldPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoldPicBox.TabIndex = 0;
            this.BoldPicBox.TabStop = false;
            this.BoldPicBox.Click += new System.EventHandler(this.OnClickTextStyle);
            // 
            // BulletesPicBox
            // 
            this.BulletesPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BulletesPicBox.Image = global::UserInterface.Properties.Resources.bullets;
            this.BulletesPicBox.Location = new System.Drawing.Point(338, 5);
            this.BulletesPicBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.BulletesPicBox.Name = "BulletesPicBox";
            this.BulletesPicBox.Size = new System.Drawing.Size(62, 27);
            this.BulletesPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BulletesPicBox.TabIndex = 4;
            this.BulletesPicBox.TabStop = false;
            this.BulletesPicBox.Click += new System.EventHandler(this.OnClickTextStyle);
            // 
            // ItalicPicBox
            // 
            this.ItalicPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItalicPicBox.Image = global::UserInterface.Properties.Resources.italic;
            this.ItalicPicBox.Location = new System.Drawing.Point(92, 5);
            this.ItalicPicBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.ItalicPicBox.Name = "ItalicPicBox";
            this.ItalicPicBox.Size = new System.Drawing.Size(62, 27);
            this.ItalicPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ItalicPicBox.TabIndex = 1;
            this.ItalicPicBox.TabStop = false;
            this.ItalicPicBox.Click += new System.EventHandler(this.OnClickTextStyle);
            // 
            // UnderLinePicBox
            // 
            this.UnderLinePicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnderLinePicBox.Image = global::UserInterface.Properties.Resources.underline;
            this.UnderLinePicBox.Location = new System.Drawing.Point(174, 5);
            this.UnderLinePicBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.UnderLinePicBox.Name = "UnderLinePicBox";
            this.UnderLinePicBox.Size = new System.Drawing.Size(62, 27);
            this.UnderLinePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UnderLinePicBox.TabIndex = 2;
            this.UnderLinePicBox.TabStop = false;
            this.UnderLinePicBox.Click += new System.EventHandler(this.OnClickTextStyle);
            // 
            // StrikeOutPicBox
            // 
            this.StrikeOutPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StrikeOutPicBox.Image = global::UserInterface.Properties.Resources.strikethrough;
            this.StrikeOutPicBox.Location = new System.Drawing.Point(256, 5);
            this.StrikeOutPicBox.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.StrikeOutPicBox.Name = "StrikeOutPicBox";
            this.StrikeOutPicBox.Size = new System.Drawing.Size(62, 27);
            this.StrikeOutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StrikeOutPicBox.TabIndex = 3;
            this.StrikeOutPicBox.TabStop = false;
            this.StrikeOutPicBox.Click += new System.EventHandler(this.OnClickTextStyle);
            // 
            // FilesPicBox
            // 
            this.FilesPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesPicBox.Image = global::UserInterface.Properties.Resources.Attachment_black;
            this.FilesPicBox.Location = new System.Drawing.Point(497, 5);
            this.FilesPicBox.Margin = new System.Windows.Forms.Padding(5);
            this.FilesPicBox.Name = "FilesPicBox";
            this.FilesPicBox.Size = new System.Drawing.Size(79, 27);
            this.FilesPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.FilesPicBox.TabIndex = 4;
            this.FilesPicBox.TabStop = false;
            this.FilesPicBox.Click += new System.EventHandler(this.OnClickAddAttachment);
            this.FilesPicBox.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.FilesPicBox.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // SolveNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(210)))), ((int)(((byte)(217)))));
            this.ClientSize = new System.Drawing.Size(581, 443);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolveNotesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotesForm";
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BoldPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletesPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItalicPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderLinePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StrikeOutPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FilesPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button CloseBtn;
        public System.Windows.Forms.RichTextBox NotesTextBox;
        private System.Windows.Forms.PictureBox BulletesPicBox;
        private System.Windows.Forms.PictureBox StrikeOutPicBox;
        private System.Windows.Forms.PictureBox UnderLinePicBox;
        private System.Windows.Forms.PictureBox ItalicPicBox;
        private System.Windows.Forms.PictureBox BoldPicBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.PictureBox FilesPicBox;
    }
}