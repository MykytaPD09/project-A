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

// Descr:
// 1. Змінив Location на Address для більшої коректності.
// 2. Змінив тип Librarian з Person на Librarian так як, Person у нас
// немає в програмі, а встановлювати IPerson не має сенсу, адже тоді
// виникає наступна ситуація.

// Ситуація: -- Хто ти воїн? Я біблотекар --
// (Тобто бібліотекарем нашої біблотеки може бути кожен хто реалізує IPerson)
//
// Приклад:
// Library library;
// library.Librarian = new Author(); - це не визве жодної помилки
// адже Autor реалізує IPerson
