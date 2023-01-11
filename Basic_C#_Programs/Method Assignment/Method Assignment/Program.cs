using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method of the console app, instantiate the class.
            Method result = new Method();

            //Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
            Console.WriteLine("Please input two number");
            int number = Convert.ToInt32(Console.ReadLine());
            
            //Call the method in the class, passing in the one or two numbers entered.

            Console.WriteLine("Your number is: " + result +
                result);
            Console.WriteLine(Method.results(number));
           
            
            
            Console.ReadLine();


            

        }
    }
}
