using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INHERITATION
{
    class LivingPlace
    {
        public float area;
        public int numOfRooms;
        public string location;
        public int price;


        public LivingPlace(float mArea,int mNumOfRooms,string mLocation,int mPrice)
        {
            area = mArea;
            numOfRooms = mNumOfRooms;
            location = mLocation;
            price = mPrice;
        }

        public float Area
        {
            get
            {
                return area;
            }
            set
            {
                Area = value;
            }
        }

        public int NumOfRooms
        {
            get
            {
                return numOfRooms;
            }
            set
            {
                NumOfRooms = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                Location = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                Price = value;
            }
        }


        public void PrintPlace()
        {
            Console.WriteLine("Area {0}\nnumber of rooms{1}\nlocation {2}\nprice {3}", area, numOfRooms, location, price);
        }

    }
}
