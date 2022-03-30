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
                    cnn.Execute(@"
                        CREATE TABLE Student(
                            Id INTEGER PRIMARY KEY NOT NULL,
                            UserId INTEGER NOT NULL,
                            FirstName VARCHAR(60) NOT NULL,
                            LastName VARCHAR(60) NOT NULL,
                            Email VARCHAR(255),
                            Major VARCHAR(60),
                            CreatedOn DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
                            FOREIGN KEY(UserId) REFERENCES Users(Id)
                    )");
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
                    cnn.Execute(@"
                        CREATE TABLE Faculty(
                            Id INTEGER PRIMARY KEY NOT NULL,
                            UserId INTEGER NOT NULL,
                            FirstName VARCHAR(60) NOT NULL,
                            LastName VARCHAR(60) NOT NULL,
                            Email VARCHAR(255),
                            Title VARCHAR(60),
                            Dept VARCHAR(120),
                            CreatedOn DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, --the day faculty was registered in system. 
                            FOREIGN KEY(UserId) REFERENCES Users(Id)
                    )");
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
                    cnn.Execute(@"
                        CREATE TABLE Assignment(
                            Id INTEGER PRIMARY KEY NOT NULL,
                            CourseId INTEGER NOT NULL,            --i.e. 53562
                            Category VARCHAR(25),                 --Homework, Quiz, Discussion
                            Description VARCHAR(128) NOT NULL,
                            DateEntered DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, --time teacher created assignment online
                            DueDate DATETIME, 
                            FOREIGN KEY(CourseId) REFERENCES Course(Id)
                    )");
                    cnn.Execute(@"
                        CREATE TABLE Grading(
                            StudentId INTEGER NOT NULL,
                            CourseId INTEGER NOT NULL,
                            AssignmentId INTEGER NOT NULL,
                            Score REAL, --i.e. 96.8%
                            DateEntered DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, --time teacher entered grades 
                            FOREIGN KEY(StudentId) REFERENCES Student(Id),
                            FOREIGN KEY(CourseId) REFERENCES Course(Id),
                            FOREIGN KEY(AssignmentId) REFERENCES Assignment(Id)
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

