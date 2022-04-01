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
             //Create a new connection to the local server
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                //Select all DB elements from the student table and return as a list. 
                var output = cnn.Query<StudentModel>("select * from Student", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveStudent(StudentModel student)
        {
             //Create a new connection to the local server
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                //Insert a new record into the student table. 
                cnn.Execute("insert into Student (Username, Password) values (@Username, @Password)", student);
            }
        }
    }
}
