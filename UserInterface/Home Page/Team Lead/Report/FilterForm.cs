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

namespace UserInterface.Home_Page.Team_Lead.Report
{
    public partial class FilterForm : Form
    {
        public event EventHandler FilterFormClose;
        private string prevString;
        private PriorityDropDownForm priorityForm;
        private MonthForm monthForm;

        public FilterForm()
        {
            InitializeComponent();
            textBox1.GotFocus += OnTextBoxGotFocus;

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        private void OnTextBoxGotFocus(object sender, EventArgs e)
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
        }

        private const int CSDropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CSDropShadow;
                return cp;
            }
        }

        public delegate void FilterHandler(int month, int year, int priority);
        public event FilterHandler Filter;

        public int Month
        {
            get; set;
        }

        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
                textBox1.Text = year.ToString();
            }
        }

        public int Priority
        {
            get; set;
        }

        public new void Dispose()
        {
            if (monthDropDownPicBox.Image != null) monthDropDownPicBox.Image.Dispose();
            if (priorityDropDownPicBox.Image != null) priorityDropDownPicBox.Image.Dispose();

            label1.Dispose();   label2.Dispose();
            textBox1.Dispose(); monthDropDownPicBox.Dispose();  priorityDropDownPicBox.Dispose();   setLabel.Dispose();
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
            Filter?.Invoke(Month, year, Priority);
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

            if (textBox1.Text.All(char.IsNumber))
            {
                year = Convert.ToInt32(textBox1.Text);
                Filter?.Invoke(Month, year, Priority);
                FilterFormClose?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OnYearKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                year = Convert.ToInt32(textBox1.Text);
                Filter?.Invoke(Month, year, Priority);
                FilterFormClose?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OnPrioritySelected(object sender, int e)
        {
            Priority = e;
            Filter?.Invoke(Month, year, Priority);
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 4 || !textBox1.Text.All(char.IsNumber))
            {
                textBox1.Text = prevString;
                textBox1.SelectionStart = 3;
                textBox1.SelectionLength = 1;
            }
            else
            {
                prevString = textBox1.Text;
            }
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
        }
    }
}
