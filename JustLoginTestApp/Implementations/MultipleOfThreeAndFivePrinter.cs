
namespace JustLoginTestApp.Console.Implementations
{
    public class MultipleOfThreeAndFivePrinter : Contracts.INumberPrinterStrategy
    {
        public string Print()
        {
            return "FizzBuzz";
        }
    }
}
