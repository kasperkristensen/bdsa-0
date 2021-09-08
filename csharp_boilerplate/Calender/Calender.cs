using System;

namespace csharp_boilerplate {
    public class Calender {
        public static bool isLeapYear(int year) {
            if (year < 1582) {
                throw new ArgumentException(String.Format("{0} is not a valid input, as it must be greater than or equal to 1582", year),"year");
            }
                
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}