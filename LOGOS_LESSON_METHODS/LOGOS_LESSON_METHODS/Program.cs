using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter number");
             int nNumber = int.Parse(Console.ReadLine());
             nNumber = MyAbs(nNumber);
             Console.WriteLine("Absolute is {0}",nNumber);
         }

         static int MyAbs(int nNum)
         {
             if (nNum < 0)
             {
                 nNum = -nNum;
             }
             return nNum;
            

            Console.WriteLine("Enter x");
            float x = float.Parse(Console.ReadLine());
            x = Maths(x);
            Console.WriteLine(x);
        }
        static float Maths(float x)
        {
            if(x>-5&&x<5)
            {
                return x * x + 29 * x - 16;
            }
            else
            {
                return x * x * x * x - 79;
            }
            */

            Console.WriteLine("Enter quantity of array");
            int nQ = int.Parse(Console.ReadLine());
            int[] nArr = new int[nQ];
            Random rand = new Random();
            for (int i=0;i<nQ;i++)
            {
                nArr[i] = rand.Next(1,9);
                Console.Write(" {0}",nArr[i]);
            }
            int nSumma=SumArray(nArr, nQ);
            Console.WriteLine();
            Console.WriteLine("Sum is {0}", nSumma);
        }

        static int SumArray(int[] A,int nQuant)
        {
            int nSum = 0;
            for (int i=0;i<nQuant;i++)
            {
                nSum = nSum + A[i];
            }
            return nSum;
        }

    }
}
