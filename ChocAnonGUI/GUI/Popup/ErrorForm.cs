using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnonGUI;


namespace ChocAnonGUI.GUI.Popup
{
    public partial class ErrorForm : Form
    {

        public ErrorForm(string message)
        {
            InitializeComponent();
            errorLabel.Text = message;
        }
    }
}
