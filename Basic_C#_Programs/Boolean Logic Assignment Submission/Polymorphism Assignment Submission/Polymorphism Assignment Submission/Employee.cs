using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission
{
    //Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.
     class Employee : IQuittable
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Quit( Employee employee)
        {

            Console.WriteLine("Name: " + FirstName + " " + LastName);


        }

        internal string Quit()
        {
            throw new NotImplementedException();
        }
    }
}
