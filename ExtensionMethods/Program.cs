using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blo and so and so and so...";
            var shortenedPost = post.Shorten(5);

            //In practical word we will be using extension method instead of creating them for instance IEnumerate below
            //Max is an extension method
            IEnumerable<int> numbers = new List<int> { 1, 2, 7, 15 };
            int MAXnumber = numbers.Max();
        }
    }

}
