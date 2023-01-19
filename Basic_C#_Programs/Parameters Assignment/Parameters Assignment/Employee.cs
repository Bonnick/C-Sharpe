using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    public class Employee<T>
    {
        //Make the Employee class take a generic type parameter.
        public List<T> Associates { get; set; }
        //Add a property to the Employee class called “things” and have its data type be a generic list matching the generic type of the class.

        public string Thing { get; set; }

        //Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.

        List<string> employee = new List<string>
        {
            "Tom Brown",
            "Raymon Thomas",
            "John Tom",
            "Marlesa Ben"
        };

        //Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.
        List<int> income = new List<int>
        {
            1000,
            2000,
            3000,
            8000

        };

            
         

     }

    
}
