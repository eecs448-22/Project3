using Dapper.Contrib.Extensions;
using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Models;
using Helper;
using DBMS;

namespace SRMS
{
    //this is the student form
    public partial class FacultyForm : Form
    {
        private string connString = SqliteDataAccess.LoadConnectionString();
        public FacultyForm(int id = 0)
        {
            InitializeComponent();
            txtStudentId.ReadOnly = true;

            this.Text = "Create New Student";
            txtCreatedOn.ReadOnly = true;

            if (id > 0)
            {
                this.Text = "Update Student Profile";

                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    var s = conn.Get<Student>(id);
                    txtStudentId.Text = s.Id.ToString();
                    txtFirstName.Text = s.FirstName;
                    txtLastName.Text = s.LastName;
                    txtUsername.Text = s.UserName;
                    txtUsername.ReadOnly = true;
                    txtPassword.Text = s.Password;
                    txtEmail.Text = s.Email;
                    txtMajor.Text = s.Major;
                    txtCreatedOn.Text = s.CreatedOn.ToString("yyyy-MM-dd HH:mm:ss");
                }
            }
            else
            {
                txtCreatedOn.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //create a student object
                var s = new Student
                {
                    Id = txtStudentId.Text.Length == 0 ? 0 : Convert.ToInt32(txtStudentId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    Major = txtMajor.Text,
                    CreatedOn = Convert.ToDateTime(txtCreatedOn.Text)
                };

                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    // SQLiteConnection exposes an Update event that clashes with
                    // the Update extension provided by Dapper.Contrib.
                    if (s.Id > 0)
                        conn.Update<Student>(s);
                    else
                        conn.Insert(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Student table");
            }
        }
    }
}





