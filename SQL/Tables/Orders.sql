CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [OrderDate] DATETIME NOT NULL, 
    [OrderStatus] INT NOT NULL, 
    [OrderPrice] FLOAT NOT NULL, 
    [BookListId] INT NOT NULL, 
    [ShippingAddressId] INT NOT NULL, 
    [BillingAddressId] INT NOT NULL, 
    [CardDetailsId] INT NOT NULL,

	CONSTRAINT PK_Orders_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Orders_BookListId FOREIGN KEY (BookListId) REFERENCES OrderBooklist(Id),
	CONSTRAINT FK_Orders_BillingAddressId FOREIGN KEY (BillingAddressId) REFERENCES Address(Id),
	CONSTRAINT FK_Order_ShippingAddressId FOREIGN KEY (ShippingAddressId) REFERENCES Address(Id),
	CONSTRAINT FK_Order_CardId FOREIGN KEY (CardDetailsId) REFERENCES CardDetails(Id) 
)