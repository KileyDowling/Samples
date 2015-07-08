use Northwind
go

select *
from EmployeeTerritories et
	inner join Territories t
	on et.TerritoryID = t.TerritoryID
	inner join Employees e
	on et.EmployeeID = e.EmployeeID

select c.CompanyName,o.OrderDate, p.ProductName, c.Country
from Orders o
	inner join Customers c
	on o.CustomerID = c.CustomerID
	inner join [Order Details] od
	on o.OrderID = od.OrderID
	inner join Products p
	on od.ProductID = p.ProductID
where c.Country = 'USA'

select *
from [Order Details] od
	inner join Products p
	on od.ProductID = p.ProductID
where p.ProductName  = 'Chai'


