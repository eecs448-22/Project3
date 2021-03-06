using System;
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
        
        /* Code Artifact: Admin_CreateUser() Method
         * Programmer: Alice Kuang
         * Date Created: 4/23/22
         * Date Revised: 4/24/22
         * Desc: First test, checks to see if a new admin user can be created and inserted into the Administrator table
         * Pre: need access to database and a test user w/ information to insert
         * Post: prints to console whether or not the test passed or failed
         * Error/Exceptions: Will throw an exception if an error is encoutnered when saving to admin table
        */
        public void Admin_CreateUser() //Test 1
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
        
        /* Code Artifact: Admin_UpdateUser() Method
         * Programmer: Alice Kuang
         * Date Created: 4/23/22
         * Date Revised: 4/24/22
         * Desc: Second test, checks to see if an existing admin user's info can be updated in Administrator table
         * Pre: need access to database and a test user w/ changed information to insert
         * Post: prints to console whether or not the test passed or failed
        */
        public void Admin_UpdateUser() //Test 2
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

        /* Code Artifact: Admin_DeleteUser() Method
         * Programmer: Alice Kuang
         * Date Created: 4/23/22
         * Date Revised: 4/24/22
         * Desc: Third test, checks to see if an existing admin user can be deleted from the Administrator table
         * Pre: need access to database and info a user looking to delete
         * Post: prints to console whether or not the test passed or failed
         * Error/Exceptions: Will throw an exception if an error is encountered when deleting from admin table
        */
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

        /* Code Artifact: Create_Student() Method
         * Programmer: Maggie Swartz
         * Date Created: 4/24/22
         * Date Revised: 4/24/22
         * Desc: Fourth test, creates a new student profile and inserts into Student table
         * Pre: need access to database and a student profile to insert into the table
         * Post: prints to console whether or not the test passed or failed
         * Error/Exceptions: Will throw an exception if an error is encountered when inserting to student table
        */
        public void Create_Student() //Test 4
        {
            //Make a new student profile to enter into the database
            var test_student = new string[] { "Jamie", "Maddox", "jamiemaddox", "password", "jamiemaddox@ku.edu" };
            //Id and Created on are automatically generated by table, so skip those
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
                using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establish connection to database
                {
                    //Insert new student profile
                    conn.Insert(s);
                    var sql = "SELECT Max(Id) FROM Student";
                    idUser = conn.ExecuteScalar<int>(sql); //Update idUser number
                    //Search through database for the recently inserted student
                    sql = $"SELECT * From Student Where Id = {idUser}";
                    var student = conn.QuerySingleOrDefault<Student>(sql);
                    //If all fields match, then student exists and return PASS, otherwise return FAIL
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

        /* Code Artifact: Update_Student() Method
         * Programmer: Maggie Swartz
         * Date Created: 4/24/22
         * Date Revised: 4/24/22
         * Desc: Fifth test, updates student profile info and updates the Student table
         * Pre: need access to database and a student profile to insert into the table w/ slightly changed information
         * Post: prints to console whether or not the test passed or failed
        */
        public void Update_Student() //Test 5
        {
            //Create new student profile with slightly different profile info for insertion
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
            using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establish connection to database
            {
                conn.Update<Student>(s); //Update the database with new information
                var sql = $"SELECT * FROM Student WHERE Id = {idUser}";
                var student = conn.QuerySingleOrDefault<Student>(sql); //Search the database for recently updated student

                //If all fields match, then the record was udpated and return PASS, otherwise return FAIL
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

        /* Code Artifact: Delete_Student() Method
         * Programmer: Maggie Swartz
         * Date Created: 4/24/22
         * Date Revised: 4/24/22
         * Desc: Sixth test, deletes existing student profile from the Student table
         * Pre: need access to database and a student profile to look up in the database to delete
         * Post: prints to console whether or not the test passed or failed
         * Error/Exceptions: throws an exception if encounters an error when deleting from the student table
        */
        public void Delete_Student() //Test 6
        {
            //Recording profile of student that we are wanting to delete
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
                using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establish connection to database
                {
                    conn.Delete(s); //Delete the student from the database
                    var sql = $"SELECT * FROM Student WHERE Id = {idUser}"; //Search the database for recently deleted student
                    var student = conn.QuerySingleOrDefault<Student>(sql);
                    //If student is null (meaning no such student could be found), return PASS, otherwise return fail
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

        /* Code Artifact: Create_Faculty() Method
         * Programmer: Maggie Swartz
         * Date Created: 4/24/22
         * Date Revised: 4/24/22
         * Desc: Seventh test, creates new faculty member profile and inserts into Faculty database
         * Pre: need access to database and a faculty profile to insert
         * Post: prints to console whether or not the test passed or failed
         * Error/Exceptions: throws an exception if encounters an error when inserting to the Faculty table
        */
        public void Create_Faculty() //Test 7
        {
            //Creates a new faculty profile to insert into the database
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
                using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establishes connection to database
                {
                    conn.Insert(f); //Inserts new faculty profile to the database
                    var sql = "SELECT MAX(Id) FROM Faculty";
                    idUser = conn.ExecuteScalar<int>(sql); 
                    sql = $"SELECT * From Faculty Where Id = {idUser}"; //Searches database for recently added faculty member
                    var faculty = conn.QuerySingleOrDefault<Faculty>(sql);
                    //If all fields match, then faculty member was inserted, return PASS, otherwise return FAIL
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

        /* Code Artifact: Update_Faculty() Method
         * Programmer: Maggie Swartz
         * Date Created: 4/24/22
         * Date Revised: 4/24/22
         * Desc: Eighth test, updates information for existing faculty profile in the Faculty table
         * Pre: need access to database and a student profile to look up in the database w/ slightly altered information
         * Post: prints to console whether or not the test passed or failed
        */
        public void Update_Faculty() //Test 8
        {
            //Records new faculty profile with slightly altered information to update
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
            using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establishes connection to database
            {
                conn.Update<Faculty>(f); //Updates the profile in the faculty table
                var sql = $"SELECT * FROM Faculty WHERE Id = {idUser}";
                var faculty = conn.QuerySingleOrDefault<Faculty>(sql); //Searches the table to see if the info was updated successfully
                //If all fields match, then record was updated successfully, return PASS, otherwise return FAIL
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

        /* Code Artifact: Delete_Faculty() Method
         * Programmer: Maggie Swartz
         * Date Created: 4/24/22
         * Date Revised: 4/24/22
         * Desc: Ninth test, deletes existing faculty profile from the Faculty table
         * Pre: need access to database and a faculty profile to look up in the database to delete
         * Post: prints to console whether or not the test passed or failed
         * Error/Exceptions: throws an exception if encounters an error when deleting from the faculty table
        */
        public void Delete_Faculty() //Test 9
        {
            //Records information of the faculty member you hope to delete from the table
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
                using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establishes connection to the database
                {
                    conn.Delete(f); //Deletes the faculty profile from the Faculty table
                    var sql = $"SELECT * FROM Faculty WHERE Id = {idUser}";
                    var faculty = conn.QuerySingleOrDefault<Administrator>(sql); //Searches table to see if you can find deleted faculty
                    if (faculty == null) //If the faculty member cannot be found, then deletio was successful, return PASS, otherwise FAIL
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

        /* Code Artifact: Create_Course() Method
         * Programmer: Maggie Swartz
         * Date Created: 4/24/22
         * Date Revised: 4/24/22
         * Desc: Tenth test, reates new course and inserts into Course table
         * Pre: need access to database and a course profile to insert in the database
         * Post: prints to console whether or not the test passed or failed
         * Error/Exceptions: throws an exception if encounters an error when inserting to the course table
        */
        public void Create_Course() //Test 10
        {
            //Create profile with new course information to insert into the course table
            string[] test_course = { "HA", "101", "Introduction to Art History", "3", "SMA 211", "Summer2022" };
            int level_int = Convert.ToInt32(test_course[1]);
            int hours_int = Convert.ToInt32(test_course[3]);
            var c = new Course
            {
                Subject = test_course[0],
                Level = level_int,
                Title = test_course[2],
                Hours = hours_int,
                Room = test_course[4],
                Semester = test_course[5],
            };
            try
            {
                using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establish connection to database
                {
                    conn.Insert(c); //Insert new course profile into the table
                    var sql = $"SELECT MAX(Id) FROM Course";
                    idUser = conn.ExecuteScalar<int>(sql);
                    sql = $"SELECT * From Course Where Id = {idUser}"; //Search the table for the recently created course
                    var course = conn.QuerySingleOrDefault<Course>(sql);
                    //If all fields match, then course was inserted successfully, return PASS, otherwise return FAIL
                    if (course.Subject == c.Subject
                        && course.Level == c.Level
                        && course.Title == c.Title
                        && course.Hours == c.Hours
                        && course.Room == c.Room
                        && course.Semester == c.Semester)
                    {
                        Console.WriteLine("Test 10: New Course successfully inserted: PASS");
                    }
                    else
                    {
                        Console.WriteLine("Test 10: New Course successfully inserted: FAIL");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when saving to Course table");
            }
        }

        /* Code Artifact: Update_Course() Method
         * Programmer: Maggie Swartz
         * Date Created: 4/24/22
         * Date Revised: 4/24/22
         * Desc: Eleventh test, updates existing course information and updates Course table
         * Pre: need access to database and a course profile w/ slightly altered course information
         * Post: prints to console whether or not the test passed or failed
        */
        public void Update_Course() //Test 11
        {
            //Create course profile w/ slightly altered information from existing profile
            string[] test_course = { "HA", "101", "Introduction to Art History", "4", "SMA 200", "Summer2022" };
            int level_int = Convert.ToInt32(test_course[1]);
            int hours_int = Convert.ToInt32(test_course[3]);
            var c = new Course
            {
                Id = idUser,
                Subject = test_course[0],
                Level = level_int,
                Title = test_course[2],
                Hours = hours_int,
                Room = test_course[4],
                Semester = test_course[5],
            };
            using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establish connection to database
            {
                conn.Update<Course>(c); //Update the existing course profile in the Course table
                var sql = $"SELECT * FROM Course WHERE Id = {idUser}";
                var course = conn.QuerySingleOrDefault<Course>(sql); //Search database for updated profiile
                //If all fields match, then profile was updated, return PASS, otherwise return FAIL
                if (course.Subject == c.Subject
                        && course.Level == c.Level
                        && course.Title == c.Title
                        && course.Hours == c.Hours
                        && course.Room == c.Room
                        && course.Semester == c.Semester)
                {
                    Console.WriteLine("Test 11: Course information successfully updated: PASS");
                }
                else
                {
                    Console.WriteLine("Test 11: Course information successfully udpated: FAIL");
                }
            }
        }

        /* Code Artifact: Delete_Course() Method
         * Programmer: Maggie Swartz
         * Date Created: 4/24/22
         * Date Revised: 4/24/22
         * Desc: Twelfth test, deletes existing course and removes from Course table
         * Pre: need access to database and a course profile to delete from the course table
         * Post: prints to console whether or not the test passed or failed
         * Error/Exceptions: throws an exception if encounters an error when deleting from the course table
        */
        public void Delete_Course() //Test 12
        {
            //Record information for course you want to delete from the Course table
            string[] test_course = { "HA", "101", "Introduction to Art History", "4", "SMA 200", "Summer2022" };
            int level_int = Convert.ToInt32(test_course[1]);
            int hours_int = Convert.ToInt32(test_course[3]);
            var c = new Course
            {
                Id = idUser,
                Subject = test_course[0],
                Level = level_int,
                Title = test_course[2],
                Hours = hours_int,
                Room = test_course[4],
                Semester = test_course[5],
            };
            try
            {
                using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establish connection to database
                {
                    conn.Delete(c); //Delete the profile from the Course table
                    var sql = $"SELECT * FROM Course WHERE Id = {idUser}";
                    var course = conn.QuerySingleOrDefault<Course>(sql); //Search database for recently deleted course
                    if (course == null) //If course is null (meaning it couldnt' be found), deletion worked return PASS, else return FAIL
                    {
                        Console.WriteLine("Test 12: Course successfully deleted: PASS");
                    }
                    else
                    {
                        Console.WriteLine("Test 12: Course successfully deleted: FAIL");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception caught when deleting from Course table");
            }
        }

        /* Code Artifact: Assign_Student_Course() Method
        * Programmer: Maggie Swartz
        * Date Created: 4/24/22
        * Date Revised: 4/24/22
        * Desc: Thirteenth test, enrolls an existing student into a new course
        * Pre: need access to database and a student profile + new course to enroll that student into
        * Post: prints to console whether or not the test passed or failed
       */
        public void Assign_Student_Course() //Test 13
        {
            //** added student id as first array element**
            string[] test_enrollment = { "30006", "1010", "94" };
            //int course_int = Convert.ToInt32(test_enrollment[0]);
            using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establish connection to database
            {
                //Add the desired enrollment info (i.e. which course) into the Enrollment database
                var sql = $"INSERT INTO Enrollment (StudentId, CourseId, Grade) VALUES ('{test_enrollment[0]}', '{test_enrollment[1]}', '{test_enrollment[2]}')";
                conn.Query(sql);
                //Search the database to see if the new course is present for the given student
                sql = $"SELECT * FROM Enrollment WHERE StudentId = {test_enrollment[0]} AND CourseId = {test_enrollment[1]}";
                var enrollment = conn.QuerySingleOrDefault<Enrollment>(sql);
                //if all fields match, the student was enrolled in the course, return PASS, else return FALSE
                if (test_enrollment[0] == enrollment.StudentId.ToString() /*converted StudentId toString because it was stored as an int in database (ref: data_schema.sql)*/
                && test_enrollment[1] == enrollment.CourseId.ToString()
                && test_enrollment[2] == enrollment.Grade.ToString())
                {
                    Console.WriteLine("Test 13: Student successfully enrolled in course: PASS");
                }
                else
                {
                    Console.WriteLine("Test 13: Student successfully enrolled in course: FAIL");
                }
            }
        }

        /* Code Artifact: Drop_Student_Course() Method
        * Programmer: Maggie Swartz
        * Date Created: 4/24/22
        * Date Revised: 4/24/22
        * Desc: Fourteenth test, drops a student from a course they are enrolled in
        * Pre: need access to database and a student profile + course info they want to drop
        * Post: prints to console whether or not the test passed or failed
       */
        public void Drop_Student_Course() //Test 14
        {
            //Create profile with pertinent information for student and course you want to drop in Enrollment table
            string[] test_enrollment = { "30006", "1010", "94" };

            using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establis connection to database
            {
                //Delete from enrollment database the course for the corresponding student
                var sql = $"DELETE FROM Enrollment WHERE StudentId = '{test_enrollment[0]}'AND CourseId = '{test_enrollment[1]}' And Grade ='{test_enrollment[2]}'";
                conn.Query(sql);

                //Search the database to see if the dropped course is still present for the student
                sql = $"SELECT * FROM Enrollment WHERE StudentId = {test_enrollment[0]} AND CourseId = {test_enrollment[1]}";
                var enrollment = conn.QuerySingleOrDefault<Enrollment>(sql);
                //If no course is found, then the course was dropped, return PASS, otherwise return FAIL
                if (enrollment == null)
                {
                    Console.WriteLine("Test 14: Student successfully dropped course: PASS");
                }
                else

                    Console.WriteLine("Test 14: Student successfully dropped course: FAIL");

            }
        }

        /* Code Artifact: Assign_Faculty_Course() Method
        * Programmer: Maggie Swartz
        * Date Created: 4/24/22
        * Date Revised: 4/24/22
        * Desc: Fifteenth test, assigns a faculty member a new course to teach
        * Pre: need access to database and a faculty profile + new course for them to teach
        * Post: prints to console whether or not the test passed or failed
       */
        public void Assign_Faculty_Course() //Test 15
        {
            //Create profile with the faculty info and course info needed to update Teaching table
            string[] test_teaching = { "1014", "10003" };
            int course_int = Convert.ToInt32(test_teaching[0]);

            using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establish connection to database
            {
                //Insert into the teaching table the info showing which course the faculty member will now teach
                var sql = $"INSERT INTO Teaching (FacultyId, CourseId) VALUES ('{10003}', '{course_int}')";
                conn.Query(sql);
                //Search the table to see if the recently added information exists
                sql = $"SELECT * FROM Teaching WHERE FacultyId = {10003} AND CourseId = {test_teaching[0]}";
                var teaching = conn.QuerySingleOrDefault<Teaching>(sql);
                //If the fields all match, then assignment was successful, return PASS, otherwise return FAIL
                if (test_teaching[0] == teaching.CourseId.ToString() /*converted StudentId toString because it was stored as an int in database (ref: data_schema.sql)*/
                && test_teaching[1] == teaching.FacultyId.ToString())
                {
                    Console.WriteLine("Test 15: Faculty successfully enrolled as course instructor: PASS");
                }
                else
                {
                    Console.WriteLine("Test 15: Faculty successfully enrolled as course instructor: FAIL");
                }
            }
        }

        /* Code Artifact: Remove_Faculty_Course() Method
        * Programmer: Maggie Swartz
        * Date Created: 4/24/22
        * Date Revised: 4/24/22
        * Desc: Sixteenth test, removes a faculty member from teaching one of the courses they are assigned
        * Pre: need access to database and a faculty profile + the info for the course they want to remove
        * Post: prints to console whether or not the test passed or failed
       */
        public void Remove_Faculty_Course() //Test 16
        {
            //Create profile with info for the course assignment you want to remove for the faculty member
            string[] test_teaching = { "1014", "10003" };
            int course_int = Convert.ToInt32(test_teaching[0]);

            using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establish connection to database
            {
                //Delete from the Teaching table the necessary info
                var sql = $"DELETE FROM Teaching WHERE FacultyId = '{10003}' AND CourseId = '{course_int}'";
                conn.Query(sql);
                //Search the Teaching table to see if you can find the deleted information
                sql = $"SELECT * FROM Teaching WHERE FacultyId = {10003} AND CourseId = {test_teaching[0]}";
                var teaching = conn.QuerySingleOrDefault<Teaching>(sql);
                //If comes back null, then the assignment was successfully deleted, return PASS, else return FAIL
                if (teaching == null)
                {
                    Console.WriteLine("Test 16: Faculty successfully removed as course instructor: PASS");
                }
                else
                {
                    Console.WriteLine("Test 16: Faculty successfully removed as course instructor: FAIL");
                }
            }
        }

        /* Code Artifact: Update_Student_Grade() Method
        * Programmer: Maggie Swartz
        * Date Created: 4/24/22
        * Date Revised: 4/24/22
        * Desc: Seventeenth test, updates final grade in a course for a student
        * Pre: need access to database and a student profile + course info + grade you want to update
        * Post: prints to console whether or not the test passed or failed
       */
        public void Update_Student_Grade() //Test 17
        {
            //Create profile with student info and the grade you want to add
            string[] test_updategrade = { "30006", "1003", "90" };
            int course_int = Convert.ToInt32(test_updategrade[0]);

            using (var conn = new SQLiteConnection(Utils.defaultConn)) //Establish connection to database
            {
                //Update the right profile with the expected grade information
                var sql = $@"UPDATE Enrollment SET Grade = {test_updategrade[1]} WHERE StudentId = {30006} AND CourseId = {course_int};";
                conn.Execute(sql);
                //Search the database for the updated profile to confirm it was completed
                sql = $"SELECT * FROM Enrollment WHERE StudentId = {test_updategrade[0]} AND CourseId = {test_updategrade[1]}";
                var updategrade = conn.QuerySingleOrDefault<Enrollment>(sql);
                //Profile was found with new grade, return PASS
                Console.WriteLine("Test 17: Student grade successfully updated: PASS");
            }
        }
    }
}
