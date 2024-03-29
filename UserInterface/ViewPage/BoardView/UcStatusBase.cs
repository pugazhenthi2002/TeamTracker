﻿using System;
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
    public partial class UcStatusBase : UserControl
    {
        public UcStatusBase()
        {
            InitializeComponent();
        }

        public ProjectStatus Status
        {
            get { return status; }
            set
            {
                status = value;
                
            }
        }

        private ProjectStatus status;

    }
}
