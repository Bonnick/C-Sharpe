using System;
using System.Collections.Generic;


namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This console code list all the items that will appear on the screen.
            List<string> Letters = new List<string>() { "A-this item is unique", "B - this item is unique", "C - this item is unique", "D - this item is unique", "C - this item is a duplicate" };
            //The foreach loop displays the message of the items on the screen.
            foreach (string lists in Letters)
           {
           Console.WriteLine(lists);
           }
           Console.ReadLine();
          
        }
    }
}
