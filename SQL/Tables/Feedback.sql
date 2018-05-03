CREATE TABLE [dbo].[Feedback]
(
	[Id] INT NOT NULL IDENTITY, 
    [FeedbackType] INT NOT NULL, 
    [Text] TEXT NOT NULL, 
    [UserId] INT NOT NULL, 
    [OrderId] INT NULL, 
    [Date] DATETIME NOT NULL,

	CONSTRAINT PK_Feedback_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Feedback_UserId FOREIGN KEY (UserId) REFERENCES UserAccount(Id),
	CONSTRAINT FK_Feedback_OrderId FOREIGN KEY (OrderId) REFERENCES Orders(Id)
)