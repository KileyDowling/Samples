Select *
From CurrentProducts

Create procedure GetProductListByCategory
(
	@Category varchar(20)
) As

Select *
From CurrentProducts
Where Category = @Category

GO


DECLARE @Category varchar(20)
SET @Category = 'No-Stay'

EXEC GetProductListByCategory @Category

Select e.EmpID, e.FirstName, e.LastName, g.GrantName, g.Amount
From [Grant] g
inner join Employee e
on e.EmpID = g.EmpID


Alter procedure GetGrantsByEmployee
(
@LastName varchar(20)
) As

Select e.EmpID, e.FirstName, e.LastName, g.GrantName, g.Amount
From [Grant] g
inner join Employee e
on e.EmpID = g.EmpID
where e.LastName = @LastName

go

Declare @LastName varchar(20)
Set @LastName = 'Brown'
exec GetGrantsByEmployee @LastName


Declare @LastName varchar(20)
Set @LastName = 'Lonning'
exec GetGrantsByEmployee @LastName


Alter procedure UpdateAndInsertGrantTable (
@GrantID  char(3),
@GrantName nvarchar(50),
@EmpID int,
@Amount smallmoney
) As
update [Grant]
set GrantName = @GrantName,EmpID = @EmpID, Amount = @Amount
where GrantID = @GrantID
select * 
from [Grant]
where GrantID = @GrantID
GO

select * 
from [Grant]
where GrantID = 001

Declare @GrantID  char(3)
Set @GrantID = '001';
exec UpdateAndInsertGrantTable @GrantID,'One More', 2, 500.00