namespace BookCave.Data.DatabaseExtraction
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CoverPhoto { get; set; }
        public int PageCount { get; set; }
        public int PublisherId { get; set; }
        public int ReleaseYear { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public int Isbn10 { get; set; } 
        public int Isbn13 { get; set; }
        public int StockCount { get; set; }
        public int Visibility { get; set; }
        public int FormatId { get; set; }
    }
}