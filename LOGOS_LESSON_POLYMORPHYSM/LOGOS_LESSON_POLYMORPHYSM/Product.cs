using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_POLYMORPHYSM
{
    abstract class Product
    {
        public int id;
        public int price;
        public string country;

        public Product(int ID,int Price, string Country)
        {
            id = ID;
            price = Price;
            country = Country;
        }
    }
}
