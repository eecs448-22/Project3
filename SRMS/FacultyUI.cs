/* =============================================================================
 * Code in this file is generated from the visual studio .NET C# winForms framework. 
 * ============================================================================= */
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using Models;
using System.Data.SQLite;
using System.Windows.Forms;
using Helper;

namespace SRMS
{
    public partial class FacultyUI : Form
    {
        private int facultyId = 0;

        public FacultyUI(int id)
        {
            facultyId = id;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ////Hide the current window and switch to the login window, found from https://www.youtube.com/watch?v=NBOaMrigrRw&t=4s
            //this.Hide();
            //LoginUI newLogin = new LoginUI();
            //newLogin.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = listBox1.SelectedIndex;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var curIdx = tabControl.SelectedIndex; //get the correct tab
            if (curIdx == 1)
            {
                var sql = $@"SELECT f.Id, f.FirstName, f.LastName, c.Subject, c.Level
                               FROM Faculty AS f
                               JOIN Teaching AS t ON f.Id = t.FacultyId
                               JOIN Course as c ON t.CourseId = c.Id
                              WHERE f.Id = {facultyId}"; //retreive all data fields

                //call display data from helpers.cs
                dataGridView2.ReadOnly = true;
                dataGridView2.AllowUserToAddRows = false;
                dataGridView2.AllowUserToDeleteRows = false;
                dataGridView2.MultiSelect = false;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Utils.DisplayData(dataGridView2, sql);
            }

            if(curIdx == 2)
            {
                var str = $@"SELECT DISTINCT c.Subject || ' ' || c.Level AS Name, c.Id AS Cid
                               FROM Faculty AS f
                               JOIN Teaching AS t ON f.Id = t.FacultyId
                               JOIN Course AS c ON t.CourseId = c.Id
                               JOIN Enrollment AS e ON e.CourseId = c.Id
                               JOIN Student AS s ON s.Id = e.StudentId
                               WHERE f.Id = {facultyId}";
                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    CourseCboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    CourseCboBox.DataSource = null;
                    var result = conn.Query(str);
                    CourseCboBox.DataSource = result.ToDataTable();
                    CourseCboBox.DisplayMember = "Name";
                    CourseCboBox.ValueMember = "Cid";
                }
                if (CourseCboBox.Items.Count > 1)
                {
                    CourseCboBox.SelectedIndex = 0;
                    CourseCboBox_SelectionChangeCommitted(CourseCboBox, null);
                }
            }
        }

        private void CourseCboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var curIdx = tabControl.SelectedIndex; //get the correct tab
            if (curIdx == 2)
            {
                var sql = $@"SELECT c.Subject, c.Level
                                  , s.Id AS StudentId, s.FirstName, s.LastName, e.Grade
                               FROM Faculty AS f
                               JOIN Teaching AS t ON f.Id = t.FacultyId
                               JOIN Course AS c ON t.CourseId = c.Id
                               JOIN Enrollment AS e ON e.CourseId = c.Id
                               JOIN Student AS s ON s.Id = e.StudentId
                               WHERE f.Id = {facultyId} and c.Id = {CourseCboBox.SelectedValue}";

                //call display data from helpers.cs
                dataGridView3.ReadOnly = true;
                dataGridView3.AllowUserToAddRows = false;
                dataGridView3.AllowUserToDeleteRows = false;
                dataGridView3.MultiSelect = false;
                dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                Utils.DisplayData(dataGridView3, sql);
            }
        }
    }
}
