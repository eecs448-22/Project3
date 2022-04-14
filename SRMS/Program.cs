/* =============================================================================
 * Code in this file is generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRMS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Run login form
            //Application.Run(new LoginUI());
            //var frmLogin = new LoginUI();
            //if (frmLogin.ShowDialog() == DialogResult.OK)
            //{
            //if (frmLogin.Login as Admin)
            Application.Run(new AdminUI());
            //else if (frmLogin.Login as Faculty)
            //    Application.Run(new FacultyForm());
            //else
            //    Application.Run(new FacultyForm());
        //}
        }
    }
}
