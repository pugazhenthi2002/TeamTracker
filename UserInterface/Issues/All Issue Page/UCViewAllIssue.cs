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
    public partial class UCViewAllIssue : UserControl
    {
        private DataTable dataTable = new DataTable();
        private string SolutionFilePath="";
        private List<Issue> IssueList;
   

        public UCViewAllIssue()
        {
            InitializeComponent();
            InitializeIssueManager();
            dataGridView1.AllowUserToAddRows = false;
            SetData();

            //IssueManager.StoreIssueCollection();
            //IssueList = IssueManager.IssueCollection;

            //dataTable.Columns.Add("Title", typeof(string));
            //dataTable.Columns.Add("Description", typeof(string));
            //dataTable.Columns.Add("Priority", typeof(string));
            //dataTable.Columns.Add("Type", typeof(string));
            //dataTable.Columns.Add("Date", typeof(DateTime));
            //dataTable.Columns.Add("Posted By", typeof(string));


            //dataTable.Rows.Add("Title 1", "Description 1", "High", "Bug", DateTime.Now, "User A");
            //dataTable.Rows.Add("Title 2", "Description 2", "Medium", "Feature Request", DateTime.Now.AddDays(-1), "User B");
            //dataTable.Rows.Add("Title 3", "Description 3", "Low", "Optimization", DateTime.Now.AddDays(-2), "User C");
            //dataTable.Rows.Add("Title 4", "Description 4", "High", "Security", DateTime.Now.AddDays(-2), "User D");
            //dataTable.Rows.Add("Title 5", "Description 5", "Low", "Optimization", DateTime.Now.AddDays(-5), "User E");
            //dataTable.Rows.Add("Title 6", "Description 6", "Medium", "Other", DateTime.Now.AddDays(-9), "User F");

            //dataGridView1.DataSource = dataTable;

            //DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            //buttonColumn.HeaderText = "Solve";
            //buttonColumn.Name = "SolveButtonCol";
            ////buttonColumn.Text = "Add solution";
            //buttonColumn.FlatStyle = FlatStyle.Flat;
            //dataGridView1.Columns.Add(buttonColumn);
            //dataGridView1.AllowUserToAddRows = false;


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

        private void SetData()
        {
            IssueList = IssueManager.IssueCollection;

            DataTable dt = new DataTable();

            dt.Columns.Add("IssueID", typeof(int));
            dt.Columns.Add("IssueName", typeof(string));
            dt.Columns.Add("IssueDesc", typeof(string));
            dt.Columns.Add("PostedBy", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Priority", typeof(string));
            dt.Columns.Add("PostedDate", typeof(DateTime));

            foreach (var issue in IssueList)
            {
                dt.Rows.Add(issue.IssueID,issue.IssueName, issue.IssueDesc, (EmployeeManager.FetchEmployeeFromID(issue.PostedBy)).EmployeeFirstName, issue.Type + "", issue.Priority + "", issue.PostedDate);
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

        private void DataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "SolveButtonCol" && e.RowIndex >= 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Title = "Open File";
                openFileDialog.InitialDirectory = @"C:\";

                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SolutionFilePath = openFileDialog.FileName;

                    string[] seperatedPath = SolutionFilePath.Split('\\');


                    if(dataGridView1.CurrentCell is DataGridViewButtonCell)
                    {
                        (dataGridView1.CurrentCell as DataGridViewButtonCell).Style.BackColor = Color.Green;
                        (dataGridView1.CurrentCell as DataGridViewButtonCell).Value = "Solved";
                    }
                    //dataGridView1.Columns[e.ColumnIndex]

                }
            }
        }

        private void OnKeyDownDatagridview(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void AddData(string title, string desc, string priority, string type, DateTime date, string postedBy)
        {
            dataTable.Rows.Add(title,desc,priority,type,date, postedBy);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            
        }

        private void OnDoubleClickCell(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = -1;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                if (column.HeaderText == "IssueID")
                {
                    columnIndex = column.Index;
                    break;
                }
            }
            if (e.RowIndex != -1)
            {
                int issueID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[columnIndex].Value);

                IssueInfoForm issueInfoForm = new IssueInfoForm();
                issueInfoForm.IssueData = IssueManager.GetIssueById(issueID);

                issueInfoForm.Show();
            }
            
        }
    }
}
