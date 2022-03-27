using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Dapper;

namespace DBMS
{
    internal class SqliteDataAccess
    {
        public static List<UserModel> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from User", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into User (Username, Password) values (@Username, @Password)", user);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
