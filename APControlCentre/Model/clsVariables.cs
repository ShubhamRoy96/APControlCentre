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
    class ClsVariables
    {
        public Label CurrentPage { get; set; }
        internal enum Pages
        {
            DASHBOARD,
            SETTINGS,
            ABOUT
        }
    }
}
