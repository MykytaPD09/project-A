using Project.Enums;

namespace Project.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int PublishedYear { get; set; }
        public Genre Genge { get; set; }

        public Book(string Title, int PublishedYear, Author author, Genre Genre)
        {
             throw new NotImplementedException();
        }
    }
}