using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            Method play = new Method();

            //Have the user enter a number

            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            //Display the output on the screen and divide the number by two
            Console.WriteLine(number + "/" + 2);
            play.results(number);

            //call the output parameter
            int sum = 0;
            play.result(out sum);
            Console.WriteLine(sum);
            Console.ReadLine();

            //Call the overload method

            string name = "First Name ";
            string day = "Last Name";
            play.results(name, day);
            Console.ReadLine();

            // Classing the static class after it is being declared.
            Cup.cup();
            Console.ReadLine();
        }
    }
}
