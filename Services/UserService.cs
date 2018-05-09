using System.Collections.Generic;
using BookCave.Models.ViewModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class UserService
    {
        private readonly ReviewRepo _reviewRepo;

        public UserService()
        {
            _reviewRepo = new ReviewRepo();
        }


    }
}