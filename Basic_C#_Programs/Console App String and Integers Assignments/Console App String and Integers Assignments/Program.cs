using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_String_and_Integers_Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers. Ask the user for a number to divide each number in the list by. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

            try
            {

                int[] numArray = new int[5];
                numArray[0] = 5;
                numArray[1] = 2;
                numArray[2] = 10;
                numArray[3] = 200;
                numArray[4] = 5000;

                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Results");

                for (int i = 0; i < numArray.Length; i++)
                {
                    var result = numArray[i] / numberOne;
                }

                for (int i = 0; i < numArray.Length; i++)
                {
                    Console.WriteLine(numArray[i]);
                }
                //Run the code, entering in non-zero numbers as the user. Look at the displayed results.
                if (numberOne == 0)
                {
                    Console.WriteLine("No non-zero number in the list of intergers");
                }
                // Run the code again, entering in zero as the number to divide by. Note any error messages you get.
                else if (numberOne <= 0)
                {
                    Console.WriteLine("Error enter a number");
                }
                //Run the code once again, entering in a string as the number to divide by. Note any error messages you get.
                //if (!Int32.IsNumber(numArray)) 
                if (!Convert.ToInt32(numberOne))
                {
                    Console.WriteLine(" Error Not an number");
                    Console.ReadLine();
                }
            }


            catch (FormatException ex)
            {
                Console.WriteLine("Please type in a valid number");
            }

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
