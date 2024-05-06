--Random Fill Table OrderItems
create proc RandomFillDataItems
as
begin
	declare @count int;
	set @count = 5;
	declare @it int;
	declare @j int;
	set @it = 211770;
	set @j = 0;
	declare @productId int;
	declare @amount int;
	while @it < 211787
	begin
		set @it = @it + 1; 
		set @j = 0;
		while @j < @count
		begin
			set @j = @j + 1;
			set @productId = floor(rand() * 6 + 1);
			set @amount = floor(rand() * 5 + 1);
			insert into OrderItems
				(Amount, ProductId, OrderId)
			values
				(@amount, @productId, @it)
		end;
	end;
end;
go

exec RandomFillDataItems;
go