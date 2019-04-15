using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Step154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int yourNumber = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\Users\Student\Documents\GitHub\C-Sharp\Step154\Logs\log.txt", true))
            {
                file.WriteLine(yourNumber);
            }
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Student\Documents\GitHub\C-Sharp\Step154\Logs\log.txt");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
                Console.ReadLine();
        }
    }
}

        