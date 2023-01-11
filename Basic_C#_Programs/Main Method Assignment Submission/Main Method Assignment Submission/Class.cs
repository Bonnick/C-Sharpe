using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment_Submission
{
    public class Play
    {

       
            public int results(int myChild)
            {
                return myChild  + 2; // Two is added to myNum
            }
            public int results(decimal myChild)
            {
            int num3 = Convert.ToInt32(myChild);
            int num4 = 40 / num3;

            return num4;  // myNum is being multiplied by 2.64
            }
            public int results( string myChild)
            {

            int num1 = Convert.ToInt32(myChild);
            int num2 = 10 - num1;

            return num2;

            

            
        }

        
    }
 }



