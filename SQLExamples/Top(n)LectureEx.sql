DECLARE @TotalToBeDeleted int

DECLARE @NumberToDeleteAtOneTime int
SET @NumberToDeleteAtOneTime = 10

select @TotalToBeDeleted = Count(*)
from CurrentProducts
where ToBeDeleted = 1

WHILE(@TotalToBeDeleted > 0)
begin
	print 'deleting a batch'
	delete top(@NumberToDeleteAtOneTime)
	from CurrentProducts
	where ToBeDeleted  = 1

end