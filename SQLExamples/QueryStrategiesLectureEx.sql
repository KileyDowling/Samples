--want to get the first, last, city, & state of corporate emp in WA

-- test 1st table logic
select * 
from Location

--test 2nd table w/ join
select *
from Location
	inner join Employee
	on Location.LocationID = Employee.LocationID

--test all tables w/ criteria
select *
from Location l
	inner join Employee e
	on l.LocationID = e.LocationID
where l.State = 'WA'

-- choose the fields
select e.FirstName, e.LastName, l.City, l.State
from Location l
	inner join Employee e
	on l.LocationID = e.LocationID
where l.State = 'WA'

--table aliasing, using the AS keyword; is option, can just say Location loc (above)
select FirstName, LastName, City, [State]
from Location as loc
	inner join Employee as emp
	on loc.LocationID = emp.LocationID
where loc.State = 'WA'

-- cross joins, don't have relatable field b/n tables, want to look for every combo b/n records in tables
Select *
From Employee
Where EmpID IN (1,2)

Select * from MgmtTraining

Select * 
From Employee
Cross Join MgmtTraining
Where EmpID IN (1,2)


-- unmatched records queries, which loc has no emp?
select *
from Location as l
	left outer join Employee as e
	on l.LocationID = e.LocationID
where e.LocationID	IS NULL
