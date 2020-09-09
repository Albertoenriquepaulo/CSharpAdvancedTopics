using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();




            //LINQ Extensions Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10);

            var cheapBooksOrderedByTitle = books
                                            .Where(b => b.Price < 10)
                                            .OrderBy(b => b.Title);

            var stringListOfcheapBooksOrderedByTitle = books
                                                            .Where(b => b.Price < 10)
                                                            .OrderBy(b => b.Title)
                                                            .Select(b => b.Title);
            //Fin LINQ Extensions Methods

            //LINQ Query Operators, this always start with "from" and always finish with the "select"
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            //Fin LINQ Query Operators

            //LINQ Extensions Methods, this method goes to an error if there is not any book with that title
            //to avoid it we can use "SingleOrDefault" line 40
            var book = books.Single(b => b.Title == "ASP.NET MVC");
            //If there is not object matching this condition the Default value will be return which in this case would be null
            var book1 = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");


            //These are used for paging data, this means skip to record/object and takes three
            var bookList = books.Skip(2).Take(3);

            foreach (var pagedBook in bookList)
            {
                Console.WriteLine(pagedBook.Title);
            }

            var priceOfMoreExpensiveBook = books.Max(b => b.Price);
            var priceOfCheapestBook = books.Min(b => b.Price);
            var totalPrices = books.Sum(b => b.Price);
            var averages = books.Average(b => b.Price);

        }
    }
}
