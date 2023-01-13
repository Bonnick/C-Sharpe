using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Assignment_Submissiomn
{
    class Method
    {
        public int results(int myNum, int myNum2 = 2)
        {
            Console.WriteLine("The second integer is myNum2 = 2");

            int sum = 0;
            sum = myNum + myNum2 + 2;

            return sum;

            // The second integer will be displayed on the screen along with the mathemational operation of the first integer. 

            //Console.WriteLine("mynum2 " + sum);
           

        }


    }
}

