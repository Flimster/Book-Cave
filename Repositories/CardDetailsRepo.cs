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
        public void Write(CardDetailsViewModel card)
        {
            _db.Add(card);
            _db.SaveChanges();
        }

        public void Remove(CardDetailsViewModel card)
        {
            _db.Remove(card);
            _db.SaveChanges();
        }

        public List<CardDetailsViewModel> GetByUserId(string userId)
        {
            var cardDetails = 
                (from C in _db.CardDetails
                join UsCa in _db.UsersCards on C.Id equals UsCa.CardId
                where userId == UsCa.AspNetUserId
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
                join UsCa in _db.UsersCards on C.Id equals UsCa.CardId
                where cardId == UsCa.CardId
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
    }
}