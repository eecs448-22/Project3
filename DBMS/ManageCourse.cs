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
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                var output = cnn.Query<CourseModel>("select * from Faculty", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveCourse(CourseModel course)
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                cnn.Execute("insert into Course (Username, Password) values (@Username, @Password)", course);
            }
        }
    }
}
