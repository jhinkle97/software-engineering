using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnonGUI.GUI.Operator;


namespace ChocAnonGUI
{
    public partial class OperatorDashboardPanel : UserControl
    {
        public OperatorDashboardPanel()
        {
            InitializeComponent();
        }
        private void addMemberButton_Click(object sender, EventArgs e)
        {
            AddUserForm launchAddMem = new AddUserForm();
            launchAddMem.ShowDialog();
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            AddServiceForm launchAddService = new AddServiceForm();
            launchAddService.ShowDialog();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            EditUserForm launchEditMem = new EditUserForm();
            launchEditMem.ShowDialog();
        }

        private void editServiceButton_Click(object sender, EventArgs e)
        {
            EditServiceForm launchEditService = new EditServiceForm();
            launchEditService.ShowDialog();
        }
    }
}
