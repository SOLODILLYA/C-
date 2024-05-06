-- 1) Creation and Filling Table of Groups
create proc GroupsStart
as
begin
	create table Groups(
		Id int not null primary key identity,
		GroupName nvarchar(50) not null unique check (GroupName != ''),
		FacultyId int not null,
		constraint FK_Faculties foreign key (FacultyId) references Faculties(Id)
	);
end;