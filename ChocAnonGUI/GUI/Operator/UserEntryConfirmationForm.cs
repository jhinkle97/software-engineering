using ChocAnonGUI.Backend.Models;
using System;
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
    public partial class UserEntryConfirmationForm : Form
    {
        public UserEntryConfirmationForm(UserModel temp)
        {
            InitializeComponent();
            Console.WriteLine(temp);
            usercodeTextBox.Text = temp.UserNumber;
            nameTextBox.Text = temp.Name;
            cityTextBox.Text = temp.City;
            stateTextBox.Text = temp.State;
            statusTextBox.Text = temp.Status;
            zipTextBox.Text = temp.Zip;
            addressTextBox.Text = temp.StreetAddress;

        }

     
    }
}
