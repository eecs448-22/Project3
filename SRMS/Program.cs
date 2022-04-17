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

            // Show login form
            var frmLogin = new LoginUI();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                // Login Role: 0) Administrator, 1) Faculty, 2) Student
                int loginRole = frmLogin.GetLoginRole();
                int userId = frmLogin.GetUserId();
                if (loginRole == 0)
                    Application.Run(new AdminUI(userId));
                else if (loginRole == 1)
                    Application.Run(new FacultyUI(userId));
                else if (loginRole == 2)
                    Application.Run(new StudentUI(userId));
            }
        }
    }
}
