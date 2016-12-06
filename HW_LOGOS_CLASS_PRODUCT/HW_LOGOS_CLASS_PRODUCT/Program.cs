using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_CLASS_PRODUCT
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] product = new Product[6];
            for (int i=0;i<6;i++)
            {
                product[i] = new Product() { price = i * 23 };
            }
            
            product[0].name = "ball";
            product[0].category = "for children";

            product[1].name = "blade";
            product[1].category = "for adults";

            product[2].name = "book";
            product[2].category = "for children";

            product[3].name = "kite";
            product[3].category = "for children";

            product[4].name = "car";
            product[4].category = "for adults";

            product[5].name = "remote control";
            product[5].category = "for adults";

            for (int i = 0; i < 6; i++)
            {
               if( product[i].category=="for children")
                    product[i].Print();
            }

        }
    }
}
