using System;
using Xunit;
using csharp_boilerplate;

namespace csharp_boilerplate_test
{
    public class isLeapYearTests
    {
        [Fact]
        public void if_divisible_by_4_return_true()
        {
            bool actual = Calender.isLeapYear(2024);

            Assert.Equal(true, actual);
        }

        [Fact]
        public void if_not_divisible_by_4_return_false()
        {
            bool actual = Calender.isLeapYear(2019);

            Assert.Equal(false, actual);
        }

        [Fact]
        public void if_divisible_by_100_return_false()
        {
            bool actual = Calender.isLeapYear(1800);

            Assert.Equal(false, actual);
        }

        [Fact]
        public void if_divisible_by_100_and_400_return_true()
        {
            bool actual = Calender.isLeapYear(2000);

            Assert.Equal(true, actual);
        }
    }
}
