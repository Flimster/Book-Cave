using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using BookCave.Models.ViewModels;
using BookCave.Repositories;

namespace BookCave.Services
{
    public class CardDetailsService
    {
        private CardDetailsRepo _cardDetailsRepo;

        private DataContext _db;

        public CardDetailsService()
        {
            _cardDetailsRepo = new CardDetailsRepo();
            _db = new DataContext();
        }

        public List<CardDetailsViewModel> GetList()
        {
            return _cardDetailsRepo.GetList();
        }

        public List<CardDetailsViewModel> GetByUserId(string UserId)
        {
            return _cardDetailsRepo.GetByUserId(UserId);
        }
    }
}