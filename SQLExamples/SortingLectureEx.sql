use SWCCorp
go

select EmpID, LastName, FirstName, HireDate, City, l.[State]
from Employee e
	inner join Location l on l.LocationID=e.LocationID
order by l .[State], l.city, LastName

select *
from Employee
order by [status]

SELECT ProductName, RetailPrice, Round((RetailPrice * 1.07),2) AS PriceWithTax
FROM CurrentProducts

SELECT FirstName + ' ' +  LastName AS [Empleyee Name], HireDate,
	CONVERT (NVARCHAR, HireDate, 1),
	CONVERT (NVARCHAR, HireDate, 101),
	CONVERT (NVARCHAR, HireDate, 103),
	CONVERT (NVARCHAR, HireDate, 106),
	CONVERT (NVARCHAR, HireDate, 107),
	CONVERT (NVARCHAR, HireDate, 110)
FROM Employee
order by LastName
