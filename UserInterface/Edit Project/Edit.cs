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

namespace UserInterface.Edit_Project
{
    public partial class Edit : UserControl
    {
        public Edit()
        {
            InitializeComponent();
        }

        public void InitializePage()
        {
            if(EmployeeManager.CurrentEmployee.EmpRoleName == "Team Lead")
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                editVersion1.ProjectCollection = VersionManager.FetchAllProjects();
                editVersion1.InitializePage();
                tabControl1.BackColor = Color.Red;
                tabControl1.SelectedIndex = 0;
            }
        }
    }
}
