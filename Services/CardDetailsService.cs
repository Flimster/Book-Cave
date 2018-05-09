using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
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

        public List<CardDetails> GetList()
        {
            return _cardDetailsRepo.GetList();
        }
    }
}