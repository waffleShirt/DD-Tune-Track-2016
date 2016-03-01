﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DD_Tune_Track
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //SQLiteDBTestDriver.Execute(); 
            SQLiteDBTestDriver.ExecuteDDTTDBCreationTest(); 

            Application.Run(new Form1());
        }
    }
}
