namespace TeamTracker
{
    partial class AddProject
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.initializeButton = new System.Windows.Forms.Button();
            this.versionUpgradeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.projectInitializationPage1 = new TeamTracker.ProjectInitializationPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.versionUpgrade1 = new TeamTracker.VersionUpgrade();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 50);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.initializeButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.versionUpgradeButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1177, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // initializeButton
            // 
            this.initializeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.initializeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.initializeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.initializeButton.FlatAppearance.BorderSize = 0;
            this.initializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initializeButton.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initializeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.initializeButton.Location = new System.Drawing.Point(0, 0);
            this.initializeButton.Margin = new System.Windows.Forms.Padding(0);
            this.initializeButton.Name = "initializeButton";
            this.initializeButton.Size = new System.Drawing.Size(588, 50);
            this.initializeButton.TabIndex = 0;
            this.initializeButton.Text = "Initialize";
            this.initializeButton.UseVisualStyleBackColor = false;
            this.initializeButton.Click += new System.EventHandler(this.OnInitializeClick);
            // 
            // versionUpgradeButton
            // 
            this.versionUpgradeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.versionUpgradeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.versionUpgradeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionUpgradeButton.FlatAppearance.BorderSize = 0;
            this.versionUpgradeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionUpgradeButton.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionUpgradeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.versionUpgradeButton.Location = new System.Drawing.Point(588, 0);
            this.versionUpgradeButton.Margin = new System.Windows.Forms.Padding(0);
            this.versionUpgradeButton.Name = "versionUpgradeButton";
            this.versionUpgradeButton.Size = new System.Drawing.Size(589, 50);
            this.versionUpgradeButton.TabIndex = 1;
            this.versionUpgradeButton.Text = "Version Upgrade";
            this.versionUpgradeButton.UseVisualStyleBackColor = false;
            this.versionUpgradeButton.Click += new System.EventHandler(this.OnVersionUpgradeClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1177, 668);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 668);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.tabPage1.Controls.Add(this.projectInitializationPage1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 50);
            this.tabPage1.Size = new System.Drawing.Size(1169, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // projectInitializationPage1
            // 
            this.projectInitializationPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectInitializationPage1.Location = new System.Drawing.Point(100, 50);
            this.projectInitializationPage1.Name = "projectInitializationPage1";
            this.projectInitializationPage1.Size = new System.Drawing.Size(969, 559);
            this.projectInitializationPage1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.tabPage2.Controls.Add(this.versionUpgrade1);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(100, 50, 100, 50);
            this.tabPage2.Size = new System.Drawing.Size(1169, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // versionUpgrade1
            // 
            this.versionUpgrade1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.versionUpgrade1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.versionUpgrade1.Location = new System.Drawing.Point(100, 50);
            this.versionUpgrade1.Name = "versionUpgrade1";
            this.versionUpgrade1.Size = new System.Drawing.Size(969, 559);
            this.versionUpgrade1.TabIndex = 0;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddProject";
            this.Size = new System.Drawing.Size(1177, 718);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button initializeButton;
        private System.Windows.Forms.Button versionUpgradeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private VersionUpgrade versionUpgrade1;
        private System.Windows.Forms.TabPage tabPage1;
        private ProjectInitializationPage projectInitializationPage1;
    }
}
