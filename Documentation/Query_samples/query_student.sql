-- Student View (1) Show enrolled courses
-- || is the concatenate operator like "+" in SQL Server
SELECT s.Id, s.FirstName, s.LastName
     , c.Subject || ' ' || c.Level AS "Class"
  FROM Student AS s
  JOIN Enrollment AS e ON s.Id = e.StudentId
  JOIN Course AS c ON e.CourseId = c.Id
 WHERE s.Id = 30002 AND e.Status = 1
 ORDER BY "Class";

-- Student View (2) Check one's score
SELECT s.Id, s.FirstName, s.LastName
     , c.Subject || ' ' || c.Level AS "Class"
     , e.Grade
  FROM Student AS s
  JOIN Enrollment AS e ON s.Id = e.StudentId
  JOIN Course AS c ON e.CourseId = c.Id
 WHERE s.Id = 30002 AND e.Status = 1
 ORDER BY "Class";
