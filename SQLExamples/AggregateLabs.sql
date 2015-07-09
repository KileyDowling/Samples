use
Northwind
go
 
--1.Find the max unit price for each product by category 
select *
from Products
order by CategoryID, UnitPrice desc

select p.CategoryID, Max(p.UnitPrice) as MaxPriceOfProduuctsByCategory
from Products as p
group by CategoryID
order by MaxPriceOfProduuctsByCategory desc

--#2.We want to get some customer data, create lists of customers with the following attributes:
--	2A.Most orders submitted
select CompanyName, COUNT(OrderID) As NumOfOrders
from Customers c
	inner join Orders o on c.CustomerID = o.CustomerID
group by CompanyName
order by NumOfOrders desc

--  2B.Highest lifetime order total amount 
	-- hint, the Order table doesn’t have the total, you will need to join to order details and calculate it)

select CompanyName, Count(o.CustomerID) as NumOfOrders, od.OrderID, Round((SUM(UnitPrice * Quantity)* (1-Discount)), 2)As TotalSum
from Customers 
	inner join Orders o on c.CustomerID = o.customerID
	inner join [Order Details] od on o.OrderID= od.OrderID
group by CompanyName, od.OrderID, od.Discount
order by TotalSum desc


select CompanyName, Count(o.CustomerID) as NumOfOrders, od.OrderID, SUM(UnitPrice * Quantity) As TotalSum
from Customers c
	inner join Orders o on c.CustomerID = o.customerID
	inner join [Order Details] od on o.OrderID= od.OrderID
group by CompanyName, od.OrderID
order by TotalSum desc

--filtering data
use SWCCorp
go

select l.City, COUNT(e.EmpID) as NumOfEmp
from Employee e
	inner join Location l on e.LocationID = l.LocationID
group by  l.City
Having COUNT(EmpID) < 3