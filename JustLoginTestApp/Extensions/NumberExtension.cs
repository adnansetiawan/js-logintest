using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustLoginTestApp.Console.Extensions
{
    public static class NumberExtension
    {
        public static bool IsMultipleOfThree(this int number)
        {
            return number % 3 == 0;
        }
        public static bool IsMultipleOfFive(this int number)
        {
            return number % 5 == 0;
        }
    }
}
