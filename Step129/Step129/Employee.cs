using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step129
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public bool isActive { get; set; }
            
        public static bool operator== (Employee emp1, Employee emp2)
        {
            return Equals(emp1.Id, emp2.Id);
        }
        public static bool operator!= (Employee emp1, Employee emp2)
        {
            return !Equals(emp1.Id, emp2.Id);
        }
    }
}
