using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment
{
    class Method
    {

        //Create a class. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result.
        public  int results(int myNum, int myNum2 = 2)
        {
            int sum = 0;
            sum = myNum + myNum2 + 2;
            return sum; 
        }
     

    }
}
