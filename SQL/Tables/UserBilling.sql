CREATE TABLE [dbo].[UserBilling]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [AddressId] INT NOT NULL,

	CONSTRAINT PK_Billing_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Billing_UserId FOREIGN KEY (UserId) REFERENCES UserAccount(Id),
	CONSTRAINT FK_Billing_OrderId FOREIGN KEY (AddressId) REFERENCES Orders(Id)
)