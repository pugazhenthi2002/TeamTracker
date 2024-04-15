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
        private int startIdx, endIdx, focusIdx=0;

        private MilestoneTemplate Template;
        private List<MilestoneTemplate> TemplateCollection;
        public List<Milestone> milestoneCollection;
        private DateTime prevEndDate, startDate, endDate;
        public event EventHandler<List<Milestone>> MilestoneExtract;

        private ProjectVersion selectedVersion;
        public ProjectVersion SelectedVersion
        {
            set
            {
                if (value != null)
                {
                    selectedVersion = value;
                    prevEndDate = startDate = value.StartDate;
                    endDate = value.EndDate;
                }
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
                if (value != null && value.Count > 0)
                {
                    milestoneCollection = value;
                    startIdx = 0;
                    endIdx = value.Count >= 6 ? 6 : value.Count;
                    isUpEnable = false;
                    isDownEnable = endIdx == value.Count ? false : true;

                    if (upPicBox.Image != null) upPicBox.Image.Dispose();
                    if (downPicBox.Image != null) downPicBox.Image.Dispose();

                    upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
                    downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;

                    SetMilestoneTemplates();
                }
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
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message);
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

        private void OnDownClick(object sender, EventArgs e)
        {
            if (isDownEnable)
            {
                startIdx++;
                endIdx++;
                InitializeControl();
            }
        }

        private void OnUpClick(object sender, EventArgs e)
        {
            if (isUpEnable)
            {
                startIdx--;
                endIdx--;
                InitializeControl();
            }
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

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            basePanel.Controls.Clear();
            milestoneCollection.Clear();
            TemplateCollection.Clear();
            prevEndDate = startDate;
            startIdx = endIdx = focusIdx = 0;
        }

        private void SetMilestoneForm()
        {
            if(milestoneCollection.Count <= 6)
            {
                Template = new MilestoneTemplate()
                {
                    Dock = DockStyle.Top,
                    SelectedMilestone = milestoneCollection[milestoneCollection.Count - 1],
                    Counter = milestoneCollection.Count,
                };
                Template.FocusChanged += OnFocusChanged;
                Template.MilestoneOperate += OnMilestoneOperation;
                Template.CheckConstraints += OnCheckContraints;
                basePanel.Controls.Add(Template);
                TemplateCollection.Add(Template);
                foreach(var Iter in TemplateCollection)
                {
                    Iter.BringToFront();
                }
                Template.Focus();
                endIdx++;
                focusIdx = TemplateCollection.Count - 1;
                InitializeControl();
            }
            else
            {
                endIdx = milestoneCollection.Count; startIdx = endIdx - 6;
                focusIdx = TemplateCollection.Count - 1;
                InitializeControl();
            }
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            BooleanMsg message = isEligibleContraints();
            if (message)
            {
                SetMilestones();
                MilestoneExtract?.Invoke(this, milestoneCollection);
                this.Close();
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message);
            }
        }

        private void SetMilestones()
        {
            DateTime prevDate = startDate;

            for (int ctr = 0; ctr < milestoneCollection.Count; ctr++)
            {
                milestoneCollection[ctr].StartDate = prevDate;
                prevDate = milestoneCollection[ctr].EndDate;
            }
        }

        private BooleanMsg isEligibleContraints()
        {
            if (milestoneCollection.Count < 5 || milestoneCollection.Count > 20)
            {
                return "Milestone Count Should Be Between 4 and 20";
            }

            DateTime prevDate = startDate;

            for(int ctr=0; ctr< milestoneCollection.Count; ctr++)
            {
                if(prevDate >= milestoneCollection[ctr].EndDate)
                {
                    return "Milestone Date is not in Proper Order";
                }
                prevDate = milestoneCollection[ctr].EndDate;
            }

            return true;
        }

        private bool OnCheckContraints(object sender, MilestoneEventArgs m)
        {
            for (int ctr = 0; ctr < milestoneCollection.Count; ctr++)
            {
                if (ctr + 1 != m.Position && m.MilestoneName == milestoneCollection[ctr].MileStoneName)
                {
                    return false;
                }
            }
            if (m.Position == 1)
            {
                return startDate < m.MilestoneDate;
            }
            else
            {
                return milestoneCollection[m.Position - 2].EndDate < m.MilestoneDate;
            }
        }

        private void OnFocusChanged(object sender, EventArgs e)
        {
            int ctr = 0;
            foreach (var Iter in TemplateCollection)
            {
                if (Iter == (sender as MilestoneTemplate))
                {
                    focusIdx = ctr;
                    Iter.IsFocused = true;
                }
                else
                {
                    Iter.IsFocused = false;
                }
                ctr++;
            }
        }

        private void OnMilestoneOperation(object sender, MilestoneEventArgs m)
        {
            if(m.Movement == MilestoneOperation.Up)
            {
                string tempName = m.MilestoneName;
                milestoneCollection[m.Position - 1].MileStoneName = milestoneCollection[m.Position - 2].MileStoneName;
                milestoneCollection[m.Position - 2].MileStoneName = tempName;
                if (focusIdx > 0)
                {
                    focusIdx--;
                    InitializeControl();
                }
                else
                {
                    if (startIdx != 0)
                    {
                        OnUpClick(this, EventArgs.Empty);
                    }
                }
            }

            if (m.Movement == MilestoneOperation.Down)
            {
                string tempName = m.MilestoneName;
                milestoneCollection[m.Position - 1].MileStoneName = milestoneCollection[m.Position].MileStoneName;
                milestoneCollection[m.Position].MileStoneName = tempName;
                if (focusIdx < TemplateCollection.Count - 1)
                {
                    focusIdx++;
                    InitializeControl();
                }
                else
                {
                    if(milestoneCollection.Count == TemplateCollection.Count)
                    {
                        focusIdx = TemplateCollection.Count - 1;
                        InitializeControl();
                    }
                    else
                    {
                        OnDownClick(this, EventArgs.Empty);
                    }
                }
            }

            if(m.Movement == MilestoneOperation.Delete)
            {
                if(endIdx == TemplateCollection.Count)
                {
                    MilestoneTemplate control = sender as MilestoneTemplate;
                    basePanel.Controls.Remove(TemplateCollection[TemplateCollection.Count-1]);
                    foreach(var Iter in milestoneCollection)
                    {
                        if(Iter.MileStoneName == m.MilestoneName)
                        {
                            milestoneCollection.Remove(Iter);
                            break;
                        }
                    }
                    TemplateCollection.RemoveAt(endIdx - 1);
                    endIdx--;
                    focusIdx = endIdx - 1;
                }
                else
                {
                    if (endIdx == milestoneCollection.Count)
                    {
                        startIdx--; endIdx--;
                    }

                    foreach (var Iter in milestoneCollection)
                    {
                        if (Iter.MileStoneName == m.MilestoneName)
                        {
                            milestoneCollection.Remove(Iter);
                            break;
                        }
                    }
                }

                prevEndDate = milestoneCollection.Count == 0 ? startDate : milestoneCollection[milestoneCollection.Count-1].EndDate;
                InitializeControl();
            }

            if(m.Movement == MilestoneOperation.Steady)
            {
                milestoneCollection[m.Position - 1].MileStoneName = m.MilestoneName;
                milestoneCollection[m.Position - 1].EndDate = m.MilestoneDate;
                InitializeControl();
            }
        }

        private void InitializeControl()
        {
            for(int ctr=startIdx, idx = 0; ctr<endIdx;ctr++, idx++)
            {
                TemplateCollection[idx].IsFocused = idx == focusIdx;
                TemplateCollection[idx].Counter = ctr+1;
                TemplateCollection[idx].IsUpSwapEnable = ctr == 0 ? false : true;
                TemplateCollection[idx].IsDownSwapEnable = ctr == milestoneCollection.Count - 1 ? false : true;
                TemplateCollection[idx].SelectedMilestone = milestoneCollection[ctr];
            }

            isUpEnable = startIdx == 0 ? false : true;
            isDownEnable = endIdx == milestoneCollection.Count ? false : true;

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();

            upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
            downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
        }

        private void SetMilestoneTemplates()
        {
            for(int ctr=0, idx=0; ctr<endIdx; ctr++, idx++)
            {
                Template = new MilestoneTemplate()
                {
                    Dock = DockStyle.Top,
                    Counter = ctr,
                    IsUpSwapEnable = ctr == 0 ? false : true,
                    IsDownSwapEnable = ctr == milestoneCollection.Count - 1 ? false : true,
                    SelectedMilestone = milestoneCollection[ctr],
                };
                Template.FocusChanged += OnFocusChanged;
                Template.MilestoneOperate += OnMilestoneOperation;
                Template.CheckConstraints += OnCheckContraints;
                basePanel.Controls.Add(Template);
                TemplateCollection.Add(Template);
            }
            foreach (var Iter in TemplateCollection)
            {
                Iter.BringToFront();
            }
            InitializeControl();
        }
    }
}
