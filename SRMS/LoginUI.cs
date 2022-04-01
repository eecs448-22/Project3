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
                Console.WriteLine(user.Username);
                Console.WriteLine(user.Password);
            }
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            user.Username = UserInput.Text;
            user.Password = PassInput.Text;
            if (ManageUser.ValidateUser(user))
            {
                Console.WriteLine("user is logged in");
            }
            else
            {
                Console.WriteLine("invalid user");
            }


        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            newPassWordLabel newAcc = new newPassWordLabel();
            newAcc.Show();
        }
    }
}
