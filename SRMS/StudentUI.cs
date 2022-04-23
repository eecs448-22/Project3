/* @Code_Artifact: StudentUI.cs
 * @brief: StudentUI.cs is responsible for the handling of all necessary backend logic needed to interact with the Student View Form. This logic includes
 *         interacting with the Database via dapper in order to display account info, view classes and interact with classes. 
 * @Name: Justin Sizoo
 * @Created: ~4/7/2022
 * @Edited: 4/23/2022
 *             -(Justin) Implement initial functionality for retreiving account information from the database.
 *             -(Justin) Add support for the user to change account info by interacting with the studentForm window.
 *             -(Justin) Initial support for viewing all the classes that a user is enrolled in.
 *             -(Justin) Initial support for enrolling in classes.
 *             -(Justin) Bux fixing and optimizing enroll and course view.
 */

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

        /* @pre: none
         * @post Close the student form
         * @exception: none
         * @side effects: none
         * @invariants: none
         * @faults: Upon logout, the form cannot reopen the login screen because of parallel processes that begin.
        */
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

        /* @pre: none
         * @post Student Id is set, dgv properties are set, and classes are shown.
         * @exception: none
         * @side effects: Classes now appear in the course view
         * @invariants: Enrollment view stays the same
         * @faults: none
        */
        public StudentUI(int id)
        {
            studentId = id;
            InitializeComponent();

            //Set the dgvClasses properties
            dgvClasses.ReadOnly = true;
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.MultiSelect = false;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Set the dgvEnrollment Properties
            dgvEnrollment.ReadOnly = true;
            dgvEnrollment.AllowUserToAddRows = false;
            dgvEnrollment.AllowUserToDeleteRows = false;
            dgvEnrollment.MultiSelect = false;
            dgvEnrollment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            displayAccountInfo();
            showClasses();
        }

        /* @pre: Database is properly set up and connected
         * @post dgvClasses displays the resulting sql querey of classes 
         * @exception: none
         * @side effects: none
         * @invariants: account info and enrollment pages stay the same
         * @faults: Student grades are not showing up.
        */
        public void showClasses()
        {
            //Sql query string
            var sql = $@"SELECT c.Id, c.Subject, c.Level, c.Title, c.Hours, c.Semester, e.Grade FROM Course AS c
                JOIN Enrollment AS e ON e.CourseId = c.Id
                JOIN Student AS s ON s.Id = e.StudentId
                WHERE s.Id = {studentId}";

            //Re-set the dgvClasses properties
            dgvClasses.ReadOnly = true;
            dgvClasses.AllowUserToAddRows = false;
            dgvClasses.AllowUserToDeleteRows = false;
            dgvClasses.MultiSelect = false;
            dgvClasses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Display the data given the sql query
            Utils.DisplayData(dgvClasses, sql);
        }


        /* @pre: Student account info is set in the database
         * @post Textboxes are updated with their corresponding values in the DB
         * @exception: none
         * @side effects: none
         * @invariants: Enrollment, class views stay the same
         * @faults: none
        */
        public void displayAccountInfo()
        {
            //Update each textBox with the given accountInfo
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

        /* @pre: a string field and label id are passed in as parameters
         * @post The given label is updated with the desired field from the SQL query. 
         * @exception: none
         * @side effects: Label text is updated
         * @invariants: Account info, enrollment,and courses stay the same
         * @faults: none
        */
        public void printLabelInfo(Label text, string field)
        {
            using (var conn = new SQLiteConnection(defaultConn))
            {
                var sql = "";
                //Sql Query string
                sql = $"SELECT {field} FROM Student WHERE Id = {studentId}";
                //Query the DB and add the result to the given label
                dynamic result = conn.QuerySingle<string>(sql);
                text.Text = result + "!"; 
            }
            
        }

        /* @pre: textBox id and a string to indicated the desired property are passed in as parameters. 
         * @post Textboxes are set to the desired property as indicated by the field string. 
         * @exception: none
         * @side effects: none
         * @invariants: Enrollment, classes stay the same
         * @faults: none
        */
        public void printAccountInfo(TextBox textField, string field)
        {
            using (var conn = new SQLiteConnection(defaultConn))
            {
                var sql = "";
                //Sql Query String
                sql = $"SELECT {field} FROM Student WHERE Id = {studentId}";
                //Query the DB and add the result to the given textBox
                dynamic result = conn.QuerySingle<string>(sql);
                textField.Text = result;  
            }
            
        }

        /* @pre: none
         * @post Selecting a listBox tab changes the tabControl to the corresponding page 
         * @exception: none
         * @side effects: none
         * @invariants: All other studentUI functionality remains the same.
         * @faults: When you select a diffferent tab control, the list box doesn't properly highlight the result. 
        */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update the tabControl index to the corresponding listBox index once it changes.
            tabControl_studentInfo.SelectedIndex = listBox1.SelectedIndex;
            //listBox1.SetSelected(tabControl_studentInfo.SelectedIndex, true);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /* @pre: a given student record exists that can be updated
         * @post user can update accout info
         * @exception: none
         * @side effects: Account info is updated for the user to see
         * @invariants: Enrollment, course views stay the same
         * @faults: none
        */
        private void button1_Click(object sender, EventArgs e)
        {
            //When a user clicks to update account info, display the studentForm and update the account info accordingly.
            updateInsert(studentId);
            displayAccountInfo();
        }

        /* @pre: none
         * @post Show password checkbox enables the password to be viewed / hidden.
         * @exception: none
         * @side none
         * @invariants: All of the sudentUI functionality remains the same
         * @faults: none
        */
        private void showPW_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showPW.Checked)
            {
                string a = textBox_password.Text;
                //If showPW is checked, let the password be viewed
                textBox_password.PasswordChar = '\0';
            }
            else if (!showPW.Checked)
            {
                //Otherwise, set all chars in the PW to *
                textBox_password.PasswordChar = '*';
            }
        }

        private void tabPage_accInfo_Click(object sender, EventArgs e)
        {

        }

        /* @pre: Valid student account info exists that can be updated. 
         * @post StudentForm is shown and updated
         * @exception: none
         * @side effects: User can edit the studentForm.
         * @invariants: Enrollment, course views remain the same.
         * @faults: none
        */
        private bool updateInsert(int id = 0)
        {
            var retval = DialogResult.Cancel;
            //Show the StudentForm with the corresponding studentID for the user
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

        /* @pre: Combobox index has been changed
         * @post Enrollment table is updated according to the selected semester from the combo box.
         * @exception: none
         * @side effects: Label text is updated to account for the given semester. 
         * @invariants: Course view, and account info remain the same. 
         * @faults: none
        */
        private void comboBox_selectSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var conn = new SQLiteConnection(defaultConn))
            {
                //Sql query string
                var sql = $"SELECT * FROM Course WHERE Semester = '{comboBox_selectSemester.Text}'";
                //Display the data that resulted from the given query.
                Utils.DisplayData(dgvEnrollment, sql);
                //Update the label text to show the proper semester
                lblEnrollment.Text = "The following courses are offered during " + comboBox_selectSemester.Text;
            }
        }

        /* @pre: Add button for enrollment is clicked
         * @post Enrollment selection is added the courses table in the DB
         * @exception: none
         * @side effects: New enrollments will appear in the course view
         * @invariants: Accout info remains the same
         * @faults: none
        */
        private void enrollAddBtn_Click(object sender, EventArgs e)
        {
        //https://stackoverflow.com/questions/3578144/index-of-currently-selected-row-in-datagridview
        https://stackoverflow.com/questions/15536223/how-do-i-avoid-object-reference-not-set-to-an-instance-of-an-object
            int rowCount = dgvEnrollment.Rows.Count; // Obtains the row count for the enrollment dgv
            //Ensures that there are entries in the dgv
            if(rowCount > 0)
            {
                //Obtain the current row index, convert to string
                int rowIndex = dgvEnrollment.CurrentRow.Index;
                string value = dgvEnrollment.Rows[rowIndex].Cells[0].Value.ToString();
                //Display a messageBox confirming enrollment in the selected course
                DialogResult confirmEnrollment = MessageBox.Show($"Do you want to enroll in the course with ID: {value}", "Confirm Enrollment", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirmEnrollment == DialogResult.Yes)
                {
                    using (var conn = new SQLiteConnection(defaultConn))
                    {
                        //Sql statement to insert into the enrollment table
                        var sql = $"INSERT INTO Enrollment (StudentId, CourseId) VALUES ('{studentId}', '{value}')";
                        conn.Query(sql);
                        //Update the classes
                        showClasses();
                    }
                    //Display a success messageBox
                    MessageBox.Show($"Success - You are now enrolled in the course with ID: {value}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //If dgv contains no entries, show an error messagebox
            else MessageBox.Show("Error - No course is selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void calender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        /* @pre: Drop button for enrollment is clicked
         * @post Enrollment selection is removed the courses table in the DB
         * @exception: none
         * @side effects: Old enrollments will no longer appear in the course view
         * @invariants: Accout info remains the same
         * @faults: none
        */
        private void dropEnrollBtn_Click(object sender, EventArgs e)
        {
        //https://stackoverflow.com/questions/3578144/index-of-currently-selected-row-in-datagridview
        https://stackoverflow.com/questions/15536223/how-do-i-avoid-object-reference-not-set-to-an-instance-of-an-object
            int rowCount = dgvClasses.Rows.Count; // Obtains the row count for the enrollment dgv
            //Ensures that there are entries in the dgv
            if (rowCount > 0)
            {
                //Obtain the current row index, convert to string
                int rowIndex = dgvClasses.CurrentRow.Index;
                string value = dgvClasses.Rows[rowIndex].Cells[0].Value.ToString();
                //Display a messageBox confirming dropping of the selected course
                DialogResult confirmEnrollment = MessageBox.Show($"Are you sure you want to drop the course with ID: {value}", "Confirm Drop", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmEnrollment == DialogResult.Yes)
                {
                    using (var conn = new SQLiteConnection(defaultConn))
                    {
                        //Sql statement to delete from the enrollment table
                        var sql = $"DELETE FROM Enrollment WHERE StudentId = '{studentId}' AND CourseId = '{value}'";
                        conn.Query(sql);
                        //Update the classes
                        showClasses();
                    }

                }
                //Display a success messageBox
                MessageBox.Show($"Success - You have withdrawn from the course with ID: {value}", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Display an error message box if no rows exist in the dgv.
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
