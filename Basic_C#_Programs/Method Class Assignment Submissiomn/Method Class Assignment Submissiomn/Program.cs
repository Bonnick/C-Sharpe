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



           
        

            //Call the method in the class, specifying the parameters by name. 

            play.results(number, number2);

            play.results(myNum: 8, myNum2: 7);

            Console.ReadLine();





            }
        }
    }



