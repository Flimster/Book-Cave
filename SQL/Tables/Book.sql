CREATE TABLE [dbo].[Book]
(
	[Id] INT NOT NULL IDENTITY, 
    [Title] TEXT NOT NULL, 
    [AuthorId] INT NOT NULL, 
    [GenreId] INT NOT NULL,
    [CoverPhoto] IMAGE NULL, 
    [PageCount] INT NULL,
    [PublisherId] INT NULL,
    [ReleaseYear] INT NULL, 
    [LanguageId] INT NULL, 
    [Price] FLOAT NULL, 
    [Description] TEXT NULL,
    [Rating] FLOAT NULL, 
    [Isbn10] INT NULL, 
    [Isbn13] INT NULL, 
    [StockCount] SMALLINT NOT NULL, 
    [Visibility] SMALLINT NOT NULL, 
    [FormatId] INT NOT NULL, 

	CONSTRAINT PK_Book_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Book_PublisherId FOREIGN KEY (PublisherId) REFERENCES Publisher(Id),
    CONSTRAINT FK_Book_FormatId FOREIGN KEY (FormatId) REFERENCES Format(Id),
    CONSTRAINT FK_Book_AuthorId FOREIGN KEY (AuthorId) REFERENCES BookAuthor(Id),
    CONSTRAINT FK_Book_LanguageId FOREIGN KEY (LanguageId) REFERENCES BookLanguage(Id)

)
