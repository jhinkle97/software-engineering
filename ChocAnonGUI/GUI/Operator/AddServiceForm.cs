using ChocAnonGUI.Backend.Controllers;
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
    public partial class AddServiceForm : Form
    {
        public AddServiceForm()
        {
            InitializeComponent();
            
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            ServiceDirectoryController serviceDirectoryController = new ServiceDirectoryController();
            ServiceDirectoryModel service = new ServiceDirectoryModel
            {
                Fee  = feeTextbox.Text,
                Name = nameTextbox.Text
            };

            //Check if empty entry, if there is show error, if not continue with entry
            if (nameTextbox.Text == "" || feeTextbox.Text == "")
            {
                MissingEntryForm launchMissingEntry = new MissingEntryForm();
                launchMissingEntry.ShowDialog();
            }
            else
            {
                service = serviceDirectoryController.AddService(service);
                //if entry is entered valid pull up information Form
                ServiceEntryConfirmationForm launchConfirmation = new ServiceEntryConfirmationForm(service);
                launchConfirmation.ShowDialog();
                //else erase the whole add user form and change button text to "Invalid entry"

                this.Close();
            }
        }

    }
}
