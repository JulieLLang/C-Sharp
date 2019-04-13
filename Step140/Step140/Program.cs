using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step140
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1.In the Main() method, create a list of 10 employees.
            //Each employee should have a first and last name, as well as an ID
            //At least two employees should be named Joe
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee { FirstName = "Julie", LastName = "Lang", Id = 23 });
            employeeList.Add(new Employee { FirstName = "Clarence", LastName = "Whorley", Id = 67 });
            employeeList.Add(new Employee { FirstName = "Marishka", LastName = "Boneparte", Id = 90 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Burgess", Id = 343 });
            employeeList.Add(new Employee { FirstName = "Atherton", LastName = "Williams III", Id = 287 });
            employeeList.Add(new Employee { FirstName = "Jesus", LastName = "Ramirez", Id= 1 });
            employeeList.Add(new Employee { FirstName = "Kalypso", LastName = "Mielow", Id = 76 });
            employeeList.Add(new Employee { FirstName = "Joesephina", LastName = "Reinland", Id = 76 });
            employeeList.Add(new Employee { FirstName = "Joe", LastName = "Biden", Id = 3 });
            employeeList.Add(new Employee { FirstName = "Margarette", LastName = "Hasselbeck", Id = 2 });

            //2. Using a foreach loop, create a new list of all employees with the first name "Joe"
            List<Employee> joeList = new List<Employee>();

            foreach (var employee in employeeList)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }

            foreach (var joe in joeList)
            {
                Console.WriteLine("{0} {1} {2}", joe.FirstName, joe.LastName, joe.Id);
            }

            //3. Do the same as #2, but this time with a lambda expression
            List<Employee> joeList1 = employeeList.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee joe in joeList1)
            {
                Console.WriteLine("{0} {1} {2}", joe.FirstName, joe.LastName, joe.Id);
            }

            //4.Using a lambda expression, make a list of all employess with an Id > 5
            List<Employee> idMoreThan = employeeList.Where(x => x.Id > 5).ToList();
            foreach (Employee num in idMoreThan)
            {
                Console.WriteLine("{0} {1} {2}", num.FirstName, num.LastName, num.Id);
            }

            Console.ReadLine();
        }
    }
}
