/* 1) Creation of tables*/
-- 1.1) Faculty Table
create table Faculties (
	Id int not null primary key identity, 
	FacultyName nvarchar(100) not null unique
);
/* 2) Filling of tables*/
-- 2.1) Faculty Table
insert into Faculties (FacultyName) values 
	('Software Engenieering'),
	('Computer Graphics'),
	('Networking'),
	('Cybersecurity');

select * from Faculties order by Id;