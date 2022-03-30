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
    public class ManageStudent
    {
        public static List<StudentModel> LoadStudents()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                var output = cnn.Query<StudentModel>("select * from Student", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveStudent(StudentModel student)
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                cnn.Execute("insert into Student (Username, Password) values (@Username, @Password)", student);
            }
        }
    }
}
