using APControlCentre.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APControlCentre;
using APControlCentre.View;

namespace APControlCentre.Controller
{
    class ClsController
    {
        public ClsController()
        {
            SubscribeEvents();
        }

        private void SubscribeEvents()
        {
            frmMainUI.NavigationButtonClicked += HandleNavigationButtonClick;
        }

        

        private void HandleNavigationButtonClick(object sender, EventArgs e)
        {
            try
            {
                Label srcLabel = sender as Label;

                ClsVariables.Pages sourcePage = (ClsVariables.Pages)Enum.Parse(typeof(ClsVariables.Pages), srcLabel.Text);
                ClsCommon.gobjclsFunctions.ChangePage(sourcePage, srcLabel);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
