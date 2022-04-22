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
        private string connString = SqliteDataAccess.LoadConnectionString();
        public FacultyForm(int id = 0)
        {
            InitializeComponent();
            txtFacultyId.ReadOnly = true;

            this.Text = "Create New Faculty";
            txtCreatedOn.ReadOnly = true;

            if (id > 0)
            {
                this.Text = "Update Faculty Profile";

                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    var f = conn.Get<Faculty>(id);
                    txtFacultyId.Text = f.Id.ToString();
                    txtFirstName.Text = f.FirstName;
                    txtLastName.Text = f.LastName;
                    txtUsername.Text = f.UserName;
                    txtUsername.ReadOnly = true;
                    txtPassword.Text = f.Password;
                    txtEmail.Text = f.Email;
                    txtTitle.Text = f.Title;
                    txtDept.Text = f.Dept;
                    txtCreatedOn.Text = f.CreatedOn.ToString("yyyy-MM-dd HH:mm:ss");
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
                //create a faculty object
                var f = new Faculty
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
                    // SQLiteConnection exposes an Update event that clashes with
                    // the Update extension provided by Dapper.Contrib.
                    if (f.Id > 0)
                        conn.Update<Faculty>(f);
                    else
                        conn.Insert(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Faculty table");
            }
        }

        private void FacultyForm_Load(object sender, EventArgs e)
        {

        }
    }
}





