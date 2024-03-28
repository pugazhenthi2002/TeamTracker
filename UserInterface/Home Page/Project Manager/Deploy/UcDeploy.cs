using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class UcDeploy : UserControl
    {
        public UcDeploy()
        {
            InitializeComponent();
        }

        private void OnClickProjectNameAndVersion(object sender, EventArgs e)
        {
            Dictionary<string, ProjectVersion> collection = new Dictionary<string, ProjectVersion>();
            collection.Add("Pedestrian Detection", new ProjectVersion() { VersionName = "v 1.0" });
            collection.Add("Chat Application", new ProjectVersion() { VersionName = "v 2.0" });
            collection.Add("Expense Tracker", new ProjectVersion() { VersionName = "v 1.3" });
            OverviewDropDownForm form = new OverviewDropDownForm();
            form.BackColor = Color.FromArgb(221, 230, 237);
            form.currentVersionCollection = collection;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = Cursor.Position;
            form.Show();
        }
    }
}
