﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnonGUI.GUI.Popup
{
    public partial class SuccessForm : Form
    {
        public SuccessForm(string message)
        {
            InitializeComponent();
            successLabel.Text = message;
        }
    }
}
