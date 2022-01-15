CREATE PROCEDURE [dbo].[BookDelete]
	@book_id int
AS
	delete from books where book_id = @book_id