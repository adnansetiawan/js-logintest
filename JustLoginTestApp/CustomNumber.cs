using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustLoginTestApp.Console
{
    public class CustomNumber
    {
        private readonly int _number;
        public CustomNumber(int number)
        { 
            _number = number;
        }
        public int Number
        { 
            get { return _number; }
        }
        public bool IsMultipleOfThree
        {
            get
            {
                return _number % 3 == 0;
            }
        }
        public bool IsMultipleOfFive
        {
            get
            {
                return _number % 5 == 0;
            }
        }
    }
   
}
