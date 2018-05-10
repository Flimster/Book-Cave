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

        public void ChangeEmail(string Id, string NewEmail)
        {
            _aspNetUserRepo.ChangeEmail(Id, NewEmail);
        }

        public void ChangeImage(string Id, string NewImage)
        {
            _aspNetUserRepo.ChangeImage(Id, NewImage);
        }

        public void ChangeName(string Id, string NewName)
        {
            _aspNetUserRepo.ChangeName(Id, NewName);
        }

        public void ChangeBookSuggestionEmail(string Id, bool NewEmailSetting)
        {
            _aspNetUserRepo.ChangeBookSuggestionEmail(Id, NewEmailSetting);
        }

        public void ChangeFavoriteBook(string Id, int BookId)
        {
            _aspNetUserRepo.ChangeFavoriteBook(Id, BookId);
        }

        public void ChangeFavoriteAuthor(string Id, int AuthorId)
        {
            _aspNetUserRepo.ChangeFavoriteAuthor(Id, AuthorId);
        }
    }
}   