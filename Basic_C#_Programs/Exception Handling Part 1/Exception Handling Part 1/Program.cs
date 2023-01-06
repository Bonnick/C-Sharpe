using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Code without Error
            //Console.WriteLine("Pick a number");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Pick a second number.");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Divide the two ");
            //int numberThree = numberOne / numberTwo;
            //Console.WriteLine(numberOne + " divide by " + numberTwo + " equals " + numberThree);
            //Console.ReadLine(); 

            // Code to hide error
            //try
            //{
            //    Console.WriteLine("Pick a number");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Divide the two ");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divide by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();


            // Exception Handling Part Two

            try
            {
                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Divide the two ");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divide by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
                return;
            }
            // Divide by zero error
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        
          
        }
    }
}
