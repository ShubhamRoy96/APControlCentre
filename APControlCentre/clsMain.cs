using APControlCentre.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APControlCentre.View
{
    static class clsMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ClsCommon.InitialiseClasses();
            ClsCommon.InitialiseForms();
            Application.Run(new frmMainUI());
        }
    }
}
