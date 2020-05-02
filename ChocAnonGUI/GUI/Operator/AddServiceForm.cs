using ChocAnonGUI.Backend.Controllers;
using ChocAnonGUI.Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            bool validFee = true;
            ServiceDirectoryModel service = new ServiceDirectoryModel();
            service.Name = nameTextbox.Text;
            try
            {
                service.Fee = Convert.ToDecimal(feeTextbox.Text, new CultureInfo("en-US"));
            }
            catch
            {
                validFee = false;
                service.Fee = 0;
            }
            if (nameTextbox.Text == "" || feeTextbox.Text == "")
            {
                MissingEntryForm launchMissingEntry = new MissingEntryForm();
                launchMissingEntry.ShowDialog();
            }
            else if (!validFee || service.Fee > (decimal)999.99)
            {
                MissingEntryForm missingEntryForm = new MissingEntryForm("Invalid fee format.\n\nPlease enter as a number or decimal\nwith a value less than 1000.00");
                missingEntryForm.ShowDialog();
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
