/* 
1. Use a ranking function to assign ranked values for each record in the employee table based on HireDate. 
The most recent hire date should be rank 1 and each distinct older date should add one without any gaps.

2.Join the Employee and PayRatestable together and display 
the FirstName, LastName, YearlySalary, and the rank from highest to lowest of the salary. 
Limit this to the first two ranks. */

--EX #1
	select  LastName, FirstName, HireDate,
		DENSE_RANK() OVER(ORDER BY HireDate DESC) AS [DENSERANK]
	from Employee


--EX #2
		select * from ( 
			select FirstName, LastName, YearlySalary,
				DENSE_RANK() over(order by YearlySalary desc) as [DENSERANK]
		from Employee e
			inner join PayRates pr on e.EmpID = pr.EmpID) as [RankedSalary]
		where [DENSERANK] < 3

