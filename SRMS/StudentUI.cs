using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Helper;
using System.Linq;


namespace SRMS
{
    public partial class StudentUI : Form
    {
        public static string defaultConn = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        private int studentId = 0;
        private void button_logOut_Click(object sender, EventArgs e)
        {
            this.Close();
            // Close the form here; otherwise, the app won't exit, which prevents us from rebuilding app.
            // https://stackoverflow.com/questions/50469473/switch-between-forms-from-main-program

            //Hide the current window and switch to the login window, found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
            //this.Hide();
            //LoginUI logOut = new LoginUI();
            //logOut.Show();
        }

        public StudentUI(int id)
        {
            studentId = id;
            InitializeComponent();

            dgvClasses.ReadOnly = true;
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.MultiSelect = false;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            displayAccountInfo();

            

            var conn = new SQLiteConnection(defaultConn);
            conn.Open();
            var sql = "";
            sql = $"SELECT CourseId FROM Enrollment WHERE StudentId = {studentId}";
            dynamic results = conn.Query<int>(sql);
            results = results.ToArray();
            Console.Write(results);

            foreach(int result in results)
            {
                var sql1 = $"SELECT * FROM Course WHERE Id = {result}";
                Utils.DisplayData(dgvClasses, sql1);
            }
        }

        public void displayAccountInfo()
        {
            printAccountInfo(textBox_firstName, "Firstname");
            printLabelInfo(labelName, "Firstname");
            printAccountInfo(textBox_lastName, "Lastname");
            printAccountInfo(textBox_id, "Id");
            printAccountInfo(textBox_username, "UserName");
            printAccountInfo(textBox_password, "Password");
            textBox_password.PasswordChar = '*';
            var sql = $"SELECT * FROM Student WHERE Id = {studentId}";
            printAccountInfo(textBox_Email, "Email");
            printAccountInfo(textBox_Major, "Major");
        }

        public void printLabelInfo(Label text, string field)
        {
            var conn = new SQLiteConnection(defaultConn);
            conn.Open();
            var sql = "";
            sql = $"SELECT {field} FROM Student WHERE Id = {studentId}";
            dynamic result = conn.QuerySingle<string>(sql);
            text.Text = result + "!";
        }
        public void printAccountInfo(TextBox textField, string field)
        {
            var conn = new SQLiteConnection(defaultConn);
            conn.Open();
            var sql = "";
            sql = $"SELECT {field} FROM Student WHERE Id = {studentId}";
            dynamic result = conn.QuerySingle<string>(sql);
            textField.Text = result;
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
            updateInsert(studentId);
            displayAccountInfo();
        }


        private void showPW_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showPW.Checked)
            {
                string a = textBox_password.Text;
                textBox_password.PasswordChar = '\0';
            }
            else if (!showPW.Checked)
            {
                textBox_password.PasswordChar = '*';
            }
        }

        private void tabPage_accInfo_Click(object sender, EventArgs e)
        {

        }

        private bool updateInsert(int id = 0)
        {
            var retval = DialogResult.Cancel;
            var student = new StudentForm(id);
            retval = student.ShowDialog();
            return DialogResult.OK == retval;
        }

        private void textBox_firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentUI_Load(object sender, EventArgs e)
        {

        }

        private void tabPage_welcome_Click(object sender, EventArgs e)
        {

        }

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
