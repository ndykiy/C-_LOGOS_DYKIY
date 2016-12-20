using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_POLYMORPHYSM
{
    class Employee:Person
    {
        int salary;
/*
        public Employee(string Name, int Age, int Salary):base(Name,Age)
        {
            salary = Salary;
        }
*/

            public void SetSalary(int value)
        {
            Console.WriteLine("Enter salary");
            salary = value;
        }

        public override string ToString()
        {
            return fullName+" earns "+salary+"$";
        }

    }
}
