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
    public partial class EditServiceForm : Form
    {
        private ServiceDirectoryModel service;
        private ErrorForm errorForm;
        public EditServiceForm()
        {
            InitializeComponent();
            disableFields(); 
            
        }

        private void searchService(object sender, EventArgs e)
        {
            string serviceCode = searchTextbox.Text;
          
            ServiceDirectoryController serviceDirectoryController = new ServiceDirectoryController();
            service = serviceDirectoryController.GetService(serviceCode);
            if (service.Name == "" || service.Fee == "")
            {
                disableFields();
                errorForm.message = "Not a valid Service ID";

            }

            servicenameTextbox.Text = service.Name;
            servicefeeTextbox.Text = service.Fee.ToString();
        }

        private void serviceeditButton_Click(object sender, EventArgs e)
        {
            ServiceDirectoryController serviceDirectoryController = new ServiceDirectoryController();
            bool validFee = true;
            service.Name = servicenameTextbox.Text;
            try
            {
                service.Fee = Convert.ToDecimal(servicefeeTextbox.Text, new CultureInfo("en-US"));
            }
            catch
            {
                validFee = false;
                service.Fee = 0;
            }

            if (servicenameTextbox.Text == "" || servicefeeTextbox.Text == "")
            {
                ErrorForm launchMissingEntry = new ErrorForm();
                launchMissingEntry.ShowDialog();
            }
            else if (!validFee || service.Fee > (decimal)999.99)
            {
                MissingEntryForm missingEntryForm = new MissingEntryForm("Invalid fee format.\n\nPlease enter as a number or decimal\nwith a value less than 1000.00");
                missingEntryForm.ShowDialog();
            }
            else
            {
                service = serviceDirectoryController.EditService(service);

                ServiceEntryConfirmationForm launchConfirmation = new ServiceEntryConfirmationForm(service);
                launchConfirmation.ShowDialog();
                this.Close();
            }
        }
        private void disableFields()
        {
            servicenameTextbox.ReadOnly = true;
            servicefeeTextbox.ReadOnly  = true;
        }
        private void enableFields()
        {
            servicenameTextbox.ReadOnly = false;
            servicefeeTextbox.ReadOnly  = false;
        }
    }
}
