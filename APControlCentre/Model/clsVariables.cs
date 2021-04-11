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


        //internal Color gcolUIDark = Color.FromArgb(9, 132, 227);
        internal Color gcolUIDark = Color.FromArgb(0, 71, 144);
        //internal Color gcolUILight = Color.FromArgb(116, 185, 255);
        internal Color gcolUILight = Color.FromArgb(224, 224, 224);//old 57, 213, 255
    }
}
