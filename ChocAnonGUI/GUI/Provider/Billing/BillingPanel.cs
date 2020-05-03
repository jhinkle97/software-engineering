using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnonGUI.Backend.Controllers;
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.GUI;

namespace ChocAnonGUI
{
    public partial class BillingPanel : UserControl
    {
        private UserModel activeProvider;
        private UserModel activeMember;
        public BillingPanel()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        public void BillingPanelRoot(string membercode, UserModel provider)
        {
            //Build the Member Object
            UserController userController = new UserController();
            activeMember   = userController.GetUser(membercode);
            activeProvider = provider;
            fillQuickView();
        }

        private void fillQuickView()
        {
            memnameTextbox.Text    = activeMember.Name;
            memstateTextbox.Text   = activeMember.State;
            memnumberTextbox.Text  = activeMember.UserNumber;
            memaddressTextbox.Text = activeMember.StreetAddress;
            memzipTextbox.Text     = activeMember.Zip;
            memcityTextbox.Text    = activeMember.City;
            memstatusTextbox.Text  = activeMember.Status;
        }


        private void billButton_Click(object sender, EventArgs e)
        {

        }

        private void lookupButton_Click(object sender, EventArgs e)
        {
            ServiceLookupForm launchServiceLookup = new ServiceLookupForm();
            launchServiceLookup.ShowDialog();
        }
    }
}
