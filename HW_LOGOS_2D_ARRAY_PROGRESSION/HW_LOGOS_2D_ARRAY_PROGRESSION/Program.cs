using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_2D_ARRAY_PROGRESSION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dimensions of matrix");
            int nW = int.Parse(Console.ReadLine());
            int nH = int.Parse(Console.ReadLine());
            int[,] nMatrix = new int[nW, nH];
            FillMatrix(nMatrix, ref nW, ref nH);
        }

        static void FillMatrix(int[,] nArray,ref int nWidth, ref int nHeight)
           {
            
            for(int i=0;i<nWidth;i++)
            {
                for (int j = 0; j < nHeight; j++)
                {
                    nArray[i, j] = i * j;
                    Console.Write("   " + nArray[i, j]);
                }
                Console.WriteLine();
            }

           }

    }
}
