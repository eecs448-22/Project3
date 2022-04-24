﻿using System;
using Models;
using System.Windows.Forms;
using System.Data.SQLite;
using Helper;
using Dapper.Contrib.Extensions;
using DBMS;
using Dapper;

namespace MyTests
{
    public class TestClass
    {
        //get the connection string from sql
        private string conn = SqliteDataAccess.LoadConnectionString();
        private int idUser = 0; //EXTREMELY IMPORTANT, helps to keep track of the last inserted user


        //NOTE: USERNAME IS A UNIQUE FIELD; RECOMMENDED TO CREATE USER AND DELETE SAME USER 
        //TO AVOID NOT BEING ABLE TO SEED THE SAME RECORD 
        public void Admin_CreateUser()
        {

            //Steps needed:
            //Make a new user profile to enter in database
            //Insert user into the database
            //Check the database to verify the user is there
            var user = new string[] { "Linda", "Smith", "linda8.smith", "test", "lsmith3@ku.edu" };

            /*Make a new user profile to enter in database*/
            var a = new Administrator //Id and Created on are automatically generated by table, so skip those
            {
                FirstName = user[0],
                LastName = user[1],
                UserName = user[2],
                Password = user[3],
                Email = user[4],
            };
            try
            {
                /*Insert user into the database and Check the database to verify the user is there*/
                //get the maxId row.
                using (var conn = new SQLiteConnection(Utils.defaultConn)) //get connection to db
                {
                    conn.Insert(a); //insert the record
                    //idUser = Convert.ToInt32(conn.LastInsertRowId);
                    var sql = "SELECT MAX(Id) FROM Administrator";
                    idUser = conn.ExecuteScalar<int>(sql);

                    //check if it was inserted
                     sql = $"SELECT * From Administrator Where Id = {idUser}";
                    var admin = conn.QuerySingleOrDefault<Administrator>(sql);

                    //If all fields match, return test passed, if not, return failed.
                    if (admin.UserName == a.UserName
                        && admin.FirstName == a.FirstName
                        && admin.LastName == a.LastName
                        && admin.Password == a.Password
                        && admin.Email == a.Email)
                    {
                        Console.WriteLine("Test 1: New Admin user successfully inserted: PASS");
                    }
                    else
                    {
                        Console.WriteLine("Test 1: New Admin user successfully inserted: FAIL");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Admin table");
            }




        }

        public void Admin_UpdateUser()
        {

            //Steps needed:
            //Make a new user profile to enter in database
            //Insert user into the database
            //Check the database to verify the user is there
            string[] user = { "Linda", "Jones", "linda10.smith", "test", "lsmith3@ku.edu" };

            /*Make a new user profile to enter in database*/
            var a = new Administrator //Id and Created on are automatically generated by table, so skip those
            {
                Id = idUser,
                FirstName = user[0],
                LastName = user[1],
                UserName = user[2],
                Password = user[3],
                Email = user[4],
            };

            /*Insert user into the database */
            using (var conn = new SQLiteConnection(Utils.defaultConn)) //get connection to db
            {
                conn.Update<Administrator>(a);

                var sql = $"SELECT * FROM Administrator WHERE Id = {idUser}";
                var admin = conn.QuerySingleOrDefault<Administrator>(sql);

                //If yes, return test passed, if no, return pass failed.

                if (admin.UserName == a.UserName
                        && admin.FirstName == a.FirstName
                        && admin.LastName == a.LastName
                        && admin.Password == a.Password
                        && admin.Email == a.Email)
                {
                    Console.WriteLine("Test 2: Admin user successfully updated: PASS");
                }
                else
                {
                    Console.WriteLine("Test 2: Admin user successfully updated: FAIL");
                }
            }
        }

        public void Admin_DeleteUser()
        {
            string[] user = { "Linda", "Jones", "linda3.smith", "test", "lsmith3@ku.edu" };

            /*Make a new user profile to enter in database*/
            var a = new Administrator //Id and Created on are automatically generated by table, so skip those
            {
                Id = idUser,
                FirstName = user[0],
                LastName = user[1],
                UserName = user[2],
                Password = user[3],
                Email = user[4],
            };
            try
            {
                /*Insert user into the database and Check the database to verify the user is there*/
                //get the maxId row.
                using (var conn = new SQLiteConnection(Utils.defaultConn)) //get connection to db
                {
                    conn.Delete(a);

                    var sql = $"SELECT * FROM Administrator WHERE Id = {idUser}";
                    var admin = conn.QuerySingleOrDefault<Administrator>(sql);

                    if (admin == null)
                    {
                        Console.WriteLine("Test 3: Admin user successfully deleted: PASS");
                    }
                    else
                    {
                        Console.WriteLine("Test 3: Admin user successfully deleted: FAIL");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when deleting from Admin table");
            }

        }
    }
}
