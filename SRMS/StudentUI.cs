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

            dgvEnrollment.ReadOnly = true;
            dgvEnrollment.AllowUserToAddRows = false;
            dgvEnrollment.AllowUserToDeleteRows = false;
            dgvEnrollment.MultiSelect = false;
            dgvEnrollment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            displayAccountInfo();
            showClasses();
        }
        public void showClasses()
        {
            var sql = $@"SELECT c.Id, c.Subject, c.Level, c.Title, c.Hours, c.Semester FROM Course AS c
                JOIN Enrollment AS e ON e.CourseId = c.Id
                JOIN Student AS s ON s.Id = e.StudentId
                WHERE s.Id = {studentId}";
            dgvClasses.ReadOnly = true;
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.MultiSelect = false;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Utils.DisplayData(dgvClasses, sql);
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
            using (var conn = new SQLiteConnection(defaultConn))
            {
                var sql = "";
                sql = $"SELECT {field} FROM Student WHERE Id = {studentId}";
                dynamic result = conn.QuerySingle<string>(sql);
                text.Text = result + "!"; 
            }
            
        }
        public void printAccountInfo(TextBox textField, string field)
        {
            using (var conn = new SQLiteConnection(defaultConn))
            {
                var sql = "";
                sql = $"SELECT {field} FROM Student WHERE Id = {studentId}";
                dynamic result = conn.QuerySingle<string>(sql);
                textField.Text = result;  
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl_studentInfo.SelectedIndex = listBox1.SelectedIndex;
            //listBox1.SetSelected(tabControl_studentInfo.SelectedIndex, true);
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

        private void comboBox_selectSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(defaultConn))
            {
                var sql = $"SELECT * FROM Course WHERE Semester = '{comboBox_selectSemester.Text}'";
                //System.Diagnostics.Debug.WriteLine(sql);
                Utils.DisplayData(dgvEnrollment, sql);
                lblEnrollment.Text = "The following courses are offered during " + comboBox_selectSemester.Text;
            }
        }
        private void enrollAddBtn_Click(object sender, EventArgs e)
        {
        //https://stackoverflow.com/questions/3578144/index-of-currently-selected-row-in-datagridview
        https://stackoverflow.com/questions/15536223/how-do-i-avoid-object-reference-not-set-to-an-instance-of-an-object
            int rowCount = dgvEnrollment.Rows.Count; // returns actual row count
            if(rowCount > 0)
            {
                int rowIndex = dgvEnrollment.CurrentRow.Index;
                string value = dgvEnrollment.Rows[rowIndex].Cells[0].Value.ToString();
                DialogResult confirmEnrollment = MessageBox.Show($"Do you want to enroll in the course with ID: {value}", "Confirm Enrollment", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirmEnrollment == DialogResult.Yes)
                {
                    using (var conn = new SQLiteConnection(defaultConn))
                    {
                        var sql = $"INSERT INTO Enrollment (StudentId, CourseId) VALUES ('{studentId}', '{value}')";
                        //var sql = $"INSERT INTO Enrollment (StudentId, CourseId, DateEntered, Status) VALUES {studentId}, {value}, {calender.TodayDate}, 1";
                        conn.Query(sql);
                        showClasses();
                    }
                    MessageBox.Show($"Success - You are now enrolled in the course with ID: {value}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else MessageBox.Show("Error - No course is selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void calender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dropEnrollBtn_Click(object sender, EventArgs e)
        {
        //https://stackoverflow.com/questions/3578144/index-of-currently-selected-row-in-datagridview
        https://stackoverflow.com/questions/15536223/how-do-i-avoid-object-reference-not-set-to-an-instance-of-an-object
            int rowCount = dgvClasses.Rows.Count; // returns actual row count
            if (rowCount > 0)
            { 
                int rowIndex = dgvClasses.CurrentRow.Index;
                string value = dgvClasses.Rows[rowIndex].Cells[0].Value.ToString();
                DialogResult confirmEnrollment = MessageBox.Show($"Are you sure you want to drop the course with ID: {value}", "Confirm Drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmEnrollment == DialogResult.Yes)
                {
                    using (var conn = new SQLiteConnection(defaultConn))
                    {
                        var sql = $"DELETE FROM Enrollment WHERE StudentId = '{studentId}' AND CourseId = '{value}'";
                        conn.Query(sql);
                        showClasses();
                    }

                }
                MessageBox.Show($"Success - You have withdrawn from the course with ID: {value}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error - No course is selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void dgvEnrollment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage_enrollment_Click(object sender, EventArgs e)
        {

        }
    }
}
