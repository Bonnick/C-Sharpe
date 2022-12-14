using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
   
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Academy of Learning Career College"); //This is the first statment that will display on the screen
                Console.WriteLine("Student Daily Report"); // This is the second statment that will display after first statement
      
                //This console command ask what is your name.
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hello, " + name + "!");
                
                //This console command ask what course are you doing.
                Console.WriteLine("What course are you on?");
                string namecourse = Console.ReadLine();
                Console.WriteLine("I am on" + namecourse + "!");
                
                //This console command ask the page number of the course.
                Console.WriteLine("What page number?");
                int pagenumber = Convert.ToInt32(Console.ReadLine());
                
               
               //This console indicate the hour study
               Console.WriteLine("How many hours do you study per day");
               int howmanyhours = Convert.ToInt32(Console.ReadLine());
               
               //This command help us to understand that the student needs help with the course
                Console.WriteLine("Do you need any help?");
            bool Doyouneedhelpwithanything = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine(Doyouneedhelpwithanything);
                // This command is basically asking a question
                Console.WriteLine("Were there any positive experience you'd like to share? Please give specifics");
                string No = Console.ReadLine();
                Console.WriteLine("Thank you");
               

                Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
                string Yes = Console.ReadLine();
                Console.WriteLine("Type below");
                
                //This command is a statement thanking you for your responses. 
                Console.WriteLine("Thanks you for your answers. An instructor will respond shortly. Have a great day");
                Console.ReadLine();



            }
        }
    }

