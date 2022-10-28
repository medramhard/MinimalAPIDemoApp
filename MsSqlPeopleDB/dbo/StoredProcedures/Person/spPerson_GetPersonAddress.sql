CREATE PROCEDURE [dbo].[spPerson_GetPersonAddress]
	@Id int
AS
begin
	select [a].[Id], [a].[StreetAddress], [a].[City], [a].[State], [a].[ZipCode]
	from [dbo].[Person] p
	left join [dbo].[PersonAddress] pa
	on p.Id = pa.PersonId
	left join [dbo].[Address] a
	on pa.AddressId = a.Id
	where p.Id = @Id;
end