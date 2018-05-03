CREATE TABLE [dbo].[UserReview]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [ReviewId] INT NOT NULL

	CONSTRAINT PK_UserReview_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserReview_UserId FOREIGN KEY ([UserId]) REFERENCES UserAccount(Id),
	CONSTRAINT FK_UserReview_ReviewId FOREIGN KEY ([ReviewId]) REFERENCES Review(Id)
)