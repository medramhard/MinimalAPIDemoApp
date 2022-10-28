CREATE PROCEDURE [dbo].[spPerson_Add]
	@FirstName nvarchar(50),
	@LastName nvarchar(50)
AS
begin
	insert into [dbo].[Person] ([FirstName], [LastName])
	values (@FirstName, @LastName);
end
