using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_Assignment_Submission
{
    public class Weeks
    {
        public DayOfWeek DayOfWeek { get; set; }
    }

    public enum DayOfWeek
    {
        Monday=1,
       Tuesday=12,
       Wednesday=14,
       Thursday=15, 
       Friday=10,
       Saturday=20,
       Sunday=40

    }
}
