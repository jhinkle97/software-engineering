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
    
    public partial class Form2 : Form {
        public string returnCode { get; set; }
        public Form2() { 
            InitializeComponent();
        }

        private void entryButton_Click(object sender, EventArgs e) {
            this.returnCode = textBox1.Text;
            this.Close();
        }
    }
}
