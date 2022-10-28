CREATE PROCEDURE [dbo].[spAddress_Add]
	@StreetAddress nvarchar(50),
	@City nvarchar(50),
	@State nvarchar(50),
	@ZipCode nvarchar(50)
AS
begin
	insert into [dbo].[Address] ([StreetAddress], [City], [State], [ZipCode])
	values (@StreetAddress, @City, @State, @ZipCode);
end