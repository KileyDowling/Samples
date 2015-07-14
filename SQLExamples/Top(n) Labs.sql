/*Database Labs for TOP(n) queries

1.	Find the oldest two employees in the employee table.

2. 	Find the 6 largest grants in the grant table, include ties.

3.  Display the 10 most expensive single day trips found in the
	CurrentProducts table (Category = No-Stay). */

	select top(2) *
	from Employee
	order by HireDate 

	select top(6) with ties *
	from [Grant]
	order by Amount desc

	select top(10) *
	from CurrentProducts
	where Category = 'Medium-Stay'
	order by RetailPrice desc

	select * from CurrentProducts

