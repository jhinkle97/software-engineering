using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChocAnonGUI.Backend.Controllers;
using ChocAnonGUI.Backend.Models;

namespace ChocAnonGUI
{
    public partial class ServiceLookupForm : Form
    {
        private BillingPanel billingPanel;
        public ServiceLookupForm(string memberName, BillingPanel parent)
        {
            billingPanel = parent;
            InitializeComponent();
            ServiceDirectoryController serviceDirectoryController = new ServiceDirectoryController();
            IEnumerable<ServiceDirectoryModel> services = serviceDirectoryController.GetServices();

            nameLabel.Text = memberName;

            foreach(ServiceDirectoryModel service in services)
            {
                servicesListview.Items.Add(new ListViewItem(new[] { service.Code, service.Name, service.Fee.ToString() }));
            }
        }

        private void servicesListview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (servicesListview.SelectedItems.Count == 0)return;

            ListViewItem item = servicesListview.SelectedItems[0];

            billingPanel.setServiceCode(item.SubItems[0].Text);
        }
    }
}
