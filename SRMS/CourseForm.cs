using Dapper.Contrib.Extensions;
using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Models;
using Helper;
using DBMS;

namespace SRMS
{
    public partial class CourseForm : Form
    {
        private string connString = SqliteDataAccess.LoadConnectionString();
        public CourseForm(int id = 0)
        {
            InitializeComponent();
            txtCourseId.ReadOnly = true;

            this.Text = "Create New Course";

            if (id > 0)
            {
                this.Text = "Update Course Profile";

                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    var c = conn.Get<Course>(id);
                    txtCourseId.Text = c.Id.ToString();
                    txtSubject.Text = c.Subject;
                    txtLevel.Text = c.Level.ToString();
                    txtTitle.Text = c.Title;
                    txtHours.Text = c.Hours.ToString();
                    txtRoom.Text = c.Room;
                    txtSemester.Text = c.Semester;
                    txtNotes.Text = c.Notes;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //create a course object
                var c = new Course
                {
                    Id = txtCourseId.Text.Length == 0 ? 0 : Convert.ToInt32(txtCourseId.Text),
                    Subject = txtSubject.Text,
                    Level = int.Parse(txtLevel.Text),
                    Title = txtTitle.Text,
                    Hours = int.Parse(txtHours.Text),
                    Room = txtRoom.Text,
                    Semester = txtSemester.Text,
                    Notes = txtNotes.Text
                };

                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    // SQLiteConnection exposes an Update event that clashes with
                    // the Update extension provided by Dapper.Contrib.
                    if (c.Id > 0)
                        conn.Update<Course>(c);
                    else
                        conn.Insert(c);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Course table");
            }
        }
    }

}




