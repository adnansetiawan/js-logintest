using JustLoginTestApp.Console.Extensions;
using JustLoginTestApp.Console.Implementations;


namespace JustLoginTestApp.Console
{
    public static class MainProgram
    {
        private const int MAX = 100;
        public static void PrintNumber()
        {
            NumberPrinterContext context = new NumberPrinterContext();
            Contracts.INumberPrinter? printer;
            for (int i = 1; i <= MAX; i++)
            {
                if (i.IsMultipleOfThree() && i.IsMultipleOfFive())
                {
                    printer = NumberPrinterFactory.Create("MultipleOfThreeAndFive");

                }
                else if (i.IsMultipleOfThree())
                {
                    printer = NumberPrinterFactory.Create("MultipleOfThree");

                }
                else if (i.IsMultipleOfFive())
                {
                    printer = NumberPrinterFactory.Create("MultipleOfFive");

                }
                else
                {
                    printer = new Implementations.DefaultPrinter(i);
                }
               
                context.SetStrategy(printer);
                context.Print();
               
               
            }

        }
       
    }
   
  
}
