using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step131
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Instantiate an Employee object with type "string" as its generic parameter.
            //Assign a list of strings as the property value of Things.
            Employee<string> Employees = new Employee<string>() { Things = new List<string> { "Rebecca", "Alice", "Steve" } };

            //3. Instantiate an Employee object with type "string" as its generic parameter.
            //Assign a list of strings as the property value of Things.
            Employee<int> EmployeeID = new Employee<int>() { Things = new List<int> { 101, 572, 1033 } };

            //5. Create a loop that prints all of the Things to the Console.
            foreach (string Employee in Employees.Things)
            {
                Console.WriteLine("Name: " + Employee);
            }

            foreach (int ID in EmployeeID.Things)
            {
                Console.WriteLine("Employee ID: " + ID);
            }

            Console.ReadLine();
        }
    }
}






