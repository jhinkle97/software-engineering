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
    public partial class billmemberForm : Form
    {
        public string path;
        public billmemberForm(string value)
        {
            InitializeComponent();
            hidePanels();
            path = value;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string memberCode = memcodeTextbox.Text;

            if (memberCode == "135" && path == "billing")
            {
                hidePanels();
                billmemberPanel2X.Show();
            } 
            else if (memberCode == "135" && path == "quickview")
            {
                hidePanels();
                billquickviewPanel1.Show();
                Console.WriteLine("You would go to the quickview panel instead");    
            }
            else 

            {
                memcodeTextbox.Clear();
                confirmationLabel.Text = "Invalid. Exit or try code again.";

            }

        }
        void hidePanels()
        {
            billmemberPanel2X.Hide();
            billquickviewPanel1.Hide();
        }

        private void billquickviewPanel1_Load(object sender, EventArgs e)
        {

        }

        private void billmemberForm_Load(object sender, EventArgs e)
        {

        }
    }
}
