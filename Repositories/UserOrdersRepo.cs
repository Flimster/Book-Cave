using BookCave.Data;
using BookCave.Data.EntityModels;

namespace BookCave.Repositories
{
    public class UserOrdersRepo
    {
        private DataContext _db;

        public UserOrdersRepo()
        {
            _db = new DataContext();
        }

        public void Write(UsersOrders UsersOrders)
        {
            _db.Add(UsersOrders);
            _db.SaveChanges();
        }

        public void Remove(UsersOrders UsersOrders)
        {
            _db.Remove(UsersOrders);
            _db.SaveChanges();
        }
    }
}