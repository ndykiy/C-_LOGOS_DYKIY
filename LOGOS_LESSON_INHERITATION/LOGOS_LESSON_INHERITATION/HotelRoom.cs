using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INHERITATION
{
    class HotelRoom:LivingPlace
    {

        int k;

        public HotelRoom(int mPrice, float mArea, int mNumOfRooms, string mLocation, int mNumOfPlaces)
            : base(mArea, mNumOfRooms, mLocation, mPrice)
        {
            k = mNumOfPlaces;
        }

        public new int Price
        {
            get
            {
                return price;
            }
        }

        public int NumOfPlaces
        {
            get
            {
                return k;
            }
            set
            {
                k = value;
            }
        }
        public int PricePerPlace
         {
             get
             {
                 return Price / NumOfPlaces;
             }
          
         }
         
        public void PrintHotelRoom()
        {
            
            Console.WriteLine("Hotel Room\nArea {0}\nnumber of rooms{1}\nlocation {2}\nprice {3}\nnum of places {4}\nprice per place {5}", area, numOfRooms, location, Price, NumOfPlaces,PricePerPlace );

        }
    }
}
