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

        Console.WriteLine("Year: ");
        var year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Month: ");
        var month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Day: ");
        var day = Convert.ToInt32(Console.ReadLine());

        // Print to the console the exact time it will be in X hours, X being the number the user entered in step 2.

        Console.WriteLine("The current date and time is " +   year +  month +  day  +  0,  0,  0,  0 );
        Console.ReadLine();
        






    }


    }

