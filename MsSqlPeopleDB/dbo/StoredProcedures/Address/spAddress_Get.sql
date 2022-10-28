CREATE PROCEDURE [dbo].[spAddress_Get]
	@Id int
AS
begin
	select [Id], [StreetAddress], [City], [State], [ZipCode]
	from [dbo].[Address]
	where [Id] = @Id;
end