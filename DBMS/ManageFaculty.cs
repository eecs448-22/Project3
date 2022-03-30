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
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                var output = cnn.Query<FacultyModel>("select * from Faculty", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveStudent(FacultyModel faculty)
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                cnn.Execute("insert into Faculty (Username, Password) values (@Username, @Password)", faculty);
            }
        }
    }
}
