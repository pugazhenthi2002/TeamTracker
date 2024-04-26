using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Home_Page.Team_Member
{
    public partial class TeamMemberHome : UserControl
    {
        public TeamMemberHome()
        {
            InitializeComponent();
        }

        public void InitializePage()
        {
            teamMemberReport1.InitializeReport();
            taskContent1.InitializePage();
            notificationContent1.NotifyList = DataHandler.FetchNotification();
        }

        private void teamMemberReport1_Load(object sender, EventArgs e)
        {

            //Issue issue = new Issue()
            //{
            //    IssueName = "testIssue1",
            //    IssueDesc = "test issue descriptin 1",
            //    PostedBy = 2,
            //    PostedDate = DateTime.Today,
            //    Type = Issue.IssueType.Bug,
            //    Priority = Issue.IssuePriority.High,
            //    Tags = new List<string> { "testtag1", "testtag2", "testtag3" }

            //};


            //IssueManager.StoreIssueCollection();
            //IssueManager.AddIssue(issue, null);
            //IssueManager.UpdateIssue(issue, null);

            //IssueManager.FetchMyIssue();
            //IssueManager.FetchIssueByType(Issue.IssueType.Bug);
            //IssueManager.FetchIssueByPriority(Issue.IssuePriority.High);
            //IssueManager.GetIssueById(1);
            //IssueManager.FetchIssueCountByDate(DateTime.Today);

            //IssueSolution soln = new IssueSolution()
            //{
            //    IssueID = issue.IssueID,
            //    Solution = "test solution 1",
            //    SolvedByID = 1
            //};

            //IssueSolution soln2 = new IssueSolution()
            //{
            //    IssueID = issue.IssueID,
            //    Solution = "test solution 2",
            //    SolvedByID = 2
            //};

            //IssueManager.AddSolution(soln, null);
            //IssueManager.AddSolution(soln2, null);

            //IssueManager.RemoveSolution(soln);
            //IssueManager.RemoveAllSolutionOfIssue(issue);

            //IssueManager.RemoveIssue(issue);
        }

        private void teamMemberReport1_Load_1(object sender, EventArgs e)
        {
           
            
        }

        private void OnLoadHome(object sender, EventArgs e)
        {
            
        }
    }
}
