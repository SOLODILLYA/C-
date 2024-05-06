-- Students Table
--1) Procedure for creation and restaration of students table
create proc StudentsStart1
as
begin
	create table Students(
		Id int not null primary key identity,
		StudentName nvarchar(50) not null check (StudentName != ''),
		BirthDay date not null,
		PhoneNumber nvarchar(50) not null check (PhoneNumber != ''),
		CurrentRate real not null check (CurrentRate between 0 and 12) default 4.0,
		GroupId int not null,
		constraint FK_Groups foreign key (GroupId) references Groups(Id)
	)
end;
go

exec StudentsStart1;
go

create proc AddNewStudent
	@studentName nvarchar(50),
	@birthDay date,
	@phoneNumber nvarchar(50),
	@currentRate real,
	@groupId int
as
begin
	insert into Students
		(StudentName, BirthDay, PhoneNumber, CurrentRate, GroupId)
	values
		(@studentName, @birthDay, @phoneNumber, @currentRate, @groupId);
end;
go
--3) Procedure to fill students table with test data
-- 1-5, 10, 12-14

create proc FillTestStudents
as
begin
	declare @studentName nvarchar(50);
	declare @birthDay date;
	declare @iterationCount int;
	declare @phoneNumber nvarchar(50);
	declare @currentRate real;
	declare @groupId int;
	set @iterationCount = 0;

	while @iterationCount < 45
	begin
		set @iterationCount = @iterationCount + 1;
		set @studentName = 'Student-' + convert(nvarchar, @iterationCount);
		set @birthDay = convert(date, '2001-01-01');
		set @phoneNumber = '+380-99-001-01-01';
		set @currentRate = floor(rand() * 12 + 1);
		if(@iterationCount between 1 and 5)
			set @groupId = 1
		if(@iterationCount between 6 and 10)
			set @groupId = 2
		if(@iterationCount between 11 and 15)
			set @groupId = 3
		if(@iterationCount between 16 and 20)
			set @groupId = 4
		if(@iterationCount between 21 and 25)
			set @groupId = 5
		if(@iterationCount between 26 and 30)
			set @groupId = 10
		if(@iterationCount between 31 and 35)
			set @groupId = 12
		if(@iterationCount between 36 and 40)
			set @groupId = 13
		if(@iterationCount between 41 and 45)
			set @groupId = 14

		exec AddNewStudent @studentName, @birthDay, @phoneNumber, @currentRate, @groupId;
	end
end;
go

exec FillTestStudents;
go

-- 4 Agregating queries to students table
-- 4.1 Summutive Rating Of Students:
select 
	sum(CurrentRate) as 'Summutive Rating'
from
	Students;
go
-- 4.2 Number Of Students:
select 
	count(Id) as 'Number of Students'
from
	Students;
go

-- 4.3 Number Of Successful Students:
select 
	count(Id) as 'Number Of Successful Students'
from
	Students
where
	CurrentRate >= 7;
go

select * from Students;
go