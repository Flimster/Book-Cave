CREATE TABLE [dbo].[OwnedBook]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [BookId] INT NOT NULL,
	
	CONSTRAINT PK_OwnedBook_Id PRIMARY KEY (Id),
	CONSTRAINT FK_OwnedBook_UserId FOREIGN KEY (UserId) REFERENCES UserAccount(Id),
	CONSTRAINT FK_OwnedBook_BookId FOREIGN KEY (BookId) REFERENCES Book(Id)
)