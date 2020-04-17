using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnonGUI
{
    public partial class billmemberPanel : UserControl
    {
        
        public billmemberPanel()
        {
            InitializeComponent();
        }

        private void confirmbillButton_Click(object sender, EventArgs e)
        {
            ConfirmServiceForm launchConfirmation = new ConfirmServiceForm();
            launchConfirmation.ShowDialog();
            billmemberForm.ActiveForm.Close();
            
            
        }

        private void directoryButton_Click(object sender, EventArgs e)
        {
            lookupProviderForm launchlookup = new lookupProviderForm();
            launchlookup.Show();

        }
    }
}
