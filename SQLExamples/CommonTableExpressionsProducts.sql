WITH CategoryAndNumberOfProducts AS
(
	Select
		CategoryID,
		CategoryName,
		(Select Count(1) from Products p
			where p.CategoryID = c.CategoryID) as NumberOfProducts
		From Categories c
), 
ProductsOverTenDollars AS
(
	Select
		ProductID,
		CategoryID,
		ProductName,
		UnitPrice
	From Products p
	where UnitPrice > 10.0
)

select c.CategoryName, c.NumberOfProducts, p.ProductName, p.UnitPrice
from ProductsOverTenDollars p
	inner join CategoryAndNumberOfProducts c on p.CategoryID = c.CategoryID
order by NumberOfProducts desc, CategoryName, UnitPrice desc, ProductName
