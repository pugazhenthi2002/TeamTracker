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
using GoLibrary;
using UserInterface;
using UserInterface.ViewPage;

namespace TeamTracker
{
    public partial class VersionUpgrade : UserControl
    {
        public VersionUpgrade()
        {
            InitializeComponent();
            InitializeBorder();
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
            versionNameTextBox.LostFocus -= AddVersionNamePlaceHolders;
            versionNameTextBox.GotFocus -= RemoveVersionNamePlaceHolders;
            descTextBox.GotFocus -= RemoveVersionDescPlaceHolders;
            descTextBox.LostFocus -= AddVersionDescPlaceHolders;
            clientTextBox.GotFocus -= RemoveClientPlaceHolders;
            clientTextBox.LostFocus -= AddClientPlaceHolders;
            chooseProjectLabel.Click -= OnChooseProject; chooseProjectLabel.MouseEnter -= OnChooseProjectLabelEnter;
            chooseProjectLabel.MouseLeave -= OnChooseProjectLabelLeave; chooseProjectLabel.Paint -= BorderDrawPaint;
            clearButton.Click -= ClearClick;    clearButton.MouseEnter -= OnButtonMouseEnter;   clearButton.MouseLeave -= OnButtonMouseLeave;   clearButton.Paint -= BorderDrawPaint;
            upgradeButton.Click -= upgradeButton_Click; upgradeButton.MouseEnter -= OnButtonMouseEnter; upgradeButton.MouseLeave -= OnButtonMouseLeave; upgradeButton.Paint -= BorderDrawPaint;
            endDatePanel.Paint -= BorderDrawPaint;  startDatePanel.Paint -= BorderDrawPaint;
            endDateTimePicker.ValueChanged -= OnDateValueChanged;   startDateTimePicker.ValueChanged -= OnDateValueChanged;
            panel10.Paint -= OnTextBoxBorderPaint;  panel2.Paint -= BorderDrawPaint;    panel3.Paint -= BorderDrawPaint;    panel4.Paint -= OnTextBoxBorderPaint; panel5.Paint -= BorderDrawPaint;
            panel6.Paint -= BorderDrawPaint; panel7.Paint -= BorderDrawPaint;   panel8.Paint -= BorderDrawPaint;    panel9.Paint -= OnTextBoxBorderPaint;
        }

        private void InitializePageColor()
        {
            clearButton.BackColor = chooseProjectLabel.BackColor = panel2.BackColor = panel3.BackColor = panel5.BackColor = startDatePanel.BackColor = endDatePanel.BackColor = panel6.BackColor = panel8.BackColor = fileAttachment1.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            label1.ForeColor = label3.ForeColor = label5.ForeColor = endDateLabel.ForeColor = startDateLabel.ForeColor = chooseProjectLabel.ForeColor = ThemeManager.GetTextColor(panel1.BackColor);
            upgradeButton.BackColor = startDateTimePicker.BorderColor = startDateTimePicker.TextColor = endDateTimePicker.BorderColor = endDateTimePicker.TextColor = ThemeManager.CurrentTheme.PrimaryI;
            BackColor = descTextBox.BackColor = startDateTimePicker.SkinColor = endDateTimePicker.SkinColor = ThemeManager.CurrentTheme.SecondaryIII;
            upgradeButton.ForeColor = ThemeManager.GetTextColor(upgradeButton.BackColor);
            clearButton.ForeColor = ThemeManager.GetTextColor(clearButton.BackColor);
            clientTextBox.BackColor = versionNameTextBox.BackColor = ThemeManager.CurrentTheme.SecondaryIII;
            versionNameTextBox.ForeColor = clientTextBox.ForeColor = descTextBox.ForeColor = ThemeManager.CurrentTheme.PrimaryI;
            ucNotFound1.BackColor = ucNotFound2.BackColor = ThemeManager.CurrentTheme.SecondaryII;
        }

        public void InitializePage()
        {
            InitializePageColor();
            chooseProjectLabel.Text = "Choose Project";
            versionNameTextBox.Text = "Enter Version";
            descTextBox.Text = "Enter Version Description";
            clientTextBox.Text = "Enter Client Email";
            ucNotFound1.Visible = ucNotFound2.Visible = true;
            startDateTimePicker.Value = endDateTimePicker.Value = DateTime.Today;
            latestUpgradedVersion1.LatestVersion = null;
            fileAttachment1.AttachmentCollection = null;
            fileAttachment1.ClearAttachments();
            profilePicAndName1.EmployeeProfile = null;
        }

        private void InitializePlaceHolders()
        {
            versionNameTextBox.LostFocus += AddVersionNamePlaceHolders;
            versionNameTextBox.GotFocus += RemoveVersionNamePlaceHolders;
            descTextBox.GotFocus += RemoveVersionDescPlaceHolders;
            descTextBox.LostFocus += AddVersionDescPlaceHolders;
            clientTextBox.GotFocus += RemoveClientPlaceHolders;
            clientTextBox.LostFocus += AddClientPlaceHolders;
        }

        private void AddVersionNamePlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(versionNameTextBox.Text))
                versionNameTextBox.Text = "Enter Version";
        }

        private void RemoveVersionNamePlaceHolders(object sender, EventArgs e)
        {
            if (versionNameTextBox.Text == "Enter Version")
            {
                versionNameTextBox.Text = "";
            }
        }

        private void RemoveVersionDescPlaceHolders(object sender, EventArgs e)
        {
            if (descTextBox.Text == "Enter Version Description")
            {
                descTextBox.Text = "";
            }
        }

        private void AddVersionDescPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descTextBox.Text))
                descTextBox.Text = "Enter Version Description";
        }

        private void RemoveClientPlaceHolders(object sender, EventArgs e)
        {
            if (clientTextBox.Text == "Enter Client Email")
            {
                clientTextBox.Text = "";
            }
        }

        private void AddClientPlaceHolders(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientTextBox.Text))
                clientTextBox.Text = "Enter Client Email";
        }

        

        private void InitializeBorder()
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width, panel3.Height, 20, 20));
            endDatePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, endDatePanel.Width, endDatePanel.Height, 20, 20));
            startDatePanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, startDatePanel.Width, startDatePanel.Height, 20, 20));
            panel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel5.Width, panel5.Height, 20, 20));
            panel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel6.Width, panel6.Height, 20, 20));
            panel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel7.Width, panel7.Height, 20, 20));
            panel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel8.Width, panel8.Height, 20, 20));
            upgradeButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, upgradeButton.Width, upgradeButton.Height, 10, 10));
            clearButton.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, clearButton.Width, clearButton.Height, 10, 10));
        }

        private void OnChooseProject(object sender, EventArgs e)
        {
            ChooseProjectForm form = new ChooseProjectForm();
            form.AvailableProjects = VersionManager.FetchAllProjectsOnCompletedStatus();
            form.ProjectSelect += OnProjectSelected;

            transparentForm = new TransparentForm();
            transparentForm.Show(ParentForm);
            transparentForm.ShowForm(form);
        }

        private void OnProjectSelected(object sender, Projects e)
        {
            (sender as ChooseProjectForm).Close();

            if (ParentForm != null)
                ParentForm.Show();

            if (e != null)
            {
                project = e;
                chooseProjectLabel.Text = e.ProjectName;
                InitializeVersionPage();
            }
        }

        private void InitializeVersionPage()
        {
            profilePicAndName1.Visible = latestUpgradedVersion1.Visible = true;
            ucNotFound1.Visible = ucNotFound2.Visible = false;
            profilePicAndName1.EmployeeProfile = EmployeeManager.FetchEmployeeFromEmpID(project.TeamLeadID);
            latestUpgradedVersion1.LatestVersion = VersionManager.FetchProjectLatestVersion(project.ProjectID);
        }

        private void upgradeButton_Click(object sender, EventArgs e)
        {
            BooleanMsg message = isEligibleForVersionUpgrade();
            if (message)
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
                    VersionManager.AddVersion(versionNameTextBox.Text, descTextBox.Text, profilePicAndName1.EmployeeProfile.EmployeeID, startDateTimePicker.Value.Date, endDateTimePicker.Value.Date, clientTextBox.Text, project.ProjectID, attachments);
                    ProjectManagerMainForm.notify.AddNotification("Version Created", project.ProjectName + "\n" + "Version Name: " + versionNameTextBox.Text);
                    DataHandler.AddNotification("New Upgrade Alert: Enhanced Notification System for Team Leaders!", "Dear Team Leader,\r\n\r\nWe're excited to announce the latest upgrade to our " + project.ProjectName + " application! As a team leader, staying informed and in control is essential, which is why we've revamped our notification system to better cater to your needs." + "\n" + "Version Name: " + versionNameTextBox.Text, DateTime.Now, project.TeamLeadID);
                    InitializePage();
                }

            }
            else
            {
                ProjectManagerMainForm.notify.AddNotification("Invalid Input", message.Message);
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
                VersionManager.AddVersion(versionNameTextBox.Text, descTextBox.Text, profilePicAndName1.EmployeeProfile.EmployeeID, startDateTimePicker.Value.Date, endDateTimePicker.Value.Date, clientTextBox.Text, project.ProjectID, null);
                InitializePage();
                ProjectManagerMainForm.notify.AddNotification("Version Created", project.ProjectName + "\n" + "Version Name: " + versionNameTextBox.Text);
                DataHandler.AddNotification("New Upgrade Alert: Enhanced Notification System for Team Leaders!", "Dear Team Leader,\r\n\r\nWe're excited to announce the latest upgrade to our " + project.ProjectName + " application! As a team leader, staying informed and in control is essential, which is why we've revamped our notification system to better cater to your needs." + "\n" + "Version Name: " + versionNameTextBox.Text, DateTime.Now, project.TeamLeadID);
            }
        }

        private BooleanMsg isEligibleForVersionUpgrade()
        {
            if (project == null) return "No Project Selected for Version Upgrade";

            if (!VersionManager.IsTeamAvailableForProject(project.TeamLeadID, startDateTimePicker.Value, endDateTimePicker.Value))
            {
                DateTime availableDate = VersionManager.FetchTeamLeadAvailableDate(project.ProjectID);
                return "Project Cannot be Started on Mentioned Date\nTeam Leader Available After "+ availableDate.ToString();
            }

            if (startDateTimePicker.Value.Date == endDateTimePicker.Value.Date) return "Project Cannot be Started on Mentioned Date\nPlease Choose Another Date";

            if (versionNameTextBox.Text == "" || versionNameTextBox.Text == "Enter Version") return "Version Name Not Mentioned";

            foreach(var Iter in versionNameTextBox.Text)
            {
                if(!((Iter<='9' && Iter>='0') || Iter == '.'))
                {
                    return "Version Name should be only Pointed Format\nLike 1.0,  2.1";
                }
            }

            if (VersionManager.IsVersionNameAlreadyExist(versionNameTextBox.Text, project.ProjectID)) return "Version Name Already Exists\nTry Another Version";

            if(descTextBox.Text == "" || descTextBox.Text == "Enter Version Description")   return "Version Description Not Mentioned";

            if (clientTextBox.Text == "" || !clientTextBox.Text.Contains("@gmail.com") || clientTextBox.Text == "Client Email")
            {
                return "Invalid Input\nEnter Proper EmailID";
            }

            if ((endDateTimePicker.Value.Date - startDateTimePicker.Value.Date).Days < 19)
            {
                return "Project Duration Should be Atleast 20 Days";
            }

            return true;
        }

        private void OnDateValueChanged(object sender, EventArgs e)
        {
            if(project!=null && VersionManager.IsTeamAvailableForProject(project.TeamLeadID, startDateTimePicker.Value, endDateTimePicker.Value))
            {
                ucNotFound1.Visible = ucNotFound2.Visible = false;
                profilePicAndName1.Visible = latestUpgradedVersion1.Visible = true;
            }
            else
            {
                ucNotFound1.Visible = ucNotFound2.Visible = true;
                profilePicAndName1.Visible = latestUpgradedVersion1.Visible = false;
            }
        }

        private void OnChooseProjectLabelEnter(object sender, EventArgs e)
        {
            chooseProjectLabel.BackColor = ThemeManager.GetHoverColor(chooseProjectLabel.BackColor);
            chooseProjectLabel.ForeColor = ThemeManager.GetTextColor(chooseProjectLabel.BackColor);
        }

        private void OnChooseProjectLabelLeave(object sender, EventArgs e)
        {
            chooseProjectLabel.BackColor = ThemeManager.GetHoverColor(ThemeManager.CurrentTheme.SecondaryII);
            chooseProjectLabel.ForeColor = ThemeManager.GetTextColor(chooseProjectLabel.BackColor);
        }

        private void ClearClick(object sender, EventArgs e)
        {
            InitializePage();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            InitializeBorder();
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

            if (attachments.Count > 0)
                return attachments;
            else { return null; }
        }

        private void OnTextBoxBorderPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen border = new Pen(ThemeManager.CurrentTheme.PrimaryI, 2);
            e.Graphics.DrawLine(border, new Point(5, (sender as Control).Height - 7), new Point((sender as Control).Width - 5, (sender as Control).Height - 7));
            border.Dispose();
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

        private void OnButtonMouseEnter(object sender, EventArgs e)
        {
            if ((sender as Control).Name == "clearButton")
                clearButton.BackColor = ThemeManager.GetHoverColor(clearButton.BackColor);
            else
                upgradeButton.BackColor = ThemeManager.GetHoverColor(upgradeButton.BackColor);

            (sender as Control).ForeColor = ThemeManager.GetTextColor((sender as Control).BackColor);
        }

        private void OnButtonMouseLeave(object sender, EventArgs e)
        {
            if ((sender as Control).Name == "clearButton")
                clearButton.BackColor = ThemeManager.CurrentTheme.SecondaryII;
            else
                upgradeButton.BackColor = ThemeManager.CurrentTheme.PrimaryI;

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
        private Projects project;

    }
}
