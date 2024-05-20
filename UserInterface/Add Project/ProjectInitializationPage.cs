using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using UserInterface.Add_Project.Custom_Control;
using UserInterface.ViewPage;
using UserInterface;

namespace TeamTracker
{
    public partial class ProjectInitializationPage : UserControl
    {
        public ProjectInitializationPage()
        {
            InitializeComponent();
            InitializePlaceHolders();
            InitializePageColor();
            ThemeManager.ThemeChange += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            InitializePageColor();
        }

        private void UnSubscribeEventsAndRemoveMemory()
        {
            ThemeManager.ThemeChange -= OnThemeChanged;
            availableTeamLeaders1.TeamLeaderClick -= OnTeamLeaderClick;
            clearButton.Click -= OnCLearClick;  clearButton.MouseEnter -= OnButtonMouseEnter;   clearButton.MouseLeave -= OnButtonMouseLeave;   clearButton.Paint -= BorderDrawPaint;
            CreateProject.Click -= OnCreateClick; CreateProject.MouseEnter -= OnButtonMouseEnter; CreateProject.MouseLeave -= OnButtonMouseLeave; CreateProject.Paint -= BorderDrawPaint;
            endDateTimePicker.ValueChanged -= OnDateValueChanged;   startDateTimePicker.ValueChanged -= OnDateValueChanged;
            panel1.Paint -= BorderDrawPaint;    panel2.Paint -= BorderDrawPaint;    panel3.Paint -= BorderDrawPaint;    panel5.Paint -= BorderDrawPaint;    panel6.Paint -= BorderDrawPaint;
            ProjectEntryTablePanel.Paint -= TextBorderPanelPaint;
            selectedTeamLeader1.OnChangeTeamLeader -= SelectedTeamLeader_OnChangeTeamLeader;
            tableLayoutPanel5.Paint -= CLientTextBorderPanelPaint;
            projectDescTextBox.GotFocus -= RemoveDescPlaceHolders;
            projectDescTextBox.LostFocus -= AddDescPlaceHolders;
            projectTitleTextBox.GotFocus -= RemoveTitlePlaceHolders;
            projectTitleTextBox.LostFocus -= AddTitlePlaceHolders;
            clientTextBox.GotFocus -= RemoveClientPlaceHolders;
            clientTextBox.LostFocus -= AddClientPlaceHolders;
        }

        private void InitializePageColor()
        {
            tableLayoutPanel2.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            fileAttachment1.BackColor = panel1.BackColor = panel2.BackColor = panel3.BackColor = panel4.BackColor = panel5.BackColor = panel6.BackColor = ucNotFound1.BackColor = clearButton.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label1.ForeColor = label2.ForeColor = label3.ForeColor = label4.ForeColor = label5.ForeColor = projectDescTextBox.ForeColor = projectTitleTextBox.ForeColor = clientTextBox.ForeColor = ThemeManager.GetTextColor(panel6.BackColor);
            startDateTimePicker.TextColor = startDateTimePicker.BorderColor = endDateTimePicker.TextColor = endDateTimePicker.BorderColor = CreateProject.BackColor = ThemeManager.CurrentTheme.PrimaryI;
            CreateProject.ForeColor = ThemeManager.GetTextColor(CreateProject.BackColor);
            clearButton.ForeColor = ThemeManager.GetTextColor(clearButton.BackColor);
            projectDescTextBox.BackColor = projectTitleTextBox.BackColor = clientTextBox.BackColor = startDateTimePicker.SkinColor = endDateTimePicker.SkinColor = ThemeManager.CurrentTheme.SecondaryIII;
        }

        public void InitializePage()
        {
            clearButton.Focus();
            InitializePageColor();
            projectDescTextBox.Text = "Enter your Desc...";
            projectTitleTextBox.Text = "Project Name";
            clientTextBox.Text = "Client Email";
            startDateTimePicker.Value = DateTime.Now;
            endDateTimePicker.Value = DateTime.Now;
            fileAttachment1.AttachmentCollection = null;
            fileAttachment1.ClearAttachments();
            ucNotFound1.Visible = true;
            availableTeamLeaders1.Visible = false;
            selectedTeamLeader1.Visible = false;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            panel1.Invalidate();
            panel2.Invalidate();
            panel3.Invalidate();
            panel4.Invalidate();
            panel5.Invalidate();
            panel6.Invalidate();
            InitializeRoundedEdge();
        }

        private void InitializeRoundedEdge()
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width, panel4.Height, 20, 20));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            CreateProject.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, CreateProject.Width, CreateProject.Height, 10, 10));
            clearButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clearButton.Width, clearButton.Height, 10, 10));
        }

        private void ProjectEntryTablePanel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(ThemeManager.CurrentTheme.PrimaryI);
            e.Graphics.DrawLine(pen, new Point(10, projectTitleTextBox.Location.Y + projectTitleTextBox.Height + 1), new Point(ProjectEntryTablePanel.Width - 10, projectTitleTextBox.Location.Y + projectTitleTextBox.Height + 1));
            e.Graphics.DrawLine(pen, new Point(10, projectDescTextBox.Location.Y + projectDescTextBox.Height + 1), new Point(ProjectEntryTablePanel.Width - 10, projectDescTextBox.Location.Y + projectDescTextBox.Height + 1));
            pen.Dispose();
        }

        private void ProjectEntryTablePanel_Resize(object sender, EventArgs e)
        {
            ProjectEntryTablePanel.Invalidate();
        }

        private void OnTeamLeaderClick(Employee employee)
        {
            selectedTeamLeader1.EmployeeProfile = employee;
            teamLeader = employee;
            selectedTeamLeader1.Visible = true;
            availableTeamLeaders1.Visible = false;
            ucNotFound1.Visible = false;
        }

        private void SelectedTeamLeader_OnChangeTeamLeader(object sender, EventArgs e)
        {
            teamLeader = null;
            selectedTeamLeader1.Visible = false;
            availableTeamLeaders1.Visible = true;
            ucNotFound1.Visible = false;
        }

        private void InitializePlaceHolders()
        {
            projectDescTextBox.GotFocus += RemoveDescPlaceHolders;
            projectDescTextBox.LostFocus += AddDescPlaceHolders;
            projectTitleTextBox.GotFocus += RemoveTitlePlaceHolders;
            projectTitleTextBox.LostFocus += AddTitlePlaceHolders;
            clientTextBox.GotFocus += RemoveClientPlaceHolders;
            clientTextBox.LostFocus += AddClientPlaceHolders;
        }

        private void AddClientPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientTextBox.Text))
                clientTextBox.Text = "Client Email";
        }

        private void RemoveClientPlaceHolders(object sender, EventArgs e)
        {
            if (clientTextBox.Text == "Client Email")
            {
                clientTextBox.Text = "";
            }
        }

        private void AddTitlePlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(projectTitleTextBox.Text))
                projectTitleTextBox.Text = "Project Name";
        }

        private void RemoveTitlePlaceHolders(object sender, EventArgs e)
        {
            if (projectTitleTextBox.Text == "Project Name")
            {
                projectTitleTextBox.Text = "";
            }
        }

        private void AddDescPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(projectDescTextBox.Text))
                projectDescTextBox.Text = "Enter your Desc...";
        }

        private void RemoveDescPlaceHolders(object sender, EventArgs e)
        {
            if (projectDescTextBox.Text == "Enter your Desc...")
            {
                projectDescTextBox.Text = "";
            }
        }

        private void OnDateValueChanged(object sender, EventArgs e)
        {
            if (VersionManager.CheckDate(startDateTimePicker.Value, endDateTimePicker.Value))
            {
                List<Employee> availableTL = EmployeeManager.FetchAvailableTeamLeaders(startDateTimePicker.Value, endDateTimePicker.Value);
                if (availableTL.Count == 0)
                {
                    teamLeader = null;
                    availableTeamLeaders1.Visible = false;
                    selectedTeamLeader1.Visible = false;
                    ucNotFound1.Visible = true;
                }
                else
                {
                    teamLeader = null;
                    availableTeamLeaders1.ClearAllEmployees();
                    availableTeamLeaders1.TeamLeaders = availableTL;
                    availableTeamLeaders1.Visible = true;
                    selectedTeamLeader1.Visible = false;
                    ucNotFound1.Visible = false;
                }
            }
            else
            {
                teamLeader = null;
                availableTeamLeaders1.Visible = false;
                selectedTeamLeader1.Visible = false;
                ucNotFound1.Visible = true;
            }
        }

        private void OnCreateClick(object sender, EventArgs e)
        {
            if (EligibleForCreatingProject())
            {
                List<VersionAttachment> attachments = FetchAttachmentFiles();
                if (attachments.Count == 0)
                {
                    WarningForm form = new WarningForm();
                    form.Content = "Are you sure, you want to Create a Project Without any Attachments?";
                    form.WarningStatus += OnWarningStatus;

                    transparentForm = new TransparentForm();
                    transparentForm.Show();
                    transparentForm.ShowForm(form);
                    //form.Show();
                }
                else
                {
                    VersionManager.AddProject(projectTitleTextBox.Text, projectDescTextBox.Text, teamLeader.EmployeeID, startDateTimePicker.Value.Date, endDateTimePicker.Value.Date, clientTextBox.Text, attachments);
                    DataHandler.AddNotification("New Project Assigned to Your Team", "Hello" + teamLeader.EmployeeFirstName +",\r\n\r\nI hope this message finds you well. I'm excited to inform you that a new project " + projectTitleTextBox.Text + "has been created and assigned to your team by " + EmployeeManager.CurrentEmployee.EmployeeFirstName, DateTime.Now, teamLeader.EmployeeID);
                    ProjectManagerMainForm.notify.AddNotification("Project Created", projectTitleTextBox.Text + "\n" + "Version Name: 1.0");
                    InitializePage();
                }
            }
        }

        private void OnWarningStatus(object sender, bool e)
        {
            (sender as WarningForm).Dispose();
            (sender as WarningForm).Close();

            if (ParentForm != null)
                ParentForm.Show();

            if (e)
            {
                VersionManager.AddProject(projectTitleTextBox.Text, projectDescTextBox.Text, teamLeader.EmployeeID, startDateTimePicker.Value.Date, endDateTimePicker.Value.Date, clientTextBox.Text, null);
                ProjectManagerMainForm.notify.AddNotification("Project Created", projectTitleTextBox.Text + "\n" + "Version Name: 1.0");
                DataHandler.AddNotification("New Project Assigned to Your Team", "Hello" + teamLeader.EmployeeFirstName + ",\r\n\r\nI hope this message finds you well. I'm excited to inform you that a new project " + projectTitleTextBox.Text + "has been created and assigned to your team by " + EmployeeManager.CurrentEmployee.EmployeeFirstName, DateTime.Now, teamLeader.EmployeeID);
                InitializePage();
            }
        }

        private bool EligibleForCreatingProject()
        {
            if (clientTextBox.Text == "" || !clientTextBox.Text.Contains("@gmail.com") || clientTextBox.Text == "Client Email" || clientTextBox.Text.Length <= 10)
            {
                ProjectManagerMainForm.notify.AddNotification("Project Creation Failed", "Invalid Input\nEnter Proper EmailID");
                return false;
            }

            for(int ctr=0; ctr < clientTextBox.Text.Length - 10; ctr++)
            {
                if(!((clientTextBox.Text[ctr]<='z' && clientTextBox.Text[ctr]>='a') || (clientTextBox.Text[ctr] <= '9' && clientTextBox.Text[ctr] >= '0')))
                {
                    ProjectManagerMainForm.notify.AddNotification("Project Creation Failed", "Invalid Input\nEnter Proper EmailID");
                    return false;
                }
            }

            if (projectTitleTextBox.Text == "" ||  projectTitleTextBox.Text == "Project Name")
            {
                ProjectManagerMainForm.notify.AddNotification("Project Creation Failed", "Invalid Input\nEnter Project Name Properly");
                return false;
            }

            if (projectDescTextBox.Text == "" || projectDescTextBox.Text == "Enter your Desc..." || projectDescTextBox.Text.Length < 300)
            {
                ProjectManagerMainForm.notify.AddNotification("Project Creation Failed", "Invalid Input\nEnter Proper Description\nDescription Length Should be Atleast 300 Characters");
                return false;
            }

            if (VersionManager.IsProjectNameAlreadyExist(projectTitleTextBox.Text))
            {
                ProjectManagerMainForm.notify.AddNotification("Project Creation Failed", "Project Name Already Exists\nYou can switch to Version Upgrade Page");
                return false;
            }

            if (teamLeader == null)
            {
                ProjectManagerMainForm.notify.AddNotification("Project Creation Failed", "No Team Leaders Appointed");
                return false;
            }

            if (!VersionManager.CheckDate(startDateTimePicker.Value, endDateTimePicker.Value))
            {
                ProjectManagerMainForm.notify.AddNotification("Project Creation Failed", "Invalid Input\nEnter Valid Project Date");
                return false;
            }

            if((endDateTimePicker.Value.Date - startDateTimePicker.Value.Date).Days < 19)
            {
                ProjectManagerMainForm.notify.AddNotification("Project Creation Failed", "Invalid Input\nProject Duration Should be Atleast 20 Days");
                return false;
            }
            return true;
        }

        private List<VersionAttachment> FetchAttachmentFiles()
        {
            List<VersionAttachment> attachments = new List<VersionAttachment>();

            if (fileAttachment1.AttachmentCollection == null || fileAttachment1.AttachmentCollection.Count == 0)
                return attachments;

            foreach (var Iter in fileAttachment1.AttachmentCollection)
            {
                attachments.Add(Iter.Value);
            }

            if(attachments.Count > 0)
            return attachments;
            else { return null; }
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

        private void TextBorderPanelPaint(object sender, PaintEventArgs e)
        {
            Pen border1 = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(border1, new Point(projectTitleTextBox.Location.X, projectTitleTextBox.Location.Y + projectTitleTextBox.Height), new Point(projectTitleTextBox.Location.X + projectTitleTextBox.Width - 1, projectTitleTextBox.Location.Y + projectTitleTextBox.Height));
            e.Graphics.DrawLine(border1, new Point(projectDescTextBox.Location.X, projectDescTextBox.Location.Y + projectDescTextBox.Height), new Point(projectDescTextBox.Location.X + projectDescTextBox.Width - 1, projectDescTextBox.Location.Y + projectDescTextBox.Height));
            border1.Dispose();
        }

        private void CLientTextBorderPanelPaint(object sender, PaintEventArgs e)
        {
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(border, new Point(clientTextBox.Location.X, clientTextBox.Location.Y + clientTextBox.Height), new Point(clientTextBox.Location.X + clientTextBox.Width - 1, clientTextBox.Location.Y + clientTextBox.Height));
            border.Dispose();
        }

        private void OnCLearClick(object sender, EventArgs e)
        {
            InitializePage();
        }

        private void OnButtonMouseEnter(object sender, EventArgs e)
        {
            if ((sender as Control).Name == "clearButton")
                clearButton.BackColor = ThemeManager.GetHoverColor(clearButton.BackColor);
            else
                CreateProject.BackColor = ThemeManager.GetHoverColor(CreateProject.BackColor);

            (sender as Control).ForeColor = ThemeManager.GetTextColor((sender as Control).BackColor);
        }

        private void OnButtonMouseLeave(object sender, EventArgs e)
        {
            if ((sender as Control).Name == "clearButton")
                clearButton.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            else
                CreateProject.BackColor = ThemeManager.CurrentTheme.PrimaryI;

            (sender as Control).ForeColor = ThemeManager.GetTextColor((sender as Control).BackColor);
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
        private Employee teamLeader;
    }
}
