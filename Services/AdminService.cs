using System;
using System.Collections.Generic;
using BookCave.Data;
using BookCave.Data.EntityModels;
using BookCave.Models.RegistrationModels;

namespace BookCave.Services
{
    public class AdminService : IAdminService
    {
        public void ProcessNewBook(BookRegistrationModel book)
        {
            if(string.IsNullOrEmpty(book.Title)) { throw new Exception("Title is empty"); }

            if(book.Authors == null) { throw new Exception("No authors selected"); }

            if(book.Genre == null) { throw new Exception("No genres selected"); }

            if(string.IsNullOrEmpty(book.Image)) { throw new Exception("No image selected"); }
            if(double.IsInfinity(book.Price)) { throw new Exception("Invalid price"); }
            if(double.IsNaN(book.Price)) { throw new Exception("Invalid price"); }
            if((book.Price <= 0)) { throw new Exception("Invalid price"); }

            //ISBN10 check
            if(string.IsNullOrEmpty(book.ISBN10)) { throw new Exception("ISBN10 is empy"); }
            if(book.ISBN10.Length != 10) { throw new Exception("Invalid length of ISBN10"); }

            //ISBN13 check
            if(string.IsNullOrEmpty(book.ISBN13)) { throw new Exception("ISBN13 is empty"); }
            if(book.ISBN13.Length != 13) { throw new Exception("Invalid length of ISBN13"); }

            if(string.IsNullOrEmpty(book.Description)) { throw new Exception("Description is empty"); }

            if(string.IsNullOrEmpty(book.Publisher)) { throw new Exception("Publisher is empty"); }
            
            if(book.Formats == null) { throw new Exception("No format selected"); }
        }
    }
}