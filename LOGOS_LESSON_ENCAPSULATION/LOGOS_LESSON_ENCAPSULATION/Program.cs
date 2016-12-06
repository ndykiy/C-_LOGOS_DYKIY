using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_ENCAPSULATION
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Mouse mouse1 = new Mouse("Logitech", 3, 1300);
           // mouse1.model = "Asus";
           // mouse1.SetDpi(1500);
            Console.WriteLine(mouse1.GetDpi());
            //Console.WriteLine("Mouse: {0} {1} {2}", mouse1.model, mouse1.numOfKeys, mouse1.dpi);
            //mouse1.Print();
            



            Employee e1 = new Employee();
            e1.Salary = 8000;
            //Console.WriteLine(e1.ID);
            e1.Print();
            */


            CustomFloat number = new CustomFloat(17,15.37f);
            //number.FirstPart = 17;
            //number.SecondPart = 0.25f;
            number.Print();

        }
    }
}
