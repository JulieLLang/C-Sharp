using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step124
{
    public abstract class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();
       
    }
}
//1. Create an abstract class called Person 
//with two properties: string firstName and string lastName.

//2. Give it the method SayName().