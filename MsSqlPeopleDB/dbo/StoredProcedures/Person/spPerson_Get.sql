CREATE PROCEDURE [dbo].[spPerson_Get]
	@Id int
AS
begin
	select *
	from [dbo].[Person]
	where [Id] = @Id;
end