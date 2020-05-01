using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnonGUI.GUI.Operator;
using ChocAnonGUI.Backend.Models;
using ChocAnonGUI.Backend.Controllers;

namespace ChocAnonGUI.GUI.Operator
{
    public partial class EditUserForm : Form
    {
        private UserModel user;
        public EditUserForm()
        {
            InitializeComponent();
            populateComboBoxes ();
            
        }

        public void populateComboBoxes()
        {
            //Populate State Combobox, Status Combobox, and Role Combobox
            string[] states = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA",
            "MI", "MN", "MS","MO","MT","MT","NE","NV","NH","NJ","NM","NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "TN", "TX", "UT", "VT", "VA",
            "WA", "WV", "WI", "WY"};
            string[] status = { "Active", "Suspended" };
            string[] roles  = { "Member", "Provider"  };
            //Fill the Comboboxes.
            stateComboBox.Items.AddRange  (states);
            statusComboBox.Items.AddRange (status);
            roleCombobox.Items.AddRange   (roles);
            //Set to dropdown only
            this.stateComboBox.DropDownStyle  = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCombobox.DropDownStyle   = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Get UserNumber from the Top Box
            string userNumber = usernumberTextBox.Text;
            //Trigger a new object with given userNumber
            //Need to add something if the searched ID is invalid
            //Fields will be locked until a User Number is entered 
            UserController userController = new UserController();
            user = userController.GetUser(userNumber);

            nameTextbox.Text = user.Name;
            statusComboBox.Text = user.Status;
            cityTextbox.Text = user.City;
            stateComboBox.Text = user.State;
            roleCombobox.Text = user.Role;
            addressTextbox.Text = user.StreetAddress;
            zipTextbox.Text = user.Zip;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            UserController userController = new UserController();

            user.Name = nameTextbox.Text;
            user.Status = statusComboBox.Text;
            user.City = cityTextbox.Text;
            user.State = stateComboBox.Text;
            user.Role = roleCombobox.Text;
            user.StreetAddress = addressTextbox.Text;
            user.Zip = zipTextbox.Text;


            if (nameTextbox.Text == "" || cityTextbox.Text == "" || addressTextbox.Text == "" || zipTextbox.Text == "" || roleCombobox.Text == "" || stateComboBox.Text == "" || statusComboBox.Text == "")
            {
                MissingEntryForm launchMissingEntry = new MissingEntryForm();
                launchMissingEntry.ShowDialog();
            }
            else
            {
                user = userController.EditUser(user);

                UserEntryConfirmationForm launchConfirmation = new UserEntryConfirmationForm(user);
                launchConfirmation.ShowDialog();
                this.Close();
            }
        }
    }
}
