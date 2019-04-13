using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step137
{
    public class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 1091.59M };

            Console.WriteLine("Amount = ${0}", number.Amount);
            Console.ReadLine();
        }
    }
}
