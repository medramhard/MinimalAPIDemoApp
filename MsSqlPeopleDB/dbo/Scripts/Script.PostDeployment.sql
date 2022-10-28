if not exists (select * from [dbo].[Person])
begin
	insert into [dbo].[Person] (FirstName, LastName)
	values ('John', 'Dow'),
	('Ann', 'Smith'),
	('Rose', 'Jenkins');

	insert into [dbo].[Address] ([StreetAddress], [City], [State], [ZipCode])
	values ('Ap #132-1051 Et Av.','Anchorage','Idaho','34554'),
	('Ap #937-6956 Ac Avenue','Dover','Missouri','85619');

	insert into [dbo].[PersonAddress] ([PersonId], [AddressId])
	values (1, 1),
	(2, 1),
	(2, 2),
	(3, 2);
end