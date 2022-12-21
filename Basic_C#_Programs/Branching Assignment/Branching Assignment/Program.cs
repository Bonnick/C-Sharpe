using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This command runs the first statment in the console.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            //This command allows you to enter a package weight

            Console.WriteLine("Please enter package weight");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your weight is: " + weight);

            //This command line runs error if the weight is greater than 50.
            if (weight > 50)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
                 }


                //This command allows you to enter the width
                Console.WriteLine("Please enter the package width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your width is: " + width);
            Console.ReadLine();

            //This command allows you to enter the height. 

            Console.WriteLine("Please enter the package height");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your height is: " + height);
            Console.ReadLine();

            //This command allows you to enter the length
            Console.WriteLine("Please enter the package lenght");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your lenght is: " + length);

            if (length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
             // multiply all three dimensions(height, width & length and multiply by weight and then divide the outcome by 100.
            int x = height;
            int y = width;
            int w = length;
            int q = weight;
            Console.WriteLine("Your estimated total for shipping this package is:");
            Console.WriteLine(x * y * w * q /100);
            Console.ReadLine();

        }
    }
}
