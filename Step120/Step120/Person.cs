﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step120
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
            {
                Console.WriteLine(FirstName + " " + LastName);
            }
    }
}


//1. Create a class called Person and 
//give it two properties, each of data type string. 
//One called FirstName, the other LastName.

//2. Give this class a void method called SayName() 
//that takes no parameters and simply writes the person's full name 
//to the console in the format of: "Name: [full name]".