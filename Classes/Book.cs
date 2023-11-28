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

// Descr:
// 1. Додав конструктор який має заповнювати поля базовими значеннями
// 2. Змінив тип поля Author з Person на Author так як, типу Person у нас
// немає в програмі, а встановлювати IPerson не має сенсу, адже тоді
// виникає наступна ситуація

// Ситуація: -- Мистецтво у нас в крові --
// (Тобто книжку може написати і автор і всі персони які
// реалізують IPerson)
//
// Приклад:
// Book book;
// book.Author = new Librarian(); - це не визве жодної помилки
// адже Librarian реалізує IPerson
