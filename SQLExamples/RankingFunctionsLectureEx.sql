use SWCCorp
go

/* Based on what we have learned, can you write a query against
 the employee table to display every third hire?  */
	select  * from (
		select LastName, FirstName, HireDate,
		ROW_number() OVER(ORDER BY HireDate DESC) AS [HireNumnber]
	from Employee) as Hires
	Where HireNumnber % 3 = 0

--notes:

select GrantName, Amount,
	RANK() OVER(ORDER BY Amount DESC) AS [RANK],
	DENSE_RANK() OVER(ORDER BY Amount DESC) AS [DENSERANK],
	ROW_NUMBER() OVER(ORDER BY Amount DESC) AS [ROWNUMBER],
	NTILE(3) OVER(ORDER BY Amount DESC) AS [GrantGroup]
from [Grant]


select  * FROM (
Select GrantName, Amount,
	RANK() OVER(ORDER BY Amount DESC) AS [RANK],
	DENSE_RANK() OVER(ORDER BY Amount DESC) AS [DENSERANK],
	ROW_NUMBER() OVER(ORDER BY Amount DESC) AS [ROWNUMBER],
	NTILE(3) OVER(ORDER BY Amount DESC) AS [GrantGroup]
from [Grant]) as RankedGrants
where [GrantGroup] < 3