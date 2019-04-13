using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step126
{
    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("I Quit!");
        }
    }
}
// 2. Have your Employee class from the previous drill inherit 
//that interface and implement the Quit() method in any way you choose.
