using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_ENCAPSULATION_STUDENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("lol",new int[]{1,3,6},"lviv");
            Console.WriteLine(student.Average);
            
          
            student.Print();
            //Console.WriteLine(student.CalcAvg(student.Mark));
           // student.Average();
        }
    }
}
