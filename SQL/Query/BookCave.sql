
CREATE TABLE [Author]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] TEXT NULL

	CONSTRAINT PK_Author_Id PRIMARY KEY (Id)
)

CREATE TABLE [Country]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] TEXT NOT NULL,

	CONSTRAINT PK_Country_Id PRIMARY KEY (Id)
)

CREATE TABLE [dbo].[CardDetails]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] TEXT NOT NULL, 
    [CardNumber] INT NOT NULL, 
    [CVC] SMALLINT NOT NULL, 
    [ExpirationDate] DATE NOT NULL,

	CONSTRAINT PK_CardDetails_Id PRIMARY KEY (Id)
)

CREATE TABLE [Genre]
(
	[Id] INT NOT NULL IDENTITY, 
    [Genre] TEXT NULL

	CONSTRAINT PK_Genre_Id PRIMARY KEY (Id)
)

CREATE TABLE [Publisher]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] TEXT NOT NULL

	CONSTRAINT PK_Publisher_Id PRIMARY KEY (Id)
)

CREATE TABLE [Language]
(
	[Id] INT NOT NULL IDENTITY, 
    [Name] TEXT NOT NULL

	CONSTRAINT PK_Language_Id PRIMARY KEY (Id)
)

CREATE TABLE [Format] (
	[Id] INT NOT NULL IDENTITY,
	[Name] TEXT NOT NULL

	CONSTRAINT PK_Format_Id PRIMARY KEY (Id)
)

CREATE TABLE [Address]
(
	[Id] INT NOT NULL IDENTITY, 
    [CountryId] INT NOT NULL, 
    [StateOrProvince] TEXT NOT NULL, 
    [Zip] VARCHAR(20) NOT NULL, 
    [StreetAddress] TEXT NOT NULL, 
    [City] TEXT NOT NULL

	CONSTRAINT PK_Address_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Address_CountryId FOREIGN KEY (CountryId) REFERENCES Country(Id)
)

CREATE TABLE [Book]
(
	[Id] INT NOT NULL IDENTITY, 
    [Title] TEXT NOT NULL,  
    [CoverPhoto] IMAGE NULL, 
    [PageCount] INT NULL,
    [PublisherId] INT NULL,
    [ReleaseYear] INT NULL, 
    [Price] FLOAT NULL, 
    [Description] TEXT NULL,
    [Rating] FLOAT NULL, 
    [Isbn10] INT NULL, 
    [Isbn13] INT NULL, 
    [StockCount] SMALLINT NOT NULL, 
    [Visibility] SMALLINT NOT NULL, 
    [FormatId] INT NOT NULL, 

	CONSTRAINT PK_Book_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Book_PublisherId FOREIGN KEY (PublisherId) REFERENCES Publisher(Id),
    CONSTRAINT FK_Book_FormatId FOREIGN KEY (FormatId) REFERENCES [Format](Id),
)


CREATE TABLE [dbo].[User]
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

CREATE TABLE [dbo].[Wishlist]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [BooksId] INT NOT NULL

	CONSTRAINT PK_Wishlist_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Wishlist_BookId FOREIGN KEY ([BooksId]) REFERENCES Book(Id),
	CONSTRAINT FK_Wishlist_UserId FOREIGN KEY ([UserId]) REFERENCES [User](Id)
)

CREATE TABLE [dbo].[UserShipping]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [ShippingId] INT NOT NULL

	CONSTRAINT PK_UserShipping_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserShipping_UserId FOREIGN KEY ([UserId]) REFERENCES [User](Id),
	CONSTRAINT FK_UserShipping_ShippingId FOREIGN KEY ([ShippingId]) REFERENCES [Address](Id)
)

CREATE TABLE [dbo].[UserReview]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [ReviewId] INT NOT NULL

	CONSTRAINT PK_UserReview_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserReview_UserId FOREIGN KEY ([UserId]) REFERENCES [User](Id),
	CONSTRAINT FK_UserReview_ReviewId FOREIGN KEY ([ReviewId]) REFERENCES Review(Id)
)

CREATE TABLE [dbo].[UserReadBook]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [BookId] INT NOT NULL

	CONSTRAINT PK_UserReadBook_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserReadBook_UserId FOREIGN KEY ([UserId]) REFERENCES [User](Id),
	CONSTRAINT FK_UserReadBook_BookId FOREIGN KEY ([BookId]) REFERENCES Book(Id)
)

CREATE TABLE [dbo].[UserPayment]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [CardId] INT NOT NULL

	CONSTRAINT PK_UserPayment_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserPayment_UserId FOREIGN KEY ([UserId]) REFERENCES [User](Id),
	CONSTRAINT FK_UserPayment_PaymentId FOREIGN KEY ([CardId]) REFERENCES CardDetails(Id)
)

CREATE TABLE [dbo].[UserCard]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [CardDetailsId] INT NOT NULL

	CONSTRAINT PK_UserCard_Id PRIMARY KEY (Id),
	CONSTRAINT FK_UserCard_UserId FOREIGN KEY (UserId) REFERENCES [User](Id),
	CONSTRAINT FK_UserCard_cardDetailsId FOREIGN KEY (CardDetailsId) REFERENCES CardDetails(Id)
)

CREATE TABLE [dbo].[Orders]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [OrderDate] DATETIME NOT NULL, 
    [OrderStatus] INT NOT NULL, 
    [OrderPrice] FLOAT NOT NULL,  
    [ShippingAddressId] INT NOT NULL, 
    [BillingAddressId] INT NOT NULL, 
    [CardDetailsId] INT NOT NULL,

	CONSTRAINT PK_Orders_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Orders_BillingAddressId FOREIGN KEY (BillingAddressId) REFERENCES [Address](Id),
	CONSTRAINT FK_Order_ShippingAddressId FOREIGN KEY (ShippingAddressId) REFERENCES [Address](Id),
	CONSTRAINT FK_Order_CardId FOREIGN KEY (CardDetailsId) REFERENCES CardDetails(Id) 
)

CREATE TABLE [dbo].[UserBilling]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [AddressId] INT NOT NULL,

	CONSTRAINT PK_Billing_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Billing_UserId FOREIGN KEY (UserId) REFERENCES [User](Id),
	CONSTRAINT FK_Billing_OrderId FOREIGN KEY (AddressId) REFERENCES Orders(Id)
)

CREATE TABLE [dbo].[OwnedBook]
(
	[Id] INT NOT NULL IDENTITY, 
    [UserId] INT NOT NULL, 
    [BookId] INT NOT NULL,
	
	CONSTRAINT PK_OwnedBook_Id PRIMARY KEY (Id),
	CONSTRAINT FK_OwnedBook_UserId FOREIGN KEY (UserId) REFERENCES [User](Id),
	CONSTRAINT FK_OwnedBook_BookId FOREIGN KEY (BookId) REFERENCES Book(Id)
)

CREATE TABLE [dbo].[OrderBooklist]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [OrderId] INT NOT NULL

	CONSTRAINT PK_OrderBooklist_Id PRIMARY KEY (Id),
	CONSTRAINT FK_OrderBooklist_BookId FOREIGN KEY (BookId) REFERENCES Book(Id),
	CONSTRAINT FK_OrderBooklist_OrderId FOREIGN KEY (OrderId) REFERENCES Orders(Id)
)



CREATE TABLE [dbo].[Feedback]
(
	[Id] INT NOT NULL IDENTITY, 
    [FeedbackType] INT NOT NULL, 
    [Text] TEXT NOT NULL, 
    [UserId] INT NOT NULL, 
    [OrderId] INT NULL, 
    [Date] DATETIME NOT NULL,

	CONSTRAINT PK_Feedback_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Feedback_UserId FOREIGN KEY (UserId) REFERENCES [User](Id),
	CONSTRAINT FK_Feedback_OrderId FOREIGN KEY (OrderId) REFERENCES Orders(Id)
)

CREATE TABLE [Review]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    [Text] TEXT NULL, 
    [Rating] FLOAT NOT NULL,
    [Date] DATETIME NOT NULL,
    [PositiveScore] INT NOT NULL DEFAULT 0, 
    [NegativeScore] INT NOT NULL DEFAULT 0 
    
	CONSTRAINT PK_Review_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Review_UserId FOREIGN KEY (UserId) REFERENCES [User](Id),
	CONSTRAINT FK_Review_BookId FOREIGN KEY (BookId) REFERENCES Book(Id)
)

CREATE TABLE [BookReview]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [ReviewId] INT NOT NULL

	CONSTRAINT PK_BookReview_Id PRIMARY KEY (Id),
	CONSTRAINT FK_BookReview_ReviewId FOREIGN KEY (ReviewId) REFERENCES Review(Id),
	CONSTRAINT FK_BookReview_bookId FOREIGN KEY (BookId) REFERENCES Book(Id)
)

CREATE TABLE [BookGenre]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [GenreId] INT NOT NULL,

	CONSTRAINT PK_BookGenre_Id PRIMARY KEY (Id),
	CONSTRAINT FK_BookGenre_BookId FOREIGN KEY (BookId) REFERENCES Book(Id),
	CONSTRAINT FK_BookGenre_GenreId FOREIGN KEY (GenreId) REFERENCES Genre(Id)
)

CREATE TABLE [BookLanguage]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [LanguageId] INT NOT NULL

	CONSTRAINT PK_BookLanguage_Id PRIMARY KEY (Id),
	CONSTRAINT FK_BookLanguage_BookId FOREIGN KEY (BookId) REFERENCES Book(Id),
	CONSTRAINT FK_BookLanguage_LanguageId FOREIGN KEY (LanguageId) REFERENCES [Language](Id)
)


CREATE TABLE [BookAuthor]
(
	[Id] INT NOT NULL IDENTITY, 
    [BookId] INT NOT NULL, 
    [AuthorId] INT NOT NULL,

	CONSTRAINT PK_BookAuthor_Id PRIMARY KEY (Id),
	CONSTRAINT FK_BookAuthor_BookId FOREIGN KEY (BookId) REFERENCES Book(Id),
	CONSTRAINT FK_BookAuthor_AuthorId FOREIGN KEY (AuthorId) REFERENCES Author(Id)
)