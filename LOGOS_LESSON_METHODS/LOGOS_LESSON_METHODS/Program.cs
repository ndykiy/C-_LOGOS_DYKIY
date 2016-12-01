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
            

            Console.WriteLine("Enter quantity of array");
            int nQ = int.Parse(Console.ReadLine());
            int[] nArr;
            nArr = NewArray(nQ);
            for(int i=0;i<nQ;i++)
            {
                Console.Write(" {0}", nArr[i]);
            }


        }

        static int[] NewArray( int nQuant)
        {
           
            int[] nA = new int[nQuant];

            for (int i = 0; i < nQuant; i++)
            {
                nA[i] = i;
            }
            return nA;
            

            Figure(3,4,6);

        }

        static void Figure(int n1)
        {
            Console.WriteLine("Line with Length {0}", n1);
        }

        static void Figure(int n1,int n2)
        {
            Console.WriteLine("Dot with coordinates {0},{1}", n1,n2);
        }

        static void Figure(int n1,int n2,int n3)
        {
            Console.WriteLine("Triangle with sides {0},{1},{2}", n1, n2,n3);
        }

        static void Figure(int n1, int n2, int n3,int n4)
        {
            Console.WriteLine("Rectangle with sides {0},{1},{2},{3}", n1, n2, n3,n4);
        }
        
            Figure(3,3 ,5,6);
        }

        static void Figure(int n1, int n2=0, int n3=0,  int n4=0)
        {


            if(n4==0&&n3!=0&&n2!=0)
            {
                Console.WriteLine("Triangle with sides {0},{1},{2}", n1, n2, n3);
            }
            else
            {
                if(n3==0&&n2!=0)
                    Console.WriteLine("Dot with coordinates {0},{1}", n1, n2);
                else
                {
                    if(n2==0)
                        Console.WriteLine("Line with Length {0}", n1);
                    else
                    {
                        Console.WriteLine("Rectangle with sides {0},{1},{2},{3}", n1, n2, n3, n4);
                    }
                }
            }
            */
            Console.WriteLine("Enter quantity of numbers");
            int nQ = int.Parse(Console.ReadLine());
            int[] a = new int[nQ];
            Random rand = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rand.Next(1, 9);
                Console.Write(" {0}" , a[i]);
            }

                int nmin, nmax;
            MinMax(a,out nmin,out nmax);
            Console.WriteLine();
            Console.WriteLine(nmin + " " + nmax);
        }

        static void MinMax(int[] arr,out int min,out int max)
        {
             min = arr[0];
             max = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
        }

    }
    }
