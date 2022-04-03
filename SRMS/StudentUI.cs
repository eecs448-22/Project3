using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRMS
{
    public partial class StudentUI : Form
    {
        private void button_logOut_Click(object sender, EventArgs e)
        {
            //Hide the current window and switch to the login window, found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
            this.Hide();
            LoginUI logOut = new LoginUI();
            logOut.Show();
        }
    }
}
