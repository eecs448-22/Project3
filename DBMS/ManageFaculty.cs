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
    public class ManageFaculty
    {
        public static List<FacultyModel> LoadFaculty()
        {
             //Create a new connection to the local server
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                //Select all DB elements from Faculty DB and return as a list
                var output = cnn.Query<FacultyModel>("select * from Faculty", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveStudent(FacultyModel faculty)
        {
             //Create a new connection to the local server
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                //Insert a new entry into the Faculty DB
                cnn.Execute("insert into Faculty (Username, Password) values (@Username, @Password)", faculty);
            }
        }
    }
}
