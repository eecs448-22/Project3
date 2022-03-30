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
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                var output = cnn.Query<AssignmentModel>("select * from Assignment", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveAssignment(AssignmentModel assignment)
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                cnn.Execute("insert into Assignment (Username, Password) values (@Username, @Password)", assignment);
            }
        }
    }
}
