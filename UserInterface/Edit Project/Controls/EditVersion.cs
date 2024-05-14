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

namespace UserInterface.Edit_Project.Controls
{
    public partial class EditVersion : UserControl
    {
        public List<Projects> ProjectCollection { get; set; }

        public EditVersion()
        {
            InitializeComponent();
        }

        public void InitializePage()
        {
            OnProjectNameChanged(this, "");
        }

        private void OnProjectNameChanged(object sender, string e)
        {
            filteredProjectCollection = new List<Projects>();
            
            foreach(var Iter in ProjectCollection)
            {
                if (Iter.ProjectName.Contains(e))
                {
                    filteredProjectCollection.Add(Iter);
                }
            }

            InitializeControl();
        }

        private void InitializeControl()
        {
            startIdx = 0;   isBackEnable = false;
            endIdx = filteredProjectCollection.Count >= 5 ? 4 : filteredProjectCollection.Count - 1;
            isNextEnable = filteredProjectCollection.Count > 5 ? true : false;

            for(int ctr=0; ctr <= endIdx; ctr++)
            {
                template = new ProjectBoardTemplate()
                {
                    Dock = DockStyle.Left,
                    Project = filteredProjectCollection[ctr]
                };
                template.ProjectSelection += OnProjectSelected;
            }
        }

        private void OnProjectSelected(object sender, Projects e)
        {
            ;
        }

        private ProjectBoardTemplate template;
        private bool isBackEnable, isNextEnable;
        private int startIdx, endIdx;
        private List<Projects> filteredProjectCollection;
    }
}
