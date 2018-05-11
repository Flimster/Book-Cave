using System.Collections.Generic;
using BookCave.Data.EntityModels;
using BookCave.Data;
using System.Linq;
using BookCave.Models.ViewModels;

namespace BookCave.Repositories
{
    public class CardDetailsRepo
    {
        private DataContext _db;

        public CardDetailsRepo()
        {
            _db = new DataContext();
        } 

        public List<CardDetailsViewModel> GetByUserId(string userId)
        {
            var cardDetails = 
                (from C in _db.CardDetails
                where userId == C.AspNetUserId
                select new CardDetailsViewModel
                {
                    Id = C.Id,
                    AspNetUserId = C.AspNetUserId,
                    Name = C.Name,
                    CardNumber = C.CardNumber,
                    Cvc = C.Cvc,
                    ExpirationDate = C.ExpirationDate,
                }).ToList();
            return cardDetails;
        }

        public CardDetailsViewModel GetByCardId(int cardId)
        {
            var cardDetails = 
                (from C in _db.CardDetails
                where cardId == C.Id
                select new CardDetailsViewModel
                {
                    Id = C.Id,
                    AspNetUserId = C.AspNetUserId,
                    Name = C.Name,
                    CardNumber = C.CardNumber,
                    Cvc = C.Cvc,
                    ExpirationDate = C.ExpirationDate,
                }).SingleOrDefault();
            return cardDetails;
        }

        public void Write(CardDetails card)
        {
            _db.Add(card);
            _db.SaveChanges();
        }

        public void Remove(CardDetails card)
        {
            _db.Remove(card);
            _db.SaveChanges();
        }
    }
}