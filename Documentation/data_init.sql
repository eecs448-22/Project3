-- Initialize the database
INSERT INTO Users(Username, Password)
VALUES ('tom.smith', 'password'),       -- 2
       ('bob.jones', 'password'),       -- 3
       ('emma.davis', 'password'),      -- 4
       ('emily.brown', 'password'),     -- 5
       ('jim.glass', 'password'),       -- 6
       ('ashley.johnson', 'password'),  -- 7
       ('charles.clark', 'password'),   -- 8
       ('david.miller', 'password'),    -- 9
       ('michael.lewis', 'password'),   -- 10
       ('samantha.nelson', 'password'); -- 11

-- Seed the first record
INSERT INTO Student(Id, UserId, FirstName, LastName)
VALUES (30001, 2, 'Tom', 'Smith');

INSERT INTO Student(UserId, FirstName, LastName)
VALUES (3, 'Bob', 'Jones'),
       (4, 'Emma', 'Davis'),
       (5, 'Emily', 'Brown'),
       (6, 'Jim', 'Glass');

-- Seed the first record
INSERT INTO Course(Id, Subject, Level, Title, Hours)
VALUES (1001, 'EECS', 101, 'New Student Seminar', 1);

INSERT INTO Course(Subject, Level, Title, Hours)
VALUES ('EECS', 138, 'Introduction to Computing', 3),
       ('EECS', 210, 'Discrete Structures', 4),
       ('MATH', 510, 'Theory of Computing', 3),
       ('PHSX', 521, 'Mechanics', 3),
       ('PHSX', 531, 'Electricity and Magnetism', 3);

INSERT INTO Enrollment(StudentId, CourseId)
VALUES (30001, 1001),
       (30002, 1002),
       (30003, 1003),
       (30004, 1004),
       (30005, 1005),
       (30002, 1006);

-- Faculty
INSERT INTO Faculty(Id, UserId, FirstName, LastName)
VALUES (10001, 7, 'Ashley', 'Johnson');

INSERT INTO Faculty(UserId, FirstName, LastName)
VALUES (8, 'Charles', 'Clark'),
       (9, 'David', 'Miller'),
       (10, 'Michael', 'Lewis'),
       (11, 'Samantha', 'Nelson');

INSERT INTO Teaching(FacultyId, CourseId)
VALUES (10001, 1001),
       (10002, 1002),
       (10003, 1003),
       (10004, 1004),
       (10005, 1005),
       (10005, 1006);

INSERT INTO Assignment(Id, CourseId, Description)
VALUES (100101, 1001, 'Reading Student Handbook P0-32');

INSERT INTO Assignment(CourseId, Description)
VALUES (1002, 'Lab #1 - Hellow World!'),
       (1003, 'Homework #2'),
       (1004, 'Quiz #2 Sound Wave'),
       (1005, 'Exam #1 Kinetics'),
       (1006, 'Homework #5 Magnetism');

INSERT INTO Grading(StudentId, CourseId, AssignmentId, Score)
VALUES (30001, 1001, 100101, 91.5),
       (30002, 1002, 100102, 67.0),
       (30002, 1006, 100106, 86.0),
       (30003, 1003, 100103, 83.5),
       (30004, 1004, 100104, 75.0),
       (30005, 1005, 100105, 95.5),
       (30005, 1006, 100106, 89.0);
