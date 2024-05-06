--Fill of Sales Table
create proc FillSales
as
begin
	declare @bookId int --> [1;3]
	declare @quantity int --> [1;5]
	declare @sold date --> [01.03.2024; getdate()]
	--
	declare @amount int;
	set @amount = 30;
	declare @it int;
	set @it = 0;
	while @it < @amount
	begin
		set @it = @it + 1;
		set @bookId = floor(rand() * 3 + 1);
		set @quantity = floor(rand() * 5 + 1);
		set @sold = getdate() - floor(rand() * 5 + 1);
		--
		insert into Sales
			(Sold, Quantity, BookId)
		values
			(@sold, @quantity, @bookId)
	end;
end;
go

exec FillSales;
go;

select * from Sales;