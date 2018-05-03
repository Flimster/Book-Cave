CREATE TABLE [dbo].[UserAccount]
(
	[Id] INT NOT NULL IDENTITY, 
    [Image] TEXT NULL, 
    [Name] TEXT NOT NULL, 
    [Email] TEXT NOT NULL, 
    [FavoriteBookId] INT NULL,   
    [FavoriteAuthorId] INT NULL, 
    [Password] TEXT NOT NULL, 
    [RegistrationDate] DATETIME NOT NULL, 
    [LastLogIn] DATETIME NOT NULL,
    [BookSuggestionEmail] TINYINT NOT NULL,     
    [ActiveStatus] INT NOT NULL DEFAULT 1, 
    [UserGroup] INT NOT NULL DEFAULT 0, 
    [TotalReports] INT NOT NULL DEFAULT 0, 
    [TotalBans] INT NOT NULL DEFAULT 0,  

	CONSTRAINT PK_UserAccount_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserAccount_FavoriteBookId FOREIGN KEY (FavoriteBookId) REFERENCES Book(Id),
	CONSTRAINT FK_UserAccount_FavoriteAuthorId FOREIGN KEY (FavoriteAuthorId) REFERENCES Author(Id),
)
