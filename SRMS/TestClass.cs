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

        
        public void Create_Student()
        {
              var test_student = new string[] { "Jamie", "Maddox", "jamiemaddox", "password", "jamiemaddox@ku.edu" };
              var s = new Student
              {
                FirstName = test_student[0],
                LastName = test_student[1],
                UserName = test_student[2],
                Password = test_student[3],
                Email = test_student[4],
               };
              try
              {
                    using (var conn = new SQLiteConnection(Utils.defaultConn))
                    {
                        conn.Insert(s);
                        var sql = "SELECT Max(Id) FROM Student";
                        idUser = conn.ExecuteScalar<int>(sql);
                        sql = $"SELECT * From Student Where Id = {idUser}";
                        var student = conn.QuerySingleOrDefault<Student>(sql);
                        if (student.UserName == s.UserName
                            && student.FirstName == s.FirstName
                            && student.LastName == s.LastName
                            && student.Password == s.Password
                            && student.Email == s.Email)
                        { 
                        Console.WriteLine("Test 4: New Student profile successfully inserted: PASS");
                        }
                        else
                        {
                            Console.WriteLine("Test 4: New Student profile successfully inserted: FAIL");
                        }
                    }
              }
              catch (Exception ex)
              {
                MessageBox.Show(ex.Message, "Exception caught when saving Student table");
              }
        }

        
        public void Update_Student()
        {
            string[] test_student = { "Jamie", "Maddox", "jamiemaddox3", "password", "jamiemaddox@ku.edu" };
            var s = new Student
            {
                Id = idUser,
                FirstName = test_student[0],
                LastName = test_student[1],
                UserName = test_student[2],
                Password = test_student[3],
                Email = test_student[4],
            };
            using (var conn = new SQLiteConnection(Utils.defaultConn))
            {
                conn.Update<Student>(s);
                var sql = $"SELECT * FROM Student WHERE Id = {idUser}";
                var student = conn.QuerySingleOrDefault<Student>(sql);
                
                if (student.UserName == s.UserName
                    && student.FirstName == s.FirstName
                    && student.LastName == s.LastName
                    && student.Password == s.Password
                    && student.Email == s.Email)
                {
                    Console.WriteLine("Test 5: Student profile successfully updated: PASS");
                }
                else
                {
                    Console.WriteLine("Test 5: Student profile successfully update: FAIL");
                }
            }
        }
        
        public void Delete_Student()
        {
            string[] test_student = { "Jamie", "Maddox", "jamiemaddox3", "password", "jamiemaddox@ku.edu" };
            var s = new Student
            {
                Id = idUser,
                FirstName = test_student[0],
                LastName = test_student[1],
                UserName = test_student[2],
                Password = test_student[3],
                Email = test_student[4],
            };
            try
            {
                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    conn.Delete(s);
                    var sql = $"SELECT * FROM Student WHERE Id = {idUser}";
                    var student = conn.QuerySingleOrDefault<Student>(sql);
                    if (student == null)
                    {
                        Console.WriteLine("Test 6: Student profile successfully deleted: PASS");
                    }
                    else
                    {
                        Console.WriteLine("Test 6: Student profile successfully delete: FAIL");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when deleting from Student table");
            }
        }
        
        public void Create_Faculty()
        {
            var test_faculty = new string[] { "Jillian", "Ward", "jillianward", "jillianward@ku.edu", "password4", "Professor", "Business" };
            var f = new Faculty
            {
                FirstName = test_faculty[0],
                LastName = test_faculty[1],
                UserName = test_faculty[2],
                Email = test_faculty[3],
                Password = test_faculty[4],
                Title = test_faculty[5],
                Dept = test_faculty[6],
            };
            try
            {
                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    conn.Insert(f);
                    var sql = "SELECT MAX(Id) FROM Faculty";
                    idUser = conn.ExecuteScalar<int>(sql);
                    sql = $"SELECT * From Faculty Where Id = {idUser}";
                    var faculty = conn.QuerySingleOrDefault<Faculty>(sql);
                    if (faculty.UserName == f.UserName
                        && faculty.FirstName == f.FirstName
                        && faculty.LastName == f.LastName
                        && faculty.Email == f.Email
                        && faculty.Password == f.Password
                        && faculty.Title == f.Title
                        && faculty.Dept == f.Dept)
                    {
                        Console.WriteLine("Test 7: New Faculty profile successfully inserted: PASS");
                    }
                    else
                    {
                        Console.WriteLine("Test 7: New Faculty profile successfully inserted: FAIL");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Faculty table");
            }
        }

        public void Update_Faculty()
        {
            string[] test_faculty = { "Jillian", "Ward", "jillianward", "jillianward@ku.edu", "newpassword", "Associate Professor", "Business" };
            var f = new Faculty
            {
                Id = idUser,
                FirstName = test_faculty[0],
                LastName = test_faculty[1],
                UserName = test_faculty[2],
                Email = test_faculty[3],
                Password = test_faculty[4],
                Title = test_faculty[5],
                Dept = test_faculty[6],
            };
            using (var conn = new SQLiteConnection(Utils.defaultConn))
            {
                conn.Update<Faculty>(f);
                var sql = $"SELECT * FROM Faculty WHERE Id = {idUser}";
                var faculty = conn.QuerySingleOrDefault<Faculty>(sql);
                if (faculty.UserName == f.UserName
                    && faculty.FirstName == f.FirstName
                    && faculty.LastName == f.LastName
                    && faculty.Password == f.Password
                    && faculty.Email == f.Email
                    && faculty.Title == f.Title
                    && faculty.Dept == f.Dept
                    )
                {
                    Console.WriteLine("Test 8: Faculty profile successfully updated: PASS");
                }
                else
                {
                    Console.WriteLine("Test 8: Faculty profile successfully update: FAIL");
                }
            }
        }

        public void Delete_Faculty()
        {
            string[] test_faculty = { "Jillian", "Ward", "jillianward", "jillianward@ku.edu", "newpassword", "Associate Professor", "Business" };
            var f = new Faculty
            {
                Id = idUser,
                FirstName = test_faculty[0],
                LastName = test_faculty[1],
                UserName = test_faculty[2],
                Email = test_faculty[3],
                Password = test_faculty[4],
                Title = test_faculty[5],
                Dept = test_faculty[6],
            };
            try
            {
                using (var conn = new SQLiteConnection(Utils.defaultConn))
                {
                    conn.Delete(f);
                    var sql = $"SELECT * FROM Faculty WHERE Id = {idUser}";
                    var faculty = conn.QuerySingleOrDefault<Administrator>(sql);
                    if (faculty == null)
                    {
                        Console.WriteLine("Test 9: Faculty profile successfully deleted: PASS");
                    }
                    else
                    {
                        Console.WriteLine("Test 9: Faculty profile successfully deleted: FAIL");
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
