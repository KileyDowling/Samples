/*
1. 	In Northwind, print a list of products, the value of the stock (unit price * quantity) 
	and sort it by the value from most to least
	
2. 	In Northwind, get a list of employees with a column called NameLastFirst which should 
	be formatted as LastName, FirstName.  Sort it alpha by last name then first name
	
3.	Take your query from #1 and also create columns to value the stock in Canadian Dollars, 
	Japanese Yen, Euros, and Pesos given today’s exchange rates */


	use Northwind
	go

	select p.ProductName, (p.UnitsInStock * p.UnitsInStock) as ValueOfStock
	from Products p
	order by ValueOfStock desc


	select e.LastName + ', '+ e.FirstName as [NameLastFirst]
	from Employees e 
	order by  e.LastName, e.FirstName

	select p.ProductName, (p.UnitsInStock * p.UnitsInStock) as ValueOfStock,
		(p.UnitsInStock * p.UnitsInStock * 1.27) As CanadianDollars,  (p.UnitsInStock * p.UnitsInStock * 121.17) As JapeneseYen,  (p.UnitsInStock * p.UnitsInStock * .91) As Euros,  (p.UnitsInStock * p.UnitsInStock * 15.8) As Pesos
	from Products p
	order by ValueOfStock desc