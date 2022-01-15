CREATE PROCEDURE [dbo].[BookAddOrEdit]
	@book_id int,
	@title  nvarchar(max),       
    @author  nvarchar(max),      
    @date_authored date,
    @categories    nvarchar(max),
    @isbn          bigint,
    @image varbinary(max),
	@copies_left   int
AS
	if not exists (select * from books where book_id = @book_id)
		insert into books values(@title, @author, @date_authored, @categories, @isbn, @image, @copies_left)
	else
		update books
		set
			title = @title,
			author = @author,
			date_authored = @date_authored,
			categories = @categories,
			isbn = @isbn,
			image = @image,
			copies_left = @copies_left
		where book_id = @book_id