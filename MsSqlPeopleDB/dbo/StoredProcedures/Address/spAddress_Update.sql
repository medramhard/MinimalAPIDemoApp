CREATE PROCEDURE [dbo].[spAddress_Update]
	@StreetAddress nvarchar(50),
	@City nvarchar(50),
	@State nvarchar(50),
	@ZipCode nvarchar(50),
	@Id int
AS
begin
	update [dbo].[Address]
	set
	[StreetAddress] = @StreetAddress,
	[City] = @City,
	[State] = @State,
	[ZipCode] = @ZipCode
	where [Id] = @Id;
end