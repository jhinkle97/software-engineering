using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnonDashboard
{
    public partial class operatorPage : UserControl
    {
        public operatorPage()
        {
            InitializeComponent();
            comboBox1.Items.Add("Add Member");
            comboBox1.Items.Add("Add Provider");
            comboBox1.Items.Add("Add Service");
            comboBox2.Items.Add("Edit Member");
            comboBox2.Items.Add("Edit Provider");
            comboBox2.Items.Add("Edit Service");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
