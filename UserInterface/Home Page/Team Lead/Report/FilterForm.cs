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
        private int monthClickCount = 0, priorityClickCount = 0;

        public FilterForm()
        {
            InitializeComponent();
        }

        
        public delegate void FilterHandler(int month, int year, int priority);
        public event FilterHandler Filter;

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

        private void OnMonthDropDownClick(object sender, EventArgs e)
        {
            if (priorityForm != null && !priorityForm.IsDisposed)
            {
                Priority = priorityForm.Priority;
                priorityForm.Close();
            }

            if (monthForm != null && !monthForm.IsDisposed)
            {
                Month = monthForm.Month;
                monthForm.Close();
            }
            else
            {
                monthForm = new MonthForm();
                monthForm.Location = monthDropDownPicBox.PointToScreen(new Point(-175, 0));
                monthForm.Month = Month;
                monthForm.MonthSelect += MonthForm_MonthSelect;
                monthForm.Show();
            }
        }

        private void MonthForm_MonthSelect(object sender, int e)
        {
            Month = e;
            Filter?.Invoke(Month, Year, Priority);
        }

        private void OnPriorityDropDownClick(object sender, EventArgs e)
        {
            if (monthForm != null && !monthForm.IsDisposed)
            {
                Month = monthForm.Month;
                monthForm.Close();
            }

            if (priorityForm != null && !priorityForm.IsDisposed)
            {
                Priority = priorityForm.Priority;
                priorityForm.Close();
            }
            else
            {
                priorityForm = new PriorityDropDownForm();
                priorityForm.Location = monthDropDownPicBox.PointToScreen(new Point(-175, 80));
                priorityForm.Priority = Priority;
                priorityForm.PrioritySelect += OnPrioritySelected;
                priorityForm.Show();
            }
        }

        private void YearSetClick(object sender, EventArgs e)
        {
            if (textBox1.Text.All(char.IsNumber))
            {
                Year = Convert.ToInt32(textBox1.Text);
                Filter?.Invoke(Month, Year, Priority);
            }
        }

        private void OnPrioritySelected(object sender, int e)
        {
            Priority = e;
            Filter?.Invoke(Month, Year, Priority);
        }
    }
}
