using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INTERFACE
{
    class Computer:IPrintable
    {
        string model;
        int price;
        int ram;

        public Computer(string m, int p, int r)
        {
            model = m;
            price = p;
            ram = r;
        }

        public void Print()
        {
            Console.WriteLine("Computer {0} costs {1} ram is {2}",model,price,ram);
        }
    }
}
