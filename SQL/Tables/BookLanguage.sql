CREATE TABLE [dbo].[BookLanguage]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [LanguageId] INT NOT NULL

	CONSTRAINT PK_BookLanguage_Id PRIMARY KEY (Id),
	CONSTRAINT FK_BookLanguage_BookId FOREIGN KEY (BookId) REFERENCES Book(Id),
	CONSTRAINT FK_BookLanguage_LanguageId FOREIGN KEY (LanguageId) REFERENCES Language(Id)
)
