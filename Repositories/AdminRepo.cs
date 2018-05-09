using System;
using System.Linq;
using System.Threading.Tasks;
using BookCave.Data;
using BookCave.Data.EntityModels;
using Microsoft.AspNetCore.Identity;

namespace BookCave.Repositories
{
    public class AdminRepo
    {
        private readonly DataContext _db;

        public AdminRepo()
        {
                _db = new DataContext();
        }

        public void DisableAccount(string email, DateTime date, UserManager<AspNetUsers> userManager)
        {
            var user = _db.AspNetUsers.SingleOrDefault(b => b.Email == email);
            
            if(user != null)
            {
                user.LockoutEnd = date;
                _db.SaveChanges();
            }
        }
    }
}