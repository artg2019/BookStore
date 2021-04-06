using Store.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books = new List<Book>{
            new Book(1,"Refactoring"),
            new Book(2,"C# in Depht"),
            new Book(3,"CLR via C#")
        };
        public List<Book> GetAllByTitle(string titlePart)
        {
            return _books.Where(b => b.Title.Contains(titlePart)).ToList();
        }
    }
}
