using System;
using System.Collections.Generic;


namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part one

            // A Array of String
            String[] s = { "Nick", "Romario", "Marlesa", "Tom", "Dandan" };
            //Ask the user to input some text
            Console.WriteLine("Provide a word; ");
            //Ask the loop to iterates through each string in the array and adds the user's text input to the end of each string.
            string word = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
            s[i] += word ;
            }
            //Create a second loop that prints off each string in the array one at a time.
            for (int i = 0; i < s.Length; i++)
            {
            Console.WriteLine(s[i]);
            }

            Console.ReadLine();  

         }
     }
} 

            //Part two

            //The Infinite Loop

             Foreloop

            for (; ; )
            {
            // An infinite Loop
             Console.WriteLine("Forever young!\n");
            }
          }
       }
   }
            //Fix the Infinite Loop so that it will execute properly

            for (int i = 1; i < 5; i++)
            {
            //The Forever young will run as the infinite loop in the body 
            Console.WriteLine("Forever young!\n");
            }
            Console.ReadLine();
           }
         }
      }

            // Part 3
            //A loop where the comparison that's used to determine whether to continue iterating the loop is a "<" operator.
            List<int> grades = new List<int>() { 5, 10, 26, 34, 26, 26, 2, 23, 26, 22 };

            for (int i = 0; i < grades.Count; i++)
            {
            Console.WriteLine(grades[i]);
            }
            // Add another loop where the comparison that's used to determine whether to continue iterating the loop is a "<=" operator.
            for (int i = 0; i <= grades.Count -1; i++)
            {
            Console.WriteLine(grades[i]);
            }
            Console.ReadLine();

           }
         }
       }



            //Part 4


           // A list of strings where each item in the list is unique.
            List<string> Letters = new List<string>() { "A", "B", "C", "D" };

            //Ask the user to input text to search for in the list.
            Console.WriteLine(" Please type one of these letters ; A,B,C,D");
            string word = Console.ReadLine();

            //A loop that iterates through the list and then displays the index of the list item that contains matching text on the screen.

            for (int i = 0; i < Letters.Count; i++)


                //Add code to check if the user put in text that isn't on the list and, if they did, tell the user their input is not on the list.

            {
                if (Letters[i] == word.ToUpper())
                {
                    Console.WriteLine("The Letter you choose is at index " + i);
                }
 
                // Add code that stops the loop from executing once a match has been found.
            }
            if (Letters.Contains(word.ToUpper()) == false)
            {
                Console.WriteLine("Console is not in the list");
            }
            Console.ReadLine();
        }
    }
}



                                    //Part 5
                                   
            // A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list. 

            List<string> Letters = new List<string>() { "A", "B", "C", "D", "C" };
          // Ask the user to select text to search for in the list.
          Console.WriteLine(" Please type one of these letters ; A,B,C,D,");
          string word = Console.ReadLine();

           //Create a loop that iterates through the list.
           
         for (int i = 0; i < Letters.Count; i++)



            {
                if (Letters[i] == word.ToUpper())
                 {
                   Console.WriteLine("The Letter you choose is at index " + i);
                }


                // Add code to the loop to check if the user put in text that isn't on the list, and if they did, tells the user their input is not on the list.
            }
            if (Letters.Contains(word.ToUpper())== false)
            {
               Console.WriteLine("Your input is not in the list");
            }
            Console.ReadLine();

        }
     }
}






                    // Part 6

          //Create a list of string that has atleast two indentical strings in the list.
      List<string> Letters = new List<string>() { "A", "B", "C", "D", "C" };
       // Second Table empty  created to do the comparison
     List<string> Array = new List<string>() { };
     //The foreach loop displays the message of the items on the screen.
          foreach (string items in Letters)
       {
        if (Array.Contains(items))
       {
        Console.WriteLine(items + " is a duplicate");
       }
       else if (!Array.Contains(items))  
       {
          Array.Add(items);
          Console.WriteLine(items + " is not a duplicate");
       }

}

     Console.ReadLine();

      }
   }
} 

