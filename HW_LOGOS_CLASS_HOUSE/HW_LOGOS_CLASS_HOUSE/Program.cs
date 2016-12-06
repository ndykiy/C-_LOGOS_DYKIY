using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_CLASS_HOUSE
{
    class Program
    {
        static void Main(string[] args)
        {
            house myHouse = new house();
            myHouse.numOfRooms = 4;
            myHouse.price = 520000;
            myHouse.area = 56.8f;
            myHouse.Print();

        }
    }
}
