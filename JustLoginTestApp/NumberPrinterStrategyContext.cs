namespace JustLoginTestApp.Console
{
    /// <summary>
    /// use strategy design pattern
    /// </summary>
    public class NumberPrinterStrategyContext
    {
        private Contracts.INumberPrinterStrategy? _numberPrinter;

       
        public void SetStrategy(Contracts.INumberPrinterStrategy numberPrinter)
        {
            _numberPrinter = numberPrinter;
        }
        public void Print()
        {
            if (_numberPrinter == null)
                throw new Exception("please set printer implementation");
            System.Console.WriteLine(_numberPrinter.Print());
        }
        
    }
}
