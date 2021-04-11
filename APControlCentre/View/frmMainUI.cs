using APControlCentre.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APControlCentre
{
    public partial class frmMain : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        public string gRED = string.Empty;
        public string gGREEN = string.Empty;
        public string gBLUE = string.Empty;
        OpenHardwareMonitor.Hardware.Computer thisComputer = new OpenHardwareMonitor.Hardware.Computer() { };

        public frmMain()
        {
            InitializeComponent();
            SunscribeEvents();
            ChangeUIPage(lblDashboard, lblDashboard);
            //StartTelemetry();
            //disableControls();
            //getAvailableComPorts();
            //foreach (string port in ports)
            //{
            //    cmboPorts.Items.Add(port);
            //    Console.WriteLine(port);
            //    if (ports[0] != null)
            //    {
            //        cmboPorts.SelectedItem = ports[0];
            //    }
            //}
        }

        private void SunscribeEvents()
        {
            try
            {
                ClsCommon.gobjclsFunctions.UIPageChanged += ChangeUIPage;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void ChangeUIPage(Label oldPage, Label newPage)
        {
            try
            {
                oldPage.BackColor = ClsCommon.gobjclsVariables.gcolUIDark;
                oldPage.ForeColor = ClsCommon.gobjclsVariables.gcolUILight;
                oldPage.Font = new Font("Overpass", 10, FontStyle.Regular, GraphicsUnit.Point);

                newPage.BackColor = ClsCommon.gobjclsVariables.gcolUILight;
                newPage.ForeColor = Color.Black;
                newPage.Font = new Font("Overpass ExtraBold", 12, FontStyle.Regular, GraphicsUnit.Point);

                ClsCommon.gobjclsVariables.CurrentPage = newPage;

                string oldsubName = oldPage.Text[0] + oldPage.Text.Substring(1).ToLower();
                string newSubname = newPage.Text[0] + newPage.Text.Substring(1).ToLower();
                string strPctOldBoxName = "pct" + oldsubName;
                string strPctNewBoxName = "pct" + newSubname;
                foreach (Control uiElement in pnlNav.Controls)
                {
                    if (uiElement is PictureBox pctBox)
                    {
                        if (pctBox.Name == strPctOldBoxName && pctBox.Name != strPctNewBoxName)
                        {
                            pctBox.BackColor = oldPage.BackColor;
                            // Get resources from .resx file.


                            // Retrieve the image.
                            Bitmap image = (Bitmap)APControlCentre.Properties.Resources.ResourceManager.GetObject("ico" + oldsubName + "_small_Alt");
                            if (image != null)
                                pctBox.Image = image;


                        }
                        else if (pctBox.Name == strPctNewBoxName)
                        {
                            pctBox.BackColor = newPage.BackColor;
                            // Retrieve the image.
                            Bitmap image = (Bitmap)APControlCentre.Properties.Resources.ResourceManager.GetObject("ico" + newSubname + "");
                            if (image != null)
                                pctBox.Image = image;
                        }
                    }
                }

                int moveLimit = 12;
                int startLocation = newPage.Padding.Right;
                for (int i = startLocation; i <= moveLimit; ++i)
                {
                    newPage.Padding = new Padding(0, 0, i, 0);
                    if (oldPage != newPage)
                        oldPage.Padding = new Padding(0, 0, moveLimit - i + startLocation, 0);
                    await Task.Delay(1);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal delegate void NavigationButtonEventHandler(object sender, EventArgs e);

        internal static event NavigationButtonEventHandler NavigationButtonClicked;


        private void BtnPage_Click(object sender, EventArgs e)
        {
            try
            {
                OnNavigationButtonClick(sender, e);
            }
            catch (Exception)
            {

                throw;
            }
        }


        protected virtual void OnNavigationButtonClick(object sender, EventArgs e)
        {
            try
            {
                NavigationButtonClicked?.Invoke(sender, e);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                pnlNav.BackColor = ClsCommon.gobjclsVariables.gcolUIDark; //Dark
                this.BackColor = ClsCommon.gobjclsVariables.gcolUILight; //Light
                lblDashboard.BackColor = ClsCommon.gobjclsVariables.gcolUILight;
                pctDashboard.BackColor = ClsCommon.gobjclsVariables.gcolUILight;
                btnMinimise.BackColor = ClsCommon.gobjclsVariables.gcolUILight;
                btnExit.BackColor = ClsCommon.gobjclsVariables.gcolUILight;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            try
            {

                btnExit.BackColor = Color.FromArgb(150, 0, 0);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            try
            {

                btnExit.BackColor = ClsCommon.gobjclsVariables.gcolUILight;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
