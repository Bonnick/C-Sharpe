using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            // 25 is added to 50
            int total = 50 + 25;
            Console.WriteLine("Fifty plus Twentyfive =" + total.ToString());
            Console.ReadLine();
           
            // 50 is multiplied to an input which results in an output more than 10,000,000
            int product = 500000 * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            // 100.5 divided by 12.5
            double quotient = 100.5 / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            // this console will produce the remainder when 20 is divided into 7
            int remainder = 20 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();

            //This command will produce a false value because 12 is not greater then 50
            bool trueOrFalse = 12 > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            


        }
    }
}
