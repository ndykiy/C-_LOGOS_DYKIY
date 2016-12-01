using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car myCar = new Car("black","Suzuki",120000,200,20,true);
             myCar.sColour = "black";
             myCar.bIsOn = true;
             myCar.nMaxSpeed = 200;
             myCar.nCurrentSpeed = 20;
             myCar.sModel = "Suzuki";
             myCar.nPrice = 200000;
             

            Car my2Car = new Car("BMW","black",1000000,250,50,true);

            myCar.PrintInfo();
            my2Car.PrintInfo();
            */

            PC comp = new PC("asus",10000,"intel core i7",4);
            comp.PrintPC();




        }
    }
}
