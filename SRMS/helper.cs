using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Helper
{
    public static class Utils
    {
        /// <summary>
        /// SQLite connection string is rather simple
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string GetSqliteConnString(string filename)
        {
            var builder = new SQLiteConnectionStringBuilder();
            builder.DataSource = filename;
            return builder.ConnectionString;
        }

        /// <summary>
        /// Hash usr and pwd with a constant salt
        /// </summary>
        /// <param name="usr"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public static string HashPassword(string usr, string pwd)
        {
            using (var sha1 = SHA1Managed.Create())
            {
                var input = usr + "bracki$h" + pwd;
                var inputBytes = Encoding.UTF8.GetBytes(input);
                var outputBytes = sha1.ComputeHash(inputBytes);
                return BitConverter.ToString(outputBytes).Replace("-", "").ToLower();
            }
        }

        /// <summary>
        /// Extension method to convert dynamic data to a DataTable. Useful for databinding.
        /// https://stackoverflow.com/questions/5573856/binding-a-gridview-to-a-dynamic-or-expandoobject-object
        /// </summary>
        /// <param name="items"></param>
        /// <returns>A DataTable with the copied dynamic data.</returns>
        public static DataTable ToDataTable(this IEnumerable<dynamic> items)
        {
            var data = items.ToArray();
            if (data.Count() == 0) return null;

            var dt = new DataTable();
            foreach (var key in ((IDictionary<string, object>)data[0]).Keys)
            {
                dt.Columns.Add(key);
            }
            foreach (var d in data)
            {
                dt.Rows.Add(((IDictionary<string, object>)d).Values.ToArray());
            }
            return dt;
        }
    }
}
