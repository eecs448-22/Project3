using Dapper.Contrib.Extensions;
using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Models;
using Helper;
using DBMS;

namespace SRMS
{
    //this form allows for creating or updating student information
    public partial class StudentForm : Form 
    {
        
        private string connString = SqliteDataAccess.LoadConnectionString(); //get connection string to database

        /* StudentForm constructor
        * Programmer: Alice Kuang
        * Date Created: 4/10/22
        * Date Revised: 4/14/22
        * Desc: this is the default constructor for student
        * Pre: takes the id of the student, or defaults to 0.
        * Post: Returns the new or updated student record. 
        * side-effects: none  
        * invariants: the record will be inserted or modified in the database
        * faults: none known
        */
        public StudentForm(int id = 0)    // if the student id is 0, we create a new student
        {
            InitializeComponent();        //initialize the form
            txtStudentId.ReadOnly = true; //make studentId a read only field
            txtCreatedOn.ReadOnly = true; //make created on a read only field

            this.Text = "Create New Student"; //set the default form header text as create student


            if (id > 0) //if student id > 0, the student already exists, so we update the student
            {
                this.Text = "Update Student Profile"; //set the default form header text as update student

                using (var conn = new SQLiteConnection(Utils.defaultConn)) //get the connection string
                {
                    var s = conn.Get<Student>(id);          //retreive data involving student into an object s
                    txtStudentId.Text = s.Id.ToString();    //get StudentId, set it as the textbox's text
                    txtFirstName.Text = s.FirstName;        //get firstName property from object, set it as the textbox's text
                    txtLastName.Text = s.LastName;          //get LastName property from object, set it as the textbox's text
                    txtUsername.Text = s.UserName;          //get UserName property from object, set it as the textbox's text
                    txtUsername.ReadOnly = true;            //set username as a read only textfield 
                    txtPassword.Text = s.Password;          //get Password property from object, set it as the textbox's text
                    txtEmail.Text = s.Email;                //get Email property from object, set it as the textbox's text
                    txtMajor.Text = s.Major;                //get Major property from object, set it as the textbox's text
                    txtCreatedOn.Text = s.CreatedOn.ToString("yyyy-MM-dd HH:mm:ss");    //get createdOn property from object, set it as the textbox's text
                }
            }
            else
            {
                txtCreatedOn.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //set the default time to current time if it is a new student. 
            }
        }

        /* Submit button object
        * Programmer: Alice Kuang
        * Date Created: 4/10/22
        * Date Revised: 4/14/22
        * Desc: this is the event handler for the submit, which updates or inserts data into database
        * Pre: requires a sender, and takes an event
        * Post: Returns a data table with the copied dynamic data. 
        * side-effects: none  
        * invariants: If succeeds, stores the record object into database.
        * faults: none known
        */
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //create a student object
                var s = new Student
                {
                    Id = txtStudentId.Text.Length == 0 ? 0 : Convert.ToInt32(txtStudentId.Text), //convert the format of the id if it it is greater than zero
                    FirstName = txtFirstName.Text, //Stores textbox input into object member FirstName
                    LastName = txtLastName.Text,   //Stores textbox input into object member LastName
                    UserName = txtUsername.Text,   //Stores textbox input into object member UserName
                    Password = txtPassword.Text,   //Stores textbox input into object member Password
                    Email = txtEmail.Text,         //Stores textbox input into object member Email  
                    Major = txtMajor.Text,         //Stores textbox input into object member Major  
                    CreatedOn = Convert.ToDateTime(txtCreatedOn.Text) //Stores textbox input into object member CreatedOn. 
                };

                using (var conn = new SQLiteConnection(Utils.defaultConn)) //get connection string
                {

                    if (s.Id > 0)                                           //if it is not a new student
                        conn.Update<Student>(s);                            //update the student into database
                    else
                        conn.Insert(s);                                     //insert a new student into database
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Student table"); //if there is a problem storing into the table, throw this exception
            }
        }
    }
}





