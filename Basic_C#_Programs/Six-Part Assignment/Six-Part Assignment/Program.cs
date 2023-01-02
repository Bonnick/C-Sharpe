using System;
using System.Collections.Generic;


namespace Six_Part_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment Part 1
            string lineOne = "Beware; ";
            string lineTwo = "for I am fearless, ";
            string lineThree = "and therefore powerful. ";

            //Concatenating the three strings:
            Console.Write(lineOne + lineTwo + lineThree);

            //Assignment Part 2
            //A string to be converted to uppercase:
            string x = "who controls the past controls the future. ";

            //Converting string to uppercase:
            Console.WriteLine(x.ToUpper());
            Console.ReadLine();
        }
    }
}
