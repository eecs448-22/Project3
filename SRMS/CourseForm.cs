using Dapper.Contrib.Extensions;
using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Models;
using Helper;
using DBMS;

namespace SRMS
{
    //this form allows for creating or updating course information
    public partial class CourseForm : Form
    {
        private string connString = SqliteDataAccess.LoadConnectionString();//get connection string to database

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
        public CourseForm(int id = 0)                   // if the course id is 0, we create a new course
        {                                               
            InitializeComponent();                      //initialize the form 
            txtCourseId.ReadOnly = true;                //make courseId a read only field
                                                        //make created on a read only field
            this.Text = "Create New Course";
                                                       //set the default form header text as create course
            if (id > 0)
            {
                this.Text = "Update Course Profile";    //if course id > 0, the course already exists, so we update the course

                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    var c = conn.Get<Course>(id);       //retreive data involving course into an object c
                    txtCourseId.Text = c.Id.ToString(); //get Course Id, set it as the textbox's text
                    txtSubject.Text = c.Subject;        //get Subject property from object, set it as the textbox's text
                    txtLevel.Text = c.Level.ToString(); //get Level property from object, set it as the textbox's text
                    txtTitle.Text = c.Title;            //get Title property from object, set it as the textbox's text
                    txtHours.Text = c.Hours.ToString(); //get Hours property from object, set it as the textbox's text
                    txtRoom.Text = c.Room;              //get Room property from object, set it as the textbox's text
                    txtSemester.Text = c.Semester;      //get Semester property from object, set it as the textbox's text
                    txtNotes.Text = c.Notes;            //get Notes property from object, set it as the textbox's text
                }
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
                //create a course object
                var c = new Course
                {
                    Id = txtCourseId.Text.Length == 0 ? 0 : Convert.ToInt32(txtCourseId.Text), //format the id it is greater than zero
                    Subject = txtSubject.Text,          //Stores textbox input into object member Subject
                    Level = int.Parse(txtLevel.Text),   //Stores textbox input into object member Level
                    Title = txtTitle.Text,              //Stores textbox input into object member Title
                    Hours = int.Parse(txtHours.Text),   //Stores textbox input into object member Hours
                    Room = txtRoom.Text,                //Stores textbox input into object member Room 
                    Semester = txtSemester.Text,        //Stores textbox input into object member Semester
                    Notes = txtNotes.Text               //Stores textbox input into object member Notes
                };

                using (var conn = new SQLiteConnection(Utils.defaultConn)) //get connection string
                {
                    if (c.Id > 0)                   //if it is not a new course
                        conn.Update<Course>(c);     //update the course into database                        
                    else                                                    
                        conn.Insert(c);             //insert a new course into database
                }                                                           
            }
            catch (Exception ex) ////if there is a problem storing into the database, throw this exception
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Course table");
            }
        }
    }

}




