using System;
using System.Collections.Generic;

class Program
{
        static void Main(string[] args)

    {
        try
        {

            {
                List<int> numOne = new List<int>() { 10, 20, 30, 40 };
                Console.WriteLine("Enter a number:");
                int newNum = Convert.ToInt32(Console.ReadLine());
                foreach (int number in numOne)
                {

                    for (int i = 0; i < numOne.Count; i++)
                    {
                        int answer = numOne[i] / newNum;
                        Console.WriteLine(numOne[i] + " " + ("/") + " " + newNum + " " + ("=") + " " + answer);
                    }

                    Console.ReadLine();
                }
            }
        }

        catch (DivideByZeroException) //3. don't divide by zero
        {
            Console.WriteLine("Please don't divide by 0!");
        }

        catch (FormatException) //4. Format exception
        {
            Console.WriteLine("Please enter a whole number.");

        }

        finally
        {
            Console.ReadLine();
        }

    }
}





      


