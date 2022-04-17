-- Initialize the database
INSERT INTO Administrator(UserName, Password)
VALUES ('admin', 'test');

-- Seed the first record
INSERT INTO Student(Id, FirstName, LastName, UserName, Password)
VALUES (30001, 'Tom', 'Smith', 'tom.smith', 'pass1');

INSERT INTO Student(FirstName, LastName, UserName, Password)
VALUES ('Bob', 'Jones', 'bob.jones', 'pass1'),
       ('Emma', 'Davis', 'emma.davis', 'pass1'),
       ('Emily', 'Brown', 'emily.brown', 'pass1'),
       ('Jim', 'Glass', 'jim.glass', 'pass1');

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
INSERT INTO Faculty(Id, FirstName, LastName, UserName, Password)
VALUES (10001, 'Ashley', 'Johnson', 'ashley.johnson', 'pass2');

INSERT INTO Faculty(FirstName, LastName, UserName, Password)
VALUES ('Charles', 'Clark', 'charles.clark', 'pass2'),
       ('David', 'Miller', 'david.miller', 'pass2'),
       ('Michael', 'Lewis', 'michael.lewis', 'pass2'),
       ('Samantha', 'Nelson', 'samantha.nelson', 'pass2');

INSERT INTO Teaching(FacultyId, CourseId)
VALUES (10001, 1001),
       (10002, 1002),
       (10003, 1003),
       (10004, 1004),
       (10005, 1005),
       (10005, 1006);
/*
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
*/