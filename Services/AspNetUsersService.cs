using System.Collections.Generic;
using BookCave.Data;
using BookCave.Models.ViewModels;
using BookCave.Repositories;
using System.Linq;
using BookCave.Data.EntityModels;

namespace BookCave.Services
{
    public class AspNetUsersService
    {
        private AspNetUsersRepo _aspNetUserRepo;
        private DataContext _db;

        public AspNetUsersService()
        {
            _aspNetUserRepo = new AspNetUsersRepo();
            _db = new DataContext();
        }

        public List<AspNetUserViewModel> GetList()
        {
            return _aspNetUserRepo.GetList();
        }
        public AspNetUserViewModel GetById(string Id)
        {
            return _aspNetUserRepo.GetById(Id);
        }

        public void ChangeEmail(string userId, string newEmail)
        {
            _aspNetUserRepo.ChangeEmail(userId, newEmail);
        }

        public void ChangeImage(string userId, string newImage)
        {
            _aspNetUserRepo.ChangeImage(userId, newImage);
        }

        public void ChangeName(string userId, string newName)
        {
            _aspNetUserRepo.ChangeName(userId, newName);
        }

        public void ChangeBookSuggestionEmail(string userId, bool newEmailSetting)
        {
            _aspNetUserRepo.ChangeBookSuggestionEmail(userId, newEmailSetting);
        }

        public void ChangeFavoriteBook(string userId, int bookId)
        {
            _aspNetUserRepo.ChangeFavoriteBook(userId, bookId);
        }

        public void ChangeFavoriteAuthor(string userId, int authorId)
        {
            _aspNetUserRepo.ChangeFavoriteAuthor(userId, authorId);
        }
    }
}   