using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INTERFACE
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*
            IPrintable[] printable = new IPrintable[3];
            Person p = new Person("Name", 1999);
            Computer c = new Computer("Asus", 1999, 200);
            printable[0] = p;
            printable[1] = c;
            printable[2] = new Person("Anton", 12);

            foreach(IPrintable elem in printable)
            {
                elem.Print();
            }
            */


            Dot d = new Dot(3, 4);
            Circle c = new Circle(1, 1, 5);
            Square s = new Square(7, 7, 3);
            d.Draw();
            c.Draw();
            c.GetArea();
            c.GetPerimetr();
            s.Draw();
            s.GetArea();
            s.GetPerimetr();


        }
    }
}
