/* =============================================================================
 * Code in this file is generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */

using Dapper;
using Dapper.Contrib.Extensions;
using Helper;
using Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SRMS
{
    public partial class FacultyUI : Form
    {
        private int facultyId = 0;
        private string passHolder = "";
        private string password = "";
        private List<int> coursesTaught;
        private TextBox gradeTextBox;
        /* @pre: Faculty account info is set in the database
         * @post: Account info, classes are loaded onto page
         * @exception: none
         * @side effects: none
         * @invariants: Gradebook, class views stay the same
         * @faults: none
        */
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
        /* @pre: Firstname in database
         * @post: First name appears on welcome page
         * @exception: none
         * @side effects: none
         * @invariants: none
         * @faults: none
        */
        private void loginPageLoadName()
        {
            using (var conn = new SQLiteConnection(Utils.defaultConn))
            {
                //Get faculty first name
                var sql = $"SELECT FirstName FROM Faculty WHERE Id = {facultyId}";
                dynamic result = conn.QuerySingle<string>(sql);
                welcomeNameLb.Text = result + "!";
            }
        }
        /* @pre: Winforms methods work
         * @post: Closes the program
         * @exception: none
         * @side effects: none
         * @invariants: none
         * @faults: none
        */
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* @pre: Account info available in database
         * @post: Account info displayed in Personal Info tab
         * @exception: none
         * @side effects: none
         * @invariants: Account info unchanged
         * @faults: none
        */
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
        /* @pre: info, textField are valid objects
         * @post: textField's text attribute is loaded in
         * @exception: none
         * @side effects: none
         * @invariants: info and textField do not change
         * @faults: none
        */
        private void showAcctField(dynamic textField, string info)
        {
            //Show info
            if (info == "")
            {
                textField.Text = "N/A";
            } else
            {
                textField.Text = info;
            }
            
        }
        /* @pre: Class info is in database
         * @post: Class info display
         * @exception: none
         * @side effects: none
         * @invariants: Class info does not change
         * @faults: none
        */
        public void displayClasses()
        {
            //Query for class info
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
        /* @pre: Personal info available in database
         * @post: Changes to personal info saved in database
         * @exception: none
         * @side effects: none
         * @invariants: none
         * @faults: none
        */
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

        /* @pre: Show password checkbox loaded in
         * @post: Password is shown or hidden
         * @exception: none
         * @side effects: none
         * @invariants: Password stays the same
         * @faults: none
        */
        private void showPassCB_CheckedChanged(object sender, EventArgs e)
        {
            //Show password or hide password
            if (passwordText.Text == passHolder)
            {
                passwordText.Text = password;
            } else
            {
                passwordText.Text = passHolder;
            }
        }
        /* @pre: Edit account info button loaded
         * @post: Open window to edit info
         * @exception: none
         * @side effects: none
         * @invariants: none
         * @faults: none
        */
        private void editAcctInfoBtn_Click(object sender, EventArgs e)
        {
            editInfo(facultyId);
            displayAcctInfo();
        }
        /* @pre: Course info in database
         * @post: Course list available in combobox
         * @exception: none
         * @side effects: none
         * @invariants: course info unchanged
         * @faults: none
        */
        private void loadCourseSelect()
        {
            using (var conn = new SQLiteConnection(Utils.defaultConn))
            {
                CourseCboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                //Query for courses
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
                    //Load into combo box
                    CourseCboBox.Items.Add(entry);
                }
            }
        
        }
        /* @pre: Student info in database
         * @post: Students enrolled in class are shown in data grid table
         * @exception: none
         * @side effects: none
         * @invariants: Student info unchanged
         * @faults: none
        */
        private void displayStudents()
        {
            var courseId = coursesTaught.ElementAt(CourseCboBox.SelectedIndex);
            //Query for students
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
        /* @pre: Grades are in database
         * @post: Student grade is updated in database
         * @exception: none
         * @side effects: none
         * @invariants: none
         * @faults: none
        */
        private void editGradeBtn_Click(Object sender, EventArgs e)
        {
            if (gradeTextBox.Text != null)
            {
                dynamic grade = gradeTextBox.Text;
                dynamic id = dgvGradebook.SelectedRows[0].Cells["Id"].Value;
                var courseId = coursesTaught.ElementAt(CourseCboBox.SelectedIndex);
                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    //Update grade sql command
                    var sql = $@"UPDATE Enrollment SET Grade = {grade} WHERE StudentId = {id} AND CourseId = {courseId};";
                    conn.Execute(sql);
                }
                gradeTextBox.Text = "";
                displayStudents();
            }
        }
        /* @pre: Course combo box has courses loaded in course list
         * @post: edit grade button created and added
         * @exception: none
         * @side effects: none
         * @invariants: none
         * @faults: none
        */
        private void CourseCboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayStudents();
            //Create edit grade button
            Button editGradeBtn = new Button()
            {
                Text = "Edit Grade",
                Location = new Point(300, 265),
                Size = new Size(120, 25)
            };
            editGradeBtn.Click += editGradeBtn_Click;
            //Create grade input text box
            gradeTextBox = new TextBox()
            {
                Location = new Point(editGradeBtn.Location.X - 110, editGradeBtn.Location.Y),
                Size = new Size(80, 25)
            };
            GradeTab.Controls.Add(editGradeBtn);
            GradeTab.Controls.Add(gradeTextBox);

        }
        /* @pre: Course combo box has courses loaded in
         * @post: editCourse called on current selected course
         * @exception: none
         * @side effects: none
         * @invariants: none
         * @faults: none
        */
        private void editCourseBtn_Click(object sender, EventArgs e)
        {
            if (CourseCboBox.SelectedItem != null)
            {
                var courseId = coursesTaught.ElementAt(CourseCboBox.SelectedIndex);
                editCourse(courseId);
            }
        }
        /* @pre: edit course button event handler made
         * @post: open window to edit course info
         * @exception: none
         * @side effects: none
         * @invariants: none
         * @faults: none
        */
        private bool editCourse(int id = 0)
        {
            //Edit course window
            var retval = DialogResult.Cancel;
            var course = new CourseForm(id);
            retval = course.ShowDialog();
            return DialogResult.OK == retval;
        }

    }
}
