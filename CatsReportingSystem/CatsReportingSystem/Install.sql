use CATS2000SQL
go

select * from tblUsers
go

create procedure spGetUser
(@UserID int = null)
as begin
	select * from tblUsers where UserID = ISNULL(@UserID,UserID)
end
go
exec spGetUser