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
                numArray[0] = 40;
                numArray[1] = 20;
                numArray[2] = 10;
                numArray[3] = 200;
                numArray[4] = 5000;

                Console.WriteLine("Pick a number");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Results");

                for (int i = 0; i < numArray.Length; i++)
                {
                    Console.WriteLine(numArray[i] / numberOne);
                }
            }


            //Run the code, entering in non-zero numbers as the user. Look at the displayed results.

            //Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution. In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

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
