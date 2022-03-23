CREATE TABLE [docker].[person]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Fistname Nvarchar(50),
	Lastname Nvarchar(50),
	date_of_birth date,
)
