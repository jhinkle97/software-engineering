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
        private bool   validated = false;
        private string procedure = "";
     
        
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
            if (service.Name != "" && service.Fee != 0)
            {
                enableFields();
                validated = true;
                servicenameTextbox.Text = service.Name;
                servicefeeTextbox.Text  = service.Fee.ToString();
            }else
            {
                disableFields();
                validated = false;
                PopupControl.printError("Invalid Service Code");
            }

           
        }

        private void serviceeditButton_Click(object sender, EventArgs e)
        {
            //Delete Functionality
            if (procedure == "DELETE" && procedure != "")
            {
                if (servicenameTextbox.Text == "" || servicefeeTextbox.Text == "")
                {
                    PopupControl.printError("You haven't lookup up a valid account");
                }
                else
                {
                    ServiceDirectoryController deleteService = new ServiceDirectoryController();
                    deleteService.DeleteService(service.Code);
                    PopupControl.printSuccess("The Service with code" + searchTextbox.Text + "\n\n was removed");
                    this.Close();
                }
            }
            else if (procedure == "EDIT" && procedure != "")
            {
                if (servicefeeTextbox.Text == "" || servicefeeTextbox.Text == "")
                {
                    PopupControl.printError("You haven't lookup up a valid account");
                }
                else
                {
                    ServiceDirectoryController serviceDirectoryController = new ServiceDirectoryController();
                    bool validFee = true;
                    service.Name = servicenameTextbox.Text;
                    //TRY CATCH
                    try {
                        service.Fee = Convert.ToDecimal(servicefeeTextbox.Text, new CultureInfo("en-US"));
                    }
                    catch {
                        validFee = false;
                        service.Fee = 0;
                    }
                    if (!validFee || service.Fee > (decimal)999.99)
                    {
                        PopupControl.printError("Invalid fee format.\n\nPlease enter as a number or decimal\nwith a value less than 1000.00");
                    }
                    else
                    {
                        service = serviceDirectoryController.EditService(service);

                        ServiceEntryConfirmationForm launchConfirmation = new ServiceEntryConfirmationForm(service);
                        launchConfirmation.ShowDialog();
                        this.Close();
                    }

                }
              
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

        private void editRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (validated == true)
            {
                enableFields();
                serviceeditButton.Text = "Edit Service";
                procedure = "EDIT";
            }
            else
                PopupControl.printError("Can't use radios without a valid service entered");
        }

        private void deleteRadio_CheckedChanged(object sender, EventArgs e)
        {
            disableFields();
            serviceeditButton.Text = "Delete Service";
            if (validated == true)
            {
                procedure = "DELETE";
            }
            
        }
    }
}
