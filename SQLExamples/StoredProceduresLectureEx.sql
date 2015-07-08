Declare @CustomerID nchar(5)
Set @CustomerID = 'BOTTM'

Select *
from Customers
where CustomerID =@CustomerID

select *
from Orders
where CustomerID = @CustomerID

Create procedure GetAllCustomers As
Select * 
From customers
Go

Create procedure GetCustomerOrdersByDate
(
	@CustomerID nchar(5),
	@MinOrderDate datetime,
	@MaxOrderDate datetime
	) As
	Select *
	from Customers
	where CustomerID = @CustomerID

	Select * 
	From Orders
	Where CustomerID = @CustomerID
		AND	OrderDate BETWEEN @MinOrderDate and @MaxOrderDate

	GO

	exec GetCustomerOrdersByDate 'BOTTM', '1/1/1997', '12/31/1997'

	Declare @CustomerID nchar(5)
	Set @CustomerID = 'BOTTM'
	exec GetCustomerOrdersByDate @CustomerID, '1/1/1997', '12/31/1997'

	
	exec GetCustomerOrdersByDate @MaxOrderDate='12/31/1997',@CustomerID='BOTTM', @MinOrderDate=
	'1/1/1997'

	ALTER procedure GetAllCustomers AS
	Select * 
	from Customers
	order by CompanyName

	exec GetAllCustomers