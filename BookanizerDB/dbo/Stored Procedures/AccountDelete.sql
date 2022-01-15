CREATE PROCEDURE [dbo].[AccountDelete]
	@account_id int
AS
	DELETE FROM ACCOUNTS WHERE account_id = @account_id