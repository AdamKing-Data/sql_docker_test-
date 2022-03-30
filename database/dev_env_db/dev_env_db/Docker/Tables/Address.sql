CREATE TABLE [docker].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Personid INT NOT NULL,
	Line1 NVARCHAR(50),
	Line2 NVARCHAR(50),
	Line3 NVARCHAR(50),
	City NVARCHAR(50),
	Postcode NVARCHAR(10),

    CONSTRAINT [FK_Address_Person] FOREIGN KEY ([personid]) REFERENCES [docker].[person] ([Id])
)

