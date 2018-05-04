using BookCave.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookCave.Data.EntityModels;

namespace BookCave.Data
{
    public class AuthenticationDbContext : IdentityDbContext<AspNetUsers>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
        }
    }
}