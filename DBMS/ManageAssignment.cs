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
    public class ManageAssignment
    {
        public static List<AssignmentModel> LoadAssignments()
        {
            //Create a connection to SQL local server
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                //Select all assignments from the server and return as a list
                var output = cnn.Query<AssignmentModel>("select * from Assignment", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveAssignment(AssignmentModel assignment)
        {
            //Create a connection to SQL local server
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                //Add a new assignment into the database
                cnn.Execute("insert into Assignment (Username, Password) values (@Username, @Password)", assignment);
            }
        }
    }
}
