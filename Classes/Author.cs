using Project.Interfaces;

namespace Project.Classes
{
    public class Author : IPerson
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public Author(string firstName, string lastName, int age)
        {
            throw new NotImplementedException();
        }
    }
}
