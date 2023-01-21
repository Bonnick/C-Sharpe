using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment_Submission
{
    public class Program
    {
        //Create an enum for the days of the week.
        public enum DayOfWeek
        {
            Monday,
            Tuesday ,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday 

        }

        static void Main(string[] args)
        {
            //Prompt the user to enter the current day of the week.
            Console.WriteLine("Enter the current Day of the Week");
            string day = Console.ReadLine();

            //Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.

            try
            {

           //Assign the value to a variable of that enum data type you just created.

                DayOfWeek week = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);
                 
                Console.WriteLine("Oh yes the day of the week is " + week);
            
            }

               
                 catch (FormatException ex)
                   {
                       Console.WriteLine("Please enter an actual day of the week" + day);
                  }

                   catch (Exception ex)
                   {
                       Console.WriteLine(ex.Message);
                   }
                   finally
                   {
                       Console.ReadLine();
                   }

             
        }
    }
}


