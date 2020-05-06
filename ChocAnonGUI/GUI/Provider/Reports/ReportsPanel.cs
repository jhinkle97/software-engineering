using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnonGUI.Backend.Reports;
using System.Configuration;
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.GUI.Provider.Reports;

namespace ChocAnonGUI
{
   
    public partial class ReportsPanel : UserControl
        
    {

        private ReportGenerator reportGenerator = new ReportGenerator();
        private UserModel provider = new UserModel();
      
        public ReportsPanel()
        {
            InitializeComponent();
            sendButton.Enabled = false;
        }

        public void SetProvider(UserModel user)
        {
            provider = user;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            PopupControl.printSuccess("Email of report successfully sent");
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            sendButton.Enabled = true;
            reportRichTextBox.Text = reportGenerator.GenerateSummaryReport();
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {

        }
     
        private void changeButton_Click(object sender, EventArgs e)
        {

        }

        private void providerButton_Click(object sender, EventArgs e)
        {
            sendButton.Enabled = true;
            reportRichTextBox.Text = reportGenerator.GenerateProviderReport(provider.UserNumber);
        }

        private void memberButton_Click_1(object sender, EventArgs e)
        {     
            GetMemberForm launchForm = new GetMemberForm();
            launchForm.ShowDialog();
            sendButton.Enabled = true;
            reportRichTextBox.Text = reportGenerator.GenerateMemberReport(launchForm.memberCode);


        }
    }
}
