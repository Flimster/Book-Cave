using BookCave.Models.RegistrationModels;

namespace BookCave.Services
{
    public interface IAdminService
    {
        void ProcessNewBook(BookRegistrationModel book);
    }
}