/* =============================================================================
 * Some code in this file (class and functions) are generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */

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
    public partial class newPassWordLabel : Form
    {
        public newPassWordLabel()
        {
            InitializeComponent();
            emailLabel.Visible = false;
            emailInput.Visible = false;
            comboBox1.SelectedIndex = 0;
            comboBox1.Enabled = false;
        }

        //Switches back to the login page if go Back button is clicked. 
        private void goBackBtn_Click(object sender, EventArgs e)
        {
            //Hide the current window and switch to the login window, found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
            this.Hide();
            LoginUI goBack = new LoginUI();
            goBack.Show();
        }

        private void ProgTitle_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //Hide the current window and switch to the login window, found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
            this.Hide();
            LoginUI goBack = new LoginUI();
            goBack.Show();
        }
    }
}
