namespace TeamTracker
{
    partial class ProjectManagerMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManagerMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.viewProjectLabel = new System.Windows.Forms.Label();
            this.viewProjectPictureBox = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.addProjectLabel = new System.Windows.Forms.Label();
            this.addProjectPictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.profilePicAndName1 = new TeamTracker.ProfilePicAndName();
            this.closePicBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.projectManagerHome1 = new UserInterface.Home_Page.Project_Manager.ProjectManagerHome();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addProject1 = new TeamTracker.AddProject();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.viewProjectTemplate1 = new UserInterface.ViewProject.ViewProjectTemplate();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewProjectPictureBox)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addProjectPictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePicBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 645);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 595);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.viewProjectLabel);
            this.panel6.Controls.Add(this.viewProjectPictureBox);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 50);
            this.panel6.TabIndex = 2;
            // 
            // viewProjectLabel
            // 
            this.viewProjectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewProjectLabel.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewProjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.viewProjectLabel.Location = new System.Drawing.Point(67, 0);
            this.viewProjectLabel.Margin = new System.Windows.Forms.Padding(0);
            this.viewProjectLabel.Name = "viewProjectLabel";
            this.viewProjectLabel.Size = new System.Drawing.Size(183, 50);
            this.viewProjectLabel.TabIndex = 2;
            this.viewProjectLabel.Text = "View Project";
            this.viewProjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewProjectLabel.Click += new System.EventHandler(this.OnViewProjectClicked);
            this.viewProjectLabel.MouseEnter += new System.EventHandler(this.OnNavMouseEnter);
            this.viewProjectLabel.MouseLeave += new System.EventHandler(this.OnNavMouseLeave);
            // 
            // viewProjectPictureBox
            // 
            this.viewProjectPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.viewProjectPictureBox.Image = global::UserInterface.Properties.Resources.View_Project;
            this.viewProjectPictureBox.Location = new System.Drawing.Point(0, 0);
            this.viewProjectPictureBox.Name = "viewProjectPictureBox";
            this.viewProjectPictureBox.Size = new System.Drawing.Size(67, 50);
            this.viewProjectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.viewProjectPictureBox.TabIndex = 1;
            this.viewProjectPictureBox.TabStop = false;
            this.viewProjectPictureBox.Click += new System.EventHandler(this.OnViewProjectClicked);
            this.viewProjectPictureBox.MouseEnter += new System.EventHandler(this.OnNavMouseEnter);
            this.viewProjectPictureBox.MouseLeave += new System.EventHandler(this.OnNavMouseLeave);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.addProjectLabel);
            this.panel5.Controls.Add(this.addProjectPictureBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 50);
            this.panel5.TabIndex = 1;
            // 
            // addProjectLabel
            // 
            this.addProjectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProjectLabel.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.addProjectLabel.Location = new System.Drawing.Point(67, 0);
            this.addProjectLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addProjectLabel.Name = "addProjectLabel";
            this.addProjectLabel.Size = new System.Drawing.Size(183, 50);
            this.addProjectLabel.TabIndex = 2;
            this.addProjectLabel.Text = "Add Project";
            this.addProjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addProjectLabel.Click += new System.EventHandler(this.OnAddProjectClicked);
            this.addProjectLabel.MouseEnter += new System.EventHandler(this.OnNavMouseEnter);
            this.addProjectLabel.MouseLeave += new System.EventHandler(this.OnNavMouseLeave);
            // 
            // addProjectPictureBox
            // 
            this.addProjectPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.addProjectPictureBox.Image = global::UserInterface.Properties.Resources.Add_Project;
            this.addProjectPictureBox.Location = new System.Drawing.Point(0, 0);
            this.addProjectPictureBox.Name = "addProjectPictureBox";
            this.addProjectPictureBox.Size = new System.Drawing.Size(67, 50);
            this.addProjectPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.addProjectPictureBox.TabIndex = 1;
            this.addProjectPictureBox.TabStop = false;
            this.addProjectPictureBox.Click += new System.EventHandler(this.OnAddProjectClicked);
            this.addProjectPictureBox.MouseEnter += new System.EventHandler(this.OnNavMouseEnter);
            this.addProjectPictureBox.MouseLeave += new System.EventHandler(this.OnNavMouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.homeLabel);
            this.panel4.Controls.Add(this.homePictureBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 50);
            this.panel4.TabIndex = 0;
            // 
            // homeLabel
            // 
            this.homeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeLabel.Font = new System.Drawing.Font("Corbel", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.homeLabel.Location = new System.Drawing.Point(67, 0);
            this.homeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(183, 50);
            this.homeLabel.TabIndex = 1;
            this.homeLabel.Text = "Home";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLabel.Click += new System.EventHandler(this.OnHomeClicked);
            this.homeLabel.MouseEnter += new System.EventHandler(this.OnNavMouseEnter);
            this.homeLabel.MouseLeave += new System.EventHandler(this.OnNavMouseLeave);
            // 
            // homePictureBox
            // 
            this.homePictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.homePictureBox.Image = global::UserInterface.Properties.Resources.Home_Normal;
            this.homePictureBox.Location = new System.Drawing.Point(0, 0);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(67, 50);
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.homePictureBox.TabIndex = 0;
            this.homePictureBox.TabStop = false;
            this.homePictureBox.Click += new System.EventHandler(this.OnHomeClicked);
            this.homePictureBox.MouseEnter += new System.EventHandler(this.OnNavMouseEnter);
            this.homePictureBox.MouseLeave += new System.EventHandler(this.OnNavMouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.headerPanel.Controls.Add(this.profilePicAndName1);
            this.headerPanel.Controls.Add(this.closePicBox);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(250, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(945, 51);
            this.headerPanel.TabIndex = 1;
            // 
            // profilePicAndName1
            // 
            this.profilePicAndName1.BackColor = System.Drawing.Color.Transparent;
            this.profilePicAndName1.Dock = System.Windows.Forms.DockStyle.Right;
            this.profilePicAndName1.EmployeeProfile = null;
            this.profilePicAndName1.Location = new System.Drawing.Point(671, 0);
            this.profilePicAndName1.Margin = new System.Windows.Forms.Padding(2);
            this.profilePicAndName1.Name = "profilePicAndName1";
            this.profilePicAndName1.Padding = new System.Windows.Forms.Padding(3);
            this.profilePicAndName1.Size = new System.Drawing.Size(218, 51);
            this.profilePicAndName1.TabIndex = 1;
            // 
            // closePicBox
            // 
            this.closePicBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.closePicBox.Image = global::UserInterface.Properties.Resources.Close;
            this.closePicBox.Location = new System.Drawing.Point(889, 0);
            this.closePicBox.Name = "closePicBox";
            this.closePicBox.Size = new System.Drawing.Size(56, 51);
            this.closePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closePicBox.TabIndex = 0;
            this.closePicBox.TabStop = false;
            this.closePicBox.Click += new System.EventHandler(this.OnCloseClick);
            this.closePicBox.MouseEnter += new System.EventHandler(this.OnCloseMouseEnter);
            this.closePicBox.MouseLeave += new System.EventHandler(this.OnCloseMouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(250, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 594);
            this.panel3.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 594);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.projectManagerHome1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 566);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // projectManagerHome1
            // 
            this.projectManagerHome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.projectManagerHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectManagerHome1.Location = new System.Drawing.Point(3, 3);
            this.projectManagerHome1.Name = "projectManagerHome1";
            this.projectManagerHome1.Size = new System.Drawing.Size(931, 560);
            this.projectManagerHome1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addProject1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // addProject1
            // 
            this.addProject1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addProject1.Location = new System.Drawing.Point(3, 3);
            this.addProject1.Name = "addProject1";
            this.addProject1.Size = new System.Drawing.Size(931, 560);
            this.addProject1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.viewProjectTemplate1);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(937, 585);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // viewProjectTemplate1
            // 
            this.viewProjectTemplate1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.viewProjectTemplate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewProjectTemplate1.Location = new System.Drawing.Point(0, 0);
            this.viewProjectTemplate1.Name = "viewProjectTemplate1";
            this.viewProjectTemplate1.Size = new System.Drawing.Size(937, 585);
            this.viewProjectTemplate1.TabIndex = 0;
            // 
            // ProjectManagerMainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1195, 645);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectManagerMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewProjectPictureBox)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addProjectPictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePicBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox closePicBox;
        private System.Windows.Forms.Panel panel3;
        private ProfilePicAndName profilePicAndName1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label viewProjectLabel;
        private System.Windows.Forms.PictureBox viewProjectPictureBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label addProjectLabel;
        private System.Windows.Forms.PictureBox addProjectPictureBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.PictureBox homePictureBox;
        private UserInterface.Home_Page.Project_Manager.ProjectManagerHome projectManagerHome1;
        private AddProject addProject1;
        private UserInterface.ViewProject.ViewProjectTemplate viewProjectTemplate1;
    }
}