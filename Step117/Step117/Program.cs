using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step117
{
    public class Program
    {
        static void Main(string[] args)
        {
            Math myNums = new Math();

            Console.WriteLine("Enter a number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Math.MyNums(numOne);

            //double numTwo = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(Math.MyNums(numTwo));

            Console.ReadLine();
        }
    }
}