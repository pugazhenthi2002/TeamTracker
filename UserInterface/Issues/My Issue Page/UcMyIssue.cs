using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using UserInterface;
using UserInterface.Issues.My_Issue_Page;

namespace TeamTracker
{
    public partial class UcMyIssue : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,     // x-coordinate of upper-left corner
          int nTopRect,      // y-coordinate of upper-left corner
          int nRightRect,    // x-coordinate of lower-right corner
          int nBottomRect,   // y-coordinate of lower-right corner
          int nWidthEllipse, // height of ellipse
          int nHeightEllipse // width of ellipse
      );

        private TransparentForm transparentForm;
        private DataTable dataTable = new DataTable();
        private Form CreateIssueForm;
        private UCCreateIssue ucCreate;
        private List<Issue> MyIssueList;
        private int ClickedRow = -1;

        public UcMyIssue()
        {
            InitializeComponent();
            InitializeIssueManager();
            dataGridView1.AllowUserToAddRows = false;
            SetData();
        }

        private void SetData()
        {
            MyIssueList = IssueManager.FetchMyIssue();
            DataTable dt = new DataTable();

            dt.Columns.Add("IssueID", typeof(int));
            dt.Columns.Add("IssueName", typeof(string));
            dt.Columns.Add("IssueDesc", typeof(string));
            dt.Columns.Add("PostedBy", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Priority", typeof(string));
            dt.Columns.Add("PostedDate", typeof(DateTime));

            foreach (var issue in MyIssueList)
            {
                dt.Rows.Add(issue.IssueID, issue.IssueName, issue.IssueDesc, (EmployeeManager.FetchEmployeeFromID(issue.PostedBy)).EmployeeFirstName, issue.Type + "", issue.Priority + "", issue.PostedDate);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["IssueID"].Visible = false;
            dataGridView1.Columns[1].Width = panelDatagridviewBase.Width * 15 / 100;
            dataGridView1.Columns[2].Width = panelDatagridviewBase.Width * 25 / 100;
            dataGridView1.Columns[3].Width = panelDatagridviewBase.Width * 15 / 100;
            dataGridView1.Columns[4].Width = panelDatagridviewBase.Width * 15 / 100;
            dataGridView1.Columns[5].Width = panelDatagridviewBase.Width * 15 / 100;
            dataGridView1.Columns[6].Width = panelDatagridviewBase.Width * 15 / 100;
        }

        private void InitializeIssueManager()
        {
            IssueManager.IssueAdded += IssueManagerIssueAdded;
            IssueManager.IssueUpdated += IssueManagerIssueUpdated;
            IssueManager.IssueRemoved += IssueManagerIssueRemoved;
        }

        private void IssueManagerIssueRemoved(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SetData();
        }

        private void IssueManagerIssueAdded(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SetData();
        }

        private void IssueManagerIssueUpdated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            SetData();
        }

        private void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                List<string> filters = new List<string>();


                //for Priority
                if (checkBoxHigh.Checked)
                    filters.Add("Priority = 'High'");
                if (checkBoxMedium.Checked)
                    filters.Add("Priority = 'Medium'");
                if (checkBoxLow.Checked)
                    filters.Add("Priority = 'Low'");


                //for type
                if (checkBoxBug.Checked)
                    filters.Add("Type = 'Bug'");
                if (checkBoxFeatureRequest.Checked)
                    filters.Add("Type = 'FeatureRequest'");
                if (checkBoxOptimization.Checked)
                    filters.Add("Type = 'Optimization'");
                if (checkBoxSecurity.Checked)
                    filters.Add("Type = 'Security'");
                if (checkBoxLogicalNeed.Checked)
                    filters.Add("Type = 'LogicalNeed'");
                if (checkBoxOther.Checked)
                    filters.Add("Type = 'Other'");

                string filter = string.Join(" OR ", filters);

                if (!string.IsNullOrEmpty(filter))
                    dataTable.DefaultView.RowFilter = filter;
                else
                    dataTable.DefaultView.RowFilter = "";
            }
        }

        private void OnKeyDownDatagridview(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                OnClickDeleteIssue(sender, e);
            }
        }

        private void OnClickCreateIssue(object sender, EventArgs e)
        {
            CreateIssueForm = new Form();
            CreateIssueForm.StartPosition = FormStartPosition.CenterScreen;
            CreateIssueForm.FormBorderStyle = FormBorderStyle.None;
            CreateIssueForm.Size = new Size(650, 450);


            ucCreate = new UCCreateIssue();
            ucCreate.Dock = DockStyle.Fill;
            ucCreate.DiscardClick += OnClickDiscardIssue;
            ucCreate.PostClick += OnClickPostIssue;

            if (sender is int)
            {
                ucCreate.IssueData = IssueManager.GetIssueById(Convert.ToInt32(sender));
            }

            CreateIssueForm.Controls.Add(ucCreate);

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(CreateIssueForm);

        }

        private void OnClickDiscardIssue(object sender, EventArgs e)
        {
            (sender as Form).Close();

            if (ParentForm != null)
                ParentForm.Show();
        }

        private void OnClickPostIssue(object sender, EventArgs e)
        {
            (sender as Form).Dispose();
            (sender as Form).Close();

            if (ParentForm != null)
                ParentForm.Show();
        }

        private void OnClickDeleteIssue(object sender, EventArgs e)
        {
            List<int> rowsToRemove = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    rowsToRemove.Add(row.Index);
                }
            }


            for (int ctr = 0; ctr < rowsToRemove.Count; ctr++)
            {
                int row = rowsToRemove[ctr];
                int issueID = Convert.ToInt32(dataGridView1["IssueID", row - ctr].Value);
                IssueManager.RemoveIssue(IssueManager.GetIssueById(issueID));
            }
        }

        private void OnDoubleClickCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int issueID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IssueID"].Value);

                OnClickCreateIssue(issueID, e);
                //ucCreate.IssueData = IssueManager.GetIssueById(issueID);
            }
        }

        private void DataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuFormMyIssue menuForm = new MenuFormMyIssue();
                menuForm.Location = Control.MousePosition;
                menuForm.EditClick += OnClickEditIssue;
                menuForm.ViewSolutionClick += OnClickviewSolution;
                menuForm.Show();

                ClickedRow = e.RowIndex;
            }
        }

        private void OnClickviewSolution(object sender, EventArgs e)
        {
            ViewSolutionForm form = new ViewSolutionForm();
            form.IssueSolutionCollection = IssueManager.FetchSolutionForIssue(Convert.ToInt32(dataGridView1.Rows[ClickedRow].Cells["IssueID"].Value));
            form.SolutionFormClose += OnSolutionFormClosed;

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(form);
        }

        private void OnSolutionFormClosed(object sender, EventArgs e)
        {
            (sender as ViewSolutionForm).Dispose();
            (sender as ViewSolutionForm).Close();

            if (ParentForm != null)
                ParentForm.Show();
        }

        private void OnClickEditIssue(object sender, EventArgs e)
        {
            OnClickCreateIssue(Convert.ToInt32(dataGridView1.Rows[ClickedRow].Cells["IssueID"].Value), e);
        }

        private void OnLineBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(Color.FromArgb(39, 55, 77), 2);
            e.Graphics.DrawLine(border, new Point(0, (sender as Control).Height - 1), new Point((sender as Control).Width, (sender as Control).Height - 1));
            border.Dispose();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
            tableLayoutPanel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel2.Width, tableLayoutPanel2.Height, 20, 20));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
            tableLayoutPanel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel2.Width, tableLayoutPanel2.Height, 20, 20));
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(201, 210, 217);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.FromArgb(221, 230, 237);
        }
    }
}
