using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using Dapper;
using System.Configuration;
using System.Runtime.CompilerServices;


namespace DBMS
{
    public class ManageUser
    {
        public static List<UserModel> LoadUsers()
        {
             //Create a new connection to the local server
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                //Select all elements from the Administrator table and return as a list 
                var output = cnn.Query<UserModel>("select * from Administrator", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(UserModel user)
        {
             //Create a new connection to the local server
            using (IDbConnection cnn = new SQLiteConnection(SqliteDataAccess.LoadConnectionString()))
            {
                //Insert a new entry into the Administrator table
                cnn.Execute("insert into Administrator (Username, Password) values (@Username, @Password)", user);
            }
        }

        public static bool ValidateUser(UserModel user)
        {
            //Check each user in the table
            foreach (UserModel otherUser in LoadUsers())
            {
                //If the username nad password exist, return true. Otherwise, return false 
                if (otherUser.Username == user.Username && otherUser.Password == user.Password)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
