using Xunit;

namespace JustLoginTestApp.Console.Test
{
    public class PrinterTest
    {
        [Fact]
        public void Test_Multiple_Of_Three()
        {
            // Arrange  
            var number = 3;
            var expected = "Fizz";
            var strategy = NumberPrinterStrategyFactory.Create(new CustomNumber(number));

            // Act  
            var result = strategy.Print();
            //Assert  
            Assert.Equal(expected, result);
        }
        [Fact]
        public void Test_Multiple_Of_Five()
        {
            // Arrange  
            var number = 5;
            var expected = "Buzz";
            var strategy = NumberPrinterStrategyFactory.Create(new CustomNumber(number));

            // Act  
            var result = strategy.Print();
            //Assert  
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Multiple_Of_Three_Five()
        {
            // Arrange  
            var number = 15;
            var expected = "FizzBuzz";
            var strategy = NumberPrinterStrategyFactory.Create(new CustomNumber(number));

            // Act  
            var result = strategy.Print();
            //Assert  
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Default()
        {
            // Arrange  
            var number = 4;
            var expected = "4";
            var strategy = NumberPrinterStrategyFactory.Create(new CustomNumber(number));

            // Act  
            var result = strategy.Print();
            //Assert  
            Assert.Equal(expected, result);
        }
    }
}