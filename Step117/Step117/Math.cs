using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step117
{
    class Math
    {
        //create class create void method that outputs an intger.  Divide the data by 2.
        public static void MyNums(int numOne)
        {
            Console.WriteLine("The Simple Soultion is : " + numOne + " / " + " 2 " + " = " + (numOne / 2));
        }

        public static double myNums(double numTwo)
        {
            return numTwo + 10.3;
        }
        
        public int myNums1(int num, out int numOne, out int numTwo)
        {
            numOne = num + 5;
            numTwo = num + 7;
            return numOne + numTwo;
        }
    }
}
