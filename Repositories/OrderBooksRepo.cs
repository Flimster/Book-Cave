using BookCave.Data;
using BookCave.Data.EntityModels;

namespace BookCave.Repositories
{
    public class OrderBooksRepo
    {
        private DataContext _db;

        public OrderBooksRepo()
        {
            _db = new DataContext();
        }

        public void Write(OrdersBooks orderBooks)
        {
            _db.Add(orderBooks);
            _db.SaveChanges();
        }
    }
}