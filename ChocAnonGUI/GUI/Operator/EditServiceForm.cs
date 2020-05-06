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
            if (enableButtons == false)
            {
                PopupControl.printError("Sorry, No valid \n\n service ID entered");
                lockFields();
            }
            else if (enableButtons == true)
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
                        ServiceEntryConfirmationForm launchConfirmation = new ServiceEntryConfirmationForm(service);
                        launchConfirmation.ShowDialog();
                        this.Close();
                    }
                }

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (enableButtons == false)
            {
                PopupControl.printError("Sorry, No valid \n\n service ID entered");
                lockFields();
            }
            else if (enableButtons == true)
            {
                ServiceDirectoryController deleteService = new ServiceDirectoryController();
                deleteService.DeleteService(service.Code);
                PopupControl.printSuccess("The Service with Code: " + service.Code + "\n\n was removed");
                this.Close();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            string serviceCode = inputTextbox.Text;

            ServiceDirectoryController serviceDirectoryController = new ServiceDirectoryController();
            service = serviceDirectoryController.GetService(serviceCode);

            if (service.Code == "")
            {
                lockFields();
                enableButtons = false;
                PopupControl.printError("Not a valid \n\n service code...");
            }
            else
            {
                unlockFields();
                enableButtons = true;
                serviceTextbox.Text = service.Name;
                feeTextbox.Text = service.Fee.ToString();
            }
        }

        private void lockFields()
        {
            serviceTextbox.ReadOnly = true;
            feeTextbox.ReadOnly = true;
        }
        private void unlockFields()
        {
            serviceTextbox.ReadOnly = false;
            feeTextbox.ReadOnly = false;
        }
    }
}
