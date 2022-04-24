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

        /* AdminForm constructor
        * Programmer: Alice Kuang
        * Date Created: 4/13/22
        * Date Revised: 4/14/22
        * Desc: this is the default constructor for Admin
        * Pre: takes the id of the Admin, or defaults to 0.
        * Post: Returns the new or updated Admin record. 
        * side-effects: none  
        * invariants: the record will be inserted or modified in the database
        * faults: none known
        */
        public AdminForm(int id = 0)                 // if the Admin id is 0, we create a new Admin
        {
            InitializeComponent();                   //initialize the form  
            txtAdminId.ReadOnly = true;              //make AdminId a read only field
            txtCreatedOn.ReadOnly = true;            //make created on a read only field  
            this.Text = "Create New Administrator";  //set the default form header as create Admin  

            if (id > 0)
            {
                this.Text = "Update Administrator Profile";  //set the default form display header as update Admin

                using (var conn = new SQLiteConnection(Utils.defaultConn)) //get the connection string
                {
                    var a = conn.Get<Administrator>(id); //retreive data involving Admin into an object s
                    txtAdminId.Text = a.Id.ToString();   //get AdminId, set it as the textbox's text
                    txtFirstName.Text = a.FirstName;     //get firstName property from object, set it as the textbox's text
                    txtLastName.Text = a.LastName;       //get LastName property from object, set it as the textbox's text
                    txtUsername.Text = a.UserName;       //get UserName property from object, set it as the textbox's text
                    txtUsername.ReadOnly = true;         //set username as a read only textfield 
                    txtPassword.Text = a.Password;       //get Password property from object, set it as the textbox's text
                    txtEmail.Text = a.Email;             //get Email property from object, set it as the textbox's text                                                
                    txtCreatedOn.Text = a.CreatedOn.ToString("yyyy-MM-dd HH:mm:ss");//get CreatedOn property from object, set it as the textbox's text
                }
            }
            else
            {
                txtCreatedOn.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); //new record, use the current time for CreatedOn
            }
        }

        /* Submit button object
        * Programmer: Alice Kuang
        * Date Created: 4/13/22
        * Date Revised: 4/14/22
        * Desc: this is the event handler for the submit, which updates or inserts data into database
        * Pre: requires a sender, and takes an event (button sumbit)
        * Post: Returns a data table with the copied dynamic data. 
        * side-effects: none  
        * invariants: if succeeds, successful insertion of record into database
        * faults: none known
        */
        private void btnSubmit_Click(object sender, EventArgs e) 
        {
            try
            {
                //create a administrator object
                var a = new Administrator
                {
                    Id = txtAdminId.Text.Length == 0 ? 0 : Convert.ToInt32(txtAdminId.Text), //convert the format of the id if it it is greater than zero
                    FirstName = txtFirstName.Text,  //Stores textbox input into object member FirstName
                    LastName = txtLastName.Text,    //Stores textbox input into object member LastName
                    UserName = txtUsername.Text,    //Stores textbox input into object member UserName
                    Password = txtPassword.Text,    //Stores textbox input into object member Password
                    Email = txtEmail.Text,          //Stores textbox input into object member Email  
                    CreatedOn = Convert.ToDateTime(txtCreatedOn.Text) //Stores textbox input into object member CreatedOn. 
                };

                using (var conn = new SQLiteConnection(Utils.defaultConn))//get connection string
                {
                    if (a.Id > 0)
                        conn.Update<Administrator>(a);                     //if it is not a new Admin
                    else                                                   //update the Admin into database
                        conn.Insert(a);
                }                                                          //insert a new Admin into database
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Administrator table"); //if there is a problem storing into the table, throw this exception
            }
        }
    }
}





