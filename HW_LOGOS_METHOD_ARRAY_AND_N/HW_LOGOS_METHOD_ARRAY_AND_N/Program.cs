using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_METHOD_ARRAY_AND_N
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int nNum = ReturnPosition();
            Console.WriteLine(nNum);

        }

        static int ReturnPosition()
        {
            Console.WriteLine("Enter quantity of array");
            int nQuantity = int.Parse(Console.ReadLine());
            int[] nArray = new int[nQuantity];
            Console.WriteLine("Enter number to look for");
            int nNumber = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int i=0;i<nQuantity;i++)
            {
                nArray[i] = rand.Next(1, 9);
                Console.Write(" "+nArray[i]);
            }
            Console.WriteLine();
            int j=-1;
            //bool bFound;
            for (int i=0;i<nQuantity;i++)
            {
                if (nArray[i] == nNumber)
                    j = i;
            }
            return j;
        }
    }
}
