using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_ENCAPSULATION
{
    class Employee
    {
        string sName;
        int id;
        int nSalary;

        public string Name
        {
            get
            {
                return sName;
            }

            set
            {
                Name = value;
            }
        }

        //Коротший варіант
     //   public string Speciality { get; set; }
      

        public int ID
        {
            get
            {
                return id;
            }
        }

        public int Salary
        {
            get
            {
                return nSalary;
            }
            set
            {
                if (nSalary - value > 500)
                {
                    nSalary = nSalary - 500;
                }
                else
                {
                    if (value - nSalary > 500)
                    {
                        nSalary = nSalary + 500;
                    }
                    else nSalary = value;
                }
            }
        }

        public Employee(string sENname="Paul McCartney",int Eid=123456,int nESalary=4500)
        {
            sName = sENname;
            id = Eid;
            nSalary = nESalary;
        }

        public int GetID()
        {
            return id;
        }

        /*
        public int GetSalary()
        {
            return nSalary;
        }

        public void SetSalary(int a)
        {
            if (nSalary-a>500)
            {
                nSalary = nSalary - 500;
            }
            else
            {
                if (a-nSalary >500)
                {
                    nSalary = nSalary + 500;
                }
                else nSalary = a;
            }
        }
        */


        public void Print()
        {
            
            Console.WriteLine("{0} {1} {2}",sName,id,nSalary);
        }
    }
}
