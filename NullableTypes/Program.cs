using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            Nullable<DateTime> date1 = null;

            Console.WriteLine("GetValueOrDefault -> " + date.GetValueOrDefault());
            Console.WriteLine("HasValue -> " + date.HasValue);
            Console.WriteLine("Value -> " + date.Value);

            Console.WriteLine("GetValueOrDefault -> " + date1.GetValueOrDefault());
            Console.WriteLine("HasValue -> " + date1.HasValue);
            Console.WriteLine("Value -> " + date1.Value);

            DateTime? date2 = new DateTime(2014, 1, 1);
            //DateTime? date3 = date2 -> this goes to an error best way to do it
            DateTime? date3 = date2.GetValueOrDefault();

            //Null Coalescing Operator
            DateTime? xdate = null;
            DateTime? xdate2;

            if (xdate != null)
            {
                xdate2 = xdate.GetValueOrDefault();
            }
            else
            {
                xdate2 = DateTime.Today;
            }

            //We can use a short way to do the same that the code above, using Null Coalescing Operator
            DateTime? ydate = null;
            DateTime? ydate2 = ydate ?? DateTime.Today;

            //Same thing we did above we can do it using the tertiary operator
            DateTime? zdate = null;
            DateTime? zdate2 = (zdate != null) ? zdate.GetValueOrDefault() : DateTime.Today;
        }
    }
}
