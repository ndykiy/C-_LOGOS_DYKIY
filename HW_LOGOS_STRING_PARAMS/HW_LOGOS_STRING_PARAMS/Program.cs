using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_STRING_PARAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string sStrichka = Console.ReadLine();

            Console.WriteLine("Enter quantity of array");
            int nQ = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[] nArr = new int[nQ];
            for (int i=0;i<nQ;i++)
            {
                nArr[i] = rand.Next(1, 9);
                Console.Write(" "+nArr[i]);

            }
            PrintResult(sStrichka,nArr);
        }

        static void PrintResult(string sString, params int[] nArray)
        {
            int nSum = 0;
            for (int i=0;i<nArray.Length;i++)
            {
                nSum = nSum + nArray[i];
            }
            if(nSum>20)
            {
                Console.WriteLine(sString);
            }
            else
            {
                Console.WriteLine("Sorry, but sum is {0}", nSum);
            }
;
        }

    }
}
