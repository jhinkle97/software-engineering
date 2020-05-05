﻿using System;
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
        private bool enableButtons = false;
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
            //Generate User Object for SQL database
            UserController userController = new UserController();
            user = userController.GetUser(userNumber);

            if (user.UserNumber == "" || user.Name == "")
            {
                PopupControl.printError("Not a valid User Number");
                enableButtons = false;
            }
            else
            {
                //Turn on Control Buttons
                enableButtons = true;
                //Insert the data of the user
                nameTextbox.Text = user.Name;
                statusComboBox.Text = user.Status;
                cityTextbox.Text = user.City;
                stateComboBox.Text = user.State;
                roleCombobox.Text = user.Role;
                addressTextbox.Text = user.StreetAddress;
                zipTextbox.Text = user.Zip;
            }
        
            

            
               
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text == "" || enableButtons == false)
            {
                PopupControl.printError("Sorry, you haven't input a \n\n correct user id in yet.");
            }
            else
            {

                if (nameTextbox.Text != "" && statusComboBox.Text != "" && cityTextbox.Text != "" && stateComboBox.Text != ""
                    && roleCombobox.Text != "" && addressTextbox.Text != "" && zipTextbox.Text != "")
                {
                    UserController userController = new UserController();

                    user.Name = nameTextbox.Text;
                    user.Status = statusComboBox.Text;
                    user.City = cityTextbox.Text;
                    user.State = stateComboBox.Text;
                    user.Role = roleCombobox.Text;
                    user.StreetAddress = addressTextbox.Text;
                    user.Zip = zipTextbox.Text;

                    UserEntryConfirmationForm launchConfirmationn = new UserEntryConfirmationForm(user);
                    launchConfirmationn.ShowDialog();
                    this.Close();
                }
                else
                {
                    PopupControl.printError("You left a field blank. \n\n Can't proceed until all filled in");
                }
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (nameTextbox.Text == "" || enableButtons == false || user.UserNumber == "")
            {
                PopupControl.printError("Sorry, you haven't input a \n\n correct user id in yet.");
            }
            else
            {
                if (nameTextbox.Text != "" && statusComboBox.Text != "" && cityTextbox.Text != "" && stateComboBox.Text != ""
                    && roleCombobox.Text != "" && addressTextbox.Text != "" && zipTextbox.Text != "")
                {
                    UserController deleteUser = new UserController();
                    PopupControl.printSuccess("You have deleted user: " + user.UserNumber + "\n\n Name: " + user.Name);
                    deleteUser.DeleteUser(user.UserNumber);
                    this.Close();
                }
                else
                {
                    PopupControl.printError("Sorry, fields need to be populated \n\n before deletion. ");
                }
            }
        }
    }
}
