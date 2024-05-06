create view CrossView
as
	select
		b.Title as 'Title',
		a.PersonName + ' ' + a.PersonSurname as 'Author'
	from
		Books b,
		BooksAuthors c,
		Authors a
	where
		c.BookId = b.Id and
		c.AuthorId = a.Id;
go
--
select * from CrossView
go