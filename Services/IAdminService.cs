using BookCave.Models.InputModel;

namespace BookCave.Services
{
    public interface IAdminService
    {
        void ProcessNewBook(BookInputModel book);
    }
}