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
            Console.WriteLine("Please input one number");
            int number = Convert.ToInt32(Console.ReadLine());
            string number2 = Console.ReadLine(); 

            if (number2 == "")
            {
                Console.WriteLine(result.results(number));
            }
             
            else
            {
                int num1 = Convert.ToInt32(number2);
                Console.WriteLine(result.results(number, num1));

           
                
            }
             
            
            
            Console.ReadLine();


            

        }
    }
}
