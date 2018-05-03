CREATE TABLE [dbo].[BookGenre]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [GenreId] INT NOT NULL,

	CONSTRAINT PK_BookGenre_Id PRIMARY KEY (Id),
	CONSTRAINT FK_BookGenre_BookId FOREIGN KEY (BookId) REFERENCES Book(Id),
	CONSTRAINT FK_BookGenre_GenreId FOREIGN KEY (GenreId) REFERENCES Genre(Id)
)