WITH EmployeeHierarchy AS
(
	-- BASE case
	SELECT
		EmployeeID,
		LastName,
		FirstName,
		ReportsTo,
		1 as HierarchyLevel

	FROM Employees
	where ReportsTo is null

	union all

	-- RECURSIVE step
	select
		e.EmployeeID,
		e.LastName,
		e.FirstName,
		e.ReportsTo,
		eh.HierarchyLevel +1 as HierarchyLevel
	from Employees e
		inner join EmployeeHierarchy eh on
			e.ReportsTo = eh.ReportsTo

) 

select * 
from EmployeeHierarchy
order by HierarchyLevel, LastName, FirstName