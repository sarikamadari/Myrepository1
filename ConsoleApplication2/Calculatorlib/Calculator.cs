using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatorlib
{
    public class Calculator
    {
        /// <summary>
        /// Calculator class
        /// </summary>
        /// <param name="a">the first parameter</param>
        /// <param name="b">the second parameter</param>
        /// <returns>the sum of input parameters</returns>
        public  int sum(int a, int b)
        {
            return a + b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public int divide(int a, int b)
        {
            return a / b;
        }
    }
}
