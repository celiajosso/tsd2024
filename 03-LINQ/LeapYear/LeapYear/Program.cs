using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // leap year method as a lambda expression
            Func<int, bool> isLeapYear = year => (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));

            // tests on the lambda expression
            Console.WriteLine("=== Test of leap year lambda function");
            Console.WriteLine("2024 is " + (isLeapYear(2024) ? "" : "not") + " a leap year");
            Console.WriteLine("2025 is " + (isLeapYear(2025) ? "" : "not") + " a leap year");

            // tests on the generic collection
            Console.WriteLine("\n\n=== Test on the generic collection");

            var myRandomList = new RandomizedList<int>();

            myRandomList.Add(1);
            myRandomList.Add(2);
            myRandomList.Add(3);
            myRandomList.Add(4);
            Console.WriteLine("- Added 1, 2, 3, 4");
            Console.WriteLine("- Random element from index 2: " + myRandomList.Get(2));
            Console.WriteLine("- The collection is " + (myRandomList.IsEmpty() ? "" : "not") + " empty");
            Console.WriteLine("- List size: " + myRandomList.Size());
        }
    }
}
