using ChocAnonGUI.Backend.Controllers;
using ChocAnonGUI.Backend.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace ChocAnonGUI
{
    
    public partial class MainDashboard : Form
    {
        private UserModel provider;
        public MainDashboard(UserModel user) 
        {
            InitializeComponent();
            provider = user;
            //Hides all the panels.
            hidePanels();


            //If Else to Determine Operator or Provider
            if (user.UserNumber == "admin")
            {
                hidePanels();
                usertitleLabel.Text = "Operator: Welcome to the Dashboard"; 
                OperatorControlPanel.Show();
            } 
            else
            {
                hidePanels();
                usertitleLabel.Text = "Provider: " + user.Name + "\nNumber: " + user.UserNumber;
                WelcomeControlPanel.Show();
            }
        }

        private void settingPicture_Click(object sender, EventArgs e)
        {
            SettingsForm LaunchAboutUs = new SettingsForm();
            LaunchAboutUs.ShowDialog();
        }


        //Hides all the panels on the dashboard
        void hidePanels() 
        {
            BillingControlPanel. Hide();
            ReportControlPanel.  Hide();
            WelcomeControlPanel. Hide();
            OperatorControlPanel.Hide();
            InvalidControlPanel. Hide();
        }

        //Triggers the Member Code Login Window
        private void MemberServiceButton_Click(object sender, EventArgs e) {
            //Windows Form to get the Code if it is valid
            PasswordConfirmForm launchConfirmation = new PasswordConfirmForm();
            launchConfirmation.ShowDialog();
            string memberCode = launchConfirmation.memberCode;

            //Logic to sort if it was null on return to the dashboard
            if (memberCode == null || memberCode == "Enter member number")
            {
                //Hide panel and show error page.
                hidePanels();
                WelcomeControlPanel.Show();
            }
            else 
            {   
                //Send updated codes to panel for use
                BillingControlPanel.BillingPanelRoot(memberCode, provider);
                hidePanels();
                BillingControlPanel.Refresh();
                BillingControlPanel.Show();
            }
        }

        //Hides all the other panels except the Reports Panel.
        private void ReportButton_Click(object sender, EventArgs e) {
            hidePanels();
            ReportControlPanel.SetProvider(provider);
            ReportControlPanel.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }
    }
}
