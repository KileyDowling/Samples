-- aggregates
use SWCCorp
go

--lecture ex
select Count(Amount) As NumOfGrants
from [grant] g
where g.EmpID is not null

-- count all grants, count all grants with an empID
select Count(*) from [grant]
select Count(EmpID) from [grant]

select g.EmpID, SUM(Amount) as SumByEmpID
from [grant]  g
where EmpID is not null
group by EmpID

select EmpId, Count(Amount) as NumOfGrantsByEmp
from [Grant]
where EmpID is not null
group by EmpID
order by NumOfGrantsByEmp desc

/* select EmpId, GrantName, Count(Amount) as NumOfGrantsByEmp
from [Grant]
where EmpID is not null
group by EmpID, GrantName
order by GrantName */

select Avg(Amount) as AvgOfAllGrants
from [grant]

select Sum(Amount) as SumOfAllGrants
from [grant]
where EmpID is not null


-- Find the Max, Min, and Average Grant amount by Employee ID
select Max(Amount) as MaxAmount
from [Grant]
group by EmpID

select Min(Amount) as MinAmount
from [Grant]
group by EmpID

select Avg(Amount) as AvgAmount
from [Grant]
group by EmpID

-- place them all in the same table
select EmpID, Count(Amount) as NumOfGrantsByEmp, Avg(Amount) as AvgAmount, Max(Amount) as MaxAmount, Min(Amount) as MinAmount
from [Grant]
where EmpID IS NOT NULL
group by EmpID
order by NumOfGrantsByEmp  desc

select SUM(Amount) as SumOfAllGrants, Count(Amount) as NumOfGrantsByEmp, Avg(Amount) as AvgAmount, Max(Amount) as MaxAmount, Min(Amount) as MinAmount
from [Grant]
where EmpID IS NOT NULL
order by NumOfGrantsByEmp  desc

select e.EmpID, e.FirstName, e.LastName, MAX(Amount) as MaxGrant
from [grant] g
	inner join Employee e on g.EmpID = e.EmpID
group by e.EmpID, e.FirstName, e.LastName
order by MaxGrant desc