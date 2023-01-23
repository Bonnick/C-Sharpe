using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment_Submission
{

    public class Employee
    {

    //        Create an Employee class with the following properties:

    //a.Id

    //b.First Name

    //c. Last Name

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public Employee(int x, string y, string z)
        {
            this.FirstName = y;
            this.LastName = z;
            this.ID = x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.
            List<Employee> EMP = new List<Employee>() 
            { 
                new Employee(1, "Joe", "Bake"),
                new Employee(2, "Joe", "Tom"),
                new Employee(3, "Pretty", "Girl"),
                new Employee(4, "Romario", "Bonnick"),
                new Employee(5, "Mar", "Bonnick"),
                new Employee(6, "Angie", "Hutchinson"),
                new Employee(7, "Marlene", "Ward"),
                new Employee(8, "Fern", "Stewart"),
                new Employee(9, "Breannaa", "Stewart"),
                new Employee(10, "Puncenella", "Ghram")

        };


            //Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.
            List<Employee> name = new List<Employee>();

            foreach(Employee x in EMP)
            {
                if (x.FirstName == "Joe")
                {
                    name.Add(x);
                }
               // Console.WriteLine(x.FirstName);
            }

            //Perform the same action again, but this time with a lambda expression.

            List<Employee> person = new List<Employee>();

            person = EMP.Where(x => x.FirstName=="Joe").ToList();

           //Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> people = new List<Employee>();
            people = EMP.Where(x => x.ID > 5).ToList();


            Console.ReadLine();
        }


       
    }




}
