using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_OOP
{
    class Car
    {
        public string sColour;
        public string sModel;
        public int nPrice;
        public int nMaxSpeed;
        public int nCurrentSpeed;
        public bool bIsOn;
        /*
        public Car(string sCarColour,string sCarModel,int nCarPrice,int nCarMaxSpeed,int nCarCurrentSpeed,bool bCarIsOn)
        {
            sModel = sCarColour;
            sColour = sCarColour;
            nPrice = nCarPrice;
            nMaxSpeed = nCarMaxSpeed;
            nCurrentSpeed = nCarCurrentSpeed;
            bIsOn = bCarIsOn;
        }
        
        public Car()
        {
            sModel = "unknown";
            sColour = "unnamed";
        }

        public Car(string sCarModel,int nCarPrice,int nCarMaxSpeed )
        {
            sModel = sCarModel;
            nPrice = nCarPrice;
            nMaxSpeed = nCarMaxSpeed;
        }
        */

        public Car(string sCarModel = "unknown", string sCarColour="Unknown", int nCarPrice=500000, int nCarMaxSpeed=200, int nCarCurrentSpeed=0, bool bCarIsOn=false)
        {
            sModel = sCarModel;
            sColour = sCarColour;
            nPrice = nCarPrice;
            nMaxSpeed = nCarMaxSpeed;
            nCurrentSpeed = nCarCurrentSpeed;
            bIsOn = bCarIsOn;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Model: {0}\nColour {1}\nPrice {2}\nCurrent speed {3}\nIs on {4}",sModel,sColour,nPrice,nCurrentSpeed,bIsOn);
        }


    }
}
