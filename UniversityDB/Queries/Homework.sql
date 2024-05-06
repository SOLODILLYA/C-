create proc DepartmentsStart
as
begin
	create table Departments(
		Id int not null primary key identity,
		DepartmentName nvarchar(100) not null check (DepartmentName != ''),
		FacultyId int not null,
		constraint FK_Departments_To_Faculties foreign key (FacultyId ) references Faculties(Id)
	)
end;
go

exec DepartmentsStart;
go

create proc SubjectsStart1
as
begin
	create table Subjects(
		Id int not null primary key identity,
		SubjectName nvarchar(100) not null check (SubjectName != '')
	)
end;
go

exec SubjectsStart1;
go

create proc TeachersStart
as
begin
	create table Teachers(
		Id int not null primary key identity,
		TeacherName nvarchar(50) not null check (TeacherName != ''),
		BirthDay date not null,
		PhoneNumber nvarchar(50) not null check (PhoneNumber != ''),
		SubjectId int not null,
		DepartmentId int not null,
		constraint FK_Teacher_To_Subject foreign key (SubjectId) references Subjects(Id),
		constraint FK_Teacher_To_Department foreign key (DepartmentId) references Departments(Id)
		)
end;
go

exec TeachersStart;
go

create proc AddNewDepartment
	@deparmentName nvarchar(100),
	@facultyId int
as
begin
	insert into Departments
		(DepartmentName, FacultyId)
	values
		(@deparmentName, @facultyId)
end;
go 

create proc AddNewSubject
	@subjectName nvarchar(50)
as
begin
	insert into Subjects
		(SubjectName)
	values
		(@subjectName);
end;
go


create proc AddNewTeacher
	@teacherName nvarchar(50),
	@birthDay date,
	@phoneNumber nvarchar(50),
	@subjectId int,
	@departmentId int
as
begin
	insert into Teachers
		(TeacherName, BirthDay, PhoneNumber, SubjectId, DepartmentId)
	values
		(@teacherName, @birthDay, @phoneNumber, @subjectId, @departmentId);
end;
go

create proc FillDepartments
as
begin
	exec AddNewDepartment 'C++', 1;
	exec AddNewDepartment 'Blender', 2;
	exec AddNewDepartment 'Server Understanding', 3;
	exec AddNewDepartment 'Malware', 4;
	exec AddNewDepartment 'Skratch', 5;
	exec AddNewDepartment 'Qualification Approval', 6;
end;
go

exec FillDepartments;
go

create proc FillSubjects
as
begin
	exec AddNewSubject 'Math';
	exec AddNewSubject 'English';
	exec AddNewSubject 'Ukranian';
	exec AddNewSubject 'History';
	exec AddNewSubject 'Programming';
	exec AddNewSubject 'Chemistry';
end;
go

exec FillSubjects;
go

create proc FillTestTeachers
as
begin
	declare @teacherName nvarchar(50);
	declare @birthDay date;
	declare @iterationCount int;
	declare @phoneNumber nvarchar(50);
	set @iterationCount = 0;

	while @iterationCount < 6
	begin
		set @iterationCount = @iterationCount + 1;
		set @teacherName = 'Teacher-' + convert(nvarchar, @iterationCount);
		set @birthDay = convert(date, '2001-01-01');
		set @phoneNumber = '+380-99-001-01-01';
		

		exec AddNewTeacher @teacherName, @birthDay, @phoneNumber, @iterationCount, @iterationCount;
	end
end;
go

exec FillTestTeachers;
go

select
	t.TeacherName as 'Teacher Name',
	t.BirthDay as 'Teacher Birthday',
	t.PhoneNumber as 'Teacher Phone Number',
	d.DepartmentName as 'Depatment Name',
	s.SubjectName as 'Subject Name'
from
	Teachers t,
	Subjects s,
	Departments d
where
	t.SubjectId = s.Id and
	t.DepartmentId = d.Id;
go
