use CATS2000SQL
go

select * from tblUsers
go

alter procedure spGetUser
as begin
	select UserName from tblUsers where UserName!='zInvalid'
end
go
exec spGetUser