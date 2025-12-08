use Learning;

CREATE VIEW StudentsCoursesView 
AS
Select s.FirstName, s.LastName, c.CourseName from Students as s
inner join Enrollments as e on e.StudentId = s.StudentId
inner join Courses as c on c.CourseId = e.CourseId;

SELECT * from StudentsCoursesView;

DROP VIEW StudentsCoursesView;