using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a loop that prints all of the Things to the Console.


            Console.WriteLine("Names of Employee");
            List<string> employee = new List<string>
        {
            "Tom Brown",
            "Raymon Thomas",
            "John Tom",
            "Marlesa Ben"
        };
            foreach (var item in employee)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("Employee income");
            List<int> income = new List<int>
        {
            1000,
            2000,
            3000,
            8000

        };

            Console.ReadLine();
        }

        
    }
}
