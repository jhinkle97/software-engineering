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
        private ServiceDirectoryModel service;
        public ServiceLookupForm()
        {
            InitializeComponent();
            runLoop();
        }

        private void runLoop()
        {
            for (int i = 821640; i < 821659; i++)
            {
                ServiceDirectoryController pullService = new ServiceDirectoryController();
                service = pullService.GetService(i.ToString());
                Console.WriteLine(i);
                if (service.Name != "")
                {
                    servicesListview.Items.Add("Service: " + service.Name + "| Cost: " + service.Fee + "| CODE: " + service.Code);
                }
            }
        }
    }
}
