using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step131
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
    }
}
//1. Make the Employee class take a generic type parameter.
//2. Add a property to the Employee class called "things" and 
//have its data type be a generic list matching the generic type of the class.
