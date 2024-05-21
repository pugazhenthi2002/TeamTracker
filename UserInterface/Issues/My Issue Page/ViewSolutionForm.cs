using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamTracker;

namespace UserInterface.Issues.My_Issue_Page
{
    public partial class ViewSolutionForm : Form
    {
        public event EventHandler SolutionFormClose;
        private bool isBackEnable, isNextEnable;
        private int startIdx, endIdx, selectedIdx = 0;

        private SolutionButton prevButton;
        private List<IssueSolution> issueSolutionCollection;
        private List<SolutionButton> buttonCollection;

        public List<IssueSolution> IssueSolutionCollection
        {
            set
            {
                if(value!=null && value.Count > 0)
                {
                    ucNotFound1.Visible = false;
                    panel2.Visible = panel3.Visible = panel5.Visible = true;
                    issueSolutionCollection = value;
                    startIdx = 0;   endIdx = value.Count >= 4 ? 3 : value.Count - 1;
                    isBackEnable = false;
                    isNextEnable = endIdx > 4 ? true : false;
                    InitializeForm();
                }
                else
                {
                    ucNotFound1.Visible = true;
                    panel2.Visible = panel3.Visible = panel5.Visible = false;
                }
            }
        }

        private void InitializeForm()
        {
            totalSolutionCOuntLabel.Text = "Total Solution: " + issueSolutionCollection.Count.ToString();
            buttonCollection = new List<SolutionButton>();
            for(int ctr=0; ctr <= endIdx; ctr++)
            {
                SolutionButton button = new SolutionButton()
                {
                    IsClicked = false,
                    LabelText = "Solution "+(ctr + 1).ToString(),
                    SelectedSolution = issueSolutionCollection[ctr],
                    Dock = DockStyle.Left,
                    BorderStyle = BorderStyle.FixedSingle,
                    Width = 200
                };

                if (ctr == selectedIdx)
                {
                    prevButton = button;
                    button.IsClicked = true;
                }
                panel4.Controls.Add(button);
                button.SolutionSelect += OnSolutionSelected;
                buttonCollection.Add(button);
            }

            foreach(var Iter in buttonCollection)
            {
                Iter.BringToFront();
            }

            solutionTemplate1.SelectedSolution = buttonCollection[0].SelectedSolution;

            isBackEnable = startIdx == 0 ? false : true;
            isNextEnable = endIdx == issueSolutionCollection.Count - 1 ? false : true;

            if (backBtn.Image != null) backBtn.Image.Dispose();
            if (nextBtn.Image != null) nextBtn.Image.Dispose();

            ResetButton();
        }

        private void InitializePageColor()
        {
            ucNotFound1.BackColor = BackColor = ThemeManager.CurrentTheme.SecondaryII;
            panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            panel2.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            totalSolutionCOuntLabel.ForeColor = ThemeManager.GetTextColor(panel2.BackColor);
            labelTitle.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);

            pictureBox1.Image?.Dispose();
            backBtn.Image?.Dispose();
            nextBtn.Image?.Dispose();

            pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light : UserInterface.Properties.Resources.Heat_Close_Light;
            ResetButton();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            if (backBtn.Image != null) backBtn.Image.Dispose();
            if (nextBtn.Image != null) nextBtn.Image.Dispose();
        }

        private void OnBackClick(object sender, EventArgs e)
        {
            if (isBackEnable)
            {
                startIdx--;
                endIdx--;
                ResetControl();
            }
        }

        private void OnNextClicked(object sender, EventArgs e)
        {
            if (isNextEnable)
            {
                startIdx++;
                endIdx++;
                ResetControl();
            }
        }

        private void OnSolutionSelected(object sender, IssueSolution e)
        {
            if(prevButton != null)
            {
                prevButton.IsClicked = false;
            }
            prevButton = (sender as SolutionButton);
            prevButton.IsClicked = true;
            selectedIdx = issueSolutionCollection.FindIndex(t1 => t1.IssueSolutionID == e.IssueSolutionID);
            solutionTemplate1.SelectedSolution = e;
            ResetControl();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "backBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = UserInterface.Properties.Resources.Cold_Left_Dark_Hover;
                }
                else
                {
                    backBtn.Image = UserInterface.Properties.Resources.Heat_Left_Dark_Hover;
                }
            }
            else if((sender as Control).Name == "nextBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    nextBtn.Image = UserInterface.Properties.Resources.Cold_Right_Dark_Hover;
                }
                else
                {
                    nextBtn.Image = UserInterface.Properties.Resources.Heat_Right_Dark_Hover;
                }
            }
            else
            {
                pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light_Hover : UserInterface.Properties.Resources.Heat_Close_Light_Hover;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "backBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Cold_Left_Dark : UserInterface.Properties.Resources.Cold_Left_Light;
                }
                else
                {
                    backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Heat_Left_Dark : UserInterface.Properties.Resources.Heat_Left_Light;
                }
            }
            else if ((sender as Control).Name == "nextBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Cold_Right_Dark : UserInterface.Properties.Resources.Cold_Right_Light;
                }
                else
                {
                    nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Heat_Right_Dark : UserInterface.Properties.Resources.Heat_Right_Light;
                }
            }
            else
            {
                pictureBox1.Image = ThemeManager.CurrentThemeMode == ThemeMode.Cold ? UserInterface.Properties.Resources.Cold_Close_Light : UserInterface.Properties.Resources.Heat_Close_Light;
            }
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            SolutionFormClose?.Invoke(this, EventArgs.Empty);
        }

        public ViewSolutionForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
            InitializePageColor();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.Instance | BindingFlags.SetProperty | BindingFlags.NonPublic, null, panel1, new object[] { true });
        }

        private void ResetControl()
        {
            for (int ctr = startIdx, idx = 0; ctr <= endIdx; ctr++, idx++)
            {
                if (ctr == selectedIdx)
                    buttonCollection[idx].IsClicked = true;
                else
                    buttonCollection[idx].IsClicked = false;

                buttonCollection[idx].LabelText = "Solution " + (ctr + 1).ToString();
                buttonCollection[idx].SelectedSolution = issueSolutionCollection[ctr];
            }

            isBackEnable = startIdx == 0 ? false : true;
            isNextEnable = endIdx == issueSolutionCollection.Count - 1 ? false : true;

            if (backBtn.Image != null) backBtn.Image.Dispose();
            if (nextBtn.Image != null) nextBtn.Image.Dispose();

            ResetButton();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void ResetButton()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Cold_Left_Dark : UserInterface.Properties.Resources.Cold_Left_Medium;
                nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Cold_Right_Dark : UserInterface.Properties.Resources.Cold_Right_Medium;
            }
            else
            {
                backBtn.Image = isBackEnable ? UserInterface.Properties.Resources.Heat_Left_Dark : UserInterface.Properties.Resources.Heat_Left_Medium;
                nextBtn.Image = isNextEnable ? UserInterface.Properties.Resources.Heat_Right_Dark : UserInterface.Properties.Resources.Heat_Right_Medium;
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
    }
}
