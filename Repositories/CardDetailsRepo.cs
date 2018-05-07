using System.Collections.Generic;
using BookCave.Data.EntityModels;
using BookCave.Data;
using System.Linq;

namespace BookCave.Repositories
{
    public class CardDetailsRepo
    {
        private DataContext _db;

        public CardDetailsRepo()
        {
            _db = new DataContext();
        }

        public List<CardDetails> GetCardDetailsList()
        {
            var cardDetails = (from C in _db.CardDetails
                        select new CardDetails
                        {
                            Id = C.Id,
                            Name = C.Name,
                            CardNumber = C.CardNumber,
                            Cvc = C.Cvc,
                            ExpirationDate = C.ExpirationDate,
                        }).ToList();
            
            return cardDetails;
        }

        public void WriteCardDetails(CardDetails card)
        {
            _db.Add(card);
            _db.SaveChanges();
        }
    }
}