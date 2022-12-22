using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a do while statement

            int count = 0;
            do
            {
                Console.WriteLine("Inside the Loop");
                count++;
            }
            while (count < 5);
            int counting = 0;

            //This is a while statement loop
            while(counting <3)
                {
                Console.WriteLine(" counting numbers");
                counting++;

            }
            Console.ReadLine();
        }
    }
}
