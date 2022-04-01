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
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI goBack = new LoginUI();
            goBack.Show();
        }

        private void ProgTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
