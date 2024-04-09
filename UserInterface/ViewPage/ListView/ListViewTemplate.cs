using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class ListViewTemplate : UserControl
    {
        public List<Task> TaskCollection
        {
            set
            {
                if (value != null && value.Count > 0)
                {
                    taskCollection = value;
                    startIdx = 0;
                    isBackEnabled = false;
                    endIdx = value.Count > 5 ? 5 : value.Count;
                    isNextEnabled = value.Count > 5 ? true : false;
                    SetTaskAllignment();
                }
                else
                {

                }
            }
        }

        private bool isBackEnabled, isNextEnabled;
        private int startIdx, endIdx;
        private SingleList listTemplate;
        private List<SingleList> singleListCollection;
        private List<Task> taskCollection;

        private void OnPaginateDown(object sender, EventArgs e)
        {
            if (isNextEnabled)
            {
                startIdx++;
                endIdx++;
                ReorderTask();
            }
        }

        public ListViewTemplate()
        {
            InitializeComponent();
        }

        private void OnPaginateUp(object sender, EventArgs e)
        {
            if (isBackEnabled)
            {
                startIdx--;
                endIdx--;
                ReorderTask();
            }
        }

        private void SetTaskAllignment()
        {
            for(int ctr=0; ctr<=endIdx; ctr++)
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

            if (paginateUp.Image != null) paginateUp.Image.Dispose();
            if (paginateDown.Image != null) paginateDown.Image.Dispose();

            paginateDown.Image = isNextEnabled ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
            paginateUp.Image = isBackEnabled ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
        }

        private void ReorderTask()
        {
            for(int ctr=startIdx, idx = 0; ctr<=endIdx; ctr++, idx++)
            {
                singleListCollection[idx].ListTask = taskCollection[ctr];
            }

            if (paginateUp.Image != null) paginateUp.Image.Dispose();
            if (paginateDown.Image != null) paginateDown.Image.Dispose();

            isNextEnabled = endIdx == taskCollection.Count - 1 ? false : true;
            isBackEnabled = startIdx == 0 ? false : true;

            paginateDown.Image = isNextEnabled ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;
            paginateUp.Image = isBackEnabled ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
        }
    }
}
