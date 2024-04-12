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

namespace UserInterface.Home_Page.Team_Lead.On_Stage
{
    public partial class MilestoneTemplate : UserControl
    {
        public delegate void MilestoneHandler(object sender, MilestoneEventArgs m);
        public event MilestoneHandler MilestoneOperate;

        public string placeHolderText;

        public int counter;
        public int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                counter = value;
                counterLabel.Text = value.ToString();
            }
        }

        public Milestone milestone;
        public Milestone SelectedMilestone
        {
            get
            {
                return milestone;
            }

            set
            {
                milestone = value;
                placeHolderText = value.MileStoneName;
                InitializeControl();
            }
        }
        public MilestoneTemplate()
        {
            InitializeComponent();
            milestoneName.LostFocus += AddMilestonePlaceHolders;
        }

        private void AddMilestonePlaceHolders(object sender, EventArgs e)
        {
            milestoneName.Text = placeHolderText;
        }

        private void InitializeControl()
        {
            milestoneName.Text = milestone.MileStoneName;
            milestoneDate.Value = milestone.EndDate;
        }

        private void OnValueChanged(object sender, EventArgs e)
        {
            MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
            {
                MilestoneDate = milestoneDate.Value,
                MilestoneName = milestoneName.Text,
                Position = Convert.ToInt32(counterLabel.Text),
                Movement = MilestoneOperation.Steady
            });
        }

        private void OnUpButtonClicked(object sender, EventArgs e)
        {
            MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
            {
                MilestoneDate = milestoneDate.Value,
                MilestoneName = milestoneName.Text,
                Position = Convert.ToInt32(counterLabel.Text),
                Movement = MilestoneOperation.Up
            });
        }

        private void OnDownButtonClicked(object sender, EventArgs e)
        {
            MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
            {
                MilestoneDate = milestoneDate.Value,
                MilestoneName = milestoneName.Text,
                Position = Convert.ToInt32(counterLabel.Text),
                Movement = MilestoneOperation.Down
            });
        }

        private void OnDelete(object sender, EventArgs e)
        {
            MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
            {
                MilestoneDate = milestoneDate.Value,
                MilestoneName = milestoneName.Text,
                Position = Convert.ToInt32(counterLabel.Text),
                Movement = MilestoneOperation.Delete
            });
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                MilestoneOperate?.Invoke(this, new MilestoneEventArgs()
                {
                    MilestoneDate = milestoneDate.Value,
                    MilestoneName = milestoneName.Text,
                    Position = Convert.ToInt32(counterLabel.Text),
                    Movement = MilestoneOperation.Delete
                });
                placeHolderText = milestoneName.Text;
            }
        }
    }
}
