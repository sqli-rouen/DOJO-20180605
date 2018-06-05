using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLI.CodingDojo
{
    public class FizzBuzz
    {
        public static string CheckValue(int value)
        {
            if(value==0)
                throw new ArgumentException();

            if (value == 3)
                return "Fizz";
            else
                return value.ToString();
        }
    }
}
