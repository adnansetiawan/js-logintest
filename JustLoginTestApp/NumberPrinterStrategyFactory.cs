

namespace JustLoginTestApp.Console
{
    /// <summary>
    /// simple factory pattern
    /// </summary>
    public class NumberPrinterStrategyFactory
    {
        private static Dictionary<string, Contracts.INumberPrinterStrategy> printers = new Dictionary<string, Contracts.INumberPrinterStrategy>();

     
        public static Contracts.INumberPrinterStrategy Create(CustomNumber number)
        {
            if (number.IsMultipleOfThree && number.IsMultipleOfFive)
            {
                return new Implementations.MultipleOfThreeAndFivePrinter();
            }
            if (number.IsMultipleOfThree)
            {
                return new Implementations.MultipleOfThreePrinter();

            }
            if (number.IsMultipleOfFive)
            {
                return new Implementations.MultipleOfFivePrinter();

            }
            return new Implementations.DefaultPrinter(number.Number);
            
        }
    }
}
