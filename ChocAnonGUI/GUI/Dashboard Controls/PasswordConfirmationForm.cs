using System;
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.Backend.Controllers;
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
    public partial class PasswordConfirmForm : Form
    {
       public string memberCode { get; set; }
        public PasswordConfirmForm()
        {
            InitializeComponent();
            memberCode = null;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            // Get the entered code from text box
            string userNumber = memcodeTextbox.Text;
            // Build a User object based on the code
            UserController userController = new UserController();
            UserModel user = userController.GetUser(userNumber);
            //Logic to see if valid
            if (user.Role == "Member")
            {
                memberCode = userNumber;
                if (user.Status == "Suspended")
                {
                    PopupControl.printError("This member is currently suspended \n\n Bill at your own risk.");
                }

                this.Close();
            }
            else
            {
                memcodeTextbox.Clear();
                memcodeTextbox.ForeColor = Color.Gray;
                memcodeTextbox.Text = "Enter member number";
                if (user.Role == "Provider")
                {
                    confirmationLabel.Text = "Invalid Login. Wrong Role";
                }
                else
                {
                    confirmationLabel.Text = "Invalid Login. NOT FOUND";
                }
                //set memberCode to null
                memberCode = null;
            }
        }
        private void memcodeTextbox_Enter(object sender, EventArgs e)
        {
            if (memcodeTextbox.Text == "Enter member number")
            {
                memcodeTextbox.Text = "";
                memcodeTextbox.ForeColor = Color.Black;
            }
        }
        
     }
    }
