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
using DBMS;

namespace SRMS
{
    public partial class CourseForm : Form
    {

        public CourseForm(int id = 0)
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private Course InitCourse(bool anew = false)
        {
            return new Course
            {
                Id = anew ? 0 : Convert.ToInt32(txtCourseId.Text),
                Title = txtTitle.Text,
                Hours = Convert.ToInt32(txtHours.Text),
                Level = Convert.ToInt32(txtLevel.Text),
                Semester = txtSemester.Text,
                Subject = txtSubject.Text,
                Room = txtRoom.Text,
                Notes = txtNotes.Text,
            };
        }
    }

}


   

