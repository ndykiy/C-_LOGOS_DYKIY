using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logos_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a, b, c;
            Console.WriteLine("Enter length af all the sides");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if(a+b>c&&a+c>b&&b+c>a)
            {
                Console.WriteLine("Triangle exists");

            }
            else
            {
                Console.WriteLine("Triangle does not exist");
            }
            */

            int i = 0;
            int nNum;
            int nSum = 0;
            for (;i<5;i++)
            {
                nNum = int.Parse(Console.ReadLine());
                nSum = nSum + nNum;
            }
            Console.WriteLine(nSum);

        }
    }
}
