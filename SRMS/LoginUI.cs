/* =============================================================================
 * Some code in this file (class and functions) are generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */

using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Models;
using Helper;
using DBMS;
using MyTests;
using System.Runtime.InteropServices;

namespace SRMS
{
    public partial class LoginUI : Form
    {
        private int userId = 0;

        // Windows API function
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public LoginUI()
        {
            //Initialize component and database
            InitializeComponent();
            createAccountBtn.Visible = false;
            signInCB.DropDownStyle = ComboBoxStyle.DropDownList;
            // 0) Administrator, 1) Faculty, 2) Student
            signInCB.SelectedIndex = 2;
            //SqliteDataAccess.InitializeDatabase();
            //foreach (UserModel user in ManageUser.LoadUsers())
            //{
            //    //Write each user into console.
            //    Console.WriteLine(user.Username);
            //    Console.WriteLine(user.Password);
            //}
        }

        public int GetLoginRole()
        {
            return signInCB.SelectedIndex;
        }

        public int GetUserId()
        {
            return userId;
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
            var role = signInCB.SelectedIndex;
            var username = UserInput.Text.Trim();
            var password = PassInput.Text.Trim();

            userId = Authenticate(username, password, role, out string status);
            if (userId == 0)
            {
                // Do not close the Login dialog if user is not valid
                if (status.Length > 0)
                {
                    lblStatus.Text = status;
                    lblStatus.Visible = true;
                }
                this.DialogResult = DialogResult.None;
            }
        }

        private int Authenticate(string usr, string pwd, int role, out string status)
        {
            status = String.Empty;
            var tblNames = new string[] { "Administrator", "Faculty", "Student" };

            if (role >= 0 && role < tblNames.Length)
            {
                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    var sql = $"SELECT Id, Password FROM {tblNames[role]} WHERE UserName = '{usr}'";
                    var user = conn.QueryFirstOrDefault(sql);
                    if (user == null)
                    {
                        status = "Invalid Username!";
                        return 0;
                    }
                    if (user.Password != pwd)
                    {
                        status = "Invalid Password!";
                        return 0;
                    }

                    return Convert.ToInt32(user.Id);
                }
            }

            return 0;
        }


/*
        private void LoginButton_Click(object sender, EventArgs e)
        {
            //When the login button is clicked, create a new user model and verify it is a valid user
            UserModel user = new UserModel();
            user.Username = UserInput.Text;
            user.Password = PassInput.Text;
            this.Hide();
            StudentUI mainView = new StudentUI(UserInput.Text);
            mainView.Show();

            if (ManageUser.ValidateUser(user))
            {
                Console.WriteLine("user is logged in");
                //If the user is valid, switch the the next form. Found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
                if(signInCB.Text == "Student")
                {
                    this.Hide();
                    StudentUI mainView = new StudentUI();
                    mainView.Show();
                }
                else
                {
                    this.Hide();
                    FacultyUI teacherView = new FacultyUI();
                    teacherView.Show();
                }
            }
            else
            {
                //Error message for invalid user.
                Console.WriteLine("invalid user");
                MessageBox.Show("Error! Invalid Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
*/
        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            //Whne the create Account button is clicked, switch pages to create account. Found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
            this.Hide();
            newPassWordLabel newAcc = new newPassWordLabel();
            newAcc.Show();
        }

        private void signInCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRunTests_Click(object sender, EventArgs e)
        {
            // show a console output/window in a forms application
            AllocConsole();

            Console.WriteLine("Test suite: ");
            
            TestClass t1 = new TestClass();
            t1.Admin_CreateUser();
            t1.Admin_UpdateUser();
            t1.Admin_DeleteUser();
            t1.Create_Student();
            t1.Update_Student();
            t1.Delete_Student();

            
        }
    }
}
