use Learning;

Create Table Students
(
	StudentId int primary key identity(1,1),
	FirstName nvarchar(50),
	-- nvarchar supports Unicode characters
	LastName nvarchar(50),
	Dob date,
	-- YYYY-MM-DD
	Active bit
	-- 0 or 1
)

Create table Enrollments
(
	EnrollmentId int primary key identity(1,1),
	StudentId int not null,
	CourseId int not null,
	Grade nchar(1) not null
)

Create table Courses
(
	CourseId int primary key identity(1,1),
	CourseName nvarchar(100),
	Credits int not null
)

-- Updating existing column of existing table.
Alter table Students Alter Column FirstName nvarchar(50) Not Null
Alter table Students Alter Column Dob date Not Null

-- Adding a new colum to existing table
Alter table Students Add Semseter int not null

ALTER TABLE Enrollments ADD CONSTRAINT Unique_Student_Course UNIQUE (studentId, courseId);

ALTER TABLE Students Add Email nvarchar(100) DEFAULT NULL;

CREATE TABLE Scores
(
	ScoreId int primary key identity(1,1),
	StudentId int not null,
	CourseId int not null,
	ScoreValue int not null DEFAULT 0,
	CONSTRAINT FK_Student FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
	CONSTRAINT FK_Course FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
)