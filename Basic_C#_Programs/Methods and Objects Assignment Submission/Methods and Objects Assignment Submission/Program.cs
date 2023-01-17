using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside of the Main method, instantiate and initialize an Employee object with a first name of “Sample” and a last name of “Student”.

            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            //Console.WriteLine(employee);

            //Call the superclass method SayName() on the Employee object.
            Console.WriteLine(employee.SayName());
            Console.ReadLine();
            
        }
    }
}
