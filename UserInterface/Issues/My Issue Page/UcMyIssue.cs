using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class UcMyIssue : UserControl
    {
        private DataTable dataTable = new DataTable();
        private Form CreateIssueForm;
        private UCCreateIssue ucCreate;
        private List<Issue> MyIssueList ;

        public UcMyIssue()
        {
            InitializeComponent();
            InitializeIssueManager();
            dataGridView1.AllowUserToAddRows = false;

            SetData();

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Solution";
            buttonColumn.Text = "Click To view Solutions";
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.FlatStyle = FlatStyle.Flat;
            buttonColumn.DefaultCellStyle.BackColor = Color.FromArgb(157, 178, 191);

            dataGridView1.Columns.Add(buttonColumn);

            dataGridView1.CellClick += DataGridViewCellClick;

        }

        private void DataGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                string issueID = dataGridView1["IssueID", rowIndex].Value.ToString();
                MessageBox.Show($"Button clicked for IssueID: {issueID}");
            }
        }

        private void SetData()
        {
            MyIssueList = IssueManager.FetchMyIssue();
            DataTable dt = new DataTable();

            dt.Columns.Add("IssueID", typeof(int));
            dt.Columns.Add("IssueName", typeof(string));
            dt.Columns.Add("IssueDesc", typeof(string));
            dt.Columns.Add("PostedBy", typeof(int));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Priority", typeof(string));
            dt.Columns.Add("PostedDate", typeof(DateTime));

            foreach (var issue in MyIssueList)
            {
                dt.Rows.Add(issue.IssueID, issue.IssueName, issue.IssueDesc, issue.PostedBy, issue.Type + "", issue.Priority + "", issue.PostedDate);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["IssueID"].Visible = false;
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
                    filters.Add("Type = 'Feature Request'");
                if (checkBoxOptimization.Checked)
                    filters.Add("Type = 'Optimization'");
                if (checkBoxSecurity.Checked)
                    filters.Add("Type = 'Security'");
                if (checkBoxLogicalNeed.Checked)
                    filters.Add("Type = 'Logical Need'");
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
            ucCreate.PostClick+= OnClickPostIssue;
            
            if(sender is int)
            {
                ucCreate.IssueData = IssueManager.GetIssueById(Convert.ToInt32(sender));
            }


            CreateIssueForm.Controls.Add(ucCreate);
            CreateIssueForm.ShowDialog();
        }

        private void OnClickDiscardIssue(object sender, EventArgs e)
        {
            //CreateIssueForm.Dispose();
            CreateIssueForm.Close();
        }

        private void OnClickPostIssue(object sender, EventArgs e)
        {
            
            //CreateIssueForm.Dispose();
            CreateIssueForm.Close();
        }

        private void OnClickDeleteIssue(object sender, EventArgs e)
        {

            List<int> rowsToRemove = new List<int> ();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    rowsToRemove.Add(row.Index);
                }
            }


            for (int ctr = 0;ctr<rowsToRemove.Count;ctr++)
            {
                int row = rowsToRemove[ctr];
                int issueID = Convert.ToInt32(dataGridView1["IssueID", row-ctr].Value);
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
    }
}
