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
       
        // Returns Default SQLite connection string
        public static string defaultConn = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        
        // Gets sqlite connection string, given a file
        public static string GetSqliteConnString(string filename) 
        {
            var builder = new SQLiteConnectionStringBuilder(); //create an object to build the connectStrign on
            builder.DataSource = filename; //specify the datasource of the object as filename
            return builder.ConnectionString; //return the connection string
        }


         /* ToDataTable function
         * Programmer: Brian Vallelunga
         * Date Created: 6/9/11
         * Date Revised: none
         * Desc: "Extension method to convert dynamic data to a DataTable. Useful for databinding." 
         *     (Reference post: https://stackoverflow.com/questions/5573856/binding-a-gridview-to-a-dynamic-or-expandoobject-object)
         * Pre: Takes dynamic IEnumerable items
         * Post: Returns a data table with the copied dynamic data. 
         * side-effects: none  
         * invariants: given non-null input, a data table will be created.
         * faults: none known
         */
        public static DataTable ToDataTable(this IEnumerable<dynamic> items)
        {
            var data = items.ToArray();  //converts the items into an array
            if (data.Count() == 0) return null; //if the array is empty, no table can be formed

            var dt = new DataTable(); //creates new dataTable object
            foreach (var key in ((IDictionary<string, object>)data[0]).Keys) //retreive the table name (key)
            {
                dt.Columns.Add(key); //add the key to each column
            }
            foreach (var d in data) //for each member of data
            {
                dt.Rows.Add(((IDictionary<string, object>)d).Values.ToArray()); //add it to each row
            }
            return dt; //return the data table
        }

        /* DisplayData function
         * Programmer: Alice Kuang
         * Date Created: 4/10/22
         * Date Revised: 4/14/22
         * Desc: Display data displays the information to the dataGridView after performing
         *       a query in sql. 
         * Pre: Requires a DataGridView object and a string with a valid sql statement to query
         * Post: Nothing
         * side-effects: Displays the queried data to the dataGridView GUI.  
         * invariants: given valid inputs, DisplayData will return a table of the queried contents
         *       to DataGridView
         * faults: none known
         */
        public static void DisplayData(DataGridView dgv, string sql)
        {
            using (var conn = new SQLiteConnection(defaultConn)) //get the connection string
            {
                dgv.DataSource = null; //initialize the dataSource as null
                var result = conn.Query(sql); //query the sql string and store the results
                dgv.DataSource = result.ToDataTable(); //convert the results into a table format, set as dgv's dataSource

                dgv.AutoResizeColumns(); //autoResize columns
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; //apply the setting to all cells in the column
                
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue; //set the table's default color as alternating rows of white and lightBlue

                
                foreach (DataGridViewColumn column in dgv.Columns) // disable sorting of the data
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable; //apply the disable sorting to each row
                }

                
                foreach (DataGridViewRow row in dgv.Rows) // display row number
                {
                    row.HeaderCell.Value = (row.Index + 1).ToString(); //increment idx and convert the row value into a string
                    row.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //apply center alignment for cell with row numbers
                }
                dgv.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders); //automatically resizes the headers for prettier formatting
            }
        }
    }
}
