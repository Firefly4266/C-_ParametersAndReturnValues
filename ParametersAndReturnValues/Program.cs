using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAndReturnValues
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator calc = new SimpleCalculator();

            Console.WriteLine(calc.Square(4));
            Console.WriteLine(calc.AddTwoNumbers(5, 6));
            Console.WriteLine("Enter a number to be squared.  ");
            string input = Console.ReadLine();
            int userRes = int.Parse(input);
            Console.WriteLine("The suqare of {0} is {1}", userRes, calc.Square(userRes));
            Console.WriteLine();
            Console.WriteLine("The maximum value is {0}.", calc.FindMaxOfThree(21, 58, 32));
            Console.WriteLine("figure that one out...");
        }
    }
}
