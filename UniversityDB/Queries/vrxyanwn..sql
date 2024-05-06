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
go
--
exec GroupsStart;
go
--
create proc AddNewGroup
	@groupName nvarchar(50),
	@facultyId int
as
begin
	insert into Groups
		(Groupname, FacultyId)
	values
		(@groupName,  @facultyId)
end;
go
--
exec AddNewGroup N'Group-1-1', 1;
exec AddNewGroup N'Group-2-1', 1;
exec AddNewGroup N'Group-3-1', 1;
--
exec AddNewGroup N'Group-1-2', 2;
exec AddNewGroup N'Group-2-2', 2;
exec AddNewGroup N'Group-3-2', 2;
--
exec AddNewGroup N'Group-1-3', 3;
exec AddNewGroup N'Group-2-3', 3;
exec AddNewGroup N'Group-3-3', 3;
--
select * from Groups;
go
--

-- 2) Data Manipulation
--2.1
select
	g.GroupName as 'Group Name',
	f.FacultyName as 'FacultyName'
from
	Groups g,
	Faculties f
where
	g.FacultyId = f.Id and
	f.Id = 2;
go
--
--2.2 
update 
	Groups
set
	GroupName = 'TestUpdateName - 1'
where 
	Id = 6;
go
--2.3
delete from
	Groups
where
	Id > 5;
go
--
select * from Groups;
go