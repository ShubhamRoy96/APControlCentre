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
    public partial class frmMainUI : Form, IClsMain
    {
        bool isConnected = false;
        private PictureBox OldIcon { get; set; }
        private PictureBox NewIcon { get; set; }



        public frmMainUI()
        {
            InitializeComponent();

            SubscribeEvents();
        }



        private void ChangeUIPage(Label oldPageLabel, Label newPageLabel)
        {
            try
            {
                UserControl newPage = null;
                UserControl oldPage = null;
                

                if (grpContainer.Controls.Count > 0)
                {
                    oldPage = grpContainer.Controls[0] as UserControl;                    
                }
                bool isInvalid = false;
                clsConstants.Pages newPageName = (clsConstants.Pages)Enum.Parse(typeof(clsConstants.Pages), newPageLabel.Text);

                switch (newPageName)
                {
                    case clsConstants.Pages.DASHBOARD:
                        newPage = ClsCommon.GetDashboard;
                        NewIcon = pctDashboard;
                        break;
                    case clsConstants.Pages.SETTINGS:
                        newPage = ClsCommon.GetSettings;
                        NewIcon = pctSettings;
                        break;
                    case clsConstants.Pages.ABOUT:
                        newPage = ClsCommon.GetAbout;
                        NewIcon = pctAbout;
                        break;
                    default:
                        isInvalid = true;
                        break;

                }

                clsConstants.Pages oldPageName = (clsConstants.Pages)Enum.Parse(typeof(clsConstants.Pages), oldPageLabel.Text);

                switch (oldPageName)
                {
                    case clsConstants.Pages.DASHBOARD:                        
                        OldIcon = pctDashboard;
                        break;
                    case clsConstants.Pages.SETTINGS:
                        OldIcon = pctSettings;
                        break;
                    case clsConstants.Pages.ABOUT:
                        OldIcon = pctAbout;
                        break;
                    default:
                        isInvalid = true;
                        break;

                }



                if (!isInvalid)
                {
                    if (oldPage != null && oldPage.Visible)
                    {
                        oldPage.Visible = false;
                        IClsUI oldPageInterface = oldPage as IClsUI;
                        object oldPbox = OldIcon;
                        oldPageInterface.ChangeIcon(ref oldPbox, EnumNewOldIndicator.Old);
                        grpContainer.Controls.Remove(oldPage);
                    }

                    newPage.Visible = true;
                    IClsUI newPageInterface = newPage as IClsUI;
                    object NewPbox = NewIcon;
                    newPageInterface.ChangeIcon(ref NewPbox, EnumNewOldIndicator.New);
                    grpContainer.Controls.Add(newPage);                    
                    newPage.Size = grpContainer.Size;

                    Task.Run(() => ChangeUIColors(oldPageLabel, newPageLabel));
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void ChangeUIColors(Label oldPageLabel, Label newPageLabel)
        {
            oldPageLabel.BackColor = ClsCommon.gobjclsVariables.gcolUIDark;
            oldPageLabel.ForeColor = ClsCommon.gobjclsVariables.gcolUILight;
            oldPageLabel.Font = new Font("Overpass", 10, FontStyle.Regular, GraphicsUnit.Point);

            newPageLabel.BackColor = ClsCommon.gobjclsVariables.gcolUILight;
            newPageLabel.ForeColor = Color.Black;
            newPageLabel.Font = new Font("Overpass ExtraBold", 12, FontStyle.Regular, GraphicsUnit.Point);

            ClsCommon.gobjclsVariables.CurrentPage = newPageLabel;

            //string oldsubName = oldPageLabel.Text[0] + oldPageLabel.Text.Substring(1).ToLower();
            //string newSubname = newPageLabel.Text[0] + newPageLabel.Text.Substring(1).ToLower();
            //string strPctOldBoxName = "pct" + oldsubName;
            //string strPctNewBoxName = "pct" + newSubname;
            //foreach (Control uiElement in pnlNav.Controls)
            //{
            //    if (uiElement is PictureBox pctBox)
            //    {
            //        if (pctBox.Name == strPctOldBoxName && pctBox.Name != strPctNewBoxName)
            //        {
            //            pctBox.BackColor = oldPageLabel.BackColor;
            //            // Get resources from .resx file.


            //            // Retrieve the image.
            //            Bitmap image = (Bitmap)APControlCentre.Properties.Resources.ResourceManager.GetObject("ico" + oldsubName + "_small_Alt");
            //            if (image != null)
            //                pctBox.Image = image;


            //        }
            //        else if (pctBox.Name == strPctNewBoxName)
            //        {
            //            pctBox.BackColor = newPageLabel.BackColor;
            //            // Retrieve the image.
            //            Bitmap image = (Bitmap)APControlCentre.Properties.Resources.ResourceManager.GetObject("ico" + newSubname + "");
            //            if (image != null)
            //                pctBox.Image = image;
            //        }
            //    }
            //}

            int moveLimit = 12;
            int startLocation = newPageLabel.Padding.Right;
            for (int i = startLocation; i <= moveLimit; ++i)
            {
                newPageLabel.Padding = new Padding(0, 0, i, 0);
                if (oldPageLabel != newPageLabel)
                    oldPageLabel.Padding = new Padding(0, 0, moveLimit - i + startLocation, 0);
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
                //foreach (Control ctl in this.Controls)
                //{

                //    MdiClient Mdi = ctl as MdiClient;
                //    if (Mdi != null)
                //    {
                //        ClsCommon.gobjclsVariables.GetMdiClient = Mdi;
                //    }

                //}
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

        //private const int SB_BOTH = 3;
        //[DllImport("user32.dll")]
        //private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);

        //protected override void WndProc(ref Message m)
        //{
        //    if (ClsCommon.gobjclsVariables.GetMdiClient != null)
        //    {
        //        ShowScrollBar(ClsCommon.gobjclsVariables.GetMdiClient.Handle, SB_BOTH, 0 /*Hide the ScrollBars*/);
        //    }
        //    base.WndProc(ref m);
        //}

        private void frmMainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClsCommon.gobjclsVariables.GetMdiClient = null;
        }



        public void UnSubscribeEvents()
        {
            throw new NotImplementedException();
        }

        public void SetDefaultValues()
        {
            throw new NotImplementedException();
        }

        public void SubscribeEvents()
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
    }
}
