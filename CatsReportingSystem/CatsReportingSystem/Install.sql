use CATS2000SQL
go

select * from tblUsers
go

alter procedure spGetUser
as begin
	select UserID,UserName from tblUsers where UserName!='zInvalid'
end
go
exec spGetUser