CREATE TABLE [dbo].[UserPayment]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [CardId] INT NOT NULL

	CONSTRAINT PK_UserPayment_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserPayment_UserId FOREIGN KEY ([UserId]) REFERENCES UserAccount(Id),
	CONSTRAINT FK_UserPayment_PaymentId FOREIGN KEY ([CardId]) REFERENCES CardDetails(Id)
)