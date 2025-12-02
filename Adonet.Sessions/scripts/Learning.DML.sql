use Learning;

Select *
from Students;
Select *
from Courses
Select *
from enrollments

--insert into Students (FirstName, LastName, Dob, Active, Semseter) values ('John', 'liver', '2000-12-01', 1, 1);
--insert into Students (FirstName, LastName, Dob, Active, Semseter) values ('Bob', null, '2000-11-01', 1, 3);
--insert into Students (FirstName, LastName, Dob, Active, Semseter) values ('Alice', null, '2000-10-01', 1, 7);
--insert into Students (FirstName, LastName, Dob, Active, Semseter) values ('Shweta', 'Tal', '2000-11-21', 1, 7);

-- Inserting emails for students
UPDATE Students SET email = 'John@example.com' WHERE FirstName = 'John';
UPDATE Students SET email = 'Bob@outlook.com' WHERE FirstName = 'Bob';
UPDATE Students SET email = 'Alice@gmail.com' WHERE FirstName = 'Alice';
UPDATE Students SET email = 'Shweta@yahoo.com' WHERE FirstName = 'Shweta';

--insert into Courses (CourseName, Credits) Values ('Biology',9);
--insert into Courses (CourseName, Credits) Values ('Maths',8);
--insert into Courses (CourseName, Credits) Values ('Chemistry',6);
insert into Courses (CourseName, Credits) Values ('Physics',7);

-- A student can enroll in multiple courses
-- A course can be enrolled by multiple students
-- Many to Many relationship
-- Grades A,B,C,E

-- insert into enrollments (studentid, courseid, grade) values (1,1,'A');
-- insert into enrollments (studentid, courseid, grade) values (1,2,'B');
-- insert into enrollments (studentid, courseid, grade) values (1,3,'E');

-- insert into enrollments (studentid, courseid, grade) values (2,1,'A');
-- insert into enrollments (studentid, courseid, grade) values (2,2,'A');

--Delete from Enrollments where EnrollmentId = 2;

