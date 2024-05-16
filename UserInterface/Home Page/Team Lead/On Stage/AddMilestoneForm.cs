using GoLibrary;
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
using UserInterface.Home_Page.Team_Lead.On_Stage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TeamTracker
{
    public partial class AddMilestoneForm : Form
    {
        public event EventHandler<List<Milestone>> MilestoneExtract;
        public ProjectVersion SelectedVersion
        {
            set
            {
                if (value != null)
                {
                    selectedVersion = value;
                    startDateLabel.Text = value.StartDate.ToShortDateString();
                    endDateLabel.Text = value.EndDate.ToShortDateString();
                    prevEndDate = startDate = value.StartDate;
                    endDate = value.EndDate;
                }
            }
        }

        public List<Milestone> MilestoneCollection
        {
            get
            {
                return milestoneCollection;
            }
            set
            {
                if (value != null && value.Count > 0)
                {
                    milestoneCollection = value;
                    startIdx = 0;
                    endIdx = value.Count >= 6 ? 6 : value.Count;
                    isUpEnable = false;
                    isDownEnable = endIdx == value.Count ? false : true;

                    if (upPicBox.Image != null) upPicBox.Image.Dispose();
                    if (downPicBox.Image != null) downPicBox.Image.Dispose();

                    upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.sort_up : UserInterface.Properties.Resources.sort_up_hover;
                    downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.sort_down : UserInterface.Properties.Resources.sort_down_hover;

                    SetMilestoneTemplates();
                }
            }
        }

        public AddMilestoneForm()
        {
            InitializeComponent();
            InitializePageColor();
            TemplateCollection = new List<MilestoneTemplate>();
            milestoneCollection = new List<Milestone>();
        }

        public new void Dispose()
        {
            for(int ctr=0; ctr < basePanel.Controls.Count; ctr++)
            {
                (basePanel.Controls[ctr] as MilestoneTemplate).Dispose();
                basePanel.Controls.RemoveAt(ctr);
                ctr--;
            }

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();
            if (closeButton.Image != null) closeButton.Image.Dispose();
            if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
            if (pictureBox3.Image != null) pictureBox3.Image.Dispose();

            pictureBox2.Dispose();  pictureBox3.Dispose();  closeButton.Dispose();  downPicBox.Dispose();   upPicBox.Dispose();
            label1.Dispose();   label2.Dispose();   label3.Dispose();   label4.Dispose();   label5.Dispose();   startDateLabel.Dispose();   endDateLabel.Dispose();
            panel1.Dispose();   panel2.Dispose();   panel3.Dispose();   panel4.Dispose();   basePanel.Dispose();
            milestoneDateTime.Dispose();    milestoneTextBox.Dispose();
            tableLayoutPanel1.Dispose();    tableLayoutPanel2.Dispose();    tableLayoutPanel3.Dispose();    tableLayoutPanel4.Dispose();    
        }

        private void InitializePageColor()
        {
            milestoneTextBox.ForeColor = panel2.BackColor = milestoneDateTime.BorderColor = milestoneDateTime.TextColor = ThemeManager.CurrentTheme.PrimaryI;
            label1.ForeColor = ThemeManager.GetTextColor(panel2.BackColor);
            BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label4.ForeColor = label5.ForeColor = startDateLabel.ForeColor = endDateLabel.ForeColor = ThemeManager.GetTextColor(BackColor);
            tableLayoutPanel2.BackColor = tableLayoutPanel3.BackColor = pictureBox2.BackColor = pictureBox3.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            label2.ForeColor = label3.ForeColor = ThemeManager.GetTextColor(tableLayoutPanel3.BackColor);
            milestoneTextBox.BackColor = milestoneDateTime.SkinColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.SecondaryIII);
        }

        private void addMilestoneButton_Click(object sender, EventArgs e)
        {
            BooleanMsg message = new BooleanMsg();
            message = IsEligibleToAdd();

            if (message)
            {
                milestoneCollection.Add(new Milestone()
                {
                    MileStoneName = milestoneTextBox.Text,
                    StartDate = prevEndDate.Date,
                    EndDate = milestoneDateTime.Value.Date,
                    Status = MilestoneStatus.Upcoming,
                    VersionID = selectedVersion.VersionID,
                    IsDelayed = false
                });
                prevEndDate = milestoneDateTime.Value;
                milestoneTextBox.Text = "";
                SetMilestoneForm();
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message);
            }
        }

        private BooleanMsg IsEligibleToAdd()
        {
            if(milestoneTextBox.Text.Length == 0 || milestoneTextBox.Text.Length > 30)
            {
                return "Milestone Name Length should be Between 0 and 30";
            }

            if(!(prevEndDate < milestoneDateTime.Value.Date && milestoneDateTime.Value.Date <= endDate))
            {
                return "Milestone Date is Invalid\nEnd Date should be within Previous Milestone Start Date and Version End Date";
            }

            if (milestoneTextBox.Text == "")
            {
                return "Milestone Name is Not Valid";
            }

            for(int ctr=0; ctr<milestoneTextBox.Text.Length; ctr++)
            {
                if(!((milestoneTextBox.Text[ctr]<='z' && milestoneTextBox.Text[ctr] >= 'a') || (milestoneTextBox.Text[ctr] <= 'Z' && milestoneTextBox.Text[ctr] >= 'A') || milestoneTextBox.Text[ctr]==' '))
                {
                    return "Milestone Name should not contains any numbers or characters";
                }
            }

            if (MilestoneContains())
            {
                return "Milestone Name Already Exists";
            }

            return true;
        }

        private BooleanMsg MilestoneContains()
        {
            foreach(var Iter in milestoneCollection)
            {
                if(Iter.MileStoneName == milestoneTextBox.Text)
                {
                    return new BooleanMsg()
                    {
                        Message = "Duplicate Milestone",
                        Result = true
                    };
                }
            }
            return false;
        }

        private void OnDownClick(object sender, EventArgs e)
        {
            if (isDownEnable)
            {
                startIdx++;
                endIdx++;
                InitializeControl();
            }
        }

        private void OnUpClick(object sender, EventArgs e)
        {
            if (isUpEnable)
            {
                startIdx--;
                endIdx--;
                InitializeControl();
            }
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            basePanel.Controls.Clear();
            milestoneCollection.Clear();
            TemplateCollection.Clear();
            prevEndDate = startDate;
            startIdx = endIdx = focusIdx = 0;
        }

        private void SetMilestoneForm()
        {
            if(milestoneCollection.Count <= 6)
            {
                Template = new MilestoneTemplate()
                {
                    Dock = DockStyle.Top,
                    SelectedMilestone = milestoneCollection[milestoneCollection.Count - 1],
                    Counter = milestoneCollection.Count,
                };
                Template.FocusChanged += OnFocusChanged;
                Template.MilestoneOperate += OnMilestoneOperation;
                Template.CheckConstraints += OnCheckContraints;
                basePanel.Controls.Add(Template);
                TemplateCollection.Add(Template);
                foreach(var Iter in TemplateCollection)
                {
                    Iter.BringToFront();
                }
                Template.Focus();
                endIdx++;
                focusIdx = TemplateCollection.Count - 1;
                InitializeControl();
            }
            else
            {
                endIdx = milestoneCollection.Count; startIdx = endIdx - 6;
                focusIdx = TemplateCollection.Count - 1;
                InitializeControl();
            }
        }

        private void OnCloseClick(object sender, EventArgs e)
        {
            BooleanMsg message = isEligibleContraints();
            if (message)
            {
                SetMilestones();
                MilestoneExtract?.Invoke(this, milestoneCollection);
                //this.Close();
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message);
            }
        }

        private void SetMilestones()
        {
            DateTime prevDate = startDate;
            if (milestoneCollection.Count >= 1)
            {
                milestoneCollection.Sort((m1, m2) => m1.EndDate.CompareTo(m2.EndDate));

                for (int ctr = 0; ctr < milestoneCollection.Count; ctr++)
                {
                    if (ctr == 0)
                    {
                        milestoneCollection[ctr].Status = MilestoneStatus.OnProcess;
                    }
                    milestoneCollection[ctr].StartDate = prevDate;
                    prevDate = milestoneCollection[ctr].EndDate;
                }

                milestoneCollection[milestoneCollection.Count - 1].EndDate = endDate;
            }
        }

        private BooleanMsg isEligibleContraints()
        {
            //if (milestoneCollection.Count < 5 || milestoneCollection.Count > 20)
            //{
            //    return "Milestone Count Should Be Between 4 and 20";
            //}

            DateTime prevDate = startDate;

            for(int ctr=0; ctr< milestoneCollection.Count; ctr++)
            {
                if(prevDate >= milestoneCollection[ctr].EndDate)
                {
                    return "Milestone Date is not in Proper Order";
                }
                prevDate = milestoneCollection[ctr].EndDate;
            }

            return true;
        }

        private void OnLineSeperatePaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            //e.Graphics.DrawLine(border, new Point(0, (sender as Control).Height/2), new Point((sender as Control).Width, (sender as Control).Height/2));
            e.Graphics.DrawLine(border, new Point((sender as Control).Width / 2, 0), new Point((sender as Control).Width / 2, (sender as Control).Height));
            e.Graphics.DrawLine(border, new Point(0, (sender as Control).Height - 2), new Point((sender as Control).Width, (sender as Control).Height - 2));
            border.Dispose();
        }

        private bool OnCheckContraints(object sender, MilestoneEventArgs m)
        {
            for (int ctr = 0; ctr < milestoneCollection.Count; ctr++)
            {
                if (ctr + 1 != m.Position && m.MilestoneName == milestoneCollection[ctr].MileStoneName)
                {
                    return false;
                }
            }
            if (m.Position == 1)
            {
                return startDate < m.MilestoneDate;
            }
            else
            {
                return milestoneCollection[m.Position - 2].EndDate < m.MilestoneDate;
            }
        }

        private void OnFocusChanged(object sender, EventArgs e)
        {
            int ctr = 0;
            foreach (var Iter in TemplateCollection)
            {
                if (Iter == (sender as MilestoneTemplate))
                {
                    focusIdx = ctr;
                    Iter.IsFocused = true;
                }
                else
                {
                    Iter.IsFocused = false;
                }
                ctr++;
            }
        }

        private void OnMilestoneOperation(object sender, MilestoneEventArgs m)
        {
            if(m.Movement == MilestoneOperation.Up)
            {
                string tempName = m.MilestoneName;
                milestoneCollection[m.Position - 1].MileStoneName = milestoneCollection[m.Position - 2].MileStoneName;
                milestoneCollection[m.Position - 2].MileStoneName = tempName;
                if (focusIdx > 0)
                {
                    focusIdx--;
                    InitializeControl();
                }
                else
                {
                    if (startIdx != 0)
                    {
                        OnUpClick(this, EventArgs.Empty);
                    }
                }
            }

            if (m.Movement == MilestoneOperation.Down)
            {
                string tempName = m.MilestoneName;
                milestoneCollection[m.Position - 1].MileStoneName = milestoneCollection[m.Position].MileStoneName;
                milestoneCollection[m.Position].MileStoneName = tempName;
                if (focusIdx < TemplateCollection.Count - 1)
                {
                    focusIdx++;
                    InitializeControl();
                }
                else
                {
                    if(milestoneCollection.Count == TemplateCollection.Count)
                    {
                        focusIdx = TemplateCollection.Count - 1;
                        InitializeControl();
                    }
                    else
                    {
                        OnDownClick(this, EventArgs.Empty);
                    }
                }
            }

            if(m.Movement == MilestoneOperation.Delete)
            {
                if(endIdx == milestoneCollection.Count)
                {
                    MilestoneTemplate control = sender as MilestoneTemplate;
                    basePanel.Controls.Remove(TemplateCollection[TemplateCollection.Count-1]);
                    foreach(var Iter in milestoneCollection)
                    {
                        if(Iter.MileStoneName == m.MilestoneName)
                        {
                            milestoneCollection.Remove(Iter);
                            break;
                        }
                    }
                    TemplateCollection.RemoveAt(endIdx - 1);
                    endIdx--;
                    focusIdx = endIdx - 1;
                }
                else
                {
                    if (endIdx == milestoneCollection.Count)
                    {
                        startIdx--; endIdx--;
                    }

                    foreach (var Iter in milestoneCollection)
                    {
                        if (Iter.MileStoneName == m.MilestoneName)
                        {
                            milestoneCollection.Remove(Iter);
                            break;
                        }
                    }
                }

                prevEndDate = milestoneCollection.Count == 0 ? startDate : milestoneCollection[milestoneCollection.Count-1].EndDate;
                InitializeControl();
            }

            if(m.Movement == MilestoneOperation.Steady)
            {
                milestoneCollection[m.Position - 1].MileStoneName = m.MilestoneName;
                milestoneCollection[m.Position - 1].EndDate = m.MilestoneDate;
                InitializeControl();
            }
        }

        private void InitializeControl()
        {
            for(int ctr=startIdx, idx = 0; ctr<endIdx;ctr++, idx++)
            {
                TemplateCollection[idx].IsFocused = idx == focusIdx;
                TemplateCollection[idx].Counter = ctr+1;
                TemplateCollection[idx].IsUpSwapEnable = ctr == 0 ? false : true;
                TemplateCollection[idx].IsDownSwapEnable = ctr == milestoneCollection.Count - 1 ? false : true;
                TemplateCollection[idx].SelectedMilestone = milestoneCollection[ctr];
            }

            isUpEnable = startIdx == 0 ? false : true;
            isDownEnable = endIdx == milestoneCollection.Count ? false : true;

            if (upPicBox.Image != null) upPicBox.Image.Dispose();
            if (downPicBox.Image != null) downPicBox.Image.Dispose();

            upPicBox.Image = isUpEnable ? UserInterface.Properties.Resources.Up_Light_Blue : UserInterface.Properties.Resources.Up_Medium_Blue;
            downPicBox.Image = isDownEnable ? UserInterface.Properties.Resources.Down_Light_Blue : UserInterface.Properties.Resources.Down_Medium_Blue;
        }

        private void SetMilestoneTemplates()
        {
            for(int ctr=0, idx=0; ctr<endIdx; ctr++, idx++)
            {
                Template = new MilestoneTemplate()
                {
                    Dock = DockStyle.Top,
                    Counter = ctr,
                    IsUpSwapEnable = ctr == 0 ? false : true,
                    IsDownSwapEnable = ctr == milestoneCollection.Count - 1 ? false : true,
                    SelectedMilestone = milestoneCollection[ctr],
                };
                Template.FocusChanged += OnFocusChanged;
                Template.MilestoneOperate += OnMilestoneOperation;
                Template.CheckConstraints += OnCheckContraints;
                basePanel.Controls.Add(Template);
                TemplateCollection.Add(Template);
            }
            foreach (var Iter in TemplateCollection)
            {
                Iter.BringToFront();
            }
            InitializeControl();
        }

        private void OnCloseMouseEnter(object sender, EventArgs e)
        {
            if (closeButton.Image != null) closeButton.Image.Dispose();

            closeButton.Image = UserInterface.Properties.Resources.Close_Dark_Blue_Hover;
        }

        private void OnCloseMouseLeave(object sender, EventArgs e)
        {
            if (closeButton.Image != null) closeButton.Image.Dispose();

            closeButton.Image = UserInterface.Properties.Resources.Close_30;
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Hand;
            if (picBox.Name == "upPicBox")
            {
                picBox.Image = UserInterface.Properties.Resources.Up_Light_Blue_Hover;
            }
            else
            {
                picBox.Image = UserInterface.Properties.Resources.Down_Light_Blue_Hover;
            }
        }

        private void OnCurveBorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            Pen border1 = new Pen(ThemeManager.CurrentTheme.SecondaryII, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (sender is PictureBox)
                e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 5));
            else
                e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 15));

            border1.Dispose();
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            PictureBox picBox = (sender as PictureBox);
            if (picBox.Image != null)
                picBox.Image.Dispose();
            Cursor = Cursors.Default;
            if (picBox.Name == "upPicBox")
            {
                picBox.Image = isUpEnable ? UserInterface.Properties.Resources.Up_Light_Blue : UserInterface.Properties.Resources.Up_Medium_Blue;
            }
            else
            {
                picBox.Image = isDownEnable ? UserInterface.Properties.Resources.Down_Light_Blue : UserInterface.Properties.Resources.Down_Medium_Blue;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(0, (sender as Control).Height - 2), new Point((sender as Control).Width, (sender as Control).Height - 2));
            border.Dispose();
        }

        private void InitializeRoundEdges()
        {
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
            tableLayoutPanel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel2.Width, tableLayoutPanel2.Height, 30, 30));
            tableLayoutPanel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel3.Width, tableLayoutPanel3.Height, 30, 30));
            pictureBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox2.Width, pictureBox2.Height, 10, 10));
            pictureBox3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pictureBox3.Width, pictureBox3.Height, 10, 10));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeRoundEdges();
        }

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

        private bool isUpEnable, isDownEnable;
        private int startIdx, endIdx, focusIdx = 0;
        private const int CSDropShadow = 0x00020000;
        private MilestoneTemplate Template;
        private List<MilestoneTemplate> TemplateCollection;
        public List<Milestone> milestoneCollection;
        private DateTime prevEndDate, startDate, endDate;
        private ProjectVersion selectedVersion;
    }
}
