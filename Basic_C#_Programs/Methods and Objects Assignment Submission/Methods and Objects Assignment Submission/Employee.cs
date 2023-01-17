using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment_Submission
{
    public class Employee : Person
    {
        //Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int.
        public int Id { get; set; }
        public string DisplayName { get; set; }


        public void SayName()
    {

        
             Console.WriteLine("Name: " + FirstName + " " + LastName);
      

        }

    }
}
