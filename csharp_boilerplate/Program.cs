using System;

namespace csharp_boilerplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            var year = Console.ReadLine();

            Console.WriteLine(year + "is a valid leap year");
        }
    }
}
