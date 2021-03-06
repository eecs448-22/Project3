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
            var dbFilePath = @"..\..\..\MainDb.db";
            if (!File.Exists(dbFilePath))
            {
                 //Create a new connection to the local server
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    //Create Administrator table
                    cnn.Execute(@"
                        CREATE TABLE IF NOT EXISTS Administrator (
                           FirstName VARCHAR(60),
                           LastName VARCHAR(60),
                           UserName VARCHAR(60) NOT NULL UNIQUE,   --Login name
                           Email VARCHAR(255),
                           Password VARCHAR(128),
                           CreatedOn DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
                       )");

                    //Insert into Administrator table
                    cnn.Execute(@"
                        INSERT INTO Administrator
                            (Username, Password)
                        VALUES
                            ('admin', 'test')");

                    //Create Student table
                    cnn.Execute(@"
                        CREATE TABLE Student(
                            Id INTEGER PRIMARY KEY NOT NULL,
                            FirstName VARCHAR(60),
                            LastName VARCHAR(60),
                            UserName VARCHAR(60) NOT NULL UNIQUE,        --Login name
                            Email VARCHAR(255),
                            Password VARCHAR(128),
                            Major VARCHAR(60), --English, CS, Math, etc.
                            CreatedOn DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP --the day student was registered in system
                        )");

                    //Create course table
                    cnn.Execute(@"
                        CREATE TABLE Course(
                            Id INTEGER PRIMARY KEY NOT NULL,
                            Subject VARCHAR(8) NOT NULL,
                            'Level' INTEGER NOT NULL,
                            Title VARCHAR(128) NOT NULL,
                            Hours INTEGER NOT NULL,
                            Room VARCHAR(60),
                            Semester VARCHAR(9),
                            Notes VARCHAR(255)
                    )");

                    //Create enrollment table
                    cnn.Execute(@"
                        CREATE TABLE Enrollment(
                            StudentId INTEGER NOT NULL,
                            CourseId INTEGER NOT NULL,
                            Grade CHAR(2),              -- Final grade
                            DateEntered DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                            Status INTEGER NOT NULL DEFAULT (1),    -- 1) Active 0) Dropped
                            FOREIGN KEY(StudentId) REFERENCES Student(Id), --studentID retreived from Primary Key of Student table
                            FOREIGN KEY(CourseId) REFERENCES Course(Id)
                    )");
                    
                    //Create Faculty Table
                    cnn.Execute(@"
                        CREATE TABLE Faculty(
                            Id INTEGER PRIMARY KEY NOT NULL,
                            FirstName VARCHAR(60),
                            LastName VARCHAR(60),
                            UserName VARCHAR(60) NOT NULL UNIQUE,        --Login name
                            Email VARCHAR(255),
                            Password VARCHAR(128),
                            Title VARCHAR(60),
                            Dept VARCHAR(120),
                            CreatedOn DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP --the day faculty was registered in system.
                        )");

                    //Create Teaching table
                    cnn.Execute(@"
                        CREATE TABLE Teaching(
                            FacultyId INTEGER NOT NULL,
                            CourseId INTEGER NOT NULL, --i.e. 53562
                            LectureTime VARCHAR(64), --Write the lecture time as a sting, i.e. MWF 6pm
                            OfficeHour VARCHAR(128), --Write the office hour availability as a string, i.e. TR 1pm
                            DateEntered DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                            FOREIGN KEY(FacultyId) REFERENCES Faculty(Id), --FacultyId retreived from Primary Key of Faculty table
                            FOREIGN KEY(CourseId) REFERENCES Course(Id)
                    )");
                }
            }
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

