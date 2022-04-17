﻿/* =============================================================================
 * Code in this file is generated from the visual studio .NET C# winForms framework. 
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
    public partial class FacultyUI : Form
    {
        private int facultyId = 0;

        public FacultyUI(int id)
        {
            facultyId = id;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            //Hide the current window and switch to the login window, found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
            this.Hide();
            LoginUI newLogin = new LoginUI();
            newLogin.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = listBox1.SelectedIndex;
        }
    }
}
