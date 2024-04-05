using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Home_Page.Team_Lead.Report
{
    public partial class FilterForm : Form
    {
        private PriorityDropDownForm priorityForm;
        private MonthForm monthForm;

        public int Month
        {
            get; set;
        }

        public int Year
        {
            get; set;
        }

        public int Priority
        {
            get; set;
        }

        private int monthClickCount = 0, priorityClickCount = 0;

        public FilterForm()
        {
            InitializeComponent();
        }

        private void OnMonthDropDownClick(object sender, EventArgs e)
        {
            monthClickCount++;

            if (monthClickCount % 2 == 0 && !monthForm.IsDisposed)
            {
                Month = monthForm.Month;
                monthForm.Close();
            }
            else
            {
                monthForm = new MonthForm();
                monthForm.Location = monthDropDownPicBox.PointToScreen(new Point(-175, 0));
                monthForm.Month = Month;
                monthForm.Show();
            }
        }

        private void OnPriorityDropDownClick(object sender, EventArgs e)
        {
            priorityClickCount++;

            if (priorityClickCount % 2 == 0 && !priorityForm.IsDisposed)
            {
                Priority = priorityForm.Priority;
                priorityForm.Close();
            }
            else
            {
                priorityForm = new PriorityDropDownForm();
                priorityForm.Location = monthDropDownPicBox.PointToScreen(new Point(-175, 0));
                priorityForm.Priority = Priority;
                priorityForm.Show();
            }
        }
    }
}
