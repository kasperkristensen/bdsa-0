namespace csharp_boilerplate {
    public class Calender {
        public static bool isLeapYear(int year) {
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }
    }
}