using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnonGUI.Backend.Controllers;
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.Backend.Reports;
using ChocAnonGUI.Backend.DataAccess;
using ChocAnonGUI.Backend.Utilities;


namespace ChocAnonGUI.GUI.Provider.Reports
{
    public partial class GetMemberForm : Form
    {
       
        public GetMemberForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string code = codeTextbox.Text;
            UserRepository userRepository = new UserRepository();
            UserModel member = userRepository.GetUser(code);

            if (codeTextbox.Text == "")
            {
                PopupControl.printError("Sorry the textbox is empty");
            }else if (member.UserNumber == null || member.Role == "Provider")
            {
                PopupControl.printError("Sorry, not a valid member code");
            }else
            {
                //Pass the string back to setReport
                this.Close();
            }
            
            
         
        }
    }
}
