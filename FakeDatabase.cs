using System.Collections.Generic;
using System.Linq;
using BookCave.Models.ViewModels;

namespace BookCave
{
    public static class FakeDatabase
    {
        public static List<BookViewModel> Books = new List<BookViewModel>()
        {
            new BookViewModel { Id = 1, Title = "Harry Potter and the chamber of secrets", Author = {"J.K Rowling"}, Genre = "Fantasy", Image = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4088/9781408855669.jpg", Price = 9.99 }, 
            new BookViewModel { Id = 2, Title = "Harry Potter and the goblet of fire", Author = {"J.K Rowling"}, Genre = "Fantasy", Image = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4088/9781408855683.jpg", Price = 12.99},
            new BookViewModel { Id = 3, Title = "Head first C#", Author = {"Abcd"}, Genre = "Computer Science", Image = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4493/9781449343507.jpg", Price = 13.99},
            new BookViewModel { Id = 4, Title = "The Lord of the Rings: The Fellowship of the Ring", Author = {"J.R.R Tolkien"}, Genre = "Fantasy", Image = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/3453/9780345339706.jpg", Price = 8.99 },
            new BookViewModel { Id = 5, Title = "Brave New World", Author = {"Aldous Huxley"}, Genre = "Science Fiction", Image = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/0994/9780099477464.jpg", Price = 15.99 },
            new BookViewModel { Id = 6, Title = "Nineteen Eighty-Four", Author ={"George Orwell"}, Genre = "Science Fiction", Image = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1410/9780141036144.jpg", Price = 9.99 },
            new BookViewModel { Id = 7, Title = "Animal Farm", Author = {"George Orwell"}, Genre = "Fiction", Image = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/1410/9780141036137.jpg", Price = 7.99 },
            new BookViewModel { Id = 8, Title = "Lord of the Flies", Author = {"William Golding"}, Genre = "Fiction", Image = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/3995/9780399501487.jpg", Price = 12.99 },
            new BookViewModel { Id = 9, Title = "The Catcher in the Rye", Author = {"J.D. Salinger"}, Genre = "Fiction", Image = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9780/3167/9780316769488.jpg", Price = 19.99 }
        };
    }
}