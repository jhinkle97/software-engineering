using ChocAnonGUI.Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocAnonGUI.GUI.Operator
{
    public partial class ServiceEntryConfirmationForm : Form
    {
        public ServiceEntryConfirmationForm(ServiceDirectoryModel service)
        {
            InitializeComponent();
            
            servicecodeTextbox.Text = service.Code;
            servicecostTextbox.Text = service.Fee;
            servicenameTextbox.Text = service.Name;
        }
    }
}
