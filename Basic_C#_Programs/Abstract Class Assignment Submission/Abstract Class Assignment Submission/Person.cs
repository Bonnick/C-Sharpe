using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment_Submission
{
   public class Person
    {
        public abstract class person
        {
            //Create an abstract class called Person with two properties: string firstName and string lastName
            public string FirstName { get; set; }

            public string LastName { get; set; }


            //Give it the method SayName().
            public void SayName()
            {

           Console.WriteLine("Name: " + FirstName + " " + LastName);


            }

        }


    }   


}
