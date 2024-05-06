create trigger AddToArchive
on Sales
after insert
as
begin
    insert into History (SalesId, EmployeeId, CustomerId, TotalPrice)
        select Id, EmployeeId, CustomerId, TotalPrice 
        from inserted;
    print 'AddToArchive trigger worked';
end;
go

insert into Sales
    (EmployeeId, CustomerId, TotalPrice)
values (1, 2, 123);
go

create trigger MoveToArchive
on Products
instead of update
as
begin
    insert into Archive (ProductTypeId, ProductionPrice, ManufacturerId, SalePrice)
    select i.ProductTypeId, i.ProductionPrice, i.ManufacturerId, i.SalePrice 
    from inserted i
    join deleted d on i.Id = d.Id
    where i.Quantity = 0;

    delete from Products
    where Id in (
        select i.Id
        from inserted i
        where i.Quantity = 0
    );

    update Products
    set ProductTypeId = i.ProductTypeId,
        Quantity = i.Quantity,
        ProductionPrice = i.ProductionPrice,
        ManufacturerId = i.ManufacturerId,
        SalePrice = i.SalePrice
    from inserted i
    where Products.Id = i.Id AND i.Quantity > 0;
end;
go

update Products set Quantity = 0 where Id = 2;
go


create trigger UserExistsTrigger
on Customers instead of insert
as
begin
    if exists (
        select 1
        from Customers c
        join inserted i on (c.ClienteEmail = i.ClienteEmail or c.ClientName = i.ClientName)
                       and c.Id!= i.Id
    )
    begin
        print 'User already exists'
        ROLLBACK TRANSACTION;
    end
    else
    begin
        INSERT INTO Customers (ClientName, ClienteEmail, ClientSexId, Discount, Subscription)
        select ClientName, ClienteEmail, ClientSexId, Discount, Subscription from inserted;
    end;
end;
go

insert into Customers (ClientName, ClienteEmail, ClientSexId, Discount, Subscription) values ('1', '1', 1, 1, 'False')
insert into Customers (ClientName, ClienteEmail, ClientSexId, Discount, Subscription) values ('1', '1', 1, 1, 'False')
go

create trigger UserDeletionTrigger
on Customers instead of delete
as
begin
    print 'It is not allowed to delete customers';
    rollback transaction;
end;
go

delete from Customers where Id = 2;
go

create trigger EmployeeDeletionTrigger
on Employees instead of delete
as
begin
    if exists(select 1 from deleted where StartDate < '2015-01-01')
    begin
        print 'It is not allowed to delete employees hired before 2015';
        rollback transaction;
    end
end;
go

insert into Employees (EmployeeName, PositionId, StartDate, GenderId, Salary) values ('1', 1, '2000-01-01', 1, 123);
delete from Employees where id = 1;
go

create trigger CheckDiscountTrigger
on Sales instead of insert
as
begin
    declare @customerId int;
    declare @totalSales money;
    declare @newOrderSum money;

    select @customerId = CustomerId from inserted;
    select @totalSales = sum(TotalPrice) from Sales where CustomerId = @customerId;
    select @newOrderSum = TotalPrice from inserted;
    set @totalSales = @totalSales + @newOrderSum;

    if(@totalSales > 50000)
    begin
        print 'Total Sales are more than 50000, apply discount'
        insert into Sales (EmployeeId, CustomerId, TotalPrice)
            select EmployeeId, CustomerId, TotalPrice * 0.85 from inserted;
        update c 
        set 
            c.Discount = 15
        from 
            Customers c
        where 
            c.Id = @customerId;
    end;
    else
    begin
        print 'Total Sales are less than 50000, no discount'
        insert into Sales (EmployeeId, CustomerId, TotalPrice)
            select EmployeeId, CustomerId, TotalPrice from inserted;
    end;
end;
go

insert into Sales (EmployeeId, CustomerId, TotalPrice) 
    values (1, 2, 123);


insert into Sales (EmployeeId, CustomerId, TotalPrice) 
    values (1, 2, 123000);
go

create trigger ProhibitAddTrigger
on Products instead of insert
as
begin
    declare @manufacturerId int;
    declare @selectedManufacturer int;

    select @manufacturerId = Id from Manufacturer where ManufacturerName = 'Sport and Sun';
    select @selectedManufacturer = ManufacturerId from inserted;

    if(@manufacturerId = @selectedManufacturer)
    begin
        print 'It is unable to add products from this manufacturer';
        rollback transaction;
    end;
    else
    begin
        insert into Products(ProductTypeId, Quantity, ProductionPrice, ManufacturerId, SalePrice)
            select ProductTypeId, Quantity, ProductionPrice, ManufacturerId, SalePrice from inserted;
    end;
end;

insert into Products values 
    (1,2,123,2,1232)
go

create trigger CheckLastItemTrigger
on Products after update
as
begin
    declare @amount int;
    select @amount = Quantity from inserted;
    if(@amount = 1)
    begin
        print 'Trigger worked'
        insert into LastItems(ProductId)
        select Id 
        from inserted;
    end;
end;

update Products set Quantity = 1 where Id = 4;