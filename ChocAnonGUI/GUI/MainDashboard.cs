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
                opControl1.Show();
                usertitleLabel.Text = "The Current Operator is: " + providerCode;
            }
            else
            {
                defaultControl1.Show();
                usertitleLabel.Text = "The Current Provider is: " + providerCode;
            }
        }

        private void billControl1_Load(object sender, EventArgs e)
        {
           

        }

        void hidePanels()
        {
            opControl1.Hide();
            defaultControl1.Hide();
            billControl1.Hide();
            reportControl1.Hide();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            hidePanels();
            billControl1.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            hidePanels();
            reportControl1.Show();

        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
