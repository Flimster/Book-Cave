CREATE TABLE [dbo].[UserReadBook]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [BookId] INT NOT NULL

	CONSTRAINT PK_UserReadBook_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserReadBook_UserId FOREIGN KEY ([UserId]) REFERENCES UserAccount(Id),
	CONSTRAINT FK_UserReadBook_BookId FOREIGN KEY ([BookId]) REFERENCES Book(Id)
)