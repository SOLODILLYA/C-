create proc ShowAllBarbersNames
as
begin
	select 
		p.PersonName as 'Barber`s Name'
	from 
		Barbers b, Person p
	where
		b.PersonId = p.Id;
end;
go
--
exec ShowAllBarbersNames;
go

create proc ReturnSeniorBarbers
as
begin
	select 
		p.PersonName as 'Barber`s name',
		p.PersonPhone as 'Barber`s phone',
		p.PersonEmail as 'Barber`s email',
		b.StartDate as 'Barber`s Start Date',
		b.BirthDate as 'Barber`s Birthday',
		pos.PositionName as 'Position',
		g.GenderName as 'Gender'
	from
		Barbers b, Person p, Positions pos, Genders g
	where	
		b.PersonId = p.Id and b.GenderId = g.Id 
		and b.PositionId = pos.Id 
		and pos.PositionName = 'Senior-Barber'
end;
go

exec ReturnSeniorBarbers;
go

create proc ReturnShavingBarbers
as
begin
	select 
		p.PersonName as 'Barber`s name',
		p.PersonPhone as 'Barber`s phone',
		p.PersonEmail as 'Barber`s email',
		b.StartDate as 'Barber`s Start Date',
		b.BirthDate as 'Barber`s Birthday',
		pos.PositionName as 'Position',
		g.GenderName as 'Gender',
		s.ServiceName as 'Service',
		s.Duration as 'Service Duration',
		s.Price as 'Service Price'
	from
		Barbers b, Person p, Positions pos, Genders g, Services s
	where	
		b.PersonId = p.Id 
		and b.GenderId = g.Id 
		and b.PositionId = pos.Id 
		and s.BarberId = b.Id
		and s.ServiceName = 'Beard Shaving'
end;
go

exec ReturnShavingBarbers;
go

create proc ReturnBarbersByService
	(@serviceName nvarchar(100))
as
begin
	select 
		p.PersonName as 'Barber`s name',
		p.PersonPhone as 'Barber`s phone',
		p.PersonEmail as 'Barber`s email',
		b.StartDate as 'Barber`s Start Date',
		b.BirthDate as 'Barber`s Birthday',
		pos.PositionName as 'Position',
		g.GenderName as 'Gender',
		s.ServiceName as 'Service',
		s.Duration as 'Service Duration',
		s.Price as 'Service Price'
	from
		Barbers b, Person p, Positions pos, Genders g, Services s
	where	
		b.PersonId = p.Id 
		and b.GenderId = g.Id 
		and b.PositionId = pos.Id 
		and s.BarberId = b.Id
		and s.ServiceName = @serviceName
end;
go

exec ReturnBarbersByService 'Beard Shaving';
go

create proc ReturnBarbersWorkingMoreThan
	(@years int)
as
begin
	select 
		p.PersonName as 'Barber`s name',
		p.PersonPhone as 'Barber`s phone',
		p.PersonEmail as 'Barber`s email',
		b.StartDate as 'Barber`s Start Date',
		b.BirthDate as 'Barber`s Birthday',
		pos.PositionName as 'Position',
		g.GenderName as 'Gender'
	from
		Barbers b, Person p, Positions pos, Genders g
	where	
		b.PersonId = p.Id and b.GenderId = g.Id 
		and b.PositionId = pos.Id 
		and b.StartDate < getdate() - 365 * @years
end
go

exec ReturnBarbersWorkingMoreThan 1;
go

create proc BarbersNumber
as
begin
	select 
		count(pos.Id) as 'Number of Barbers',
		pos.PositionName as 'Position'
	from 
		Positions pos, Barbers b
	where 
		pos.PositionName IN ('Senior-Barber', 'Junior-Barber')
		and pos.Id = b.PositionId
	group by
		pos.PositionName
end;
go

exec BarbersNumber;
go


create proc RegularCustomers
	@visitCount int
as
begin
	select 
        p.PersonName AS 'Name',
        p.PersonPhone AS 'Phone',
        p.PersonEmail AS 'Email'
    from 
       Customers c
        JOIN ArchiveOfVisits a ON c.Id = a.CustomerId
        JOIN Person p ON c.PersonId = p.Id
    group by
        p.PersonName, p.PersonPhone, p.PersonEmail
    having 
        COUNT(a.Id) >= @VisitCount
end;
go

exec RegularCustomers 1;
go

create trigger PreventBarberDeletionTrigger
on Barbers
instead of delete 
as
begin
	declare @posId int;
	select @posId = Id 
	from Positions 
	where PositionName = 'Chief-Barber';
    if (select count(*) from Barbers where positionId = @posId) <= 1
    begin
        if exists (select * from deleted where positionId = @posId)
        begin
			print 'Only one chief barber is left';
            rollback transaction;
        end
    end
	else
	begin
		delete from Barbers where Id IN (select Id from deleted);
	end;

end;
go

delete from Barbers where Id = 15;
go


create trigger CheckBarberAge
on Barbers
instead of insert
as
begin
    if exists (
        select * 
        from inserted 
        where datediff(year, BirthDate, getdate()) < 21
    )
    begin
        print 'Cannot add barbers younger than 21 years old.';
        rollback transaction;
    end
	else
	begin
		insert into Barbers (PersonId, StartDate, BirthDate, PositionId, GenderId) 
        select PersonId, StartDate, BirthDate, PositionId, GenderId
        from inserted;
	end
end;
go

insert into Barbers 
(PersonId, StartDate, BirthDate, PositionId, GenderId)
values
	(1, '2/2/2000', '2/2/2000', 2,2 );
go

insert into Barbers 
(PersonId, StartDate, BirthDate, PositionId, GenderId)
values
	(1, '2/2/2000', '2/2/2015', 2,2 );
go