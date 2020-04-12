using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnonDashboard {
    public partial class Form1 : Form
    {
        public string currentSelection;
        public string loginCode;
        public Form1() {
            InitializeComponent();
            managerPage1.Hide();
            memberPage1.Hide();
            operatorPage1.Hide();
            providerPage1.Hide();
        }

        private void providerButton_Click(object sender, EventArgs e) {
            Console.WriteLine("You just hit the Provider Button");
            //Launch Login and Return If Code Is Valid
            Form2 launchLogin = new Form2();
            launchLogin.ShowDialog();
            Console.WriteLine(launchLogin.returnCode);
            managerPage1.Hide();
            memberPage1.Hide();
            operatorPage1.Hide();
            providerPage1.Hide();
            providerPage1.Show();
        }

        private void memberButton_Click(object sender, EventArgs e) {
            Console.WriteLine("You just hit the Member Button");
            //Launch Login and Return If Code Is Valid
            Form2 launchLogin = new Form2();
            launchLogin.ShowDialog();
            Console.WriteLine(launchLogin.returnCode);
            managerPage1.Hide();
            memberPage1.Hide();
            operatorPage1.Hide();
            providerPage1.Hide();
            memberPage1.Show();
        }

        private void operatorButton_Click(object sender, EventArgs e) {
            Console.WriteLine("You just hit the Operator Button");
            //Launch Login and Return If Code Is Valid
            Form2 launchLogin = new Form2();
            launchLogin.ShowDialog();
            Console.WriteLine(launchLogin.returnCode);
            managerPage1.Hide();
            memberPage1.Hide();
            operatorPage1.Hide();
            providerPage1.Hide();
            operatorPage1.Show();
        }

        private void managerButton_Click(object sender, EventArgs e) {
            Console.WriteLine("You just hit the Manager Button");
            //Launch Login and Return If Code Is Valid
            Form2 launchLogin = new Form2();
            launchLogin.ShowDialog();
            Console.WriteLine(launchLogin.returnCode);
            managerPage1.Hide();
            memberPage1.Hide();
            operatorPage1.Hide();
            providerPage1.Hide();
            managerPage1.Show();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("You just hit the settings button");
        }
    }
}
