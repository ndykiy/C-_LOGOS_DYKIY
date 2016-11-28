using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_MATRIX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dimension of matrix");
            int n = int.Parse(Console.ReadLine());
            int[,] nMatrix=new int[n,n];
            int nSum = 0,nSumAnti=0;
            Random rnd=new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    nMatrix[i, j] = rnd.Next(1, 10);
                    Console.Write("  {0}", nMatrix[i, j]);
                }
                Console.WriteLine();
            }
            for(int i=0;i<n;i++)
            {
                
                    nSum = nSum + nMatrix[i, i];
                    nSumAnti = nSumAnti + nMatrix[i, n-i-1];
                
            }
            Console.WriteLine("Sum ={0}",nSum);
            Console.WriteLine("Sum ={0}", nSumAnti);
        }
    }
}
