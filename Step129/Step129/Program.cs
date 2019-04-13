using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step129
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1, isActive = true };
            Employee emp2 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 2, isActive = true };
            Employee emp3 = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1, isActive = true };


            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp2 == emp3);
            Console.WriteLine(emp1 == emp3);

            Console.ReadLine();
        }
    }
}
