using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INTERFACE
{
    class Circle:Figure,IDrawable,IGeometrical
    {
        public int radius;

        public Circle(int X, int Y,int R):base(X,Y)
        {
            radius = R;
        }

        public void Draw()
        {
            Console.WriteLine("\n\nCoordinates of center: \nX {0}  Y {1}\nThe radius is {2} cm", x, y,radius);
        }

        public float GetArea()
        {
            Console.WriteLine("This circle is {0} m2", radius*radius*3.14);
            return radius * radius * 3.14f;
        }

        public float GetPerimetr()
        {
            Console.WriteLine("Its perimeter is {0} m", radius * 3.14*2);
            return radius * 3.14f * 2f;
        }

    }
}
