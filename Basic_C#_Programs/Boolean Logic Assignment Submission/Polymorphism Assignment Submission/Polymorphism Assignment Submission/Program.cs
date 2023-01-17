using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it. Hint: an object can be of an interface type if it implements that specific interface.


            Employee employee = new Employee();
            employee.FirstName = "Romario";
            employee.LastName = "Bonnick";
            Console.WriteLine(employee.Quit());
            Console.ReadLine();


            
        }

        
    }
}
