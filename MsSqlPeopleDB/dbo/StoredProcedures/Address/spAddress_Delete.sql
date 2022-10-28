CREATE PROCEDURE [dbo].[spAddress_Delete]
	@Id int
AS
begin
	delete from [dbo].[Address]
	where [Id] = @Id;
end