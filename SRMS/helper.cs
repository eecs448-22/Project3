using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Helper
{
    public static class Utils
    {
        /// <summary>
        /// Default SQLite connection string
        /// </summary>
        public static string defaultConn = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

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

        public static void DisplayData(DataGridView dgv, string sql)
        {
            using (var conn = new SQLiteConnection(defaultConn))
            {
                dgv.DataSource = null;
                var result = conn.Query(sql);
                dgv.DataSource = result.ToDataTable();

                //autoResize columns
                dgv.AutoResizeColumns();
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

                // disable sorting
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                // display row number
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                    row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            }
        }
    }
}
