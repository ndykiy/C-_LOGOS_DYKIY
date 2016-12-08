using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INHERITATION
{
    class Villa:LivingPlace
    {
        public int numOfBaths;
        public bool hasFountain;


        public Villa(int mNumOfBaths,bool mHasFountain,float mArea,int mNumOfRooms,string mLocation,int mPrice):base( mArea,  mNumOfRooms,  mLocation,mPrice)
        {
            numOfBaths = mNumOfBaths;
            hasFountain = mHasFountain;
        }


        public void PrintVilla()
        {
            Console.WriteLine("Villa\nArea {0}\nnumber of rooms{1}\nlocation {2}\nprice {3}\nnum of baths {4}\nfountain {5}", area, numOfRooms, location, price,numOfBaths,hasFountain);
        }


    }
}
