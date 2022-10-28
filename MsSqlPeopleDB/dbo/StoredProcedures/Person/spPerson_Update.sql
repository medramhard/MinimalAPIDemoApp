CREATE PROCEDURE [dbo].[spPerson_Update]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Id int
AS
begin
	update [dbo].[Person]
	set
	[FirstName] = @FirstName,
	[LastName] = @LastName
	where [Id] = @Id;
end