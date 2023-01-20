using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment_Submission
{
    public class Employee
    {
        //Create an Employee class with Id, FirstName and LastName properties. 
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        //In the Employee class, overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property. Remember that comparison operators must be overloaded in pairs. 


        public static bool operator == (Employee employee, Employee employee1)
        {
            if (employee.ID == employee1.ID)

                return true;
            else
                return false;
        }

        public static bool operator!= (Employee employee, Employee employee1)
    {
         if (employee.ID != employee1.ID)
            return true;
         else
            return false;
       

    }


}
