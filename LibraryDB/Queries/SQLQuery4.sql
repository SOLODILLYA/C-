-- 2 Set of procedures to fill tables
-- 2.1
create proc AddNewAuthor
	@personName nvarchar(100),
	@personSurname nvarchar(100)
as
begin
	insert into Authors values (@personName, @personSurname);
end;
go
-- 2.2
create proc AddNewBook
	@title nvarchar(100),
	@genreId int,
	@publisherId int,
	@publishYear int,
	@pages int,
	@price money
as
begin
	insert into Books values 
		(@title, @genreId, @publisherId, @publishYear, @pages, @price);
end;
go
-- 2.3
create proc AddNewBooks_Authors
	@bookId int,
	@authorId int
as
begin
	insert into Books_Authors values (@bookId, @authorId);
end;
go
-- 2.4 
create proc AddNewGenre
	@genereName nvarchar(100)
as
begin
	insert into Genres values (@genereName);
end;
go
-- 2.5
create proc AddNewGroup
	@groupName nvarchar(100)
as
begin
	insert into Groups values (@groupName);
end;
go
-- 2.6
create proc AddNewRecord
	@readerId int,
	@bookId int,
	@librarianId int,
	@issueDate datetime
as
begin
	insert into Journal values 
		(@readerId, @bookId, @librarianId, @issueDate, NULL);
end;
go
--2.7
create proc AddNewLibrarian
	@personName nvarchar(100),
	@personSurname nvarchar(100),
	@phone nvarchar(100)
as
begin
	insert into Librarians values (@personName, @personSurname, @phone);
end;
go
--2.8
create proc AddNewPublisher
	@publisherName nvarchar(100)
as
begin
	insert into Publishers values (@publisherName);
end;
go
--2.9
create proc AddNewReader
	@personName nvarchar(100),
	@personSurname nvarchar(100),
	@phone nvarchar(100),
	@groupId int
as
begin
	insert into Readers values (@personName, @personSurname, @phone, @groupId);
end;
go
-- 3 Procedure to fill base tables with test data
create proc FillBaseTables
as
begin
	declare @n int;
	declare @it int;
	set @n = 5;
	set @it = 0;

	while @it < @n
	begin
		set @it = @it + 1;
		-- 1 - Genres (5)
		declare @genereName nvarchar(100);
		set @genereName =  'Genre-' + convert(nvarchar, @it)
		exec AddNewGenre @genereName;
		-- 2 - Groups (5)
		declare @groupName nvarchar(100);
		set @groupName =  'Group-' + convert(nvarchar, @it)
		exec AddNewGroup @groupName;
		-- 3 - Publishers (5)
		declare @publisherName nvarchar(100);
		set @publisherName =  'Publisher-' + convert(nvarchar, @it)
		exec AddNewPublisher @publisherName;
	end;
end;
go 

exec FillBaseTables;
go