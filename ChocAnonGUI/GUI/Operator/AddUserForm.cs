using ChocAnonGUI.Backend.Controllers;
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.GUI.Operator;
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
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            populateComboBoxes();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            UserModel      userModel      = new UserModel
            {
                Name          = nameTextbox.Text,
                City          = cityTextbox.Text,
                StreetAddress = addressTextbox.Text,
                Zip           = zipTextbox.Text,
                Role          = roleCombobox.Text,
                State         = stateComboBox.Text,
                Status        = statusComboBox.Text,
            };
            if (nameTextbox.Text == "" || cityTextbox.Text == "" || addressTextbox.Text == "" || zipTextbox.Text == "" || roleCombobox.Text == "" || stateComboBox.Text == "" || statusComboBox.Text == "")
            {
                MissingEntryForm launchMissingEntry = new MissingEntryForm();
                launchMissingEntry.ShowDialog();
            }
            else
            {
                userModel = userController.AddUser(userModel);
                //if entry is entered valid pull up information Form
                UserEntryConfirmationForm launchConfirmation = new UserEntryConfirmationForm(userModel);
                launchConfirmation.ShowDialog();
                //else erase the whole add user form and change button text to "Invalid entry"

                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleCombobox.Text == "Member")
            {
                submitButton.Text = "Add New Member";
            }
            else if (roleCombobox.Text == "Provider") {
                submitButton.Text = "Add New Provider";
            }
            
        }

        public void populateComboBoxes()
        {
            //Populate State Combobox, Status Combobox, and Role Combobox
            string[] states = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA",
            "MI", "MN", "MS","MO","MT","MT","NE","NV","NH","NJ","NM","NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "TN", "TX", "UT", "VT", "VA",
            "WA", "WV", "WI", "WY"};
            string[] status = { "Active", "Suspended" };
            string[] roles = { "Member", "Provider" };
            //Fill the Comboboxes.
            stateComboBox.Items.AddRange(states);
            statusComboBox.Items.AddRange(status);
            roleCombobox.Items.AddRange(roles);
            //Set to dropdown only
            this.stateComboBox.DropDownStyle  = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCombobox.DropDownStyle   = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }
    }
}
