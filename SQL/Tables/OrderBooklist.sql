CREATE TABLE [dbo].[OrderBooklist]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [OrderId] INT NOT NULL

	CONSTRAINT PK_OrderBooklist_Id PRIMARY KEY (Id),
	CONSTRAINT FK_OrderBooklist_BookId FOREIGN KEY (BookId) REFERENCES Book(Id),
	CONSTRAINT FK_OrderBooklist_OrderId FOREIGN KEY (OrderId) REFERENCES Orders(Id)
)