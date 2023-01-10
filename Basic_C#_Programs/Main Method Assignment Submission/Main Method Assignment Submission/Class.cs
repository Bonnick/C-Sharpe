using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment_Submission
{
    public class Play
    {

       
            public static int results(int myChild)
            {
                return myChild  + 2; // Two is added to myNum
            }
            public static decimal results2(decimal myChild)
            {
                return myChild * 2.64m; // myNum is being multiplied by two
            }
            public static string results3( string myChild)
            {

            var num = 0;
            for (var i = 0; i < myChild.Length; i++)
            {
              num = num * 10 + (myChild[i] - '0');
            }
            return myChild;

            

            
        }

        
    }
 }



