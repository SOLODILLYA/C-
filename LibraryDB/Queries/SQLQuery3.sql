-- 1. Start script to create full system of tables
create proc CreateBaseTables
as
begin
-- 1.1 Genres
	create table Genres(
		Id int not null primary key identity,
		GenereName nvarchar(100) not null unique
	);
-- 1.2 Publisher
	create table Publishers(
		Id int not null primary key identity,
		PublisherName nvarchar(100) not null unique
	);
-- 1.3 Librarians
	create table Librarians(
		Id int not null primary key identity,
		PersonName nvarchar(100) not null,
		PersonSurname nvarchar(100) not null,
		MobilePhone nvarchar(100) not null unique
	);
-- 1.4 Groups
	create table Groups(
		Id int not null primary key identity,
		GroupName nvarchar(100) not null unique
	);
-- 1.5 Readers
	create table Readers(
		Id int not null primary key identity,
		PersonName nvarchar(100) not null,
		PersonSurname nvarchar(100) not null,
		MobilePhone nvarchar(100) not null unique,
		GroupId int not null,
		constraint FK_Reader_To_Groups foreign key (GroupId) references Groups(Id)
	);
-- 1.6 Books
	create table Books(
		Id int not null primary key identity,
		Title nvarchar(100) not null,
		GenreId int not null,
		PublisherId int not null,
		PublishYear int not null,
		Pages int not null,
		Price money not null
		constraint FK_Book_To_Publisher foreign key (PublisherId) references Publishers(Id),
		constraint FK_Book_To_Genre foreign key (GenreId) references Genres(Id)
	);
-- 1.7 Authors
	create table Authors(
		Id int not null primary key identity,
		PersonName nvarchar(100) not null,
		PersonSurname nvarchar(100) not null
	);
-- 1.8 CrossTable -> Books_Authors
	create table Books_Authors(
		Id int not null primary key identity,
		BookId int not null,
		AuthorId int not null,
		constraint FK_Books foreign key (BookId) references Books(Id),
		constraint FK_Authors foreign key (AuthorId) references Authors(Id)
	);
-- 1.9 Journal
	create table Journal(
		Id int not null primary key identity,
		ReaderId int not null,
		BookId int not null,
		LibrarianId int not null,
		IssueDate datetime not null default getdate(),
		ReturnDate datetime null,
		constraint FK_Journal_To_Reader foreign key (ReaderId) references Readers(Id),
		constraint FK_Journal_To_Book foreign key (BookId) references Books(Id),
		constraint FK_Journal_To_Librarian foreign key (LibrarianId) references Librarians(Id),
	);
end;
--drop table Books_Authors
--drop table Librarians
--drop table Journal
--drop table Authors
--drop table Books
--drop table Readers
--drop table Groups
--drop table Genres
--drop table Publishers
--drop proc CreateBaseTables
go
--
exec CreateBaseTables
go
--