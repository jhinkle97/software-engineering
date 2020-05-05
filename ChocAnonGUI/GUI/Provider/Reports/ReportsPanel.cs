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

namespace ChocAnonGUI
{
    public partial class ReportsPanel : UserControl
    {
        private ReportGenerator reportGenerator = new ReportGenerator();
        private UserModel provider = new UserModel();
        public ReportsPanel()
        {
            InitializeComponent();
        }

        public void SetProvider(UserModel user)
        {
            provider = user;
        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            reportRichTextBox.Text = reportGenerator.GenerateSummaryReport();
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {

        }

        private void memberButton_Click(object sender, EventArgs e)
        {

        }

        private void providerButton_Click(object sender, EventArgs e)
        {
            reportRichTextBox.Text = reportGenerator.GenerateProviderReport(provider.UserNumber);
        }
    }
}
