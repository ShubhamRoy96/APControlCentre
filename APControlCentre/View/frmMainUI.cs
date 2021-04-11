using APControlCentre.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APControlCentre.View
{
    public partial class frmMainUI : Form
    {
        bool isConnected = false;
        
        

        public frmMainUI()
        {
            InitializeComponent();
            SunscribeEvents();

            
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
                Form newForm = new Form();
                Form oldForm = this.ActiveMdiChild;
                bool isInvalid = false;
                clsConstants.Pages page = (clsConstants.Pages)Enum.Parse(typeof(clsConstants.Pages), newPage.Text);
                switch (page)
                {
                    case clsConstants.Pages.DASHBOARD:
                        newForm = ClsCommon.GetFrmDashboard;
                        break;
                    case clsConstants.Pages.SETTINGS:
                        newForm = ClsCommon.GetFrmSettings;
                        break;
                    case clsConstants.Pages.ABOUT:
                        newForm = ClsCommon.GetFrmAbout;
                        break;
                    default:
                        isInvalid = true;
                        break;

                }

                if (!isInvalid)
                {
                    if (oldForm != null && oldForm.Visible)
                    {
                        oldForm.Hide();
                    }


                    newForm.Show();

                    newForm.MdiParent = this;
                    newForm.Width = this.Width - pnlNav.Width;
                    newForm.Height = this.Height;
                    newForm.Location = new Point(pnlNav.Width, btnExit.Height);                    

                    ClsCommon.gobjclsVariables.GetMdiClient.BackColor = newForm.BackColor;
                }
                await ChangeUIColors(oldPage, newPage);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task ChangeUIColors(Label oldPage, Label newPage)
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
                foreach (Control ctl in this.Controls)
                {

                    MdiClient Mdi = ctl as MdiClient;
                    if (Mdi != null)
                    {
                        ClsCommon.gobjclsVariables.GetMdiClient = Mdi;
                    }

                }
                ChangeUIPage(lblDashboard, lblDashboard);
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

        private const int SB_BOTH = 3;
        [DllImport("user32.dll")]
        private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

        protected override void WndProc(ref Message m)
        {
            if (ClsCommon.gobjclsVariables.GetMdiClient != null)
            {
                ShowScrollBar(ClsCommon.gobjclsVariables.GetMdiClient.Handle, SB_BOTH, 0 /*Hide the ScrollBars*/);
            }
            base.WndProc(ref m);
        }

        private void frmMainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClsCommon.gobjclsVariables.GetMdiClient = null;
        }
    }
}
