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
    public partial class Settings : UserControl, IClsUI
    {

        String[] ports;
        DataSender dataSender;
        public bool areLightsON { get; set; }


        public Settings()
        {
            InitializeComponent();
            getAvailableComPorts();
        }


        private void Settings_Load(object sender, EventArgs e)
        {
            foreach (string port in ports)
            {
                cboPorts.Items.Add(port);
                if (ports[0] != null)
                {
                    cboPorts.SelectedItem = ports[0];
                }
            }
            this.BackColor = ClsCommon.gobjclsVariables.gcolUILight;
        }
        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string selectedPort = cboPorts.GetItemText(cboPorts.SelectedItem);
            ClsCommon.gobjclsVariables.port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);

            if (dataSender == null)
            {
                dataSender = new DataSender(ClsCommon.gobjclsVariables.port);
            }

        }

        public void SubscribeEvents()
        {
            throw new NotImplementedException();
        }

        public void UnSubscribeEvents()
        {
            throw new NotImplementedException();
        }

        public void SetDefaultValues()
        {
            throw new NotImplementedException();
        }

        public void ChangeIcon(ref object objPbox, EnumNewOldIndicator indicator)
        {
            try
            {
                Bitmap image = null;

                if (indicator.Equals(EnumNewOldIndicator.Old))
                    image = (Bitmap)Properties.Resources.ResourceManager.GetObject("icoSettings_small_Alt");
                else
                    image = (Bitmap)Properties.Resources.ResourceManager.GetObject("icoSettings");

                ClsCommon.gobjclsFunctions.ChangeNavButtonImage(ref objPbox, image, indicator);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string RED = Math.Abs(Convert.ToInt32(txtRed.Text.PadLeft(3, '0')) - 255).ToString().PadLeft(3, '0');
            string GREEN = Math.Abs(Convert.ToInt32(txtGreen.Text.PadLeft(3, '0')) - 255).ToString().PadLeft(3, '0');
            string BLUE = Math.Abs(Convert.ToInt32(txtBlue.Text.PadLeft(3, '0')) - 255).ToString().PadLeft(3, '0');


            string RGBdata = "#RGB" + RED + GREEN + BLUE + "|";
            DataSender.Enqueue(RGBdata);
        }

        private void btnPowerON_Click(object sender, EventArgs e)
        {
            string lightsStatus = string.Empty;
            if (!areLightsON)
            {
                areLightsON = true;
                btnPowerON.Text = "OFF";
                lightsStatus = "#STA|";
            }
            else
            {
                areLightsON = false;
                btnPowerON.Text = "ON";
                lightsStatus = "#STO|";
            }            
             DataSender.Enqueue(lightsStatus);
        }
    }
}
