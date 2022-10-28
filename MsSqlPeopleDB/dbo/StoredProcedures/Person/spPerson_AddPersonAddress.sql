CREATE PROCEDURE [dbo].[spPerson_AddPersonAddress]
	@PersonId int,
	@AddressId int
AS
begin
	insert into [dbo].[PersonAddress] ([PersonId], [AddressId])
	values (@PersonId, @AddressId);
end
