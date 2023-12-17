namespace Project.Classes
{
    public class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Book> Books { get; set; }
        public Librarian Librarian { get; set; }
    }
}
