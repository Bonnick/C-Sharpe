using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval Form"); // The program start by printing car insurance approval form

            // This command ask user input to type in there age.
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            Console.ReadLine();
            
            //This command is indicating that the user has no DUI.
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine(false || false);
            Console.ReadLine();

            // This command allow user put on speeding tickets.
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
  
            // When you put in 1 speeding ticket the result is true. If you have 4 speeding ticket the results is false. 
            bool speedticket = (tickets < 3);
            Console.WriteLine(speedticket);
            Console.ReadLine();



            
        }
    }
}
