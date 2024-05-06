-- 1. Scalar functions
create function AddNumbers(@x real, @y real)
returns real 
begin
	return (@x + @y);
end;
go
--
-- 1.1
select dbo.AddNumbers(15,25) as 'Sum of two numbers';
go
-- 1.2
declare @b real, @a real, @c real;
set @a = 111;
set @b = 222;
set @c = dbo.AddNumbers(@a, @b);
--
print @a;
print '+';
print @b;
print '=';
print @c;
--
print convert(nvarchar, @a) + ' + ' + convert(nvarchar, @b) + ' = ' + convert(nvarchar, @c);
go
-- 2. Table Functions
create function FilterMessages(@categoryName nvarchar(50))
returns table
as
	return (
		select
			m.Content as 'Message category'
		from
			Messages m 
			inner join
			Categories c
		on
			m.CategoryId = c.Id
		where
			c.Name = @categoryName
	);
go
--
select * from dbo.FilterMessages('Category-1');
select * from dbo.FilterMessages('Category-2');
select * from dbo.FilterMessages('Category-3');
go