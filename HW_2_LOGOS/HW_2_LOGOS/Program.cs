using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_LOGOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius (cm):");
            float fRadius = (float.Parse)(Console.ReadLine());
            Console.WriteLine("Length of the circle is {0} cm",2*fRadius*3.1415);
        }
    }
}
