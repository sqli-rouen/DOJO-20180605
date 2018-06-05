using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLI.CodingDojo
{
    public class FizzBuzz
    {
        public static int CheckValue(int value)
        {
            if (value == 0)
                throw new ArgumentException();
            else 
                return value;
        }
    }
}
