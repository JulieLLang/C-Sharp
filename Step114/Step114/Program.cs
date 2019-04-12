using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step114
{
    class Program
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Input a whole number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(+ Math.AddTwoNumbers(numOne));
            Console.ReadLine();

            Console.WriteLine("Input a number with a decimal: ");
            double numTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.AddTwoNumbers(numTwo));
            Console.ReadLine();

            Console.WriteLine("Input another whole number: ");
            int numThree = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.AddTwoNumbers(numThree * 10));
            Console.ReadLine();

        }

    }
}
