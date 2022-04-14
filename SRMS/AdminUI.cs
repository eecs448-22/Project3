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
        private string[] tblNames = null;
        private DataGridView[] tblGrids = null; //dataGridViews 
        public AdminUI()
        {
            InitializeComponent();

            tblNames = new string[] { "Administrator", "Faculty", "Student", "Course" };
            tblGrids = new DataGridView[] { dgvAdmin, dgvFaculty, dgvStudent, dgvCourse };

            //Customize the DataGridView objects
            foreach (var dgv in tblGrids)
            {
                dgv.ReadOnly = true;
                dgv.AllowUserToAddRows = false;
                dgv.AllowUserToDeleteRows = false;
                dgv.MultiSelect = false;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {
            tabControlAdmin_SelectedIndexChanged(tabControlAdmin, null);
        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curIdx = tabControlAdmin.SelectedIndex; //get the correct tab
            var sql = $"SELECT * FROM {tblNames[curIdx]}"; //retreive all data fields

            //call display data from helpers.cs
            Utils.DisplayData(tblGrids[curIdx], sql);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int idx = tabControlAdmin.SelectedIndex;

            if (updateInsert(idx))
            {
                //immediately "refresh" the datagridView
                var sql = $"SELECT * FROM {tblNames[idx]}";
                Utils.DisplayData(tblGrids[idx], sql);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idx = tabControlAdmin.SelectedIndex;
            var id = Convert.ToInt32(tblGrids[idx].SelectedRows[0].Cells[0].Value);

            if (updateInsert(idx, id))
            {
                //immediately "refresh" the datagridView
                var sql = $"SELECT * FROM {tblNames[idx]}";
                Utils.DisplayData(tblGrids[idx], sql);
            }
        }

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
                    //var prof = new FacultyForm(id);
                    //retval = prof.ShowDialog();
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
            this.Close();
        }

    }



}
