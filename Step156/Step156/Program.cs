using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step156
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateValue = new DateTime();
            dateValue = DateTime.Now;

            Console.WriteLine("{0}", dateValue);
            Console.WriteLine("Please enter a number:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("In {0} hours, the date and time will be: \n{1}.", x, dateValue.AddHours(x));

            Console.ReadLine();
        }
    }
}
