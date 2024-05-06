--3.
-- Create a trigger that blocks a deletion of book if 
-- this book is top seller
create trigger CheckBookForDelete
on Books for delete
as
begin
	-- 1
	declare @delBookId int;
	declare @bestBookId int;
	declare @maxSalesNum int;

	-- 2
	select @delBookId = Id from deleted;

	-- 3
	declare @buffTable table(
		BookId int,
		Quantity int
	);

	-- 4
	insert @buffTable 
		select b.Id, sum(s.Quantity)
		from Books b inner join Sales s
		on b.Id = s.BookId
		group by b.Id;

	-- 5
	select @maxSalesNum = max(buff.Quantity)
	from @buffTable buff;

	-- 6
	select @bestBookId = buff.BookId
	from @buffTable buff
	where buff.Quantity = @maxSalesNum;

	-- 7 
	if(@delBookId = @bestBookId)
	begin
		print 'The book is top seller';
		print 'Top sellers deletion is prohibitet';
		rollback transaction;
	end
	else
	begin
		print 'Book can be deleted';
	end
end;
go
--
delete from Books where Id = 1;
go
--
select * from Books;
go
--
select * from Sales;
go