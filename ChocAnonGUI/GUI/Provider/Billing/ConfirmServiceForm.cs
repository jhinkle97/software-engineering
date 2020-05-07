using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnonGUI.Backend.Controllers;
using ChocAnonGUI.Backend.Models;



namespace ChocAnonGUI
{
    public partial class ConfirmServiceForm : Form
    {
        private ServiceModel billedService;
        public ConfirmServiceForm(ServiceModel service)
        {
            InitializeComponent();
            billedService = service;
            providerLabel.Text     = billedService.Provider.Name;
            serviceLabel.Text      = billedService.ServiceDirectory.Code;
            printmemberLabel.Text  = billedService.Member.Name;
            printfeeLabel.Text     = billedService.ServiceDirectory.Fee.ToString();
            printserviceLabel.Text = billedService.ServiceDirectory.Name;
            
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (codeTextbox.Text == billedService.ServiceDirectory.Code)
            {
                ServiceController serviceController = new ServiceController();
                serviceController.AddService(billedService);
                PopupControl.printSuccess("Billing Submission Complete");
                this.Close();
            }
            else
            {
                PopupControl.printError("Sorry, given code did not \n\n match the entered code");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
