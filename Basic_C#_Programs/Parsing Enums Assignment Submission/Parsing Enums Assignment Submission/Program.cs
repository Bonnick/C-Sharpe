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
           try
            {


                //int myNum = (int)DayOfWeek.Monday;

                //Console.WriteLine(myNum);

                Weeks days = new Weeks();
                Console.WriteLine("Enter the current day of the week");
                int myNum = (int)DayOfWeek.Monday;
                int myNum = Convert.ToInt32(Console.ReadLine(DayOfWeek));
                

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
