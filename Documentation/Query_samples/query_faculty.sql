-- Facult View: (1) which courses professor teaches

SELECT f.Id, f.FirstName, f.LastName
     , c.Subject || ' ' || c.Level AS "Course Desc"
  FROM Faculty AS f
  JOIN Teaching AS t ON f.Id = t.FacultyId
  JOIN Course as c ON t.CourseId = c.Id
 WHERE f.Id = 10005;

-- Facult View: (2) student roster professor teaches
SELECT f.Id, f.FirstName || ' ' || f.LastName AS Professor
     , c.Subject || ' ' || c.Level AS "Course Desc"
     , s.Id AS StudentId, s.FirstName || ' ' || s.LastName AS Student
     , e.Grade
  FROM Faculty AS f
  JOIN Teaching AS t ON f.Id = t.FacultyId
  JOIN Course AS c ON t.CourseId = c.Id
  JOIN Enrollment AS e ON e.CourseId = c.Id
  JOIN Student AS s ON s.Id = e.StudentId
 WHERE f.Id = 10005;
