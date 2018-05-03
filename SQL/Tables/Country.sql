CREATE TABLE [dbo].[Country]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] TEXT NOT NULL,

	CONSTRAINT PK_Country_Id PRIMARY KEY (Id)
)