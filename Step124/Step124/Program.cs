using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step124
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            employee.SayName();

            Console.ReadLine();
        }
    }
}
//5. Inside the Main() method, instantiate an Employee 
//object with firstName "Sample" and lastName "Student". 
//Call the SayName() method on the object.