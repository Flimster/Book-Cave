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

        public void Write(UsersOrders userOrders)
        {
            _db.Add(userOrders);
            _db.SaveChanges();
        }
    }
}