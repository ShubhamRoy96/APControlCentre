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

namespace APControlCentre.Model
{
    class ClsFunctions
    {

        internal delegate void ChangeUIPageHandler(Label oldPage, Label newPage);
        internal event ChangeUIPageHandler UIPageChanged;

        internal void ChangePage(ClsVariables.Pages page, Label newPage)
        {
            try
            {
                Label oldPage = ClsCommon.gobjclsVariables.CurrentPage;
                if (oldPage != newPage)
                    UIPageChanged?.Invoke(oldPage, newPage);

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
