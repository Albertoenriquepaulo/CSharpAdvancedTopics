using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book{Title = "Ado Bible", Price = 5},
                new Book{Title = "ASP.NET MVC", Price = 9.99f},
                new Book{Title = "The black book of code", Price = 12},
                new Book{Title = "C# Advanced Topics", Price = 7},
                new Book{Title = "JavScripts Vanilla for Dummies", Price = 9}
            };
        }
    }
}
