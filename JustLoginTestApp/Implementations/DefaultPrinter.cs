using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustLoginTestApp.Console.Implementations
{
    public class DefaultPrinter : Contracts.INumberPrinterStrategy
    {
        private readonly int _number;
        public DefaultPrinter(int number)
        {
            _number = number;
        }
        public string Print()
        {
            return _number.ToString();
        }
    }
}
