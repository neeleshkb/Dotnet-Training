use Learning;

-- Create a stored procedure to get all students
CREATE PROCEDURE GetAllStudents
AS
BEGIN
    SELECT * from Students;
END

EXEC GetAllStudents;

-- Drop the stored procedure
-- DROP PROCEDURE GetAllStudents;

-- Create a stored procedure to get all students with their enrolled courses
CREATE PROCEDURE GetAllStudentsCourses
As
BEGIN
    select s.FirstName, c.CourseName from Students as s
    inner join Enrollments as e on e.StudentId = s.StudentId
    inner join Courses as c on c.CourseId = e.CourseId; 
END

EXEC GetAllStudentsCourses;

-- Drop the stored procedure
-- DROP PROCEDURE GetAllStudentsCourses;

-- Create a stored procedure to get student details by StudentId
CREATE PROCEDURE GetStudentDetails
    @StudentId INT
AS
BEGIN
    SELECT * from Students WHERE StudentId = @StudentId;
END

EXEC GetStudentDetails @StudentId = 1;

-- Drop the stored procedure
-- DROP PROCEDURE GetStudentDetails;

-- Create a stored procedure to get total count of students
CREATE PROCEDURE GetStudentsCount
    @Count INT OUTPUT
AS
BEGIN
    SELECT @Count = COUNT(*) FROM Students;
END

-- Call the stored procedure and get the output parameter, Declare a variable to hold the output
DECLARE @TotalStudents INT;
EXEC GetStudentsCount @Count = @TotalStudents OUTPUT;
SELECT @TotalStudents;

-- Stored procedure which uses input and output parameters
CREATE PROCEDURE GetStudentCoursesCount
    @StudentId INT,
    @CourseCount INT OUTPUT
AS
BEGIN   
    SELECT @CourseCount = COUNT(*) FROM Enrollments WHERE StudentId = @StudentId;
END

-- Call the stored procedure and get the output parameter, Declare a variable to hold the output
DECLARE @TotalCourses INT;
EXEC GetStudentCoursesCount @StudentId = 1, @CourseCount = @TotalCourses OUTPUT;
SELECT @TotalCourses;