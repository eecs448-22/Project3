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
        private List<int> coursesTaught;
        private TextBox gradeTextBox;
        public FacultyUI(int id)
        {
            facultyId = id;
            InitializeComponent();
            loginPageLoadName();
            displayAcctInfo();
            displayClasses();
            loadCourseSelect();
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
            var sql = $@"SELECT c.Id, c.Subject, c.Level, c.Title, c.Hours, c.Semester FROM Course AS c
                JOIN Teaching AS t ON t.CourseId = c.Id
                JOIN Faculty AS f ON f.Id = t.FacultyId
                WHERE f.Id = {facultyId}";

            dgvClasses.ReadOnly = true;
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.MultiSelect = false;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Utils.DisplayData(dgvClasses, sql);
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

        private void loadCourseSelect()
        {
            using (var conn = new SQLiteConnection(Utils.defaultConn))
            {
                CourseCboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                var sql = $@"SELECT c.Id, c.Subject, c.Level, c.Semester FROM Course AS c 
                            JOIN Teaching AS t ON t.CourseId = c.Id
                            JOIN Faculty AS f ON f.Id = t.FacultyId
                            WHERE f.Id = {facultyId}";
                var courses = conn.Query<Course>(sql);
                courses = courses.ToArray();
                coursesTaught = new List<int>();
                foreach (Course c in courses)
                {
                    coursesTaught.Add(c.Id);
                    var entry = $"{c.Subject} {c.Level} {c.Semester}";
                    CourseCboBox.Items.Add(entry);
                }
            }
        
        }
        private void displayStudents()
        {
            var courseId = coursesTaught.ElementAt(CourseCboBox.SelectedIndex);
            var sql = $@"SELECT s.Id, s.FirstName, s.LastName, e.Grade FROM Student AS s
                           JOIN Enrollment AS e ON s.Id = e.StudentId
                           WHERE e.CourseId = {courseId}";
            dgvGradebook.ReadOnly = true;
            dgvGradebook.AllowUserToAddRows = false;
            dgvGradebook.AllowUserToDeleteRows = false;
            dgvGradebook.MultiSelect = false;
            dgvGradebook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Utils.DisplayData(dgvGradebook, sql);
        }

        private void editGradeBtn_Click(Object sender, EventArgs e)
        {
            if (gradeTextBox.Text != null)
            {
                dynamic grade = gradeTextBox.Text;
                dynamic id = dgvGradebook.SelectedRows[0].Cells["Id"].Value;
                var courseId = coursesTaught.ElementAt(CourseCboBox.SelectedIndex);
                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    var sql = $@"UPDATE Enrollment SET Grade = {grade} WHERE StudentId = {id} AND CourseId = {courseId};";
                    conn.Execute(sql);
                }
                gradeTextBox.Text = "";
                displayStudents();
            }
        }
        private void CourseCboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayStudents();
            Button editGradeBtn = new Button()
            {
                Text = "Edit Grade",
                Location = new Point(300, 265),
                Size = new Size(120, 25)
            };
            editGradeBtn.Click += editGradeBtn_Click;
            gradeTextBox = new TextBox()
            {
                Location = new Point(editGradeBtn.Location.X - 110, editGradeBtn.Location.Y),
                Size = new Size(80, 25)
            };
            GradeTab.Controls.Add(editGradeBtn);
            GradeTab.Controls.Add(gradeTextBox);

        }

        private void dgvGradebook_selectedRowSelected(object sender, EventArgs e)
        {

        }

        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            if (CourseCboBox.SelectedItem != null)
            {
                var courseId = coursesTaught.ElementAt(CourseCboBox.SelectedIndex);
                editCourse(courseId);
            }
        }

        private bool editCourse(int id = 0)
        {
            var retval = DialogResult.Cancel;
            var course = new CourseForm(id);
            retval = course.ShowDialog();
            return DialogResult.OK == retval;
        }

        private void dgvGradebook_Click(object sender, EventArgs e)
        {
            
        }
    }
}
