using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculatorlib;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal=new Calculator();
            var result = cal.sum(2,4);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
