
create trigger CheckSaleTrigger
on Sales for insert
as
begin
	declare @insDate date;
	select @insDate = Published from 
		Books b, inserted i
	where 
		b.Id = i.BookId;
	if(@insDate >= getdate() - 7)
	begin
		print 'This book is new, adding of sale will be blocked';
		rollback transaction;
	end;
	else
	begin
		print 'Sale is successfully added to Sales';
	end;
end;
go

insert into Books values 
	('ToBlock', 35, getdate(), 35, 3);
go

declare @bookId int;
select @bookId = Id from Books b where b.Title = 'ToBlock'

insert into Sales values
	(getdate(), 2, @bookId);
go

select * from Sales;
go

insert into Books values 
	('NotToBlock', 35, getdate() - 14, 35, 3);
go

declare @bookId int;
select @bookId = Id from Books b where b.Title = 'NotToBlock'
insert into Sales values
	(getdate(), 2, @bookId);
go

select * from Sales;
go