use SWCCorp
go


select *
from Employee as e
	inner join PayRates as pr on e.EmpID = pr.EmpID
where ManagerID = 11

update pr
	set YearlySalary = YearlySalary + 1000
from Employee as e
	inner join PayRates as pr on e.EmpID = pr.EmpID
where ManagerID = 11

update pr
	set YearlySalary = YearlySalary + 1000
from Employee as e
	inner join PayRates as pr on e.EmpID = pr.EmpID
where ManagerID = 11 and YearlySalary is not null

use
Movies
go

insert into Movies (MovieTitle, RunningTime, Rating)
Values
	('A-List Explorers',96,'PG-13'),
	('Bonker Bonzo',75,'G'),
	('Chumps to Chumps',75,'PG-13'),
	('Dare or Die',110,'R'),
	('EeeeGhads',88,'G')

select * from Movies

delete Movies
where RunningTime > 107

use
SWCCorp
go

delete e
from Employee e
	inner join Location as l on e.LocationID = l.LocationID
where l.City = 'Chicago'

select *
from Employee e
	inner join Location as l on e.LocationID = l.LocationID
	where l.City = 'Chicago'

select *
from Location

insert into Location(LocationID,Street, City,[State])
Values(3,'55 WildWind', 'Chicago', 'IL')

