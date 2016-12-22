using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INTERFACE
{
    abstract class Figure
    {
        public int x;
        public int y;

        public Figure(int X, int Y)
        {
            x = X;
            y = Y;
        }
    }
}
