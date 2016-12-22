using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INTERFACE
{
    class Dot:Figure,IDrawable
    {
        public Dot(int X, int Y):base(X,Y)
        { }

        public void Draw()
        {
            Console.WriteLine("Coordinates of dot: \nX {0}  Y {1}", x, y);
        }
    }
}
