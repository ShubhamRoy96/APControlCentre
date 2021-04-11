﻿using APControlCentre.Controller;
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
        internal static frmDashboard GetFrmDashboard;
        internal static frmSettings GetFrmSettings;
        internal static frmAbout GetFrmAbout;

        
        internal static void InitialiseClasses()
        {
            gobjclsVariables = new ClsVariables();
            gobjclsController = new ClsController();
            gobjclsFunctions = new ClsFunctions();            
        }

        internal static void InitialiseForms()
        {
            GetFrmDashboard = new frmDashboard();
            GetFrmSettings = new frmSettings();
            GetFrmAbout = new frmAbout();
        }


    }
}
