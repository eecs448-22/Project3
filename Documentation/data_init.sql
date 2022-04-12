-- Initialize the database
INSERT INTO Administrator
    (Username, Password)
VALUES
    ('admin', 'test');

-- Seed the first record
INSERT INTO Student(Id, FirstName, LastName, UserName)
VALUES (30001, 'Tom', 'Smith', 'tom.smith');

INSERT INTO Student(FirstName, LastName, UserName)
VALUES ('Bob', 'Jones', 'bob.jones'),
       ('Emma', 'Davis', 'emma.davis'),
       ('Emily', 'Brown', 'emily.brown'),
       ('Jim', 'Glass', 'jim.glass');

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
INSERT INTO Faculty(Id, FirstName, LastName, UserName)
VALUES (10001, 'Ashley', 'Johnson', 'ashley.johnson');

INSERT INTO Faculty(FirstName, LastName, UserName)
VALUES ('Charles', 'Clark', 'charles.clark'),
       ('David', 'Miller', 'david.miller'),
       ('Michael', 'Lewis', 'michael.lewis'),
       ('Samantha', 'Nelson', 'samantha.nelson');

INSERT INTO Teaching(FacultyId, CourseId)
VALUES (10001, 1001),
       (10002, 1002),
       (10003, 1003),
       (10004, 1004),
       (10005, 1005),
       (10005, 1006);
