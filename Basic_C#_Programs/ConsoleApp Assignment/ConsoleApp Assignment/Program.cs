using System;
using System.Collections.Generic;


namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part one

            //String[] s = { "Nick", "Romario", "Marlesa", "Tom", "Dandan" };
            //Console.WriteLine("Provide a word; ");
            //string word = Console.ReadLine();
            //for (int i = 0; i < s.Length; i++)
            //{
            //s[i] += word ;
            //}

            //for (int i = 0; i < s.Length; i++)
            //{
            //Console.WriteLine(s[i]);
            //}

            //Console.ReadLine();  

            //}
            //}
            //} 

            //Part two

            //The Infinite Loop

            // Foreloop

            //            for (; ; )
            //            {
            //                // The Forever young will run as the infinite loop in the body 
            //                Console.WriteLine("Forever young!\n");
            //            }
            //        }
            //    }
            //}


            //Fix the Infinite Loop

            //for (int i = 1; i < 5; i++)
            //{
            //The Forever young will run as the infinite loop in the body 
            //Console.WriteLine("Forever young!\n");
            //}
            //Console.ReadLine();
            // }
            //}
            //}

            // Part 3
            //iterate the loop.
            //List<int> grades = new List<int>() { 5, 10, 26, 34, 26, 26, 2, 23, 26, 22 };

            //for (int i = 0; i < grades.Count; i++)
            //{
            // Console.WriteLine(grades[i]);
            //}
            // for (int i = 0; i <= grades.Count -1; i++)
            //{
            //Console.WriteLine(grades[i]);
            //}
            //Console.ReadLine();

            //}
            //}
            //}



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
//            List<string> Letters = new List<string>() { "A", "B", "C", "D", "C" };
//            Console.WriteLine(" Please type one of these letters ; A,B,C,D,");
//            string word = Console.ReadLine();



//            for (int i = 0; i < Letters.Count; i++)



//            {
//                if (Letters[i] == word.ToUpper())
//                {
//                    Console.WriteLine("The Letter you choose is at index " + i);
//                }



//            }
//            if (Letters.Contains(word.ToUpper())== false)
//            {
//                Console.WriteLine("Your input is not in the list");
//            }
//            Console.ReadLine();

//        }
//    }
//}
















//// Part 6
////This console code list all the items that will appear on the screen.
//List<string> Letters = new List<string>() { "A", "B", "C", "D", "C" };
//// Second Table created to do the comparison
//List<string> Array = new List<string>() { };
////The foreach loop displays the message of the items on the screen.
//foreach (string items in Letters)
//{
//    if (Array.Contains(items))
//    {
//        Console.WriteLine(items + " is a duplicate");
//    }
//    else if (!Array.Contains(items))  
//        {
//          Array.Add(items);
//        Console.WriteLine(items + " is not a duplicate");
//        }

//}

//Console.ReadLine();

//}
//}
//} 

