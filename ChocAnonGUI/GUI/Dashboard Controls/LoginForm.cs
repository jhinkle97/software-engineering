using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChocAnonGUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string getCode = inputTextbox.Text;

            if (getCode == "1234")
            {
                MainDashboard launchDash = new MainDashboard(getCode);
                this.Hide();
                outputLabel.Text = "Login Successful, Logging in....";
                launchDash.ShowDialog();
                this.Close();
            } else if (getCode == "12345678")
            {
                MainDashboard launchDash = new MainDashboard(getCode);
                this.Hide();
                outputLabel.Text = "Login Successful, Logging in....";
                launchDash.ShowDialog();
                this.Close();
            }else

            {
                inputTextbox.Clear();
                inputTextbox.ForeColor = Color.Gray;
                inputTextbox.Text = "Enter provider number";

                outputLabel.Text = "Invalid Login, Try Again or Exit";
            }



            
        }

        private void inputTextbox_Enter(object sender, EventArgs e)
        {
            if (inputTextbox.Text == "Enter provider number")
            {
                inputTextbox.Text = "";
                inputTextbox.ForeColor = Color.Black;
            }
        }

        private void terminalLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
