using Project.Interfaces;

namespace Project.Classes
{
    public class Librarian : IPerson
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Librarian(string FirstName, string LastName, int age, int salary)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            Age = age;
            Salary = salary;
        }
    }
}
