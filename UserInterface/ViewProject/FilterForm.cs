using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.ViewProject
{
    public partial class FilterForm : Form
    {
        public List<Employee> EmployeeCollection
        {
            set
            {
                employeeCollection = value;
                InitializeForm();
            }
        }

        private List<Employee> employeeCollection;
        public FilterForm()
        {
            InitializeComponent();
        }

        private void InitializeForm()
        {

        }
    }
}
