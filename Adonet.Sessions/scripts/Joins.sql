use Learning;

select * from Students;
select * from Courses;
select * from Enrollments;

-- Inner Join to get list of students with their enrolled courses
-- Inner Join only returns matching records from both tables
select s.FirstName, c.CourseName from Students as s
inner join Enrollments as e on e.StudentId = s.StudentId
inner join Courses as c on c.CourseId = e.CourseId;

-- Left Join to get all students with their enrolled courses (if any)
-- Left Join returns all records from left table and matching records from right table
select * from Students as s
left join Enrollments as e on e.StudentId = s.StudentId
where e.EnrollmentId is null;

-- Left Join to get all courses with their enrolled students (if any)
-- Left Join returns all records from left table and matching records from right table
select * from Courses as c
left JOIN Enrollments as e on e.CourseId = c.CourseId
where e.EnrollmentId is null;

-- Right Join to get all courses with their enrolled students (if any)
-- Right Join returns all records from right table and matching records from left table
select * from Students as s
INNER JOIN Enrollments as e on e.StudentId = s.StudentId
RIGHT JOIN Courses as c on c.CourseId = e.CourseId;

-- Right Join to get all courses with their enrolled students (if any)
-- Right Join returns all records from right table and matching records from left table
Select * from Enrollments as e 
RIGHT JOIN Courses as c on c.CourseId = e.CourseId

-- Left Join to get all courses with their enrolled students (if any)
-- Left Join returns all records from left table and matching records from right table
select * from Courses as c
LEFT JOIN Enrollments as e on e.CourseId = c.CourseId;

-- Above two queries will give same result set but the query plan will be different

-- Left Join returns all records from left table and matching records from right table
-- Right Join returns all records from right table and matching records from left table

-- A student has enrolled in a course or not
-- A course has enrolled by a student or not
-- Full Join to get all students with their enrolled courses (if any) and all courses with their enrolled students (if any)
select * from Students as s
FULL JOIN Enrollments as e on e.StudentId = s.StudentId
FULL JOIN Courses as c on c.CourseId = e.CourseId;