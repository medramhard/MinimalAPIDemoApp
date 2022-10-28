CREATE PROCEDURE [dbo].[spPerson_GetAll]

AS
begin
	select [Id], [FirstName], [LastName]
	from [dbo].[Person];
end