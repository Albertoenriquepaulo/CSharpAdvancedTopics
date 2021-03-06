﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //arguments => expresion
            //No arguments, () => ...
            //one arguments we can avoid using parenthesis, x => ...
            //More than one arguments we have to use parenthesis, (x,y) => ...
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            //Scope
            const int factor = 5;
            Func<int, int> multipler = n => n * factor;
            int result = multipler(10);

            //Way 1 - Using Predicate functions
            var books = new BookRepository().GetBooks();
            var cheapBooks1 = books.FindAll(IsCheaperThan10);
            foreach (var book in cheapBooks1)
            {
                Console.WriteLine(book.Title);
            }

            //Way 2 - Using lambda expression and LINQ
            BookRepository bookRepository = new BookRepository();
            List<Book> cheapBooks2 = (bookRepository.GetBooks()).Where(book => book.Price < 10).ToList();
            Console.WriteLine("--------------------");
            foreach (var book in cheapBooks2)
            {
                Console.WriteLine(book.Title);
            }

            //Way 3 - Using Lambda expression
            var books3 = new BookRepository().GetBooks();
            var cheapBooks3 = books3.FindAll(b => b.Price < 10);
            Console.WriteLine("--------------------");
            foreach (var book in cheapBooks3)
            {
                Console.WriteLine(book.Title);
            }
        }

        // This is used as a Predicate function in Way 1
        private static bool IsCheaperThan10(Book book)
        {
            return book.Price < 10;
        }
    }
}
