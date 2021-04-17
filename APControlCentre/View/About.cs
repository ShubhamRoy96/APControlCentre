using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APControlCentre.Model;

namespace APControlCentre.View
{
    public partial class About : UserControl,IClsUI
    {
        public About()
        {
            InitializeComponent();
            InitializeResources();
        }
        private void InitializeResources()
        {
            try
            {
                this.BackColor = ClsCommon.gobjclsVariables.gcolUILight;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ChangeIcon(ref object objPbox, EnumNewOldIndicator indicator)
        {
            try
            {

                Bitmap image = null;

                if (indicator.Equals(EnumNewOldIndicator.Old))
                    image = (Bitmap)Properties.Resources.ResourceManager.GetObject("icoAbout_small_Alt");

                else
                    image = (Bitmap)Properties.Resources.ResourceManager.GetObject("icoAbout");


                ClsCommon.gobjclsFunctions.ChangeNavButtonImage(ref objPbox, image, indicator);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetDefaultValues()
        {
            throw new NotImplementedException();
        }

        public void SubscribeEvents()
        {
            throw new NotImplementedException();
        }

        public void UnSubscribeEvents()
        {
            throw new NotImplementedException();
        }
    }
}
