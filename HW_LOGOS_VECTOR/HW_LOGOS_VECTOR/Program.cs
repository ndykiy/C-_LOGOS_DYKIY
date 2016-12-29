using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_VECTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector[] vector = new Vector[10];
            for(int i=0;i<10;i++)
            {
                vector[i] = new Vector();
                vector[i].SetX();
                vector[i].SetY();
            }

            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Length of {0} vector is {1}", i + 1, vector[i].SetL());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                if(vector[i].SetL()>5)
                Console.WriteLine("Length of {0} vector is {1}", i + 1, vector[i].SetL());
            }

        }
    }
}
