use
Northwind
go

SELECT OrderId, CustomerID, Orders.EmployeeID, LastName, FirstName
from Orders 
	Left Join Employees
		on Orders.EmployeeID = orders.EmployeeID

use
SWCCorp
go

SELECT City, LastName
From Employee
	right join Location
	on Location.LocationID = Employee.LocationID

SELECT City, LastName
From Employee
	full outer join Location
	on Location.LocationID = Employee.LocationID

use Northwind
go

SELECT OrderID, CustomerID, Orders.EmployeeID, LastName, FirstName
From Orders
	left join Employees
		on orders.EmployeeID = Employees.EmployeeID
		where orders.EmployeeID is NULL OR LastName Like 'S%'