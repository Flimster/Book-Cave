CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL IDENTITY, 
    [CountryId] INT NOT NULL, 
    [StateOrProvince] TEXT NOT NULL, 
    [Zip] VARCHAR(20) NOT NULL, 
    [StreetAddress] TEXT NOT NULL, 
    [City] TEXT NOT NULL

	CONSTRAINT PK_Address_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Address_CountryId FOREIGN KEY (CountryId) REFERENCES Country(Id)
)