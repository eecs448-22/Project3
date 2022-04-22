using Dapper.Contrib.Extensions;
using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Models;
using Helper;
using DBMS;

namespace SRMS
{
    public partial class AdminForm : Form
    {
        private string connString = SqliteDataAccess.LoadConnectionString();
        public AdminForm(int id = 0)
        {
            InitializeComponent();
            txtAdminId.ReadOnly = true;

            this.Text = "Create New Administrator";
            txtCreatedOn.ReadOnly = true;

            if (id > 0)
            {
                this.Text = "Update Administrator Profile";

                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    var a = conn.Get<Administrator>(id);
                    txtAdminId.Text = a.Id.ToString();
                    txtFirstName.Text = a.FirstName;
                    txtLastName.Text = a.LastName;
                    txtUsername.Text = a.UserName;
                    txtUsername.ReadOnly = true;
                    txtPassword.Text = a.Password;
                    txtEmail.Text = a.Email;
                    txtCreatedOn.Text = a.CreatedOn.ToString("yyyy-MM-dd HH:mm:ss");
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
                //create a administrator object
                var a = new Administrator
                {
                    Id = txtAdminId.Text.Length == 0 ? 0 : Convert.ToInt32(txtAdminId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    CreatedOn = Convert.ToDateTime(txtCreatedOn.Text)
                };

                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    // SQLiteConnection exposes an Update event that clashes with
                    // the Update extension provided by Dapper.Contrib.
                    if (a.Id > 0)
                        conn.Update<Administrator>(a);
                    else
                        conn.Insert(a);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Administrator table");
            }
        }
    }
}





