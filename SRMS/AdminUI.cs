using Dapper.Contrib.Extensions;
using System;
using Models;
using System.Data.SQLite;
using System.Windows.Forms;
using Helper;

namespace SRMS
{
    public partial class AdminUI : Form
    {
        private int adminId = 0; //id variable for insertion into database
        private string[] tblNames = null; //tables containing dataview names
        private DataGridView[] tblGrids = null; //tables to represent the 4 dataviews 


        /* AdminUI constructor
        * Programmer: Alice Kuang
        * Date Created: 4/10/22
        * Date Revised: 4/14/22
        * Desc: this is the default constructor for Admin, instantiates two tables for ease of referencing 
        *       dataGridViews and customizes the presets of dataGridView
        * Pre: takes the id of the Admin
        * Post: none
        * side-effects: defines the properties of dataGridView 
        * invariants: called when the AdminUI form is launched
        * faults: none known
        */
        public AdminUI(int id)
        {
            adminId = id;
            InitializeComponent();

            tblNames = new string[] { "Administrator", "Faculty", "Student", "Course" }; //initialze data
            tblGrids = new DataGridView[] { dgvAdmin, dgvFaculty, dgvStudent, dgvCourse };  //initialze data


            foreach (var dgv in tblGrids) //Customize each of the DataGridView objects
            {
                dgv.ReadOnly = true; //set the datagridview as readonly 
                dgv.AllowUserToAddRows = false; //prevent user from adding rows
                dgv.AllowUserToDeleteRows = false; //prevent user from deleting rows
                dgv.MultiSelect = false; //prevent user from selecting multiple rows
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //set full row selection
            }
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            tabControlAdmin_SelectedIndexChanged(tabControlAdmin, null); //change the tab
        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curIdx = tabControlAdmin.SelectedIndex; //get the currently selected tab
            var sql = $"SELECT * FROM {tblNames[curIdx]}"; //make sql statement to retreive all data fields
            Utils.DisplayData(tblGrids[curIdx], sql); //call displayData from helpers.cs to get the data view
        }

        /* Create Button
        * Programmer: Alice Kuang
        * Date Created: 4/10/22
        * Date Revised: 4/14/22
        * Desc: Creates a new Record
        * Pre: Buttonclick event received
        * Post: Returns the new record into its table. 
        * side-effects: none
        * invariants: the record will be inserted in the database
        * faults: none known
        */
        private void btnCreate_Click(object sender, EventArgs e)
        {
            int idx = tabControlAdmin.SelectedIndex; //use the selectedIdx

            if (updateInsert(idx)) //call updateInsert method for selected datagridView
            {
                //immediately "refresh" the datagridView
                var sql = $"SELECT * FROM {tblNames[idx]}"; //get all the input from the data
                Utils.DisplayData(tblGrids[idx], sql);      //display it in the corresponding datagridview
            }
        }

        /* Update Button
      * Programmer: Alice Kuang
      * Date Created: 4/10/22
      * Date Revised: 4/14/22
      * Desc: Updates an existing Record
      * Pre: Buttonclick event received
      * Post: Returns the Updated record into its table. 
      * side-effects: none
      * invariants: the record will be inserted in the database
      * faults: none known
      */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idx = tabControlAdmin.SelectedIndex;
            var id = Convert.ToInt32(tblGrids[idx].SelectedRows[0].Cells[0].Value);

            if (updateInsert(idx, id))
            {
                //immediately "refresh" the datagridView
                var sql = $"SELECT * FROM {tblNames[idx]}"; //get all the input from the data
                Utils.DisplayData(tblGrids[idx], sql);      // display it in the corresponding datagridview
            }
        }

        /* Delete Button
        * Programmer: Alice Kuang
        * Date Created: 4/10/22
        * Date Revised: 4/14/22
        * Desc: Updates an existing Record
        * Pre: Buttonclick event received
        * Post: Returns the Updated record into its table. 
        * side-effects: none
        * invariants: the record will be inserted in the database
        * faults: none known
        */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var idx = tabControlAdmin.SelectedIndex;
                var tid = Convert.ToInt32(tblGrids[idx].SelectedRows[0].Cells[0].Value);

                bool retval = false;
                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    switch (idx)
                    {
                        case 0:
                            var a = new Administrator { Id = tid };
                            retval = conn.Delete(a);
                            break;

                        case 1:
                            var f = new Faculty { Id = tid };
                            retval = conn.Delete(f);
                            break;

                        case 2:
                            var s = new Student { Id = tid };
                            retval = conn.Delete(s);
                            break;

                        case 3:
                            var c = new Course { Id = tid };
                            retval = conn.Delete(c);
                            break;

                        default:
                            // do nothing
                            break;
                    }
                }

                if (retval)
                {
                    var sql = $"SELECT * FROM {tblNames[idx]}";
                    Utils.DisplayData(tblGrids[idx], sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when deleting");
            }
        }

        /* AdminUI constructor
* Programmer: Alice Kuang
* Date Created: 4/10/22
* Date Revised: 4/14/22
* Desc: this is the default constructor for Admin
* Pre: takes the id of the Admin
* Post: Returns the new or updated Admin record. 
* side-effects: none  
* invariants: the record will be inserted or modified in the database
* faults: none known
*/
        //update and isnert based on tab idx and id. id = 0 is insert; id > 0 is udpate
        private bool updateInsert(int idx, int id = 0)
        {
            var retval = DialogResult.Cancel;
            switch (idx)
            {
                case 0:
                    var admin = new AdminForm(id);
                    retval = admin.ShowDialog();
                    break;

                case 1:
                    var prof = new FacultyForm(id);
                    retval = prof.ShowDialog();
                    break;

                case 2:
                    var student = new StudentForm(id);
                    retval = student.ShowDialog();
                    break;

                case 3:
                    var course = new CourseForm(id);
                    retval = course.ShowDialog();
                    break;

                default:
                    // do nothing
                    break;
            }

            return DialogResult.OK == retval;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); //call close upon logout
        }


    }



}
