CREATE TABLE [dbo].[BookReview]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [ReviewId] INT NOT NULL

	CONSTRAINT PK_BookReview_Id PRIMARY KEY (Id),
	CONSTRAINT FK_BookReview_ReviewId FOREIGN KEY (ReviewId) REFERENCES Review(Id),
	CONSTRAINT FK_BookReview_bookId FOREIGN KEY (BookId) REFERENCES Book(Id)
)