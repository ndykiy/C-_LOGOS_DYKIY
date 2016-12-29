using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_VECTOR
{
    class Vector
    {
        public int x;
        public int y;

        public void    SetX()
        {
            Console.WriteLine("Enter x");
            x =int.Parse(Console.ReadLine());
        }

        public void  SetY()
        {
            Console.WriteLine("Enter y");
          y=  int.Parse(Console.ReadLine());
        }


        public double SetL()
        {
            return Math.Sqrt(x*x+y*y);
        }
      
    }
}
