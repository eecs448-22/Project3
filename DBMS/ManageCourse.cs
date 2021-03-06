using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Dapper;
using System.Configuration;

namespace DBMS
{
    public class ManageCourse
    {
        public static List<CourseModel> LoadCourses()
        {
            //Create a new connection to the local server
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                //Get all database elements from the faculty DB and return as a list
                var output = cnn.Query<CourseModel>("select * from Faculty", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveCourse(CourseModel course)
        {
             //Create a new connection to the local server
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                //Add a new course into the Course DB
                cnn.Execute("insert into Course (Username, Password) values (@Username, @Password)", course);
            }
        }
    }
}
