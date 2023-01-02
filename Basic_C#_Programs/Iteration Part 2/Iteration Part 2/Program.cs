using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Part_2
{
    class Program
    {
        //static void Main(string[] args)
        //{
            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
            //for (int j = 0; j < names.Length; j++)
            //{
                //if (names[j] == "Jesse")
                //{
                    //Console.WriteLine(names[j]);
               // }
            //}
            //Console.ReadLine();
        //}
      //}

        // This code run every every name.

        //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
            //for (int j = 0; j < names.Length; j++);
                //{
                    //Console.WriteLine(names[j]);
               // }
            //Console.ReadLine();

           //List 
         //List<int> testScores = new List<int>();
           //testScores.Add(98);
           //testScore.Add(99);
           //testScores.Add(81);
           //testScore.Add(72);
           //testScore.Add(70);

            //foreach (int score in testScores)
            //{
              //if (score > 85)
            //} 
             //{
                //Console.writeLine("Passing test score:" + score);
             //}
           //}
       //Console.ReadLine();
      //}

        //string
         //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daneil"};
         
        //foreach (string name in names)
            //{
               //if (name == "Jesse")
            //}
             // Console.WriteLine(name);
            //}
       // }
      //Console.ReadLine();

     //}

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 74, 23, 99};
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
          if (score > 85)
        }
          passingScores.Add(score);
        } 
    }
      Console.WriteLine(passingScores.Count);
      Console.ReadLine();

     }
   }
} 

