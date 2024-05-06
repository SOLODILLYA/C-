-- Random fill of table Orders
create proc RandomFillData
as
begin
	declare @count int;
	set @count = 5;
	declare @it int;
	declare @j int;
	set @it = 0;
	set @j = 0;
	declare @clientId int;
	declare @managerId int;
	declare @courierId int;
	declare @startDate datetime;
	declare @statusId int;
	while @it < @count
	begin
		set @it = @it + 1;
		set @clientId = floor(rand() * 3 + 1);
		set @managerId = floor(rand() * 3 + 1);
		set @courierId = floor(rand() * 3 + 1);
		set @statusId = floor(rand() * 5 + 1);
		set @startDate = dateadd(day,  -1 * floor(rand() * 10 + 1), getdate());
		--
		insert into Orders
			(ClientId, ManagerId, CourierId, StartDate, StatusId)
		values
			(@clientId, @managerId, @courierId, @startDate, @statusId)
	end;
end;
go
--
exec RandomFillData;
go

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