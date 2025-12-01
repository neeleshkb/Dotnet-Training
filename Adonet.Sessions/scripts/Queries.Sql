use Learning;

select *
from Students;

select FirstName
from Students;

select *
from Students
where Dob BETWEEN '2000-11-01' and '2000-11-30';

select *
from Students
where LastName is null and Semseter >= 7;

select *
from Students
where Semseter BETWEEN 3 and 8;

select *
from Students
WHERE email like '%yahoo%';
-- contains yahoo anywhere in the email

select *
from Students
where email like 'John%';
-- starts with John


select *
from Students
where Semseter IN (3,4,5,6,7,8);

