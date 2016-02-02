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
@SIN varchar(max) = null,
@FirstName varchar(max) = null,
@LastName varchar(max) = null,
@DOB date =null
)
as begin
	if exists
	(select ID,SIN,FirstName,LastName,DOB from Clients
	where  (ID =@ID) or
		(SIN =@SIN) or
		 (FirstName like '%' +@FirstName+ '%') or
		 (LastName like '%' +@LastName+ '%') or
		 (DOB = @DOB))
		 begin
			select ID,SIN,FirstName,LastName,DOB from Clients
			where  (ID =@ID)
		 end
	if @@ROWCOUNT = 0
		begin
			select 'No Result Found!' as result
		end
end
go

exec spGetClientBySearch @FirstName='ret'
exec spGetClientBySearch @SIN=' '
exec spGetClientBySearch @LastName='Dou'
exec spGetClientBySearch @DOB='1970'
exec spGetClientBySearch @ID='32156'
exec spGetClientBySearch @FirstName=' '
exec spGetClientBySearch @SIN='540'
exec spGetClientBySearch @LastName='dfsfer'
exec spGetClientBySearch @DOB='4214'
exec spGetClientBySearch @ID='NULL'