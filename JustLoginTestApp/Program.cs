// See https://aka.ms/new-console-template for more information

using JustLoginTestApp.Console;

const int MAX = 100;
NumberPrinterStrategyContext context = new NumberPrinterStrategyContext();

for (int i = 1; i <= MAX; i++)
{
    var printer = NumberPrinterStrategyFactory.Create(i);
    context.SetStrategy(printer);
    context.Print();

}
Console.ReadLine();
