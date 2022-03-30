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
    public class ManageUser
    {
        public static List<UserModel> LoadUsers()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                var output = cnn.Query<UserModel>("select * from Users", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(UserModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
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

    }
}
