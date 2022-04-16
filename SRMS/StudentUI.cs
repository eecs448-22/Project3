using Dapper.Contrib.Extensions;
using System;
using Models;
using System.Data.SQLite;
using System.Windows.Forms;
using Helper;

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

        public StudentUI(string username)
        {
            InitializeComponent();
            dgvInfo.ReadOnly = true;
            dgvInfo.AllowUserToAddRows = false;
            dgvInfo.AllowUserToDeleteRows = false;
            dgvInfo.MultiSelect = false;
            dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvClasses.ReadOnly = true;
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.MultiSelect = false;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var sql = $"SELECT * FROM Student WHERE UserName = \"{username}\""; //retreive all data fields
            var sql1 = $"SELECT * FROM Course";
            Utils.DisplayData(dgvInfo, sql);
            Utils.DisplayData(dgvClasses, sql1);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl_studentInfo.SelectedIndex = listBox1.SelectedIndex;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
