using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step162
{
    public class Employee
    {
        //CONST VAR CREATION
        const string name = "Squirrel Head Enterprise";

        public string First;
        public string Last;
        public int Id;

        //CHAIN 2 CONSTRUCTORS TOGETHER
        public Employee(string txt1) : this(txt1, "-", 500)
        {
            var First = txt1; //VAR CREATION USING "VAR"
        }

        public Employee(string txt1, string txt2) : this(txt1, txt2, 0)
        {
            First = txt1;
            Last = txt2;
        }

        public Employee(string txt1, string txt2, int integer)
        {
            First = txt1;
            Last = txt2;
            Id = integer;
        }

        public void printName()
        {
            Console.WriteLine(First + " " + Last + " " + "Employee Id: " + Id + "\nIs the CEO of" + " " + name);
        }
    }
}