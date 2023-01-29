using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_Assignment
{


    }



    class Program
    {

   
        


        
        
        public static void Main(string[] args)
        {
       
        
        // Print the current date and time to the console.
        
        DateTime now = DateTime.Now;
        Console.WriteLine(now);
        Console.ReadLine();

       // Ask the user for a number

        Console.WriteLine("Please enter a number between 1 and 10 ");
        var number = Convert.ToInt32(Console.ReadLine());
       
       
        // Print to the console the exact time it will be in X hours, X being the number the user entered in step 2.

        Console.WriteLine("The time it will be when X is added to DateTime " + now.AddHours(number));
        Console.ReadLine();
        






    }


    }

