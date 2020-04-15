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
    public partial class MainDashboard : Form
    {
        public string loginCode;
        public MainDashboard()
        {
            InitializeComponent();
            hidePanels();
            defaultControl1.Show();
            
        }

        private void billControl1_Load(object sender, EventArgs e)
        {
           

        }

        void hidePanels()
        {
            opControl1.Hide();
            defaultControl1.Hide();
            billControl1.Hide();
            reportControl1.Hide();

        }

        private void billButton_Click(object sender, EventArgs e)
        {
            hidePanels();
            billControl1.Show();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            hidePanels();
            reportControl1.Show();

        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            hidePanels();
            opControl1.Show();
        }
    }
}
