-- Triggers - automatic server procedures dedicated 
-- to programm of additional actions in another tables,
-- which support or replace actions in target table
-- ====================================================
-- Examples:
-- ====================================================

-- 1. Trigger-Observer:
create trigger AddAuthorTrigger
on Authors after insert
as
begin
	print 'Number of rows addded: ' + convert(nvarchar, @@rowcount);
	declare @amount int;
	select @amount = count(Id) from Authors;
	print 'Total number of Authors: ' + convert(nvarchar, @amount);
end;
go

insert into Authors values ('Vasil Pupkin', '1992-01-01');

insert into Authors values ('Mikola Shubkin', '1992-03-04'),('Vasil Pupkin', '1992-01-01'),('Vasil Pupkin', '1992-01-01');
go
-- 2. Blocking trigger
-- Create a trigger to block creation of Book if it was written more than a month ago
create trigger CheckDateTrigger
on Books for insert
as
begin
	declare @insDate date;
	select @insDate = Published from inserted;
	if(@insDate <= getdate() - 30)
	begin
		print 'This book is not new, adding will be blocked';
		rollback transaction;
	end;
	else
	begin
		print 'Book is successfully added to Books';
	end;
end;
go
--
insert into Books values
	(32, 'Correct-Book-1', 555, '2024-03-01', 777, 3);
insert into Books values
	(33, 'InCorrect-Book-1', 555, '2024-01-01', 777, 3);
go

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

select * from Books;
go

insert into Sales values
	(getdate(), 2, 33);
go

insert into Books values 
	('NotToBlock', 35, getdate() - 14, 35, 3);
go

select * from Books;
go

insert into Sales values
	(getdate(), 2, 34);
go