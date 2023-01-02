using System;
using System.Collections.Generic;


namespace Console_App_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
       
          
            // Array of String
            string[] test= { "Hello", "Jesse", "Romario"};
              Console.WriteLine("enter a number 0-2");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0 || number <= 2)
            {
                Console.WriteLine(test[number]);
            }
            Console.ReadLine();

            //one dimensional array of integers

            int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
            Console.WriteLine("enter a array 0-7");
            int array = Convert.ToInt32(Console.ReadLine());
            if (array >=0 || array<=6)
            {
                Console.WriteLine(numArray2[array]);

    
            if (array > 6)
            {
                Console.WriteLine("Index selected does not exit");
            }
            else
            { 


            //List of String
            //List<string> intList = new List<string>() { "Hello", "Jesse", "Romario" };
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Jesse");
            intList.Add("Romario");

            Console.WriteLine("enter a number 0-2");
            int List = Convert.ToInt32(Console.ReadLine());
            if (List >=0 || List <=2)
            {
                Console.WriteLine(intList[List]);
            }
            else if ( List > 2)
            {
               Console.WriteLine(" Something went wrong");
            }

            Console.ReadLine();


            }
        }
    }
}