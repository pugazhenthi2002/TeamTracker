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
            
            SetData();

        }

        private void SetData()
        {
            MyIssueList = IssueManager.FetchMyIssue();
            DataTable dt = new DataTable();

            dt.Columns.Add("IssueName", typeof(string));
            dt.Columns.Add("IssueDesc", typeof(string));
            dt.Columns.Add("PostedBy", typeof(int));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Priority", typeof(string));
            dt.Columns.Add("PostedDate", typeof(DateTime));

            foreach (var issue in MyIssueList)
            {
                dt.Rows.Add(issue.IssueName, issue.IssueDesc, issue.PostedBy, issue.Type + "", issue.Priority + "", issue.PostedDate);
            }

            dataGridView1.DataSource = dt;
        }

        private void InitializeIssueManager()
        {
            // Subscribe to the IssuesChanged event
            IssueManager.IssuesChanged += IssueManager_IssuesChanged;
        }

        private void IssueManager_IssuesChanged(object sender, EventArgs e)
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
            CreateIssueForm.Size = new Size(700, 600);


            ucCreate = new UCCreateIssue();
            ucCreate.Dock = DockStyle.Fill;
            ucCreate.DiscardClick += OnClickDiscardIssue;
            ucCreate.PostClick+= OnClickPostIssue;

            CreateIssueForm.Controls.Add(ucCreate);
            CreateIssueForm.ShowDialog();
        }

        private void OnClickDiscardIssue(object sender, EventArgs e)
        {
            CreateIssueForm.Dispose();
        }

        private void OnClickPostIssue(object sender, EventArgs e)
        {
            
            CreateIssueForm.Dispose();
        }

        private void OnClickDeleteIssue(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow) 
                {
                    dataGridView1.Rows.Remove(row);

                    int issueID = Convert.ToInt32(row.Cells["IssueID"].Value);
                    IssueManager.RemoveIssue(IssueManager.GetIssueById(issueID));
                }
                
            }
        }
    }
}
