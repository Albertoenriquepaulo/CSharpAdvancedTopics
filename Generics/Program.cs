using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(10);
            //int a = numbers[0];

            var dictionary = new GenericDictionary<string, int>();

            var num = new Nullable<int>(5);
            Console.WriteLine("has Value ? " + num.HasValue);
            Console.WriteLine("Value: " + num.GetValueOrDefault());

            var num1 = new System.Nullable<int>(5);
            Console.WriteLine("has Value ? " + num1.HasValue);
            Console.WriteLine("Value: " + num1.GetValueOrDefault());

        }
    }
}
