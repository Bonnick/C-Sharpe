using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submissiomn
{
    class Program
    {
        static void Main(string[] args)
        {
            Method play = new Method();
            // Call a method in the Class passing in two numbers. 
            Console.WriteLine("Passing in number one");
            int number = Convert.ToInt32(Console.ReadLine());
            //Call a method in the class passing in two numbers.
            Console.WriteLine("Passing in number two");
            int number2 = Convert.ToInt32(Console.ReadLine());



            //Object one = new Object();
            //number2 = one.results(number);

            //Call the method in the class, specifying the parameters by name. 
            Console.WriteLine(play.results(number));

            Console.ReadLine();





            }
        }
    }



