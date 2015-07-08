use Northwind
go

select * 
from Products

select *
from Products
where ProductName = 'Queso Cabrales'

select p.ProductName, p.UnitsInStock
from Products p
where ProductName IN('Laughing Lumberjack Lager','Outback Lager','Ravioli Angelo')


select *
from Orders
where CustomerID = 'QUEDE'

SELECT *
FROM Orders
WHERE Freight > 100

SELECT *
FROM Orders	
WHERE Freight BETWEEN 10 AND 20

SELECT *
FROM Customers
WHERE CompanyName LIKE 'A%'

-- % any number of char, _ exactly 1 char
SELECT *
FROM Customers
WHERE CompanyName LIKE '_A%'

--starts w/ A or B w/ any other char after
SELECT *
FROM Customers
WHERE CompanyName LIKE '[AB]%'

-- starts w/ A to K w/ any other char after
SELECT *
FROM Customers
WHERE CompanyName LIKE '[A-K]%'

-- starts w/ A where N is not the next char
SELECT *
FROM Customers
WHERE CompanyName LIKE 'A[^N]%'

-- starts w/ A where N-Z is not the next char
SELECT *
FROM Customers
WHERE CompanyName LIKE 'A[^N-Z]%'