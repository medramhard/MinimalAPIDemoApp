CREATE PROCEDURE [dbo].[spAddress_GetAll]

AS
begin
	select [Id], [StreetAddress], [City], [State], [ZipCode]
	from [dbo].[Address];
end