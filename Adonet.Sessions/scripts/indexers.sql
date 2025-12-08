use Learning;

SELECT * FROM Students;

INSERT INTO Students (FirstName, LastName, Dob, Active, Semseter, Email)
VALUES ('Amit', 'Kumar', '2000-01-15', 1, 3, 'Amit.kumar@example.com');

-- Two types of indexes: Clustered and Non-Clustered
-- Clustered Index: It sorts and stores the data rows in the table based on the key values.

-- CREATE CLUSTERED INDEX IDX_Students_LastName
-- ON Students (LastName);

CREATE NONCLUSTERED INDEX IDX_Students_Email
ON Students (Email);

CREATE NONCLUSTERED INDEX IDX_Students_FirstName
ON Students (FirstName);

select * from Students
WHERE Email = 'Amit.kumar@example.com';