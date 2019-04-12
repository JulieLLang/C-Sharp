using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step115
{
    class Program
    {
        static void Main(string[] args)
        {


            Math math = new Math();
            //Math.AddTwoNumbers(numOne, numTwo = 0);

            Console.WriteLine("Please input a number: ");
            int inputOne = Convert.ToInt32(Console.ReadLine());

            Console.ReadLine();

            Console.WriteLine("Please input another number, only if you want to: ");
            string inputTwoStr = Console.ReadLine();

            Console.ReadLine();



            if (!string.IsNullOrEmpty(inputTwoStr))
            {
                int inputTwo = Convert.ToInt32(inputTwoStr);

                Console.WriteLine("Thanks for your inputs! (" + inputOne + " * 2) " + "+ " + inputTwo + " = " + Math.AddTwoNumbers(inputOne, inputTwo));

            }
            else
            {
                Console.WriteLine("Without a second number your problem works out to: " + inputOne + " * 2 " + " = " + Math.AddTwoNumbers(inputOne));
            }
            Console.ReadLine();
        }
    }
}
