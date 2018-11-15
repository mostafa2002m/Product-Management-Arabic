using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRODUCTS_MANAGEMENT.PL;

namespace PRODUCTS_MANAGEMENT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string User_FullName;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new PL.frm_Pos());

            Application.Run(new PL.frmMain());

        }
    }
}
