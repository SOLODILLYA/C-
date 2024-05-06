create proc CreateBaseTables
as
begin
-- 1 Movie
-- Title
	create table Movies(
			Id int not null primary key identity,
			Title nvarchar(100) not null 
		);
-- 2 Genre
-- Name
	create table Genres(
		Id int not null primary key identity,
		GenereName nvarchar(100) not null unique
	);
-- 3 Director
-- Name
-- Surname
	create table Directors(
		Id int not null primary key identity,
		PersonName nvarchar(100) not null,
		PersonSurname nvarchar(100) not null
	);
-- 4 Actor
-- Name
-- Surname
	create table Actors(
		Id int not null primary key identity,
		PersonName nvarchar(100) not null,
		PersonSurname nvarchar(100) not null
	);
-- 5 Room 
-- Number
	create table Rooms(
		Id int not null primary key identity,
		RoomNumber int unique
	);
-- 6 Session
-- MovieId
-- RoomId
-- Time
	create table SessionsTable(
		Id int not null primary key identity,
		MovieId int,
		MovieTime datetime,
		RoomId int,
		constraint FK_Session_To_Movie foreign key (MovieId) references Movies(Id),
		constraint FK_Session_To_Room foreign key (RoomId) references Rooms(Id)
	);
-- 7 Ticket
-- Price
-- SessionId
-- IssueDate
	create table Tickets(
			Id int not null primary key identity,
			Price money,
			IssueDate datetime default getdate(),
			SessionId int,
			constraint FK_Ticket_To_Session foreign key (SessionId) references SessionsTable(Id)
		);
-- 8 Actors-To-Movies
-- ActorId
-- MovieId
	create table Actors_Movies(
		Id int not null primary key identity,
		ActorId int not null,
		MovieId int not null,
		constraint FK_Actors foreign key (ActorId) references Actors(Id),
		constraint FK_Movies foreign key (MovieId) references Movies(Id)
	);
-- 9 Directors-To-Movies
-- DirectorId
-- MovieId
	create table Directors_Movies(
		Id int not null primary key identity,
		DirectorId int not null,
		MovieId int not null,
		constraint FK_Directors foreign key (DirectorId) references Directors(Id),
		constraint FK_Movies_2 foreign key (MovieId) references Movies(Id)
	);
-- 10 Movies-To-Genres
	create table Movies_Genres(
		Id int not null primary key identity,
		GenreId int not null,
		MovieId int not null,
		constraint FK_Genres foreign key (GenreId) references Genres(Id),
		constraint FK_Movies_3 foreign key (MovieId) references Movies(Id)
	);
end;
go


exec CreateBaseTables;
go

create proc AddNewActor
	@personName nvarchar(100),
	@personSurname nvarchar(100)
as
begin
	insert into Actors values (@personName, @personName)
end;
go

create proc AddNewActor_Movie
	@movieId int,
	@actorId int
as
begin
	insert into Actors_Movies values (@actorId, @movieId)
end;
go

create proc AddNewDirector
	@personName nvarchar(100),
	@personSurname nvarchar(100)
as
begin
	insert into Directors values (@personName, @personName)
end;
go

create proc AddNewDirector_Movie
	@movieId int,
	@directorId int
as
begin
	insert into Directors_Movies values (@directorId, @movieId)
end;
go

create proc AddNewGenre
	@genreName nvarchar(100)
as
begin
	insert into Genres values (@genreName)
end;
go

create proc AddNewMovie
	@title nvarchar(100)
as
begin
	insert into Movies values (@title)
end;
go

create proc AddNewMovie_Genre
	@movieId int,
	@genreId int
as
begin
	insert into Movies_Genres values (@genreId, @movieId)
end;
go

create proc AddNewRoom
	@num int
as
begin
	insert into Rooms values (@num)
end;
go

create proc AddNewSession
	@movieId int,
	@movieTime datetime,
	@roomId int
as
begin
	insert into SessionsTable values (@movieId, @movieTime, @roomId)
end;
go

create proc AddNewTicket
	@sessionId int,
	@price money
as
begin
	insert into Tickets values (@price, NULL, @sessionId)
end;
go


create proc FillTestData
as
begin
	declare @n int;
	declare @it int;
	set @n = 5;
	set @it = 0;
	while @it < @n
	begin
		set @it = @it + 1;
		-- 1 - Actors (5)
		declare @actorName nvarchar(100);
		set @actorName =  'ActorName-' + convert(nvarchar, @it);
		declare @actorSurname nvarchar(100);
		set @actorSurname =  'ActorSurname-' + convert(nvarchar, @it);
		exec AddNewActor @actorName, @actorSurname;
		-- 2 - Directors (5)
		declare @directorName nvarchar(100);
		set @directorName =  'DirectorName-' + convert(nvarchar, @it);
		declare @directorSurname nvarchar(100);
		set @directorSurname =  'DirectorSurname-' + convert(nvarchar, @it);
		exec AddNewDirector @directorName, @directorSurname;
		-- 3 - Genres (5)
		declare @genreName nvarchar(100);
		set @genreName =  'Genre-' + convert(nvarchar, @it);
		exec AddNewGenre @genreName;
		-- 4 - Movies (5)
		declare @movieName nvarchar(100);
		set @movieName =  'Movie-' + convert(nvarchar, @it);
		exec AddNewMovie @movieName;
		-- 5 - Rooms (5)
		exec AddNewRoom @it;
		-- 6 - Sessions (5)
		declare @currentDateTime datetime;
		set @currentDateTime = getdate();
		exec AddNewSession @it, @currentDateTime, @it;
		-- 7 - Tickets (5)
		declare @price money;
		set @price = convert(money, @it);
		exec AddNewTicket  @it, @price;
		-- 8 - Actors_Movies (5)
		exec AddNewActor_Movie @it, @it;
		-- 9 - Directors_Movies (5)
		exec AddNewDirector_Movie @it, @it;
		--10 - Movies_Genres (5)
		exec AddNewMovie_Genre @it, @it;
	end;
end;
go

exec FillTestData;
go