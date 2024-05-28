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
using UserInterface.Add_Project.Custom_Control;

namespace TeamTracker
{
    public partial class UCViewAllIssue : UserControl
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
        private string SolutionFilePath="";
        private List<Issue> IssueList;
   
        public void InitializePage()
        {
            filterPeople1.InitializeFilter();
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
        }

        private void InitializePageColor()
        {
            filterPeople1.BackColor = tableLayoutPanel1.BackColor = tableLayoutPanel2.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            dataGridView1.BackgroundColor = BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            checkBoxBug.ForeColor = checkBoxFeatureRequest.ForeColor = checkBoxHigh.ForeColor = checkBoxLogicalNeed.ForeColor = checkBoxLow.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            checkBoxMedium.ForeColor = checkBoxOptimization.ForeColor = checkBoxOther.ForeColor = checkBoxSecurity.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            label1.ForeColor = label2.ForeColor = label3.ForeColor = ThemeManager.CurrentTheme.PrimaryI;

            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = ThemeManager.CurrentTheme.PrimaryI,
                ForeColor = ThemeManager.CurrentTheme.SecondaryIII,
                Font = new Font(new FontFamily("Ebrima"), 14, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            dataGridView1.RowsDefaultCellStyle = new DataGridViewCellStyle()
            {
                ForeColor = ThemeManager.CurrentTheme.PrimaryI,
                BackColor = ThemeManager.CurrentTheme.SecondaryIII,
                Font = new Font(new FontFamily("Ebrima"), 12),
                SelectionBackColor = ThemeManager.CurrentTheme.SecondaryII,
                SelectionForeColor = ThemeManager.CurrentTheme.PrimaryI,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
        }

        public UCViewAllIssue()
        {
            InitializeComponent();
            InitializeIssueManager();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
            dataGridView1.AllowUserToAddRows = false;
            SetData();
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
                if (issue.PostedBy != EmployeeManager.CurrentEmployee.EmployeeID)
                    dt.Rows.Add(issue.IssueID, issue.IssueName, issue.IssueDesc, (EmployeeManager.FetchEmployeeFromID(issue.PostedBy)).EmployeeFirstName + " " + (EmployeeManager.FetchEmployeeFromID(issue.PostedBy)).EmployeeLastName, issue.Type + "", issue.Priority + "", issue.PostedDate);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["IssueID"].Visible = false;
            dataGridView1.Columns[1].Width = panelDatagridviewBase.Width * 15 / 100;
            dataGridView1.Columns[2].Width = panelDatagridviewBase.Width * 25 / 100;
            dataGridView1.Columns[3].Width = panelDatagridviewBase.Width * 15 / 100;
            dataGridView1.Columns[4].Width = panelDatagridviewBase.Width * 15 / 100;
            dataGridView1.Columns[5].Width = panelDatagridviewBase.Width * 15 / 100;
            dataGridView1.Columns[6].Width = panelDatagridviewBase.Width * 15 / 100;

            dataGridView1.Columns[1].AutoSizeMode = dataGridView1.Columns[2].AutoSizeMode = dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = dataGridView1.Columns[5].AutoSizeMode = dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                List<string> filters = new List<string>();
                string filter1, filter2="";

                if (selectedEmployee != null)
                {
                    filter2 = "PostedBy = '" + selectedEmployee.EmployeeFirstName + " " + selectedEmployee.EmployeeLastName + "'";
                }

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


                if (filters.Count > 0)
                {
                    filter1 = "(";
                    filter1 += string.Join(" OR ", filters);
                    filter1 += ")";
                    if (selectedEmployee != null)
                        filter1 += " AND " + filter2;
                }
                else
                {
                    filter1 = filter2;
                }
                

                if (!string.IsNullOrEmpty(filter1))
                    dataTable.DefaultView.RowFilter = filter1;
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
                issueInfoForm.IssueInfoFormClose += OnFormClosed;
                transparentForm = new TransparentForm();
                transparentForm.Show();
                transparentForm.ShowForm(issueInfoForm);
            }
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            (sender as IssueInfoForm).Dispose();
            (sender as IssueInfoForm).Close();

            if (ParentForm != null)
                ParentForm.Show();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
            tableLayoutPanel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel2.Width, tableLayoutPanel2.Height, 20, 20));
            filterPeople1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, filterPeople1.Width, filterPeople1.Height, 20, 20));
        }

        private void OnEmployeeSelected(object sender, Employee e)
        {
            selectedEmployee = e;
            OnCheckBoxCheckedChanged(checkBoxBug, EventArgs.Empty);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
            tableLayoutPanel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel2.Width, tableLayoutPanel2.Height, 20, 20));
            filterPeople1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, filterPeople1.Width, filterPeople1.Height, 20, 20));
        }

        private Employee selectedEmployee;

        private void OnLineBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(0, (sender as Label).Height - 1), new Point((sender as Label).Width, (sender as Label).Height - 1));
            border.Dispose();
        }
    }
}
