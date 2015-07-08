select *
from Employee e
	cross join Location l

select *
from Employee e
	left join [Grant] g
	on g.EmpID = e.EmpID
	where g.GrantID is null