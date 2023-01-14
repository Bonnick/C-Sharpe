using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment_Submission
{
    class Method
    {
        public void results(int myNum)
        {


            int sum = 0;
            sum = myNum / 2;

            Console.WriteLine(sum);
        }
        public void result(out int sum)
        {

            //Output Parameter
            sum = 4;
            sum = sum / 2;


        }

        // Overload method

        public void results(string  myNum , string myNum2)
        {

            Console.WriteLine(myNum  + myNum2);
              

            
            //int  sum = "0";
            //sum = myNum + 2;

        }

    }
}
