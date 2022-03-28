using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Dapper;
using System.Configuration;
using System.IO;

namespace DBMS
{
    public class SqliteDataAccess
    {
        public static void InitializeDatabase()
        {
            var dbFilePath = @".\MainDb.db";
            if (!File.Exists(dbFilePath))
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    cnn.Execute(@"
                    CREATE TABLE IF NOT EXISTS Users (
                        Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                        Username NVARCHAR(64) NOT NULL,
                        Password NVARCHAR(128) NOT NULL
                    )");
                    cnn.Execute(@"
                        INSERT INTO Users
                            (Username, Password)
                        VALUES
                            ('admin', 'test')");
                }
            }
        }
        public static List<UserModel> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from Users", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Users (Username, Password) values (@Username, @Password)", user);
            }
        }

        public static bool ValidateUser(UserModel user)
        {

            foreach (UserModel otherUser in LoadUsers())
            {
                if (otherUser.Username == user.Username && otherUser.Password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

