using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for math to occur:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your results for addition: " + numOne +" + 100 " + " = " + Math.AddTwoNumbers(numOne)); 
            Console.ReadLine();

            Console.WriteLine("Your results for division: " + numOne + " / 2 " + " = " + Math.DivideTwoNumbers(numOne));
            Console.ReadLine();

            Console.WriteLine("Your results for multiplication: " + numOne + " * 5 " + " = " + Math.MultiplyTwoNumbers(numOne));
            Console.ReadLine();

        }
    }
}
