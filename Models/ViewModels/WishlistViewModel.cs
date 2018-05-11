using System.Collections.Generic;
using BookCave.Models.ViewModels;

namespace BookCave.Models.ViewModels
{
    public class WishlistViewModel
    {
        public string AspNetUsersId { get; set; }
        public List<BookViewModel> Book { get; set; }
    }
}