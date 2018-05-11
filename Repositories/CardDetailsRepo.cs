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
        public List<CardDetailsView> GetList()
        { 
            var cardDetails = (from C in _db.CardDetails
                        select new CardDetailsView
                        {
                            Id = C.Id,
                            Name = C.Name,
                            CardNumber = C.CardNumber,
                            Cvc = C.Cvc,
                            ExpirationDate = C.ExpirationDate,
                        }).ToList();
            
            return cardDetails;
        }

        public void Write(CardDetailsView card)
        {
            _db.Add(card);
            _db.SaveChanges();
        }

        public void Remove(CardDetailsView card)
        {
            _db.Remove(card);
            _db.SaveChanges();
        }

        public List<CardDetailsView> GetByUserId(string UserId)
        {
            var cardDetails = 
                (from C in _db.CardDetails
                join UsCa in _db.UsersCards on C.Id equals UsCa.CardId
                where UserId == UsCa.AspNetUserId
                select new CardDetailsView
                {
                    Id = C.Id,
                    Name = C.Name,
                    CardNumber = C.CardNumber,
                    Cvc = C.Cvc,
                    ExpirationDate = C.ExpirationDate,
                }).ToList();
            return cardDetails;
        }
    }
}