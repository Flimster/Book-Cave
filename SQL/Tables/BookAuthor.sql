CREATE TABLE [dbo].[BookAuthor]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [AuthorId] INT NOT NULL,

	CONSTRAINT PK_BookAuthor_Id PRIMARY KEY (Id),
	CONSTRAINT FK_BookAuthor_BookId FOREIGN KEY (BookId) REFERENCES Book(Id),
	CONSTRAINT FK_BookAuthor_AuthorId FOREIGN KEY (AuthorId) REFERENCES Author(Id)
)
