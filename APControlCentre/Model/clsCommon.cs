using APControlCentre.Controller;
using APControlCentre.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace APControlCentre.Model
{
    internal static class ClsCommon
    {


        internal static ClsVariables gobjclsVariables;
        internal static ClsController gobjclsController;
        internal static ClsFunctions gobjclsFunctions;

        internal static Dashboard GetDashboard;
        internal static Settings GetSettings;
        internal static About GetAbout;


        internal static void InitialiseClasses()
        {
            gobjclsVariables = new ClsVariables();
            gobjclsController = new ClsController();
            gobjclsFunctions = new ClsFunctions();            
        }

        internal static void InitialisePages()
        {
            GetDashboard = new Dashboard();
            GetSettings = new Settings();
            GetAbout = new About();
        }


    }
}
