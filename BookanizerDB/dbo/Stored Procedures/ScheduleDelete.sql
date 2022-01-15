CREATE PROCEDURE [dbo].[ScheduleDelete]
	@sched_id int
AS
	delete from schedules where sched_id = @sched_id
