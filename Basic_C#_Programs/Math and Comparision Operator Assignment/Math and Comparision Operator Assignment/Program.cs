 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_and_Comparision_Operator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Anonymous Income Comparison Program"); // The program start by printing the following statment on the screen

            Console.WriteLine("Person 1");

            Console.WriteLine("Hourly Rate");// The console produces the hourly rate of $15 per hour for person 1 
            int total = 5+ 10;
            Console.WriteLine(total.ToString());
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?"); // The console produces the amount of hours person week person 1 works which is 40.
            int product = 5 * 8;
            Console.WriteLine(product);
            Console.ReadLine();


            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate");// The console produces the hourly rate for person 2 which is $20 per hour.
            int difference = 25 - 5;
            Console.WriteLine( difference.ToString());
            Console.ReadLine();

            Console.WriteLine("Hours worked per week?");// This console produces the amount of hours person 2 work per week which is 40.
            int quotient = 80 / 2;
            Console.WriteLine(quotient);
            Console.ReadLine();

            Console.WriteLine("Annual salary of person 1:"); //This console produces a statement telling us how much is person one annual salary
            Console.WriteLine("31200");

            Console.WriteLine("Annual salary of person 2:"); // This console produces a statment telling us how much is person two annual salary 
            Console.WriteLine("41600");
            //This console produces the false statement because person 1 is not making more money than person 2. 
            int Annualsalaryofperson1 = 31200;
            int Annualsalaryofperson2 = 41600;

            bool Annualsalary = Annualsalaryofperson1 > Annualsalaryofperson2;
            Console.WriteLine(Annualsalary);
            Console.ReadLine();


            



        }
    }
}
