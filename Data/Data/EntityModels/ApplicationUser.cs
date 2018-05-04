using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Data.EntityModels
{
    public class ApplicationUser : IdentityUser
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public int FavoriteBookId { get; set; }
        public Book FavoriteBook { get; set; }
        public int FavoriteAuthorId { get; set; }
        public Author FavoriteAuthor { get; set; }
        public string Password { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLoggedInDate { get; set; }
        public bool BookSuggestionsEmail { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserGroup { get; set; }
        public int TotalReports { get; set; }
        public int TotalBans { get; set; }

        #region NavigationProperties
        public List<Order> OrderHistoryId { get; set; }
        public Order OrderHistory { get; set; }
        public List<Book> OwnedBooksId { get; set; }
        public Book OwnedBooks { get; set; }
        public List<Book> ReadBooksId { get; set; }
        public Book ReadBooks { get; set; }
        public List<Book> WishListId { get; set; }
        public Book WishList { get; set; }
        public List<Review> ReviewsId { get; set; }
        public Review Reviews { get; set; }
        public List<CardDetails> PaymentsId { get; set; }
        public CardDetails Payments { get; set; }
        public List<Address> BillingAddressesId { get; set; }
        public Address BillingAddresses { get; set; }
        public List<Address> ShippingAddressesId { get; set; }
        public Address ShippingAddresses { get; set; }
        #endregion
    }
}