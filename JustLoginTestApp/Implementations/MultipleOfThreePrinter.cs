
namespace JustLoginTestApp.Console.Implementations
{
    public class MultipleOfThreePrinter : Contracts.INumberPrinterStrategy
    {
        private readonly Contracts.INumberPrinterStrategy? _decorator;

        public MultipleOfThreePrinter(Contracts.INumberPrinterStrategy? decorator = null)
        {
            _decorator = decorator;
        }
        public string Print()
        {

            return "Fizz" + _decorator?.Print();
           
        }
    }
}
