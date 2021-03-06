﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnonGUI.GUI.Operator
{
    public partial class ConfirmDeleteForm : Form
    {
        public bool check { get; set; }
        public ConfirmDeleteForm(bool temp)
        {
            InitializeComponent();
            check = temp;
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            check = true;
            this.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            check = false;
            this.Close();
        }
    }
}
