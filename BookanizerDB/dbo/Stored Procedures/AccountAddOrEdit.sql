create proc AccountAddOrEdit
@account_id int,
@username varchar(50),
@password varchar(50)
as
if not exists(select * from accounts where account_id = @account_id)
	insert into accounts values(@username,@password)
else
	update accounts
	set
		username = @username,
		password = @password
	where account_id = @account_id