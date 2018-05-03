CREATE TABLE [dbo].[Wishlist]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [BooksId] INT NOT NULL

	CONSTRAINT PK_Wishlist_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Wishlist_BookId FOREIGN KEY ([BooksId]) REFERENCES Book(Id),
	CONSTRAINT FK_Wishlist_UserId FOREIGN KEY ([UserId]) REFERENCES UserAccount(Id)
)