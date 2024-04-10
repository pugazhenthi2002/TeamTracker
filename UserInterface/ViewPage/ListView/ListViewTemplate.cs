using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UserInterface.ViewPage.ListView;

namespace TeamTracker
{
    public partial class ListViewTemplate : UserControl
    {
        public List<Task> DoneTaskCollection
        {
            set
            {
                if(value!=null && value.Count > 0)
                {
                    doneCardCollection = new List<DoneCardTemplate>();
                    doneCollection = value;
                    startDoneIdx = 0; isDoneBackEnabled = false;
                    endDoneIdx = value.Count > 4 ? 4 : value.Count;
                    isDoneNextEnabled = value.Count > 4 ? true : false;
                    SetDoneAllignment();
                }
            }
        }
        public List<Task> RemainingTaskCollection
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    singleListCollection = new List<SingleList>();
                    taskCollection = value;
                    startRemainingIdx = 0;
                    isRemainingBackEnabled = false;
                    endRemainingIdx = value.Count > 5 ? 5 : value.Count;
                    isRemainingNextEnables = value.Count > 5 ? true : false;
                    SetRemainingTaskAllignment();
                }
                else
                {

                }
            }
        }

        private bool isRemainingBackEnabled, isRemainingNextEnables, isDoneBackEnabled, isDoneNextEnabled;
        private int startRemainingIdx, endRemainingIdx, startDoneIdx, endDoneIdx;
        private DoneCardTemplate doneCards;
        private SingleList listTemplate;
        private List<SingleList> singleListCollection;
        private List<DoneCardTemplate> doneCardCollection;
        private List<Task> taskCollection;
        private List<Task> doneCollection;

        private void OnPaginateDown(object sender, EventArgs e)
        {
            if (isRemainingNextEnables)
            {
                startRemainingIdx++;
                endRemainingIdx++;
                ReorderRemainingTask();
            }
        }

        private void OnDonePaginateBack(object sender, EventArgs e)
        {
            if(isDoneBackEnabled)
            {
                startDoneIdx--;
                endDoneIdx--;
                ReorderDoneTask();
            }
        }

        private void OnDonePaginateNext(object sender, EventArgs e)
        {
            if (isDoneNextEnabled)
            {
                startDoneIdx++;
                endDoneIdx++;
                ReorderDoneTask();
            }
        }

        public ListViewTemplate()
        {
            InitializeComponent();
        }

        private void OnPaginateUp(object sender, EventArgs e)
        {
            if (isRemainingBackEnabled)
            {
                startRemainingIdx--;
                endRemainingIdx--;
                ReorderRemainingTask();
            }
        }

        private void SetRemainingTaskAllignment()
        {
            for(int ctr=0; ctr<=endRemainingIdx; ctr++)
            {
                listTemplate = new SingleList()
                {
                    ListTask = taskCollection[ctr],
                    Height = 50,
                    Dock = DockStyle.Top
                };
                singleListControlPanel.Controls.Add(listTemplate);
                singleListCollection.Add(listTemplate);
            }

            foreach(var Iter in singleListCollection)
            {
                Iter.BringToFront();
            }

            if (remainingTaskpaginateUp.Image != null) remainingTaskpaginateUp.Image.Dispose();
            if (remainingTaskpaginateDown.Image != null) remainingTaskpaginateDown.Image.Dispose();

            remainingTaskpaginateDown.Image = isRemainingNextEnables ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
            remainingTaskpaginateUp.Image = isRemainingBackEnabled ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
        }

        private void ReorderRemainingTask()
        {
            for(int ctr=startRemainingIdx, idx = 0; ctr<=endRemainingIdx; ctr++, idx++)
            {
                singleListCollection[idx].ListTask = taskCollection[ctr];
            }

            if (remainingTaskpaginateUp.Image != null) remainingTaskpaginateUp.Image.Dispose();
            if (remainingTaskpaginateDown.Image != null) remainingTaskpaginateDown.Image.Dispose();

            isRemainingNextEnables = endRemainingIdx == taskCollection.Count - 1 ? false : true;
            isRemainingBackEnabled = startRemainingIdx == 0 ? false : true;

            remainingTaskpaginateDown.Image = isRemainingNextEnables ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
            remainingTaskpaginateUp.Image = isRemainingBackEnabled ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
        }

        private void ReorderDoneTask()
        {
            for(int ctr=startDoneIdx, idx = 0; ctr<=endDoneIdx; ctr++, idx++)
            {
                singleListCollection[idx].ListTask = taskCollection[ctr];
            }

            if (doneTaskPageBack.Image != null) doneTaskPageBack.Image.Dispose();
            if (doneTaskPageNext.Image != null) doneTaskPageNext.Image.Dispose();

            doneTaskPageNext.Image = isRemainingNextEnables ? UserInterface.Properties.Resources.Next : UserInterface.Properties.Resources.Next_Hover;
            doneTaskPageBack.Image = isRemainingBackEnabled ? UserInterface.Properties.Resources.Back : UserInterface.Properties.Resources.Back_Hover;
        }

        private void SetDoneAllignment()
        {
            for (int ctr = 0; ctr <= endDoneIdx; ctr++)
            {
                doneCards = new DoneCardTemplate()
                {
                    Width = 200,
                    Dock = DockStyle.Left
                };
                doneTaskPanel.Controls.Add(doneCards);
                doneCardCollection.Add(doneCards);
            }

            foreach (var Iter in doneCardCollection)
            {
                Iter.BringToFront();
            }

            if (doneTaskPageBack.Image != null) doneTaskPageBack.Image.Dispose();
            if (doneTaskPageNext.Image != null) doneTaskPageNext.Image.Dispose();

            doneTaskPageNext.Image = isRemainingNextEnables ? UserInterface.Properties.Resources.Next : UserInterface.Properties.Resources.Next_Hover;
            doneTaskPageBack.Image = isRemainingBackEnabled ? UserInterface.Properties.Resources.Back : UserInterface.Properties.Resources.Back_Hover;
        }
    }
}
