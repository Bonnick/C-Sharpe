using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the main() method of a console app, instantiate the class and call the one method, passing in an integer. Display the result to the screen.

            Play result = new Play(); // Right here I instantiate the class
            //result.results(10); This way did not work so I tired another way and it works.
            Console.WriteLine(result.results(10));



            //In the main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the results to the screen. 

            Play option = new Play(); // Right here I instantiate the class
            //option.results(20.7m); // When I use this one it did not work but when I tried the console.WriteLine it did. 
            Console.WriteLine(option.results(2.7889m));

            //In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen.

            Play correct = new Play(); // Right here I instantiate the class.
            //correct.results("30"); // When I use this code it did not work until I use the console.WriteLine method. 
            Console.WriteLine(correct.results("30"));

                Console.ReadLine();
        
        } 
    }
}
