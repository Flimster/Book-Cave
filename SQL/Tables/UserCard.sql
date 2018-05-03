CREATE TABLE [dbo].[UserCard]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [CardDetailsId] INT NOT NULL

	CONSTRAINT PK_UserCard_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserCard_UserId FOREIGN KEY ([UserId]) REFERENCES UserAccount(Id),
	CONSTRAINT FK_UserCard_cardDetailsId FOREIGN KEY ([CardDetailsId]) REFERENCES CardDetails(Id)
)