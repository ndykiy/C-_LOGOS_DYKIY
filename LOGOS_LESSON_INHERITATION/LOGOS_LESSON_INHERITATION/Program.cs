using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INHERITATION
{
    class Program
    {
        static void Main(string[] args)
        {

            //Product p1 = new Product(159021, 15);
            // p1.PrintGeneralInfo();
            /*Carrot c1 = new Carrot(199999, 12f,23.4f);
            c1.PrintGeneralInfo();*/



            /*Computer c1 = new Computer("Asus", "i7", true, 999);
            Console.WriteLine(c1);
            c1.display.width = 1920;
            c1.display.height = 1080;
            Console.WriteLine(c1.display.Resolution);
            


            Villa v1 = new Villa(4,true,754.3f,14,"spain",20000123);
            
            v1.PrintVilla();

    */

            HotelRoom b123 = new HotelRoom(120,120.4f,4,"rwfvbw",4);
            b123.PrintHotelRoom();
        }
    }
}
