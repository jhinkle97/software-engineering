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
    public partial class PasswordConfirmForm : Form
    {
       public string memberCode { get; set; }
        public PasswordConfirmForm()
        {
            InitializeComponent();
           
            
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            memberCode = memcodeTextbox.Text;
            
            //INSERT CODE TO
            //GO TO DATABASE AND VERIFY THE MEMBER
            //CODE WHICH IS THEN PASSED BACK AS
            //A STRING VALUE

            //IF IT IS VALIDATED PASS MEMBER NUMBER BACK TO DASHBOARD
            //ELSE DISPLAY AN ERROR MESSAGE ON THE POPUP FORM
            
            //IF THEY EXIT THE PASSWORD CONFIRMATION WITHOUT ENTERING A 
            //VALID MEMBERCODE, A ERROR PANE SHOWS UP ON THE DASHBOARD

        }

      }
    }
