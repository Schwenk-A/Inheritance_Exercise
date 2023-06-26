using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    public class Employee
    {
        public string name { get; set; }
        public string department { get; set; }
        public double salary { get; set; }
        public DateTime start_date { get; set; }

        public double GetRaise()
        {
            return salary * 0.05;
        }

        public void ChangeDepartment(string new_department)
        {
            department = new_department;
        }

        public double GetBonus()
        {
            return salary * 0.10;
        }
    }
}

