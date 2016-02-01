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
go
--proc for search clients in home page--
alter procedure spGetClientBySearch
(
@ID int = null,
@SIN varchar = null,
@FirstName varchar(max) = null,
@LastName varchar(max) = null,
@DOB date =null
)
as begin
	select ID,SIN,FirstName,LastName,DOB from Clients
	where  (ID =@ID) or
		(SIN Like '%' +@SIN+ '%') or
		 (FirstName like '%' +@FirstName+ '%') or
		 (LastName like '%' +@LastName+ '%') or
		 (DOB = @DOB)
end
go

exec spGetClientBySearch @FirstName='doug'