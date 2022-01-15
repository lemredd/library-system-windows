CREATE PROCEDURE [dbo].[ScheduleAdd]
	@account_id int,
	@book_id int,
	@date_start date,
	@date_end date,
	@status nvarchar(50)
AS
	insert into schedules
	values (
		@account_id ,
		@book_id ,
		@date_start ,
		@date_end ,
		@status
	)