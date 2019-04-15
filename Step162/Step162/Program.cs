using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step162
{
    class Program
    {
        static void Main(string[] args)
        {
            const string companyName = "JAR";

            Console.WriteLine("Welcome to {0}. \nHow many JAR's of Jam would you like?", companyName);
            var jam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("That will be: " + jam + " JAR's of Jam on the way!\nWe guarantee you won't be disappointed!Thank you for your business.");
            Console.ReadLine();
        }
    }
}

