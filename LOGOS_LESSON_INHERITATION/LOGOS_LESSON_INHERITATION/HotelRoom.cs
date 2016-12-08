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

        public HotelRoom(int Price,int NumOfPlaces, float mArea,int mNumOfRooms,string mLocation):base( mArea,  mNumOfRooms,  mLocation, Price)
        {
            PricePerPlace = Price/NumOfPlaces;
        }

        public new int Price { get; set; }
  
        public int NumOfPlaces   {  get;set;}

        public int PricePerPlace { get; set; }
        /* {
             get
             {
                 return k;
             }
             set
             {
               k = value;
             }
         }
         */
        public void PrintHotelRoom()
        {
            Console.WriteLine("Hotel Room\nArea {0}\nnumber of rooms{1}\nlocation {2}\nprice {3}\nnum of places {4}\nprice per place {5}", area, numOfRooms, location, Price, NumOfPlaces,PricePerPlace );

        }
    }
}
