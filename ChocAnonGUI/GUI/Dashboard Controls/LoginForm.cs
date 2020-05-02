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
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.Backend.Controllers;

namespace ChocAnonGUI
{
    public partial class LoginForm : Form
    {
        public UserModel user;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string userNumber = inputTextbox.Text;

            if (userNumber == "admin")
            {
                MainDashboard launchDash = new MainDashboard(userNumber);
                this.Hide();
                outputLabel.Text = "Login Successful, Logging in....";
                launchDash.ShowDialog();
                this.Close();
            }
            else
            {
                UserController userController = new UserController();
                user = userController.GetUser(userNumber);

                if(user.Role == "Provider")
                {
                    MainDashboard launchDash = new MainDashboard(user.UserNumber);
                    this.Hide();
                    outputLabel.Text = "Login Successful, Logging in....";
                    launchDash.ShowDialog();
                    this.Close();
                }
                else
                {
                    inputTextbox.Clear();
                    inputTextbox.ForeColor = Color.Gray;
                    inputTextbox.Text = "Enter provider number";
                    if(user.Role == "Member")
                    {
                        outputLabel.Text = "Invalid Login. User found with incorrect role. Try Again or Exit";
                    }
                    else
                    {
                        outputLabel.Text = "Invalid Login. User not found. Try Again or Exit";
                    }
                }
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

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
