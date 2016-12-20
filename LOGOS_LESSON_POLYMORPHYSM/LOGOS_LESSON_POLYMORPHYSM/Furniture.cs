using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_POLYMORPHYSM
{
   abstract class Furniture:Product
    {
        string material;
        Random rand = new Random();

        public Furniture(int ID,int Price,string Country,string Material):base(ID,Price,Country)
        {
            material = Material;
        }

        public string Style
        {
            get
            {
                int k = rand.Next(1, 10);
                if (k <5)
                {
                    return "luxury";
                }
                else return "economy";
            }
        }
    }
}
