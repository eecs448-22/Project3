/* =============================================================================
 * Some code in this file (class and functions) are generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */

using Dapper;
using Helper;
using MyTests;
using System;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SRMS
{
    public partial class LoginUI : Form
    {
        private int userId = 0;

        // Windows API function to setup opening a console
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public LoginUI()
        {
            InitializeComponent(); //Initialize component and database
            signInCB.DropDownStyle = ComboBoxStyle.DropDownList; // 0) Administrator, 1) Faculty, 2) Student
            signInCB.SelectedIndex = 2; //set the default selected as student
        }

        public int GetLoginRole()
        {
            return signInCB.SelectedIndex; //return selected index
        }

        public int GetUserId()
        {
            return userId; //return userId
        }

        /* Login button 
        * Programmer: Alice Kuang
        * Date Created: 4/10/22
        * Date Revised: 4/14/22
        * Desc: this is the event handler authenticates a user exists in the database
        * Pre: requires a sender, and takes an event (button sumbit)
        * Post: nothing
        * side-effects: displays error message if invalid credentials or transitions to specified form  
        * invariants: if succeeds, successful insertion of record into database
        * faults: none known
        */
        private void LoginButton_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = false; //hide the Login Status label
            var role = signInCB.SelectedIndex; //get the account type from sign-in comboBox
            var username = UserInput.Text.Trim(); //get user input for userName
            var password = PassInput.Text.Trim(); //get user input for password

            userId = Authenticate(username, password, role, out string status); //check if this is a valid user
            if (userId == 0) //if one of the fields is invalid 
            {
               
                if (status.Length > 0) //ensure a status was returned
                {
                    lblStatus.Text = status; //assign the status to the label text
                    lblStatus.Visible = true; //show the Login Status label
                }
                this.DialogResult = DialogResult.None;  // Keep the login dialog open
            }
        }

        /* Authenticate button 
        * Programmer: Alice Kuang
        * Date Created: 4/10/22
        * Date Revised: 4/14/22
        * Desc: this function checks for valid login credentials
        * Pre: requires the username, password, and role from the form; it also has an out 
        *      string called status, which is instantiated inside the callee function 
        * Post: returns 0 if authentication failed or the id number if authentication successful
        * side-effects: displays error message if invalid credentials or transitions to specified form  
        * invariants: if succeeds, successful insertion of record into database
        * faults: none known
        */
        private int Authenticate(string usr, string pwd, int role, out string status)
        {
            status = String.Empty; //start with an empty status
            var tblNames = new string[] { "Administrator", "Faculty", "Student" }; 

            if (role >= 0 && role < tblNames.Length) //check if role valid (Admin, student, or faculty selected)
            {
                using (var conn = new SQLiteConnection(Utils.defaultConn)) //get database connection
                {
                    var sql = $"SELECT Id, Password FROM {tblNames[role]} WHERE UserName = '{usr}'"; //sql statement to get id and password
                    var user = conn.QueryFirstOrDefault(sql); //get the data through using the sql string to query from the database
                    if (user == null) //if the user could not be found after the query
                    {
                        status = "Invalid Username!"; //return this status
                        return 0;
                    }
                    if (user.Password != pwd) //if the password does not matche the password in the query
                    {
                        status = "Invalid Password!";  //return this status
                        return 0;
                    }

                    return Convert.ToInt32(user.Id); //else, the user was valid; return their id. 
                }
            }

            return 0; //invalid role
        }



        private void btnRunTests_Click(object sender, EventArgs e)
        {
            // show a console output/window in a forms application
            AllocConsole();

            Console.WriteLine("Test suite: ");

            //Calls the test suite functions, which:
            TestClass t1 = new TestClass();
            t1.Admin_CreateUser(); //Test 1:
            t1.Admin_UpdateUser(); //Test 2:
            t1.Admin_DeleteUser(); //Test 3:
            t1.Create_Student(); //Test 4:
            t1.Update_Student(); //Test 5:
            t1.Delete_Student(); //Test 6:
            t1.Create_Faculty(); //Test 7:
            t1.Update_Faculty(); //Test 8:
            t1.Delete_Faculty(); //Test 9:
            t1.Create_Course(); //Test 10:
            t1.Update_Course(); //Test 11:
            t1.Delete_Course(); //Test 12:
            t1.Assign_Student_Course(); //Test 13:
            t1.Drop_Student_Course(); //Test 14:
            t1.Assign_Faculty_Course(); //Test 15:
            t1.Remove_Faculty_Course(); //Test 16:
            t1.Update_Student_Grade(); //Test 17:
        }
    }
}
