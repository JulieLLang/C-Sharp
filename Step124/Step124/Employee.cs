﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step124
{
    public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
//3. Create another class called Employee and have it inherit from the Person class.
//4. Implement the SayName() method inside of the Employee class.