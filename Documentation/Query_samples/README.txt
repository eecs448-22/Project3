
Retrieving all data:
SELECT * 
  FROM table <-- * = ALL; allows you to select all the fields from table

EX) 
SELECT *
  FROM Student;

-----------------------------------------------------------------------------------
How to retreive a specific type of data. 
We can "JOIN" elements of two tables together. 

For example, let's say you want to check a student w/ ID 30002 grade's.
Give student field an alias 's' with the AS keyword.
Extract relevant data from the Enrollment and Course tables by matching the student ID 
foreign key in the tables and JOIN them to the original table

-- Student View (1): Show student with 30002's enrolled courses and grades
-- || is the concatenate operator like "+" in SQL Server
-- Order by organizes a given field in ascending/ descending order

SELECT s.Id, s.FirstName, s.LastName
     , c.Subject || ' ' || c.Level AS "Class"
  FROM Student AS s
  JOIN Enrollment AS e ON s.Id = e.StudentId
  JOIN Course AS c ON e.CourseId = c.Id
 WHERE s.Id = 30002 AND e.Status = 1
 ORDER BY "Class";

-----------------------------------------------------------------------------------