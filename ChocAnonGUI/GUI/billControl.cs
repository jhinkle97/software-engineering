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
    public partial class BillControl : UserControl
    {
        public BillControl()
        {
            InitializeComponent();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            billmemberForm launchBilling = new billmemberForm("billing");
            launchBilling.ShowDialog();
        }

        private void quickviewButton_Click(object sender, EventArgs e)
        {
            billmemberForm launchBilling = new billmemberForm("quickview");
            launchBilling.ShowDialog();
        }
    }
}
