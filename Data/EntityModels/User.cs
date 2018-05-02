using System;
using System.Collections.Generic;

namespace Book_Cave.Data.EntityModels
{
    public class User
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int FavoriteBookId { get; set; }
        public int FavoriteAuthorId { get; set; }
        public string Password { get; set; }
        public List<int> OrderHistoryId { get; set; }
        public List<int> OwnedBooksId { get; set; }
        public List<int> ReadBooksId { get; set; }
        public List<int> WishListId { get; set; }
        public List<int> ReviewsId { get; set; }
        public List<int> PaymentsId { get; set; }
        public List<int> BillingAddressesId { get; set; }
        public List<int> ShippingAddressesId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LastLoggedInDate { get; set; }
        public bool BookSuggestionsEmail { get; set; }
        public bool ActiveStatus { get; set; }
        public int UserGroup { get; set; }
        public int TotalReports { get; set; }
        public int TotalBans { get; set; }
    }
}