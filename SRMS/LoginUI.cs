/* =============================================================================
 * Some code in this file (class and functions) are generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */


using DBMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SRMS
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
            SqliteDataAccess.InitializeDatabase();
            foreach (UserModel user in ManageUser.LoadUsers())
            {
                //Write each user into console.
                Console.WriteLine(user.Username);
                Console.WriteLine(user.Password);
            }
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //When the login button is clicked, create a new user model and verify it is a valid user
            UserModel user = new UserModel();
            user.Username = UserInput.Text;
            user.Password = PassInput.Text;
            if (ManageUser.ValidateUser(user))
            {
                Console.WriteLine("user is logged in");
                //If the user is valid, switch the the next form. Found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
                this.Hide();
                MainUI mainView = new MainUI();
                mainView.Show();
            }
            else
            {
                //Error message for invalid user.
                Console.WriteLine("invalid user");
            }


        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            //Whne the create Account button is clicked, switch pages to create account. Found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
            this.Hide();
            newPassWordLabel newAcc = new newPassWordLabel();
            newAcc.Show();
        }
    }
}
