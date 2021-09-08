using System;

namespace csharp_boilerplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            var year = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Calender.isLeapYear(year) ? "yay" : "nay");
        }
    }
}
