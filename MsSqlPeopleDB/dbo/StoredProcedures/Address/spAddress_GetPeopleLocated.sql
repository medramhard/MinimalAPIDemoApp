CREATE PROCEDURE [dbo].[spAddress_GetPeopleLocated]
	@Id int
AS
begin
	select p.*
	from [dbo].[Address] a
	left join [dbo].[PersonAddress] pa
	on a.Id = pa.AddressId
	left join [dbo].[Person] p
	on pa.PersonId = p.Id
	where a.Id = @Id;
end