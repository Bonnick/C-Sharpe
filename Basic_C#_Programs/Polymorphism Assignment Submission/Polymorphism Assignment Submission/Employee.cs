using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission
{
    //Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
    public class Employee : IQuittable
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }


         void IQuittable.Quit()
            //(Employee employee)
        {

            Console.WriteLine("Name: Romario Bonnick" );


        }


    }
}
