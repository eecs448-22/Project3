using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS
{
    public class CourseModel
    {
        //Getters and setters for the Courses model
        public int Id { get; set; }
        public string Subject { get; set; }
        public int Level { get; set; }
        public string Title { get; set; }
        public int Hours { get; set; }
        public string Room { get; set; }
        public string Semester { get; set; }
        public string Notes { get; set; }


    }
}
