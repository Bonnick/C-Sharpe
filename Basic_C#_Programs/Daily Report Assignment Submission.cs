using System;


namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College"); //This is the first statment that will display on the screen
            Console.WriteLine("Student Daily Report"); // This is the second statment that will display after first statement
            Console.ReadLine();
            //This console command ask what is your name.
            Console.WriteLine("What is your name?"); 
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();
            //This console command ask what course are you doing.
            Console.WriteLine("What course are you on?");
            string namecourse = Console.ReadLine();
            Console.WriteLine("I am on" + namecourse + "!");
            Console.Read();
            //This console command ask the page number of the course.
            Console.WriteLine("What page number?");
            string pagenumber = Console.ReadLine();
            Console.WriteLine("Please provide the Page number" + "!");
            Console.Read();
            //This command help us to understand that the student needs help with the course
            bool Doyouneedhelpwithanything = true;
            Console.WriteLine(Doyouneedhelpwithanything);
            // This command is basically asking a question
            Console.WriteLine("Were there any positive experience you'd like to share? Please give specifics");
            string No = Console.ReadLine();
            Console.WriteLine("Thank you");
            Console.Read();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string Yes = Console.ReadLine();
            Console.WriteLine("Type below");
            Console.Read();
            Console.ReadLine();
        
            //This command is a statement thanking you for your responses. 
            Console.WriteLine("Thanks you for your answers. An instructor will respond shortly. Have a great day");
            Console.ReadLine();



        }
    }
}
