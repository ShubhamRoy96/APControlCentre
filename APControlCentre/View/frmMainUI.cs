using APControlCentre.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APControlCentre
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            SunscribeEvents();
            ChangeUIPage(lblDashboard, lblDashboard);
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
                oldPage.BackColor = Color.FromArgb(9, 132, 227);

                oldPage.Font = new Font("Overpass", 10, FontStyle.Regular, GraphicsUnit.Point);

                newPage.BackColor = Color.FromArgb(116, 185, 255);
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
                            Bitmap image = (Bitmap)APControlCentre.Properties.Resources.ResourceManager.GetObject("ico" + oldsubName + "_small");
                            if (image != null)
                                pctBox.Image = image;
                            //pctBox.Size = new Size(pctBox.Size.Height - 10, pctBox.Size.Width - 10);


                        }
                        else if (pctBox.Name == strPctNewBoxName)
                        {
                            pctBox.BackColor = newPage.BackColor;
                            // Retrieve the image.
                            Bitmap image = (Bitmap)APControlCentre.Properties.Resources.ResourceManager.GetObject("ico" + newSubname + "");
                            if (image != null)
                                pctBox.Image = image;
                            //pctBox.Size = new Size(pctBox.Size.Height + 10, pctBox.Size.Width + 10);
                        }
                    }
                }

                int moveLimit = 12;
                for (int i = 1; i <= moveLimit; ++i)
                {
                    newPage.Padding = new Padding(0, 0, i, 0);
                    if (oldPage != newPage)
                        oldPage.Padding = new Padding(0, 0, moveLimit - i, 0);
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
                pnlNav.BackColor = Color.FromArgb(9, 132, 227); //Dark
                this.BackColor = Color.FromArgb(116, 185, 255); //Light
                lblDashboard.BackColor = Color.FromArgb(116, 185, 255);
                pctDashboard.BackColor = Color.FromArgb(116, 185, 255);
                btnMinimise.BackColor = Color.FromArgb(116, 185, 255);
                btnExit.BackColor = Color.FromArgb(116, 185, 255);
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

                btnExit.BackColor = Color.FromArgb(116, 185, 255);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
