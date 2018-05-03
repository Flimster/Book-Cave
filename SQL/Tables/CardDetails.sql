CREATE TABLE [dbo].[CardDetails]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] VARCHAR(200) NOT NULL, 
    [CardNumber] INT NOT NULL, 
    [CVC] SMALLINT NOT NULL, 
    [ExpirationDate] DATE NOT NULL,

	CONSTRAINT PK_CardDetails_Id PRIMARY KEY (Id)
)