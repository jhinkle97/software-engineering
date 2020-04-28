﻿using ChocAnonGUI.Backend.Controllers;
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
            userModel = userController.AddUser(userModel);
            //if entry is entered valid pull up information Form
            EntryConfirmationForm launchConfirmation = new EntryConfirmationForm(userModel);
            launchConfirmation.ShowDialog();
            //else erase the whole add user form and change button text to "Invalid entry"

            this.Close();
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
            //Populate User Type Combobox
            roleCombobox.Items.Add("Provider");
            roleCombobox.Items.Add("Member");
            //Populate State Combobox
            string[] states = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA",
            "MI", "MN", "MS","MO","MT","MT","NE","NV","NH","NJ","NM","NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "TN", "TX", "UT", "VT", "VA",
            "WA", "WV", "WI", "WY"};
            stateComboBox.Items.AddRange(states);

        }
    }
}