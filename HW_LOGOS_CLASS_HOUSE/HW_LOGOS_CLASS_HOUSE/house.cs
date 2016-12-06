using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_CLASS_HOUSE
{
    class house
    {
        public int numOfRooms;
        public int price;
        public float area;

        public house()
        {
             numOfRooms = 0;
        }

        public house(int number,int cina,float square)
        {
            numOfRooms = number;
            price = cina;
            area = square;
        }

public void Print()
        {
            Console.WriteLine("Price for square meter is {0}", price / area);
        }
    }
}
