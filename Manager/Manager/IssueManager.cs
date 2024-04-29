using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoLibrary;


namespace TeamTracker
{
    public static class IssueManager
    {
        public static List<Issue> IssueCollection = new List<Issue>();
        public static List<IssueSolution> IssueSolutionCollection = new List<IssueSolution>();
        public static event EventHandler IssueUpdated;
        public static event EventHandler IssueAdded;
        public static event EventHandler IssueRemoved;
        

        public static BooleanMsg StoreIssueCollection()
        {
            IssueCollection = DataHandler.StoreIssueDetails();
            IssueSolutionCollection = DataHandler.StoreIssueSolutionDetails();

            if (IssueCollection == null) return "Couldn't able to Connect Task Collection";
            else if (IssueSolutionCollection == null) return "Couldn't able to connect solution collection";
            else return true;
        }

        //Add's the issue and its attachment
        public static void AddIssue(Issue issue, IssueAttachment attachment)
        {
            DataHandler.AddIssue(issue);
            IssueCollection.Add(issue);

            if (attachment != null)
            {
                attachment.IssueID = issue.IssueID;
                DataHandler.AddIssueAttachment(attachment);
            }
            OnIssueAdded(EventArgs.Empty);


        }

        private static void OnIssueUpdated(EventArgs e)
        {
            IssueUpdated?.Invoke(null, e);
        }
        private static void OnIssueAdded(EventArgs e)
        {
            IssueAdded?.Invoke(null, e);
        }
        private static void OnIssueRemoved(EventArgs e)
        {
            IssueRemoved?.Invoke(null, e);
        }


        public static List<Issue> GetIssueCollection()
        {
            return IssueCollection;
        }

        public static List<IssueSolution> GetIssueSolution()
        {
            return IssueSolutionCollection;
        }

        //updates the issuedetails with its attachement
        public static void UpdateIssue(Issue issue,IssueAttachment attachment)
        {

            for(int ctr = 0;ctr<IssueCollection.Count;ctr++)
            {
                if (issue.IssueID == IssueCollection[ctr].IssueID)
                {
                    DataHandler.UpdateIssue(issue);
                    IssueCollection[ctr] = issue;
                }
            }
            if (attachment != null) DataHandler.UpdateIssueAttachment(issue.IssueID, attachment);
            OnIssueUpdated(EventArgs.Empty);
        }

        //removes the entire issue
        public static void RemoveIssue(Issue issue)
        {

            for(int ctr = 0;ctr<IssueCollection.Count;ctr++)
            {
                if (issue.IssueID == IssueCollection[ctr].IssueID)
                {
                    DataHandler.RemoveIssue(issue);
                    DataHandler.RemoveIssueAttachment(issue);

                    RemoveAllSolutionOfIssue(IssueCollection[ctr]);
                    IssueCollection.Remove(issue);
                }
            }
            OnIssueRemoved(EventArgs.Empty);
        }

        //returns the issue posted by the current user
        public static List<Issue> FetchMyIssue()
        {
            List<Issue> myIssue = new List<Issue>();

            foreach(Issue ctr in IssueCollection)
            {
                if(ctr.PostedBy == EmployeeManager.CurrentEmployee.EmployeeID)
                {
                    myIssue.Add(ctr);
                }
            }

            return myIssue;
        }

        //return the issues according to the type
        public static List<Issue> FetchIssueByType(Issue.IssueType type)
        {
            List<Issue> issueList = new List<Issue>();

            foreach (Issue ctr in IssueCollection)
            {
                if (ctr.Type == type)
                {
                    issueList.Add(ctr);
                }
            }

            return issueList;
        }

        //returns the issue according to its priority
        public static List<Issue> FetchIssueByPriority(Issue.IssuePriority priority)
        {
            List<Issue> issueList = new List<Issue>();

            foreach (Issue ctr in IssueCollection)
            {
                if (ctr.Priority == priority)
                {
                    issueList.Add(ctr);
                }
            }

            return issueList;
        }

        //fetches the issue by its id
        public static Issue GetIssueById(int id)
        {
            foreach (Issue ctr in IssueCollection)
            {
                if (ctr.IssueID == id)
                {
                    return ctr;
                }
            }

            return null;
        }

        //returns the count of issue on particular date
        public static int FetchIssueCountByDate(DateTime date)
        {
            int count = 0;
            foreach (Issue ctr in IssueCollection)
            {
                if (ctr.PostedDate == date)
                {
                    count++;
                }
            }

            return count;
        }

        public static void AddSolution(IssueSolution issueSoln, IssueSolutionAttachment attachment)
        {
            DataHandler.AddIssueSolution(issueSoln);
            IssueSolutionCollection.Add(issueSoln);
            if (attachment != null)
            {
                attachment.IssueSolutionID = issueSoln.IssueID;
                DataHandler.AddIssueSolutionAttachment(attachment);
            }
        }

        public static List<IssueSolution> FetchSolutionForIssue(int id)
        {
            List<IssueSolution> result = new List<IssueSolution>();

            foreach(var Iter in IssueSolutionCollection)
            {
                if(Iter.IssueID == id)
                {
                    result.Add(Iter);
                }
            }

            return result;
        }

        //removes a particular solutoion
        public static void RemoveSolution(IssueSolution issueSoln)
        {
            if(IssueSolutionCollection.Contains(issueSoln))
            {
                IssueSolutionCollection.Remove(issueSoln);
                DataHandler.RemoveSolution(issueSoln);
                DataHandler.RemoveSolutionAttachment(issueSoln);
            }
        }

        //removes all the solution of issue
        public static void RemoveAllSolutionOfIssue(Issue issue)
        {
            List<IssueSolution> solnToRemove = new List<IssueSolution>();

            for(int ctr = 0;ctr<IssueSolutionCollection.Count;ctr++)
            {
                if(IssueSolutionCollection[ctr].IssueID == issue.IssueID)
                {
                    solnToRemove.Add(IssueSolutionCollection[ctr]);
                    DataHandler.RemoveSolution(IssueSolutionCollection[ctr]);
                    DataHandler.RemoveSolutionAttachment(IssueSolutionCollection[ctr]);

                }
            }

            foreach(IssueSolution sln in solnToRemove)
            {
                IssueSolutionCollection.Remove(sln);
            }
        }



    }
}
