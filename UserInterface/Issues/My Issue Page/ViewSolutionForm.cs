﻿using System;
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

            if (backPicBox.Image != null) backPicBox.Image.Dispose();
            if (nextPicBox.Image != null) nextPicBox.Image.Dispose();

            backPicBox.Image = isBackEnable ? Properties.Resources.Left_Dark_Blue : Properties.Resources.Left_Light_Blue;
            nextPicBox.Image = isBackEnable ? Properties.Resources.Right_Dark_Blue : Properties.Resources.Right_Light_Blue;
        }

        private void InitializePageColor()
        {
            ucNotFound1.BackColor = BackColor = ThemeManager.CurrentTheme.SecondaryII;
            panel1.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            panel2.BackColor = ThemeManager.CurrentTheme.SecondaryI;
            totalSolutionCOuntLabel.ForeColor = ThemeManager.GetTextColor(panel2.BackColor);
            labelTitle.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        public new void Dispose()
        {
            panel1.Dispose();   panel2.Dispose();   panel3.Dispose();   panel4.Dispose();   panel5.Dispose();
            if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            if (backPicBox.Image != null) backPicBox.Image.Dispose();
            if (nextPicBox.Image != null) nextPicBox.Image.Dispose();
            pictureBox1.Dispose();  backPicBox.Dispose();  nextPicBox.Dispose();
            totalSolutionCOuntLabel.Dispose();   labelTitle.Dispose();
            solutionTemplate1.Dispose();
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
            if ((sender as PictureBox).Image != null) (sender as PictureBox).Image.Dispose();

            if ((sender as Control).Name == "nextPicBox") nextPicBox.Image = UserInterface.Properties.Resources.Right_Dark_Blue_Hover;
            else if ((sender as Control).Name == "backPicBox") backPicBox.Image = UserInterface.Properties.Resources.Left_Dark_Blue_Hover;
            else pictureBox1.Image = UserInterface.Properties.Resources.Close_Dark_Blue_Hover;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if ((sender as PictureBox).Image != null) (sender as PictureBox).Image.Dispose();

            if ((sender as Control).Name == "nextPicBox") nextPicBox.Image = isBackEnable ? Properties.Resources.Right_Dark_Blue : Properties.Resources.Right_Light_Blue;
            else if ((sender as Control).Name == "backPicBox") backPicBox.Image = isBackEnable ? Properties.Resources.Left_Dark_Blue : Properties.Resources.Left_Light_Blue;
            else pictureBox1.Image = UserInterface.Properties.Resources.Close_30;
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
            ThemeManager.ThemeChange += OnThemeChanged;

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

            if (backPicBox.Image != null) backPicBox.Image.Dispose();
            if (nextPicBox.Image != null) nextPicBox.Image.Dispose();

            backPicBox.Image = isBackEnable ? Properties.Resources.Left_Dark_Blue : Properties.Resources.Left_Light_Blue;
            nextPicBox.Image = isNextEnable ? Properties.Resources.Right_Dark_Blue : Properties.Resources.Right_Light_Blue;
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
