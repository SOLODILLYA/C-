-- Data Representation in T-SQL
-- 1
create view AuthorsView
as
	select 
		PersonName as 'Author Name',
		PersonSurname as 'Author Surname'
	from
		Authors;
go
--
select * from AuthorsView;
go
--
create view BooksView
as
	select
		b.Title as 'Title',
		g.GenreName as 'Genre',
		p.PublisherName as 'Publisher',
		b.Pages as 'Pages',
		b.Price as 'Price'
	from
		Books b,
		Publishers p,
		Genres g
	where
		b.GenreId = g.Id and 
		b.PublisherId = p.Id;
go
--
select * from BooksView
go
--
