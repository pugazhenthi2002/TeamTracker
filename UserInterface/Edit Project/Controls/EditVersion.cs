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
using UserInterface.ViewProject;
using UserInterface.ViewPage;
using GoLibrary;
using System.Runtime.InteropServices;

namespace UserInterface.Edit_Project.Controls
{
    public partial class EditVersion : UserControl
    {
        public List<Projects> ProjectCollection { get; set; }

        public EditVersion()
        {
            InitializeComponent();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void InitializePageColor()
        {
            BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            label1.ForeColor = ThemeManager.GetTextColor(BackColor);
            fileAttachment1.BackColor = panel8.BackColor = startDatePanel.BackColor = endDatePanel.BackColor = chooseVersionLabel.BackColor = panel13.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            descTextBox.BackColor = clientTextBox.BackColor = startDateTimePicker.SkinColor = endDateTimePicker.SkinColor = ThemeManager.CurrentTheme.SecondaryIII;
            descTextBox.ForeColor = clientTextBox.ForeColor = startDateTimePicker.BorderColor = endDateTimePicker.BorderColor = startDateTimePicker.TextColor = endDateTimePicker.TextColor = ThemeManager.CurrentTheme.PrimaryI;
            chooseVersionLabel.ForeColor = label2.ForeColor = label5.ForeColor = startDateLabel.ForeColor = endDateLabel.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            updateButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            panel4.BackColor = DeleteButton.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            updateButton.ForeColor = ThemeManager.GetTextColor(updateButton.BackColor);
            DeleteButton.ForeColor = ThemeManager.GetTextColor(DeleteButton.BackColor);
            searchVersion1.BackColor = ThemeManager.CurrentTheme.SecondaryII;

            BackBtn.Image?.Dispose();
            NextBtn.Image?.Dispose();

            ResetButton();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            BackBtn.Image?.Dispose();   NextBtn.Image?.Dispose();

            BoardBasePanelClear();
            ThemeManager.ThemeChange -= OnThemeChanged;
            panel5.Paint -= OnLineSeperatePaint; endDateLabel.Paint -= OnLineSeperatePaint; startDateLabel.Paint -= OnLineSeperatePaint;
            label2.Paint -= OnLineSeperatePaint; label5.Paint -= OnLineSeperatePaint; panel1.Paint -= OnLineSeperatePaint;
            panel4.Paint -= BorderDrawPaint; endDatePanel.Paint -= BorderDrawPaint; startDatePanel.Paint -= BorderDrawPaint; updateButton.Paint -= BorderDrawPaint;
            panel6.Paint -= BorderDrawPaint; panel8.Paint -= BorderDrawPaint; panel13.Paint -= BorderDrawPaint; DeleteButton.Paint -= BorderDrawPaint;
            chooseVersionLabel.Click -= OnChooseVersionClicked; updateButton.Click -= OnUpdateClicked;  DeleteButton.Click -= OnDeleteClicked; NextBtn.Click -= OnNextBtnClicked;
            searchVersion1.ProjectNameChange -= OnProjectNameChanged;   BackBtn.Click -= OnBackBtnClicked;
        }

        public void InitializePage()
        {
            OnProjectNameChanged(this, "");
            clientTextBox.Text = descTextBox.Text = "";
            startDateTimePicker.Value = endDateTimePicker.Value = DateTime.Now.Date;
            selectedProject = null;
            selectedVersion = null;
            fileAttachment1.Clear = true;
            fileAttachment1.AttachmentCollection = null;
            chooseVersionLabel.Text = "Choose Version";
        }

        private void OnProjectNameChanged(object sender, string e)
        {
            boardBasePanel.SuspendLayout();
            selectedProject = null; selectedVersion = null;
            filteredProjectCollection = new List<Projects>();
            
            foreach(var Iter in ProjectCollection)
            {
                if (Iter.ProjectName.Contains(e))
                {
                    filteredProjectCollection.Add(Iter);
                }
            }

            InitializeControl();
            boardBasePanel.ResumeLayout();
        }

        private void InitializeControl()
        {
            startIdx = 0;   isBackEnable = false;
            endIdx = filteredProjectCollection.Count >= 5 ? 4 : filteredProjectCollection.Count - 1;
            isNextEnable = filteredProjectCollection.Count > 5 ? true : false;

            BoardBasePanelClear();

            for(int ctr=0; ctr <= endIdx; ctr++)
            {
                template = new ProjectBoardTemplate()
                {
                    Dock = DockStyle.Left,
                    Project = filteredProjectCollection[ctr]
                };
                template.ProjectSelection += OnProjectSelected;
                boardBasePanel.Controls.Add(template);
            }

            foreach(Control Iter in boardBasePanel.Controls)
            {
                Iter.BringToFront();
            }
        }

        private void BoardBasePanelClear()
        {
            for(int ctr=0;ctr< boardBasePanel.Controls.Count; ctr++)
            {
                (boardBasePanel.Controls[ctr] as ProjectBoardTemplate).ProjectSelection -= OnProjectSelected;
                (boardBasePanel.Controls[ctr] as ProjectBoardTemplate).Dispose();
                ctr--;
            }
        }

        private void OnProjectSelected(object sender, Projects e)
        {
            InitializePage();
            selectedVersionCollection = VersionManager.FetchAllVersionFromProject(e.ProjectID);
            selectedProject = e;
            selectedVersion = selectedVersionCollection[0];
            fileAttachment1.Clear = true;
            chooseVersionLabel.Text = selectedVersion.VersionName;
            startDateTimePicker.Value = selectedVersion.StartDate;
            endDateTimePicker.Value = selectedVersion.EndDate;
            descTextBox.Text = selectedVersion.VersionDescription;
            clientTextBox.Text = selectedVersion.ClientEmail;
            Dictionary<string, VersionAttachment> attachments = new Dictionary<string, VersionAttachment>();

            var result = DataHandler.FetchAttachmentsByVersionID(selectedVersion.VersionID);

            if(result != null)
            {
                foreach (var Iter in result)
                {
                    attachments.Add(Iter.DisplayName, Iter);
                }

                fileAttachment1.AttachmentCollection = attachments;
            }
            
        }

        private void OnNextBtnClicked(object sender, EventArgs e)
        {
            if (isNextEnable)
            {
                startIdx++; endIdx++;
                ResetControls();
            }
        }

        private void OnBackBtnClicked(object sender, EventArgs e)
        {
            if (isBackEnable)
            {
                startIdx--; endIdx--;
                ResetControls();
            }
        }

        private void ResetControls()
        {
            for(int ctr=startIdx, idx = 0; ctr <= endIdx; ctr++, idx++)
            {
                (boardBasePanel.Controls[idx] as ProjectBoardTemplate).Project = filteredProjectCollection[ctr];
            }

            isBackEnable = startIdx == 0 ? false : true;
            isNextEnable = endIdx == filteredProjectCollection.Count - 1 ? false : true;

            ResetButton();
        }

        private void OnChooseVersionClicked(object sender, EventArgs e)
        {
            if (selectedProject != null)
            {
                VersionViewForm form = new VersionViewForm()
                {
                    VersionCollection = selectedVersionCollection,
                    Location = chooseVersionLabel.PointToScreen(new Point(0, chooseVersionLabel.Height + 5)),
                    Width = chooseVersionLabel.Width,
                    BackColor = ThemeManager.CurrentTheme.SecondaryI
                };
                form.VersionSelected += OnVersionSelected;
                form.Show();
            }
        }

        private void OnVersionSelected(object sender, ProjectVersion e)
        {
            InitializePage();
            selectedProject = VersionManager.FetchProjectFromID(e.ProjectID);
            selectedVersion = e;
            fileAttachment1.Clear = true;
            chooseVersionLabel.Text = selectedVersion.VersionName;
            startDateTimePicker.Value = selectedVersion.StartDate;
            endDateTimePicker.Value = selectedVersion.EndDate;
            descTextBox.Text = selectedVersion.VersionDescription;
            clientTextBox.Text = selectedVersion.ClientEmail;
            Dictionary<string, VersionAttachment> attachments = new Dictionary<string, VersionAttachment>();

            var result = DataHandler.FetchAttachmentsByVersionID(selectedVersion.VersionID);
            if (result != null)
            {
                foreach (var Iter in result)
                {
                    attachments.Add(Iter.DisplayName, Iter);
                }
                fileAttachment1.AttachmentCollection = attachments;
            }

            
        }

        private void OnUpdateClicked(object sender, EventArgs e)
        {
            var result = isEligibleForVersionUpgrade();

            

            if (result)
            {
                WarningForm form = new WarningForm();
                form.Content = "Are you sure, you want to update the Project Version? This will affect the milestone and task duration";
                form.WarningStatus += OnUpdateStatus;

                transparentForm = new TransparentForm();
                transparentForm.Show();
                transparentForm.ShowForm(form);
            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", result.Message);
            }
        }

        private void OnUpdateStatus(object sender, bool e)
        {
            (sender as WarningForm).WarningStatus -= OnUpdateStatus;
            (sender as WarningForm).Close();

            if (e)
            {
                VersionManager.UpdateVersion(selectedVersion.VersionID, selectedVersion.VersionName, descTextBox.Text, selectedVersion.StatusOfVersion, startDateTimePicker.Value.Date, endDateTimePicker.Value.Date, clientTextBox.Text, FetchAttachmentFiles());
                DataHandler.AddEdit(new TeamTracker.Edit()
                {
                    EditModeID = selectedVersion.VersionID,
                    ModeOfEdit = EditMode.Version
                });
                InitializePage();
            }
        }

        private BooleanMsg isEligibleForVersionUpgrade()
        {
            if (selectedVersion == null) return "No Version Selected for Version Edition";

            if (selectedVersion.StatusOfVersion == ProjectStatus.Completed && endDateTimePicker.Value.Date >= DateTime.Now.Date) return "Completed Project Version should be behind today's Date";

            if (selectedVersion.StatusOfVersion == ProjectStatus.UpComing && startDateTimePicker.Value.Date <= DateTime.Now.Date) return "Upcoming Project Version should be beyond today's Date";

            if ((selectedVersion.StatusOfVersion == ProjectStatus.OnStage || (selectedVersion.StatusOfVersion == ProjectStatus.OnProcess) || (selectedVersion.StatusOfVersion == ProjectStatus.Deployment)) && !(startDateTimePicker.Value.Date <= DateTime.Now.Date && DateTime.Now.Date <= endDateTimePicker.Value.Date)) return "OnProcess Project Version should not be beyond today's Date Or behind Todays date";

            if (startDateTimePicker.Value.Date == endDateTimePicker.Value.Date) return "Project Cannot be Started on Mentioned Date\nPlease Choose Another Date";

            if (descTextBox.Text == "" || descTextBox.Text == "Enter Version Description") return "Version Description Not in Valid Format";

            if (clientTextBox.Text == "" || !clientTextBox.Text.Contains("@gmail.com") || clientTextBox.Text == "Client Email")
            {
                return "Enter Proper EmailID";
            }

            if ((endDateTimePicker.Value.Date - startDateTimePicker.Value.Date).Days < 19)
            {
                return "Project Duration Should be Atleast 20 Days";
            }

            return true;
        }

        private List<VersionAttachment> FetchAttachmentFiles()
        {
            List<VersionAttachment> attachments = new List<VersionAttachment>();

            if (fileAttachment1.AttachmentCollection == null || fileAttachment1.AttachmentCollection.Count == 0)
                return null;

            foreach (var Iter in fileAttachment1.AttachmentCollection)
            {
                attachments.Add(Iter.Value);
            }

            return attachments;
        }

        

        private void OnDeleteClicked(object sender, EventArgs e)
        {
            if (selectedVersion == null)
            {
                ProjectManagerMainForm.notify.AddNotification("Warning", "No Version Selected for Version Edition") ;
                return;
            }

            WarningForm form = new WarningForm();

            if(selectedVersion.StatusOfVersion == ProjectStatus.OnProcess || selectedVersion.StatusOfVersion == ProjectStatus.OnStage || selectedVersion.StatusOfVersion == ProjectStatus.Deployment)
            {
                form.Content = "Are you sure, you want to delete the Project Version? This Version is Already in Development Stage. This will also delete the task, milestone, task source code and Complete Source Code related to it.";
            }
            else
            {
                form.Content = "Are you sure, you want to delete the Project Version? This will also delete the task, milestone, task source code and Complete Source Code related to it.";
            }
            
            form.WarningStatus += OnDeleteStatus;

            transparentForm = new TransparentForm();
            transparentForm.Show();
            transparentForm.ShowForm(form);
        }

        private void OnDeleteStatus(object sender, bool e)
        {
            (sender as WarningForm).Close();

            if (e)
            {
                VersionManager.DeleteVersion(selectedVersion);
                InitializePage();
            }
        }

        private void BorderDrawPaint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(0, 0, (sender as Control).Width - 2, (sender as Control).Height - 2);
            Pen border1 = new Pen(ThemeManager.CurrentTheme.SecondaryIII, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            if (sender is Button)
                e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 5));
            else
                e.Graphics.DrawPath(border1, BorderGraphicsPath.GetRoundRectangle(rec, 10));

            border1.Dispose();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeBorder();
        }

        private void InitializeBorder()
        {
            panel13.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel13.Width, panel13.Height, 20, 20));
            endDatePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, endDatePanel.Width, endDatePanel.Height, 20, 20));
            startDatePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, startDatePanel.Width, startDatePanel.Height, 20, 20));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 20, 20));
            updateButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, updateButton.Width, updateButton.Height, 10, 10));
            DeleteButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, DeleteButton.Width, DeleteButton.Height, 10, 10));
        }

        private void OnLineSeperatePaint(object sender, PaintEventArgs e)
        {
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(border, 0, (sender as Control).Height - 1, (sender as Control).Width, (sender as Control).Height - 1);
            border.Dispose();
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "BackBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    BackBtn.Image = Properties.Resources.Cold_Left_Dark_Hover;
                }
                else
                {
                    BackBtn.Image = Properties.Resources.Heat_Left_Dark_Hover;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    NextBtn.Image = Properties.Resources.Cold_Right_Dark_Hover;
                }
                else
                {
                    NextBtn.Image = Properties.Resources.Heat_Right_Dark_Hover;
                }
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image?.Dispose();
            if ((sender as Control).Name == "BackBtn")
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    BackBtn.Image = isBackEnable ? Properties.Resources.Cold_Left_Dark : Properties.Resources.Cold_Left_Medium;
                }
                else
                {
                    BackBtn.Image = isBackEnable ? Properties.Resources.Heat_Left_Dark : Properties.Resources.Heat_Left_Medium;
                }
            }
            else
            {
                if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
                {
                    NextBtn.Image = isNextEnable ? Properties.Resources.Cold_Right_Dark : Properties.Resources.Cold_Right_Medium;
                }
                else
                {
                    NextBtn.Image = isNextEnable ? Properties.Resources.Heat_Right_Dark : Properties.Resources.Heat_Right_Medium;
                }
            }
        }

        private void ResetButton()
        {
            if (ThemeManager.CurrentThemeMode == ThemeMode.Cold)
            {
                BackBtn.Image = isBackEnable ? Properties.Resources.Cold_Left_Dark : Properties.Resources.Cold_Left_Medium;
                NextBtn.Image = isNextEnable ? Properties.Resources.Cold_Right_Dark : Properties.Resources.Cold_Right_Medium;
            }
            else
            {
                BackBtn.Image = isBackEnable ? Properties.Resources.Heat_Left_Dark : Properties.Resources.Heat_Left_Medium;
                NextBtn.Image = isNextEnable ? Properties.Resources.Heat_Right_Dark : Properties.Resources.Heat_Right_Medium;
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

        private TransparentForm transparentForm;
        private ProjectBoardTemplate template;
        private bool isBackEnable, isNextEnable;
        private int startIdx, endIdx;
        private Projects selectedProject;
        private List<Projects> filteredProjectCollection;
        private ProjectVersion selectedVersion;
        private List<ProjectVersion> selectedVersionCollection;
    }
}
