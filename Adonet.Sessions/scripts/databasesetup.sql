-- ============================================
--   SCHOOL DATABASE - SQLITE VERSION
-- ============================================

-- Drop tables if they already exist
DROP TABLE IF EXISTS Enrollments;
DROP TABLE IF EXISTS Students;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Department;

-- ============================================
--   TABLES
-- ============================================

-- 1) Students Table
CREATE TABLE Students (
    StudentId   INTEGER PRIMARY KEY AUTOINCREMENT,
    FirstName   TEXT NOT NULL,
    LastName    TEXT NOT NULL,
    BirthDate   TEXT,               -- SQLite stores dates as TEXT
    Email       TEXT UNIQUE
);

-- 2) Courses Table
CREATE TABLE Courses (
    CourseId    INTEGER PRIMARY KEY AUTOINCREMENT,
    CourseName  TEXT NOT NULL,
    Credits     INTEGER NOT NULL CHECK (Credits > 0)
);

-- 3) Enrollments Table (Many-to-Many)
CREATE TABLE Enrollments (
    EnrollmentId INTEGER PRIMARY KEY AUTOINCREMENT,
    StudentId    INTEGER NOT NULL,
    CourseId     INTEGER NOT NULL,
    Grade        TEXT,
    FOREIGN KEY (StudentId) REFERENCES Students(StudentId),
    FOREIGN KEY (CourseId) REFERENCES Courses(CourseId)
);

CREATE TABLE Department (
    Id Integer primary key AUTOINCREMENT,
    DName Text
);

-- ============================================
--   SAMPLE DATA
-- ============================================

-- Insert Students
INSERT INTO Students (FirstName, LastName, BirthDate, Email) VALUES
('John',  'Doe',   '2002-05-14', 'john.doe@example.com'),
('Anna',  'Smith', '2001-09-22', 'anna.smith@example.com'),
('David', 'Lee',   '2003-01-30', 'david.lee@example.com');

-- Insert Courses
INSERT INTO Courses (CourseName, Credits) VALUES
('Mathematics', 3),
('Computer Science', 4),
('History', 2);

-- Insert Enrollments
INSERT INTO Enrollments (StudentId, CourseId, Grade) VALUES
(1, 1, 'A'),
(1, 2, 'B'),
(2, 1, 'A'),
(2, 3, 'C'),
(3, 2, 'B');


-- Insert Departments
INSERT INTO Department (Id, DName) Values
(1, 'Science'),
(2, 'Maths'),
(3, 'Biology');