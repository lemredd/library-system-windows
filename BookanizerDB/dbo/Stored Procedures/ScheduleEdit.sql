-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
CREATE PROCEDURE ScheduleEdit 
	-- Add the parameters for the stored procedure here
	@sched_id int, 
	@date_start date,
	@date_end date,
	@status nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update schedules
	set
		date_start = @date_start,
		date_end = @date_end,
		status = @status
	where sched_id = @sched_id
END
