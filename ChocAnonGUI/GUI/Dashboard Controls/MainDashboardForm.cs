using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnonGUI
{
    public partial class MainDashboard : Form
    {
        
        public MainDashboard(string providerCode)
        {
            InitializeComponent();
            hidePanels();
            if (providerCode == "12345678")
            {
                hidePanels();
                usertitleLabel.Text = "Operator: " + providerCode;
                OperatorControlPanel.Show();
            }
            else
            {
                hidePanels();
                usertitleLabel.Text = "Provider: " + providerCode;
                WelcomeControlPanel.Show();
            }
        }

        private void settingPicture_Click(object sender, EventArgs e)
        {
            AboutUsForm LaunchAboutUs = new AboutUsForm();
            LaunchAboutUs.ShowDialog();

        }
        void hidePanels() {
            BillingControlPanel.Hide();
            ReportControlPanel.Hide();
            WelcomeControlPanel.Hide();
            OperatorControlPanel.Hide();
            InvalidControlPanel.Hide();
        }

        private void MemberServiceButton_Click(object sender, EventArgs e)
        {
            PasswordConfirmForm launchConfirmation = new PasswordConfirmForm();
            launchConfirmation.ShowDialog();
            string memberCode = launchConfirmation.memberCode;
            if (memberCode == "")
            {
                hidePanels();
                InvalidControlPanel.Show();
            }else
            {
                hidePanels();
                BillingControlPanel.Show();
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            hidePanels();
            ReportControlPanel.Show();
            
        }

      
    }
}
