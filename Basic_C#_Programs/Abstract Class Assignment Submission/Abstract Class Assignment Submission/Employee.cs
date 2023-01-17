using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment_Submission
{
    public class Employee: Person
    {
        //Create another class called Employee and have it inherit from the Person class.


        public string FirstName { get; set; }

        public string LastName { get; set; }

        //Implement the SayName() method inside of the Employee class.
        public void SayName()
        {

            Console.WriteLine("Name: " + FirstName + " " + LastName);


        }
    }
}
