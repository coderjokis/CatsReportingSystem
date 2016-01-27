use CATS2000SQL
go

select * from tblUsers
go

alter procedure spGetUser
as begin
	select * from tblUsers
end
go
exec spGetUser