using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_POLYMORPHYSM
{
    class Employer:Person
    {
        string company;

       /* public Employer(string Name, int Age, string Company):base(Name,Age)
        {
            company = Company;
        }
        */

            public void SetCompany(string  value)
        {
            Console.WriteLine("Enter company");
            company =value;
        }

        public override string ToString()
        {
            return fullName+" from "+company;
        }
    }
}
