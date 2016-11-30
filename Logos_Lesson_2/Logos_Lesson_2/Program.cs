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
            

            int i = 0;
            int nNum;
             float   nAverage;
            int nSum = 0;
            for (;i<5;i++)
            {
                nNum = int.Parse(Console.ReadLine());
                nSum = nSum + nNum;
                
            }
            nAverage = (float)(nSum) / 5;
            Console.WriteLine(nAverage);
            Console.WriteLine(nSum);
            

            int i = 0;
            int nNum = int.Parse(Console.ReadLine());
            float nAverage;
            int nSum = nNum;
            while(nNum!=0)
            {
                nNum = int.Parse(Console.ReadLine());
                nSum = nSum + nNum;
                i++;
            }
            nAverage = (float)(nSum) / i;
            Console.WriteLine(nAverage);
            Console.WriteLine(nSum);
            */

            Console.WriteLine("Enter Quantity of * strings");
            int nQuantity = int.Parse(Console.ReadLine());
            string sString = "*";
            for (int i=0;i<nQuantity;i++)
            {
                //Console.WriteLine(sString);
                Print(sString);
                sString = "*"+sString + "*";
            }
            


        }


        private static void Print(string text)
        {
            var width = Console.WindowWidth;
            var padding = width / 2 + text.Length / 2;
            Console.WriteLine("{0," + padding + "}", text);
        }
    }
}
