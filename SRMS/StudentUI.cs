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
        public StudentUI()
        {
            InitializeComponent();
        }

        private void StudentUI_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage_welcome_Click(object sender, EventArgs e)
        {

        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            //Hide the current window and switch to the login window, found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
            this.Hide();
            LoginUI logOut = new LoginUI();
            logOut.Show();
        }

        private void textBox_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_major_Click(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_major_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void label_lastName_Click(object sender, EventArgs e)
        {

        }

        private void label_firstName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
