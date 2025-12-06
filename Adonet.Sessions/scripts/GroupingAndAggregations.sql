use Learning;

select * from Students;
select * from Courses;
select * from Enrollments;

-- Total number of students
select COUNT(StudentId) as TotalStudents from Students;

-- Total number of courses
select COUNT(CourseId) as TotalCourses from Courses;

-- Total number of enrollments by a specific student (e.g., StudentId = 1)
select StudentId, COUNT(*) as TotalEnrollments from Enrollments where StudentId = 1;

-- Number of courses enrolled per student
SELECT FirstName, ISNULL(TotalEnrollments, 0) as TotalEnrollments from Students as s
LEFT Join (
    SELECT StudentId, COUNT(*) as TotalEnrollments from Enrollments
    GROUP BY StudentId
) as resultTable on resultTable.StudentId = s.StudentId;

-- Number of courses enrolled per student using GROUP BY
SELECT StudentId, COUNT(*) as TotalEnrollments from Enrollments
GROUP BY StudentId

-- Number of students enrolled in any course
SELECT COUNT(DISTINCT StudentId) as EnrolledStudents from Enrollments

-- Number of students enrolled per course
SELECT CourseId, COUNT(StudentId) as Students from Enrollments -- where CourseId=1;
GROUP BY CourseId;

-- List of courses with number of enrolled students (including courses with zero enrollments)
Select CourseName, ISNULL(NumberOfStudents, 0) as NumberOfStudents from Courses as c
LEFT JOIN (SELECT CourseId, COUNT(StudentId) as NumberOfStudents from Enrollments -- where CourseId=1;
GROUP BY CourseId) as resultTable on resultTable.CourseId = c.CourseId;

-- Having clause to filter groups
-- Courses with more than 1 enrolled student
SELECT CourseId, COUNT(StudentId) as Students from Enrollments
GROUP BY CourseId
HAVING COUNT(StudentId) > 1;

-- List of courses with more than 1 enrolled student
SELECT c.CourseName, Students from Courses as c
INNER JOIN (SELECT CourseId, COUNT(StudentId) as Students from Enrollments
GROUP BY CourseId
HAVING COUNT(StudentId) > 1) AS resultTable on resultTable.CourseId = c.CourseId;

SELECT * from Enrollments;
select * from Scores;

-- Total score obtained by a specific student (e.g., StudentId = 1)
Select SUM(ScoreValue) from Scores where StudentId =1;

-- Total score obtained by each student
select StudentId, COUNT(CourseId) as courseId, SUM(ScoreValue) as TotalScore from Scores as s
GROUP BY StudentId;

-- Students with total score greater than or equal to 200
select StudentId, COUNT(CourseId) as courseId, SUM(ScoreValue) as TotalScore from Scores as s
GROUP BY StudentId
HAVING SUM(ScoreValue) >=200;

-- Average score per course
Select CourseId, AVG(ScoreValue) as AverageScore from Scores
GROUP by CourseId;

-- Min and Max score per course
Select CourseId, MIN(ScoreValue) as MinScore, MAX(ScoreValue) as MaxScore from Scores
GROUP by CourseId;

-- Min and Max score per course with course name
Select CourseName, MinScore, MaxScore from Courses as c
INNER JOIN (
    Select CourseId, MIN(ScoreValue) as MinScore, MAX(ScoreValue) as MaxScore from Scores
    GROUP by CourseId
) as resultTable on resultTable.CourseId = c.CourseId;