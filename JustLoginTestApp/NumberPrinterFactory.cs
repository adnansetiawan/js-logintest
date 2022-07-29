
namespace JustLoginTestApp.Console
{
    /// <summary>
    /// simple factory pattern
    /// </summary>
    public class NumberPrinterFactory
    {
        private static Dictionary<string, Contracts.INumberPrinter> printers = new Dictionary<string, Contracts.INumberPrinter>();

        static NumberPrinterFactory()
        {
            
            printers.Add("MultipleOfThree", new Implementations.MultipleOfThreePrinter());
            printers.Add("MultipleOfFive", new Implementations.MultipleOfFivePrinter());
            printers.Add("MultipleOfThreeAndFive", new Implementations.MultipleOfThreeAndFivePrinter());

        }

        public static Contracts.INumberPrinter? Create(string type)
        {
            if(string.IsNullOrEmpty(type))
                return null;
            return printers[type];
        }
    }
}
