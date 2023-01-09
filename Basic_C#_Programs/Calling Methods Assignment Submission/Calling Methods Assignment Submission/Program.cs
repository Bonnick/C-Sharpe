using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() program, ask the user what number they want to do the math operations on.

            Console.WriteLine("Pick a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + number);

            //Call each method in turn, passing the user input to the method.Display the returned integer to the screen.

            Console.WriteLine(Student.results(number) + "\n" + Student.results1(number) + "\n" + Student.results2(number));

            Console.ReadLine();
           
        }
    }

    // Put other class here if neccessary
}

