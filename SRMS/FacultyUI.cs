/* =============================================================================
 * Code in this file is generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */

using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Windows.Forms;
using Helper;
using Models;

namespace SRMS
{
    public partial class FacultyUI : Form
    {
        private int facultyId = 0;
        private string passHolder = "";
        private string password = "";
        public FacultyUI(int id)
        {
            facultyId = id;
            InitializeComponent();
            dgvClasses.ReadOnly = true;
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.MultiSelect = false;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loginPageLoadName();
            displayAcctInfo();
            displayClasses();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void loginPageLoadName()
        {
            using (var conn = new SQLiteConnection(Utils.defaultConn))
            {
                var sql = $"SELECT FirstName FROM Faculty WHERE Id = {facultyId}";
                dynamic result = conn.QuerySingle<string>(sql);
                welcomeNameLb.Text = result + "!";
            }
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ////Hide the current window and switch to the login window, found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
            //this.Hide();
            //LoginUI newLogin = new LoginUI();
            //newLogin.Show();
        }
        public void displayAcctInfo()
        {
            using (var conn = new SQLiteConnection(Utils.defaultConn))
            {
                var f = conn.Get<Faculty>(facultyId);
                showAcctField(facultyIdText, f.Id.ToString());
                showAcctField(firstNameText, f.FirstName);
                showAcctField(lastNameText, f.LastName);
                showAcctField(usernameText, f.UserName);
                password = f.Password;
                if (passHolder == "")
                {
                    for (int i = 0; i < f.Password.Length; i++)
                    {
                        passHolder = passHolder + "*";
                    }
                }
                passwordText.Text = passHolder;
                showAcctField(emailText, f.Email);
                showAcctField(departmentText, f.Dept);
            }
        }

        private void showAcctField(dynamic textField, string info)
        {
            if (info == "")
            {
                textField.Text = "N/A";
            } else
            {
                textField.Text = info;
            }
            
        }
        public void displayClasses()
        {
            using (var conn = new SQLiteConnection(Utils.defaultConn))
            {
                var sql = $"SELECT CourseId FROM Teaching WHERE FacultyId = {facultyId}";
                dynamic results = conn.Query<int>(sql);
                results = results.ToArray();
                if (results.Length > 0)
                {
                    var sql1 = $"SELECT * FROM Course WHERE Id = {results[0]}";
                    int count = 1;
                    foreach (dynamic result in results)
                    {
                        if (count < results.Length)
                        {
                            sql1 = sql1 + $" OR Id = {results[count]}";
                            count++;
                        }
                    }
                    Utils.DisplayData(dgvClasses, sql1);
                }
                else
                {
                    dgvClasses.DataSource = null;
                    dgvClasses.Rows.Clear();
                }
            }
        }

        private bool editInfo(int id = 0)
        {
            var retval = DialogResult.Cancel;
            var student = new FacultyForm(id);
            retval = student.ShowDialog();
            return DialogResult.OK == retval;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            userInfo.SelectedIndex = listBox1.SelectedIndex;
        }


        

        private void showPassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordText.Text == passHolder)
            {
                passwordText.Text = password;
            } else
            {
                passwordText.Text = passHolder;
            }
        }

        private void editAcctInfoBtn_Click(object sender, EventArgs e)
        {
            editInfo(facultyId);
            displayAcctInfo();
        }

        private void courseSelect()
        {

        }
        private void CourseCboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curIdx = tabControl.SelectedIndex; //get the correct tab
            if (curIdx == 1)
            {
                var sql = $@"SELECT f.Id, f.FirstName, f.LastName, c.Subject, c.Level
                               FROM Faculty AS f
                               JOIN Teaching AS t ON f.Id = t.FacultyId
                               JOIN Course as c ON t.CourseId = c.Id
                              WHERE f.Id = {facultyId}"; //retreive all data fields

                //call display data from helpers.cs
                dataGridView2.ReadOnly = true;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.AllowUserToDeleteRows = false;
                dataGridView2.MultiSelect = false;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Utils.DisplayData(dataGridView2, sql);
            }

            if(curIdx == 2)
            {
                var str = $@"SELECT DISTINCT c.Subject || ' ' || c.Level AS Name, c.Id AS Cid
                               FROM Faculty AS f
                               JOIN Teaching AS t ON f.Id = t.FacultyId
                               JOIN Course AS c ON t.CourseId = c.Id
                               JOIN Enrollment AS e ON e.CourseId = c.Id
                               JOIN Student AS s ON s.Id = e.StudentId
                               WHERE f.Id = {facultyId}";
                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    CourseCboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    CourseCboBox.DataSource = null;
                    var result = conn.Query(str);
                    CourseCboBox.DataSource = result.ToDataTable();
                    CourseCboBox.DisplayMember = "Name";
                    CourseCboBox.ValueMember = "Cid";
                }
                if (CourseCboBox.Items.Count > 1)
                {
                    CourseCboBox.SelectedIndex = 0;
                    CourseCboBox_SelectionChangeCommitted(CourseCboBox, null);
                }
            }
        }

        private void CourseCboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var curIdx = tabControl.SelectedIndex; //get the correct tab
            if (curIdx == 2)
            {
                var sql = $@"SELECT c.Subject, c.Level
                                  , s.Id AS StudentId, s.FirstName, s.LastName, e.Grade
                               FROM Faculty AS f
                               JOIN Teaching AS t ON f.Id = t.FacultyId
                               JOIN Course AS c ON t.CourseId = c.Id
                               JOIN Enrollment AS e ON e.CourseId = c.Id
                               JOIN Student AS s ON s.Id = e.StudentId
                               WHERE f.Id = {facultyId} and c.Id = {CourseCboBox.SelectedValue}";

                //call display data from helpers.cs
                dataGridView3.ReadOnly = true;
                dataGridView3.AllowUserToAddRows = false;
                dataGridView3.AllowUserToDeleteRows = false;
                dataGridView3.MultiSelect = false;
                dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Utils.DisplayData(dataGridView3, sql);
            }
        }
    }
}
