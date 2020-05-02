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
                memberCode = "NULL";
            }





            

            
            
            //INSERT CODE TO
            //GO TO DATABASE AND VERIFY THE MEMBER
            //CODE WHICH IS THEN PASSED BACK AS
            //A STRING VALUE

            //IF IT IS VALIDATED PASS MEMBER NUMBER BACK TO DASHBOARD
            //ELSE DISPLAY AN ERROR MESSAGE ON THE POPUP FORM
            
            //IF THEY EXIT THE PASSWORD CONFIRMATION WITHOUT ENTERING A 
            //VALID MEMBERCODE, A ERROR PANE SHOWS UP ON THE DASHBOARD

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
