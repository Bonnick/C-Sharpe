using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment_Submission
{
    public class Program
    {
        static void Main(string[] args)
        {

            string[] DayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            foreach (string Weeks in DayOfWeek)
            {



                try
                {

                    Console.WriteLine("Enter the Days of the Week");
                    int Days = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The current Day of the week" + Days);
                }


                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter an actual day of the week");
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
}

