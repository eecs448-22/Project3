using Dapper.Contrib.Extensions;
using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Models;
using Helper;
using DBMS;

namespace SRMS
{
    //this is the faculty form
    public partial class FacultyForm : Form
    {

        /* CourseForm constructor
        * Programmer: Alice Kuang
        * Date Created: 4/10/22
        * Date Revised: 4/14/22
        * Desc: this is the default constructor for course
        * Pre: takes the id of the course, or defaults to 0.
        * Post: Returns the new or updated course record. 
        * side-effects: none  
        * invariants: the record will be inserted or modified in the database
        * faults: none known
        */
        private string connString = SqliteDataAccess.LoadConnectionString();
        public FacultyForm(int id = 0)                  // if the student id is 0, we create a new student
        {                                               
            InitializeComponent();                      //initialize the form
            txtFacultyId.ReadOnly = true;               //make studentId a read only field
                                                        //make created on a read only field
            this.Text = "Create New Faculty";
            txtCreatedOn.ReadOnly = true;              //set the default form header text as create student

            if (id > 0)       //if student id > 0, the student already exists, so we update the student
            {
                this.Text = "Update Faculty Profile";

                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    var f = conn.Get<Faculty>(id);       //retreive data involving student into an object s
                    txtFacultyId.Text = f.Id.ToString(); //get FacultyId, set it as the textbox's text
                    txtFirstName.Text = f.FirstName;     //get firstName property from object, set it as the textbox's text
                    txtLastName.Text = f.LastName;       //get LastName property from object, set it as the textbox's text
                    txtUsername.Text = f.UserName;       //get UserName property from object, set it as the textbox's text
                    txtUsername.ReadOnly = true;         //set username as a read only textfield 
                    txtPassword.Text = f.Password;       //get Password property from object, set it as the textbox's text
                    txtEmail.Text = f.Email;             //get Email property from object, set it as the textbox's text
                    txtTitle.Text = f.Title;             //get Title property from object, set it as the textbox's text
                    txtDept.Text = f.Dept;                 //get Dept property from object, set it as the textbox's text
                    txtCreatedOn.Text = f.CreatedOn.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            else
            {
                txtCreatedOn.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
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
                //create a faculty object
                var f = new Faculty //use input from form to fill in corresponding object property field
                {
                    Id = txtFacultyId.Text.Length == 0 ? 0 : Convert.ToInt32(txtFacultyId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    Title = txtTitle.Text,
                    Dept = txtDept.Text,
                    CreatedOn = Convert.ToDateTime(txtCreatedOn.Text)
                };

                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    if (f.Id > 0) // if the faculty is greater than zero
                        conn.Update<Faculty>(f); //update the record
                    else
                        conn.Insert(f); //create a new record
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Faculty table");
            }
        }

    }
}





