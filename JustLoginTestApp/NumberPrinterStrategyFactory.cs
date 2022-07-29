
using JustLoginTestApp.Console.Extensions;

namespace JustLoginTestApp.Console
{
    /// <summary>
    /// simple factory pattern
    /// </summary>
    public class NumberPrinterStrategyFactory
    {
        private static Dictionary<string, Contracts.INumberPrinterStrategy> printers = new Dictionary<string, Contracts.INumberPrinterStrategy>();

     
        public static Contracts.INumberPrinterStrategy Create(int number)
        {
            if (number.IsMultipleOfThree() && number.IsMultipleOfFive())
            {
                return new Implementations.MultipleOfThreeAndFivePrinter();
            }
            else if (number.IsMultipleOfThree())
            {
                return new Implementations.MultipleOfThreePrinter();

            }
            else if (number.IsMultipleOfFive())
            {
                return new Implementations.MultipleOfFivePrinter();

            }
            else
            {
                return new Implementations.DefaultPrinter(number);
            }
        }
    }
}
