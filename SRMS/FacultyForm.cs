using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace SRMS
{
    public partial class FacultyForm : Form
    {
        public FacultyForm(string type)
        {
            InitializeComponent();
        }

        private FacultyForm InitFaculty(bool anew = false)
        {
            return new Faculty
            {
                Id = anew ? 0 : Convert.ToInt32(txtStudentId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                Major = txtMajor.Text,
                CreatedOn = Convert.ToDateTime(txtCreatedOn.Text)
            };
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //Trace.Assert(connString.Length > 0, "Invalid SQLite database!");

                using (var conn = new SQLiteConnection(connString))
                {
                    conn.Insert(InitFaculty(true));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught in btnInsert_Click()");
            }
        }
    }
}
