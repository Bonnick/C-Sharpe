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
            int total = Convert.ToInt32(Console.ReadLine());
           
 

            Console.WriteLine("Hours worked per week?"); // The console produces the amount of hours person week person 1 works which is 40.
            int product = Convert.ToInt32(Console.ReadLine());
            
          


            Console.WriteLine("Person 2");

            Console.WriteLine("Hourly Rate");// The console produces the hourly rate for person 2 which is $20 per hour.
            int difference = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Hours worked per week?");// This console produces the amount of hours person 2 work per week which is 40.
            int quotient = Convert.ToInt32(Console.ReadLine());
            int Annualsalaryofperson1 = (total*product) * 52;
            int Annualsalaryofperson2 = (difference*quotient) * 52;

            
             
            
          
            bool Annualsalary = Annualsalaryofperson1 > Annualsalaryofperson2;
            Console.WriteLine("Is Person 1 Salary greater than Person 2 Salary " + Annualsalary);
            Console.ReadLine();


            



        }
    }
}
