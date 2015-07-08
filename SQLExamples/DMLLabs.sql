use SWCCorp
go

select *
from Employee

update Employee
	set LastName = 'Green'
where EmpID = 11

update e
	set Status = 'Internal'
from Location l
	inner join Employee e on l.LocationID = e.LocationID
where l.City = 'Seattle'

select *
from Employee
inner join Location on Employee.LocationID = Location.LocationID

update l
	set l.Street = '123 1st St'
from Location l
where l.LocationID = 1

update g
	set g.Amount = 25000
from [Grant] g
inner join Employee e on g.EmpID  = e.EmpID
where e.LocationID = 2


select *
from [Grant] g
inner join Employee e on g.EmpID  = e.EmpID

use
Movies
go

select * from Movies

delete Movies
where Movies.Rating = 'G'

use SWCCorp
go

insert into MgmtTraining(ClassName,ClassDurationHours)
Values('One Two Step',120),
('Get Low',20)

select *
from MgmtTraining

update MgmtTraining
	set ClassName = 'Goodies'
where ClassID = 8

delete MgmtTraining
where ClassDurationHours = 20
