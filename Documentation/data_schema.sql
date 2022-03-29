--The following will create the dataTable in Sql with the specified variables as columns. 

--UNDERSTANDING SQL
--VARCHAR is an array of characters, basically a string
--NOT NULL means user is required to specify file
--PRIMARY KEY is a reference to the row the data is in, it auto increments by one
--FOREIGN KEY allows reference to another table's data (i.e. referencing their primary key)
--CreatedOn marks the time which the database is created based on the current time (CURRENT_TIMESTAMP)
--DATETIME format specifies YEAR:MONTH:DAY HOUR:MIN:SEC, i.e. "1900-01-01 00:00:00"

CREATE TABLE Student(
    Id INTEGER PRIMARY KEY NOT NULL,
    FirstName VARCHAR(60) NOT NULL,
    LastName VARCHAR(60) NOT NULL,
    UserName VARCHAR(60) NOT NULL, --onlineID
    Email VARCHAR(255),
    Password VARCHAR(128),
    Major VARCHAR(60), --English, CS, Math, etc. 
    CreatedOn DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP --the day student was registered in system
);

CREATE TABLE Course(
    Id INTEGER PRIMARY KEY NOT NULL,
    Dept VARCHAR(8) NOT NULL, --i.e. EECS 
    CourseAbbrev VARCHAR(8) NOT NULL, --i.e. EECS 448
    "Level" INTEGER NOT NULL,   --Upper/Lower Level
    Title VARCHAR(128) NOT NULL,--i.e. "Software Programming 1"
    Hours INTEGER NOT NULL,     --Credit Hours
    Room VARCHAR(60),           -- Classroom # or online
    Semester VARCHAR(9),        -- i.e. Spring 2022
    Notes VARCHAR(255)          --brief course description
);

CREATE TABLE Enrollment(
    StudentId INTEGER NOT NULL,
    CourseId INTEGER NOT NULL,
    Grade CHAR(2),              -- Final grade
    DateEntered DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    Status INTEGER NOT NULL DEFAULT (1),    -- 1) Active 0) Dropped
    FOREIGN KEY(StudentId) REFERENCES Student(Id), --studentID retreived from Primary Key of Student table
    FOREIGN KEY(CourseId) REFERENCES Course(Id) --same for courseID
);

CREATE TABLE Faculty(
    Id INTEGER PRIMARY KEY NOT NULL,
    FirstName VARCHAR(60) NOT NULL,
    LastName VARCHAR(60) NOT NULL,
    UserName VARCHAR(60) NOT NULL,
    Email VARCHAR(255),
    Password VARCHAR(128),
    Title VARCHAR(60),
    Dept VARCHAR(120),
    CreatedOn DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP --the day faculty was registered in system. 
);

CREATE TABLE Teaching(
    FacultyId INTEGER NOT NULL,
    CourseId INTEGER NOT NULL, --i.e. 53562
    LectureTime VARCHAR(64), --Write the lecture time as a sting, i.e. MWF 6pm
    OfficeHour VARCHAR(128), --Write the office hour availability as a string, i.e. TR 1pm
    DateEntered DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY(FacultyId) REFERENCES Faculty(Id), --FacultyId retreived from Primary Key of Faculty table
    FOREIGN KEY(CourseId) REFERENCES Course(Id) --same for courseID
);

CREATE TABLE Assignment(
    Id INTEGER PRIMARY KEY NOT NULL,
    CourseId INTEGER NOT NULL, --i.e. 53562
    Category VARCHAR(25) --Homework, Quiz, Discussion
    Description VARCHAR(128) NOT NULL,
    DateEntered DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, --time teacher created assignment online
    DueDate DATETIME, 
    FOREIGN KEY(CourseId) REFERENCES Course(Id)
);

CREATE TABLE Grading(
    StudentId INTEGER NOT NULL,
    CourseId INTEGER NOT NULL,
    AssignmentId INTEGER NOT NULL,
    Score REAL, --i.e. 96.8%
    DateEntered DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP, --time teacher entered grades 
    FOREIGN KEY(StudentId) REFERENCES Student(Id),
    FOREIGN KEY(CourseId) REFERENCES Course(Id),
    FOREIGN KEY(AssignmentId) REFERENCES Assignment(Id)
);
