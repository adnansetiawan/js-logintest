namespace JustLoginTestApp.Console
{
    /// <summary>
    /// use strategy design pattern
    /// </summary>
    public class NumberPrinterContext
    {
        private Contracts.INumberPrinter? _numberPrinter;

       
        public void SetStrategy(Contracts.INumberPrinter? numberPrinter)
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
