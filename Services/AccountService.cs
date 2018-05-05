using System;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;

namespace Book_Cave.Services
{
    public class AccountService
    {
        AspNetUsers _user;

        public AccountService()
        {
            _user = new AspNetUsers();
        }

        public AspNetUsers InitializeAccount(RegisterViewModel model)
        {
            _user = new AspNetUsers
            {
                Image = "",
                Name = "",
                //Foreign key FavoriteBook
                FavoriteBookId = 0,
                //Foreign key FavoriteAuthor
                FavoriteAuthorId = 0,
                RegistrationDate = DateTime.Now,
                LastLoggedInDate = DateTime.Now,
                BookSuggestionsEmail = false,
                ActiveStatus = true,
                UserGroup = 0,
                TotalReports = 0,
                TotalBans = 0,
                UserName = model.Email,
                Email = model.Email
            };

            return _user;
        }
    }
}