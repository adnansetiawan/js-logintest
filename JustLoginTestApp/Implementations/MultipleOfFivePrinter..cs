
namespace JustLoginTestApp.Console.Implementations
{
    public class MultipleOfFivePrinter : Contracts.INumberPrinterStrategy
    {
        private readonly Contracts.INumberPrinterStrategy? _decorator;

        public MultipleOfFivePrinter(Contracts.INumberPrinterStrategy? decorator = null)
        {
            _decorator = decorator;
        }
        public string Print()
        {

            return "Buzz" + _decorator?.Print();

        }
    }
}
