use SWCCorp
go

select * 
from [Grant]
order by GrantName

select *
from Employee
order by HireDate desc

select p.ProductName, p.Category, p.RetailPrice
from CurrentProducts  p
order by p.RetailPrice 

select *
from [Grant] g
order by g.Amount desc, g.GrantName

select e.FirstName, e.LastName, l.City
from Employee e
	full outer join location l on e.LocationID = l.LocationID
order by City
