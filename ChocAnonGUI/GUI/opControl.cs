﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnonGUI
{
    public partial class OpControl : UserControl
    {
        public OpControl()
        {
            InitializeComponent();
        }

        private void chocolate1_Click(object sender, EventArgs e)
        {

        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            addmemberForm launchAddMem = new addmemberForm();
            launchAddMem.ShowDialog();
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {

        }
    }
}