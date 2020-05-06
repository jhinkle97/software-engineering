using ChocAnonGUI.Backend.Controllers;
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.GUI.Operator;
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

namespace ChocAnonGUI
{
   
    public partial class EditServiceForm : Form
    {

        private bool enableButtons = false;
        private ServiceDirectoryModel service;
   
        public EditServiceForm()
        {
            InitializeComponent();
            lockFields();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (serviceTextbox.Text == "" || feeTextbox.Text == "")
              {
                  PopupControl.printError("Fill in the empty fields please");
            }
            else
            {
                ServiceDirectoryController editService = new ServiceDirectoryController();
                service.Name = serviceTextbox.Text;
                bool validFee = true;

                //TRY CATCH
                try
                {
                    service.Fee = Convert.ToDecimal(feeTextbox.Text, new CultureInfo("en-US"));
                }
                catch
                {
                    validFee = false;
                    service.Fee = 0;
                }
                if (!validFee || service.Fee > (decimal)999.99)
                {
                    PopupControl.printError("Invalid fee format.\n\nPlease enter as a number or decimal\nwith a value less than 1000.00");
                }
                else
                {
                    service = editService.EditService(service);
                    if (service.Code == null)
                    {
                        PopupControl.printError("Something went wrong.");
                    }
                    else
                    {
                        ServiceEntryConfirmationForm launchConfirmation = new ServiceEntryConfirmationForm(service);
                        launchConfirmation.ShowDialog();
                    }
                    this.Close();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            ServiceDirectoryController deleteService = new ServiceDirectoryController();
            if (deleteService.DeleteService(service.Code))
            {
                PopupControl.printSuccess("The Service with Code: " + service.Code + "\n\n was removed");
            }
            else
            {
                PopupControl.printError("Something went wrong.");
            }
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string serviceCode = inputTextbox.Text;

            ServiceDirectoryController serviceDirectoryController = new ServiceDirectoryController();
            service = serviceDirectoryController.GetService(serviceCode);

            if (service.Code == null)
            {
                lockFields();
                PopupControl.printError("Not a valid \n\n service code...");
            }
            else
            {
                unlockFields();
                serviceTextbox.Text = service.Name;
                feeTextbox.Text = service.Fee.ToString();
            }
        }

        private void lockFields()
        {
            serviceTextbox.Enabled = false;
            feeTextbox.Enabled = false;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
        }
        private void unlockFields()
        {
            serviceTextbox.Enabled = true;
            feeTextbox.Enabled = true;
            editButton.Enabled = true;
            deleteButton.Enabled = true;
        }
    }
}
