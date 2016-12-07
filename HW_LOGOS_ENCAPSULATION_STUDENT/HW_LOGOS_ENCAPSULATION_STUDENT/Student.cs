using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_ENCAPSULATION_STUDENT
{
    class Student
    {
       private string sPIB;
       private int[] nMark = new int[3];
       private string sAddress;


        public Student(string pib,int[] mark,string add)
        {
            sPIB = pib;
            nMark = mark;
            sAddress = add;
        }

       public string PIB
        {
            get
            {
                return sPIB;
            }
           set
            {
                PIB = value;
            }
        }

        public int[] Mark
       {
           get
           {
               return nMark;
           }
           
       }

        public int Average
        {
            get
            {
                return CalcAvg(nMark);
            }
        }

        public int CalcAvg(int[] mark)
        {
            return  (mark[0] + mark[1] + mark[2]) / mark.Length;
        }

        string Address
        {
            get
            {
                return sAddress;
            }
            set
            {
                Address = value;
            }
        }

        public void Print()
        {
            Console.WriteLine(sPIB);
            Console.WriteLine("Marks {0} {1} {2}",nMark[0],nMark[1],nMark[2]);
            Console.WriteLine(sAddress);
            //Console.WriteLine(nAverage);
        }
    }
}
