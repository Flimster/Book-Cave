using System;
using BookCave.Data.DatabaseExtraction;
using BookCave.Models;

namespace BookCave.Services
{
    public class AccountService
    {
        public void InitializeUser(ApplicationUser appUser)
        {
            //TODO: Repo for user profile
            var user = new UserAccount
            {
                Image = "~/images/DefaultProfileImage.png",
                Name = "",
                Email = appUser.Email,
                FavoriteBookId = 0,
                FavoriteAuthorId = 0,
                Password = appUser.PasswordHash,
                RegistrationDate = DateTime.Now,
                LastLogIn = DateTime.Now,
                BookSuggestionEmail = 0,
                ActiveStatus = 1,
                UserGroup = 1,
                TotalReports = 0,
                TotalBans = 0
            };
        }

        public AccountService()
        {
            
        }
    }
}