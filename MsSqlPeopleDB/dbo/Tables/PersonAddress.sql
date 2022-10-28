CREATE TABLE [dbo].[PersonAddress]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonId] INT NOT NULL, 
    [AddressId] INT NOT NULL, 
    CONSTRAINT [FK_PersonAddress_Person] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]) ON DELETE CASCADE, 
    CONSTRAINT [FK_PersonAddress_Address] FOREIGN KEY ([AddressId]) REFERENCES [Address]([Id]) ON DELETE CASCADE
)
