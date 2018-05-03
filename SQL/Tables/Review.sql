CREATE TABLE [dbo].[Review]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    [Text] TEXT NULL, 
    [Rating] FLOAT NOT NULL,
    [Date] DATETIME NOT NULL,
    [PositiveScore] INT NOT NULL DEFAULT 0, 
    [NegativeScore] INT NOT NULL DEFAULT 0 
    
	CONSTRAINT PK_Review_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Review_UserId FOREIGN KEY (UserId) REFERENCES UserAccount(Id),
	CONSTRAINT FK_Review_BookId FOREIGN KEY (BookId) REFERENCES Book(Id)
)