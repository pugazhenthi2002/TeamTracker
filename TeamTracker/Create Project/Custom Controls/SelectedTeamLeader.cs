﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamTracker
{
    public partial class SelectedTeamLeader : UserControl
    {
        public Employee EmployeeProfile
        {
            get
            {
                return employee;
            }

            set
            {
                employee = value;
                if(value!=null)
                {
                    label2.Text = value.EmployeeFirstName;
                    if(profilePictureBox.Image != null)
                    {
                        profilePictureBox.Image.Dispose();
                    }
                    profilePictureBox.Image = Image.FromFile(value.EmpProfileLocation);
                }
            }
        }

        public event EventHandler OnChangeTeamLeader;
        public SelectedTeamLeader()
        {
            InitializeComponent();
        }

        private void OnResize(object sender, EventArgs e)
        {
            int value = (Width - profilePictureBox.Width) / 2;
            panel4.Padding = new Padding(value, 30, value, 0);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            int value = (Width - profilePictureBox.Width) / 2;
            panel4.Padding = new Padding(value, 0, value, 0);
        }

        private void OnChangeTLClick(object sender, EventArgs e)
        {
            OnChangeTeamLeader?.Invoke(this, new EventArgs());
        }

        private Employee employee;
    }
}
