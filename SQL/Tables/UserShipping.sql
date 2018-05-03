CREATE TABLE [dbo].[UserShipping]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [ShippingId] INT NOT NULL

	CONSTRAINT PK_UserShipping_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserShipping_UserId FOREIGN KEY ([UserId]) REFERENCES UserAccount(Id),
	CONSTRAINT FK_UserShipping_ShippingId FOREIGN KEY ([ShippingId]) REFERENCES Address(Id)
)