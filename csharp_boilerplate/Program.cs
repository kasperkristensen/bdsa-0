using System;

namespace csharp_boilerplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            
            try {
            var year = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Calender.isLeapYear(year) ? "yay" : "nay");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
