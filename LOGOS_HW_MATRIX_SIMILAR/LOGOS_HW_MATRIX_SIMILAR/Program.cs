using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_HW_MATRIX_SIMILAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dimensions of matrix");
            int n, m;
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int[,] nMatrix1 = new int[n, m];
            int[,] nMatrix2 = new int[n, m];
            for(int i=0;i<n;i++)
            {
               for(int j=0;j<m;j++)
               {
                   nMatrix1[i,j] = rand.Next(1, 9);
                   nMatrix2[i,j] = rand.Next(1, 9);
               }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" {0}",nMatrix1[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" {0}", nMatrix2[i, j]);
                }
                Console.WriteLine();
            }

            int nQuantity = n * m;
            int nSame = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (nMatrix1[i, j] == nMatrix2[i, j])
                        nSame++;
                }
                
            }

            Console.WriteLine("Matrixes are similar for {0}% ", (float)(nSame*100 / (n*m)));


        }
    }
}
