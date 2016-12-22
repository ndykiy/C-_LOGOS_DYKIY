using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INTERFACE
{
    class Square:Figure,IDrawable,IGeometrical
    {
        public int width;

        public Square(int X, int Y, int W):base(X,Y)
        {
            width = W;
        }

        public void Draw()
        {
            Console.WriteLine("\n\nCoordinates of left higher dot: \nX {0}  Y {1}\nThe length of side is {2}", x, y,width);
        }

        public float GetArea()
        {
            Console.WriteLine("This square is {0} m2", width * width);
            return width * width;
        }

        public float GetPerimetr()
        {
            Console.WriteLine("Its perimeter is {0} m", 4 * width);
            return 4 * width;
        }
    }
}
