using GoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterface.Home_Page.Team_Lead.On_Stage;

namespace TeamTracker
{
    public partial class AddMilestoneForm : Form
    {
        private bool isUpEnable, isDownEnable;
        private int startIdx, endIdx;

        private MilestoneTemplate Template;
        private List<MilestoneTemplate> TemplateCollection;
        public List<Milestone> milestoneCollection;
        private DateTime prevEndDate, startDate, endDate;

        private ProjectVersion selectedVersion;
        public ProjectVersion SelectedVersion
        {
            set
            {
                selectedVersion = value;
                prevEndDate = startDate = value.StartDate;
                endDate = value.EndDate;
            }
        }

        public List<Milestone> MilestoneCollection
        {
            get
            {
                return milestoneCollection;
            }
            set
            {
                milestoneCollection = value;
            }
        }

        public AddMilestoneForm()
        {
            InitializeComponent();
            TemplateCollection = new List<MilestoneTemplate>();
            milestoneCollection = new List<Milestone>();
        }

        private void addMilestoneButton_Click(object sender, EventArgs e)
        {
            BooleanMsg message = new BooleanMsg();
            message.Message = "Data Entered is Invalid";
            message = (prevEndDate < milestoneDateTime.Value && milestoneDateTime.Value <= endDate) && (milestoneTextBox.Text != "") && (!MilestoneContains());

            if (message)
            {
                milestoneCollection.Add(new Milestone()
                {
                    MileStoneName = milestoneTextBox.Text,
                    StartDate = prevEndDate,
                    EndDate = milestoneDateTime.Value,
                    Status = SetMilestoneStatus(prevEndDate, milestoneDateTime.Value),
                    VersionID = selectedVersion.VersionID,
                });
                prevEndDate = milestoneDateTime.Value;
                milestoneTextBox.Text = "";
                SetMilestoneForm();
            }
            else
            {
                //ProjectManagerMainForm.notify.AddNotification("Invalid Input", message);
            }
        }

        private BooleanMsg MilestoneContains()
        {
            foreach(var Iter in milestoneCollection)
            {
                if(Iter.MileStoneName == milestoneTextBox.Text)
                {
                    return new BooleanMsg()
                    {
                        Message = "Duplicate Milestone",
                        Result = true
                    };
                }
            }
            return false;
        }

        private MilestoneStatus SetMilestoneStatus(DateTime startDate, DateTime endDate)
        {
            if(endDate < DateTime.Now)
            {
                return MilestoneStatus.Completed;
            }
            else if(startDate <= DateTime.Now && DateTime.Now <= endDate)
            {
                return MilestoneStatus.OnProcess;
            }
            else
            {
                return MilestoneStatus.Upcoming;
            }
        }

        private void SetMilestoneForm()
        {
            if(milestoneCollection.Count <= 4)
            {
                Template = new MilestoneTemplate()
                {
                    Dock = DockStyle.Top,
                    SelectedMilestone = milestoneCollection[milestoneCollection.Count - 1],
                    Counter = milestoneCollection.Count
                };
                Template.MilestoneOperate += OnMilestoneOperation;
                basePanel.Controls.Add(Template);
                TemplateCollection.Add(Template);
                foreach(var Iter in TemplateCollection)
                {
                    Iter.BringToFront();
                }
                Template.Focus();
                endIdx++;
            }
            else
            {
                startIdx++; endIdx++;
                InitializeControl();
            }
        }

        private void OnMilestoneOperation(object sender, MilestoneEventArgs m)
        {
            //throw new NotImplementedException();
        }

        private void InitializeControl()
        {
            for(int ctr=startIdx, idx = 0; ctr<endIdx;ctr++, idx++)
            {
                TemplateCollection[idx].SelectedMilestone = milestoneCollection[ctr];
                TemplateCollection[idx].Counter = ctr+1;
            }
        }
    }
}
