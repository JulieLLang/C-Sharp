using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step103
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1) Create a one-dimensional Array of strings.  Ask the user to input some text.
            ////create a loop that goes through each string in the Array, adding the user's text to the string.
            ////Then create a loop that prints off each string in the Array on a seperate line.

            Console.WriteLine("Please enter your name: ");
            string newName = Console.ReadLine();
            Console.WriteLine("Thanks " + newName + " for adding your name to our mailing list:");
            string[] names = new string[5] { "Julie", "Isaac", "Clarence", "Kitten", " " };

            for (int i = 0; i < names.Length; i++)
            {
                names[names.Length - 1] = (newName);
                Console.WriteLine(names[i]);
            }

            Array.Resize(ref names, names.Length + 1);

            Console.ReadLine();

            ////// 2. Create an infinate loop


            ////for ( ; ; )
            ////{
            ////    Console.Write(1);

            ////}

            //// 3. Fix the infinate loop

            //for (int i = 1; i > 0; i--)
            //{
            //    Console.Write(1);

            //}
            //Console.ReadLine();

            //// 4. Create a loop where the comparison used to determin whether to continue iterating the loop is a "<" Operator.

            //{
            //    int x = 1;

            //    while (x < 4)
            //    {
            //        Console.WriteLine("< 4!");

            //        x++;
            //    }
            //}
            //Console.ReadLine();

            ////5.Create a loop where the comparison used to determin whether tp continue iterating the loop is a "<=" Operator.

            //{
            //    int x = 1;

            //    while (x <= 4)
            //    {
            //        Console.WriteLine("<= 4!");

            //        x++;
            //    }
            //}
            //Console.ReadLine();

            ////6.Create a List of strings where each item in the list is unique.
            ////Ask the user to select text to search for in the List.
            ////Create a loop that iterates through the list and then displays 
            ////the index of the array that contains matching text on the screen.
            ///AND
            ////7. Add code to that above loop that tells a user if they put in text that isn’t in the List.
            ///AND
            ////8.Add code to that above loop that stops it from executing once a match has been found.

            //List<string> colors = new List<string>() { "red", "orange", "yellow", "green", "blue", "indigo", "violet" };

            //Console.WriteLine("Please choose a color of the rainbow");
            //string yourAns = Console.ReadLine().ToLower();

            //var i = 0;
            //bool colorF = false;

            //while (i < colors.Count)
            //{
            //    if (yourAns == colors[i])
            //    {
            //        colorF = true;
            //        Console.WriteLine("you chose index " + i);
            //        // step 8
            //        break;
            //    }
            //    i++;   
            //}
            //// step 7
            //if (colorF == false)
            //{
            //    Console.WriteLine("You enterd a color that doesn't exist.");
            //}
            //Console.ReadLine();

            ////9. Create a List of strings that has at least two identical strings in the List. 
            ////Ask the user to select text to search for in the List.
            ////Create a loop that iterates through the list and then displays the indices of the array 
            ////that contain matching text on the screen.
            ///AND
            ////10. Add code to that above loop that tells a user if they put in text that isn’t in the List.

            //List<string> animals = new List<string>()
            //{ "bear", "dog", "cat", "unicorn", "horse", "tiger", "camel", "cat" };

            //Console.WriteLine("Please choose an animal");
            //string yourAns = Console.ReadLine().ToLower();

            //var i = 0;
            //bool animal = false;

            //while (i < animals.Count)
            //{
            //    if (yourAns == animals[i])
            //    {
            //        animal = true;
            //        Console.WriteLine("you chose the animal at index " + i);

            //    }
            //    i++;
            //}
            //// step 10
            //if (animal == false)
            //{
            //    Console.WriteLine("You enterd an animal doesn't exist.");
            //}
            //Console.ReadLine();


            ////11.Create a List of strings that has at least two identical strings in the List. 
            ////Create a foreach loop that evaluates each item in the list, 
            ////and displays a message showing the string and whether or not it has already appeared in the list.

            //List<string> list = new List<string>() { "apple", "orange", "pear", "blueberries", "melon", "apple" };
            //List<string> newList = new List<string>();

            //var i = 0;
            //foreach (var item in list)
            //{
            //    if (!newList.Contains(item))
            //    {
            //        newList.Add(item);
            //        Console.WriteLine(item + " is not in the list");
            //    }
            //    else
            //    {
            //        Console.WriteLine("this item has already appeared in the list: " + list[i]); 
            //    }
            //}
            //Console.ReadLine();
        }
    }

}