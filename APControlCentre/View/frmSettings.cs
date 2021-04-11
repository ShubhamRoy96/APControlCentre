using APControlCentre.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APControlCentre.View
{
    public partial class frmSettings : Form
    {

        String[] ports;
        
        public frmSettings()
        {
            InitializeComponent();
            getAvailableComPorts();
        }
       

        private void frmSettings_Load(object sender, EventArgs e)
        {
            foreach (string port in ports)
            {
                cboPorts.Items.Add(port);
                if (ports[0] != null)
                {
                    cboPorts.SelectedItem = ports[0];
                }
            }
        }
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ClsCommon.gobjclsVariables.port = cboPorts.GetItemText(cboPorts.SelectedItem);
        }
    }
}
