// See https://aka.ms/new-console-template for more information

using JustLoginTestApp.Console;

const int MAX = 100;
NumberPrinterStrategyContext context = new NumberPrinterStrategyContext();

for (int number = 1; number <= MAX; number++)
{
    var printer = NumberPrinterStrategyFactory.Create(new CustomNumber(number));
    context.SetStrategy(printer);
    context.Print();

}
Console.ReadLine();
